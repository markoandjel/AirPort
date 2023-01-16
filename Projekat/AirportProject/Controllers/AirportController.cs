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
        public void CreateAirport(Airport a)
        {
            Dictionary<string,object> queryDict= new Dictionary<string,object>();
            queryDict.Add("name",a.Name);
            queryDict.Add("code",a.Code);
            queryDict.Add("city", a.City);
            var query = new CypherQuery("CREATE (n:Airport{name:'" + a.Name + "',city:'" + a.City + "',code:'" + a.Code + "'})",queryDict,CypherResultMode.Set,databaseName);
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
            return null;
        }
    }
}
