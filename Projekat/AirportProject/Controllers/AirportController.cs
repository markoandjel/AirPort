using AirportProject.DomainModel;
using AirportProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AirportProject.Controllers;
using Neo4j.Driver;
using Neo4jClient;
using Neo4jClient.Cypher;
using System.Windows.Forms;
using NHibernate.Loader.Custom;
using NHibernate.Mapping;
using NHibernate.Util;
using Newtonsoft.Json;

namespace AirportProject.Controllers
{
    public class AirportController
    {
        private readonly IDriver _driver;
        public AirportController()
        { 

        }
        public AirportController(IDriver driver)
        {
            _driver = driver;
        }

        public void CreateAirport(Airport a)
        {
            var session = _driver.Session(conf => conf
            .WithDefaultAccessMode(AccessMode.Write)
            .WithDatabase("airport"))
<<<<<<< HEAD
            .Run("CREATE (a:Airport {name: $name,city: $city,code: $code})", new { name = a.Name, code = a.Code, city = a.City });
=======
            .Run("MERGE (a:Airport {name: $name,city: $city,code: $code})", new { name = a.Name, code = a.Code, city = a.City });
>>>>>>> c50863486bc646f0af288a1cdf987f6d29803a0b
        }

        public List<Airport> GetAllAirports()
        {
            var session = _driver.Session(conf => conf
            .WithDatabase("airport"));

            var airports = new List<Airport>();
            var res = session.ExecuteRead(tx =>
            {
                var cursor = tx.Run(@"MATCH(n: Airport) RETURN n LIMIT 25");
                return cursor.ToList();
            });

            foreach(var r in res)
            {
                var node = JsonConvert.SerializeObject(r[0].As<INode>().Properties);
                airports.Add(JsonConvert.DeserializeObject<Airport>(node));
            }
            return airports;
        }

        public void DeleteAirport(Airport a)
        {
            var session = _driver.Session(conf => conf
            .WithDatabase("airport"));
            var res = session.Run("MATCH (a:Airport {name:$name,city:$city,code:$code}) Delete a",new {name=a.Name,city=a.City,code=a.Code });

        }
        public void UpdateAirport(Airport airportOld,Airport airportNew)
        {
            var session = _driver.Session(conf => conf
                        .WithDatabase("airport"));
            var res = session.Run("MATCH (a:Airport {name:$name,city:$city,code:$code}) SET a.name=$nameNew,a.city=$cityNew,a.code=$codeNew", 
                new { name = airportOld.Name, city = airportOld.City, code = airportOld.Code,
                    nameNew=airportNew.Name,cityNew=airportNew.City,codeNew=airportNew.Code});
        }

        public void UpdateAirport(Airport airportOld, Airport airportNew)
        {
            var session = _driver.Session(conf => conf
                        .WithDatabase("airport"));
            var res = session.Run("MATCH (a:Airport {name:$name,city:$city,code:$code}) SET a.name=$nameNew,a.city=$cityNew,a.code=$codeNew",
                new
                {
                    name = airportOld.Name,
                    city = airportOld.City,
                    code = airportOld.Code,
                    nameNew = airportNew.Name,
                    cityNew = airportNew.City,
                    codeNew = airportNew.Code
                });
        }
    }
}
