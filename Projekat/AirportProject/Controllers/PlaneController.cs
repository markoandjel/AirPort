using AirportProject.DomainModel;
using Neo4j.Driver;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace AirportProject.Controllers
{
    internal class PlaneController : Neo4jConnect
    {
        private readonly IDriver _driver;
        private ISession _sessionPlane;

        public PlaneController()
        {
        }

        public PlaneController(IDriver driver) 
        {
            _driver = driver;
            _sessionPlane = _driver.Session(conf => conf
            .WithDatabase("neo4j"));

        }

        public void CreatePlane(Plane p)
        {
            _sessionPlane.Run("MATCH (a:Airline{name:$name}) " +
                "MERGE (p:Plane {manufacturer: $man, model: $mod, code: $code})" +
                "MERGE (p)-[r:BelongsTo]->(a)", new { name = p.Airline.Name, man=p.Manufacturer, mod=p.Model, code=p.Code });
        }

        public void DeletePlane(Plane p)
        {
            _sessionPlane.Run("MATCH (p:Plane {manufacturer:$man, model: $mod, code: $code})" +
                "MATCH(a:Airline{name:$name})" +
                "MATCH(p)-[r:BelongsTo]->(a)"+
                "DELETE r  DELETE p", new { man = p.Manufacturer, mod=p.Model, code=p.Code, name=p.Airline.Name });
        }

        public void UpdatePlane(Plane planeOld, Plane planeNew)
        {
            _sessionPlane.Run("MATCH (p:Plane{manufacturer: $manOld, model: $modOld, code: $codeOld})" +
                " SET p.manufacturer= $manNew, p.model=$modNew, p.code=$codeNew",
                new { manOld = planeOld.Manufacturer,
                    modOld = planeOld.Model,
                    codeOld = planeOld.Code,
                    manNew = planeNew.Manufacturer,
                    modNew = planeNew.Model,
                    codeNew = planeNew.Code }); 

            
        }

        public List<Plane> GetAllPlanes(string airlineName)
        {


            Airline airline = new Airline(airlineName);
            var planes = new List<Plane>();
            var readPlanes = _sessionPlane.ExecuteRead(tx =>
            {
                var cursor = tx.Run(@"MATCH(a:Airline{name:$name})<-[r:BelongsTo]-(plane)" +
                    " RETURN plane",
                    new {name=airlineName});
                return cursor.ToList();
            });
            int i = 0;
            foreach (var r in readPlanes)
            {
                var node = JsonConvert.SerializeObject(r[0].As<INode>().Properties);
                planes.Add(JsonConvert.DeserializeObject<Plane>(node));
                planes[i].Airline = airline;
                i++;
            }
            return planes;
        }

    }
}
