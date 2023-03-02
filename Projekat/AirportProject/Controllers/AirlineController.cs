using AirportProject.DomainModel;
using Neo4j.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.Controllers
{
    public class AirlineController:Neo4jConnect
    {
        private new readonly IDriver _driver;
        private ISession _sessionAirline;

        public AirlineController()
        {

        }
        public AirlineController(IDriver driver)
        {
            _driver = driver;
            _sessionAirline = _driver.Session(conf => conf
           .WithDatabase("neo4j"));
        }

        public void CreateAirline(Airline a)
        {
            _sessionAirline.Run("MERGE (a:Airline {name: $name})", new { name = a.Name});
        }

        public void DeleteAirline(Airline a)
        {
            _sessionAirline.Run("MATCH (a:Airline {name:$name}) Delete a", new { name = a.Name});
        }

        public void UpdateAirline(Airline airlineOld, Airline airlineNew)
        {

            _sessionAirline.Run("MATCH (a:Airline {name:$nameOld}) SET a.name=$nameNew",
                new
                {
                    nameOld = airlineOld.Name,
                    nameNew = airlineNew.Name,
                });
        }

        public List<Airline> GetAllAirlines()
        {



            var airlines = new List<Airline>();
            var readAirlines = _sessionAirline.ExecuteRead(tx =>
            {
                var cursor = tx.Run(@"MATCH(c: Airline) RETURN c LIMIT 25");
                return cursor.ToList();
            });

            foreach (var r in readAirlines)
            {
                var node = JsonConvert.SerializeObject(r[0].As<INode>().Properties);
                airlines.Add(JsonConvert.DeserializeObject<Airline>(node));
            }
            return airlines;
        }
        public void AddFlight()
        { 
        }

    }
}
