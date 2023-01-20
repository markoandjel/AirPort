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

namespace AirportProject.Controllers
{
    public class AirportController:Neo4jConnect
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
            .Run("MERGE (a:Airport {name: $name,city: $city,code: $code})", new { name = a.Name, code = a.Code, city = a.City });
        }

        [Obsolete]
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
            .WithDatabase("airport"));


            var res = session.ReadTransaction(tx =>
            {
                var cursor = tx.Run(@"MATCH(n: Airport) RETURN n.city as city LIMIT 25");
                var records = cursor.ToList();
                return records.Select(x=>x["city"].As<string>());
            });
            var lista = res.ToList();


            var res2 = session.ReadTransaction(tx =>
            {
                var cursor = tx.Run(@"MATCH(n: Airport) RETURN n");

                //IRecord row = cursor.Single();
                List<IRecord> rows=cursor.ToList();
                //IReadOnlyList<string> columns = row.Keys;

                //string city=row.Values.ContainsKey("")
                
                var records = cursor.ToList();
                return records.Select(x => x["city"].As<string>());
            });
            var lista2 = res2.ToList();
            return null;
        }
    }
}
