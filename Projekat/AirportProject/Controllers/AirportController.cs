using Neo4j.Driver;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace AirportProject.Controllers
{
    public class AirportController
    {
        private CityController _cityController;
        private readonly IDriver _driver;
        private readonly ISession _session;
        public AirportController()
        { 

        }
        public AirportController(IDriver driver)
        {
            _driver = driver;
            _session = _driver.Session(conf => conf
            .WithDefaultAccessMode(AccessMode.Write)
            .WithDatabase("neo4j"));
            _cityController = new CityController(driver);
        }

        public void CreateAirport(DomainModel.Airport a)
        {
            _session
            .Run("MERGE (a:Airport {name: $name,city: $city,code: $code})", new { name = a.Name, code = a.Code, city = a.City });
            _cityController.ConnectDisconnectAirport(a.City, true);
        }

        public List<DomainModel.Airport> GetAllAirports()
        {

            var airports = new List<DomainModel.Airport>();
            var res = _session.ExecuteRead(tx =>
            {
                var cursor = tx.Run(@"MATCH(n: Airport) RETURN n LIMIT 25");
                return cursor.ToList();
            });

            foreach(var r in res)
            {
                var node = JsonConvert.SerializeObject(r[0].As<INode>().Properties);
                airports.Add(JsonConvert.DeserializeObject<DomainModel.Airport>(node));
            }
            return airports;
        }

        public void DeleteAirport(DomainModel.Airport a)
        {
            
            _cityController.ConnectDisconnectAirport(a.City,false, a.Code);
            var res = _session.Run("MATCH (a:Airport {name:$name,city:$city,code:$code}) Delete a",new {name=a.Name,city=a.City,code=a.Code });
            //_cityController.ConnectDisconnectAirport(a.City, true, a.Code);

        }
        public void UpdateAirport(DomainModel.Airport airportOld, DomainModel.Airport airportNew)
        {
            var res = _session.Run("MATCH (a:Airport {name:$name,city:$city,code:$code}) SET a.name=$nameNew,a.city=$cityNew,a.code=$codeNew", 
                new { name = airportOld.Name, city = airportOld.City, code = airportOld.Code,
                    nameNew=airportNew.Name,cityNew=airportNew.City,codeNew=airportNew.Code});
        }

    }
}
