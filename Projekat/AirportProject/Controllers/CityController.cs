using Neo4j.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportProject.DomainModel;

namespace AirportProject.Controllers
{
    public class CityController : Neo4jConnect
    {
        private readonly IDriver _driver;
        private ISession _sessionCity;
        public CityController()
        {

        }
        public CityController(IDriver driver)
        {
            _driver = driver;
            _sessionCity = _driver.Session(conf => conf
           .WithDatabase("neo4j"));
        }

        public void CreateCity(City c)
        {

            _sessionCity.Run("MERGE (c:City {name: $name,country: $country})", new { name = c.Name, country = c.Country });
            ConnectDisconnectAirport(c.Name, true);
        }

        public List<City> GetAllCities()
        {



            var cities = new List<City>();
            var readCities = _sessionCity.ExecuteRead(tx =>
            {
                var cursor = tx.Run(@"MATCH(c: City) RETURN c LIMIT 25");
                return cursor.ToList();
            });

            foreach (var r in readCities)
            {
                var node = JsonConvert.SerializeObject(r[0].As<INode>().Properties);
                cities.Add(JsonConvert.DeserializeObject<City>(node));
            }
            return cities;
        }

        public void DeleteCity(City c)
        {
            ConnectDisconnectAirport(c.Name, false);
            _sessionCity.Run("MATCH (c:City { country:$country, name:$name}) Delete c", new { name = c.Name, country = c.Country });

        }
        public void UpdateCity(City cityOld, City cityNew)
        {

            _sessionCity.Run("MATCH (c:City {name:$nameOld,country:$countryOld}) SET c.name=$nameNew, c.country=$countryNew",
                new
                {
                    nameOld = cityOld.Name,
                    countryOld = cityOld.Country,
                    nameNew = cityNew.Name,
                    countryNew = cityNew.Country,

                });
           // ConnectDisconnectAirport(cityOld.Name, false);
           // ConnectDisconnectAirport(cityNew.Name, true);
        }

        public void ConnectDisconnectAirport (String name, bool connect, String airportCode="XXXX") 
        {
            List<IRecord> readElements;
            if (airportCode == "XXXX")
            {
                readElements = _sessionCity.ExecuteRead(tx =>
                {
                    var cursor = tx.Run(@"MATCH(a:Airport{city:$cityName}) RETURN a", new { cityName = name });
                    return cursor.ToList();
                });
            }
            else
            {
                readElements = _sessionCity.ExecuteRead(tx =>
                {
                    var cursor = tx.Run(@"MATCH(a:Airport{city:$cityName, code:$cityCode}) RETURN a", new { cityName = name, cityCode=airportCode });
                    return cursor.ToList();
                });

            }

            foreach(var e in readElements)
            {
                var node = JsonConvert.SerializeObject(e[0].As<INode>().Properties);
                Airport temp= JsonConvert.DeserializeObject<Airport>(node);
                if(connect)
                    _sessionCity.Run("MATCH(c:City{name:$cityName}),(a:Airport{code: $airportCode})" +
                                     "MERGE(a)-[r:IN]->(c)" +
                                     "RETURN a", new { airportCode = temp.Code, cityName = name});
                else
                    _sessionCity.Run("MATCH(c:City{name:$cityName}),(a:Airport{code: $airportCode})" +
                                    "MATCH p=(a)-[r:IN]->(c)" +
                                    "DELETE r", new { airportCode = temp.Code, cityName = name });
            }
        }
    }
}