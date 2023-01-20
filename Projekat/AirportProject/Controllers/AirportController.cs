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

namespace AirportProject.Controllers
{
    public class AirportController:Neo4jConnect
    {
        private IDriver _driver;
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
            .Run("CREATE (a:Airport {name: $name,city: $city,code: $code})", new { name = a.Name, code = a.Code, city = a.City });
        }

        public List<Airport> GetAllAirports() 
        {
            /*var session = Connector.Driver.Session();
            try
            {
               List<Airport> listAiports= (List<Airport>)session.Run("MATCH(p:Airport) return p LIMIT 3");
                return listAiports;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }*/

            var session = _driver.Session(conf => conf
            .WithDefaultAccessMode(AccessMode.Read)
            .WithDatabase("airport"))
            .Run("MATCH(p:Airport) return p LIMIT 3");
            return null;
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
