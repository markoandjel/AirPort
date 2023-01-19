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
        private IGraphClient _client;
        public AirportController()
        { 

        }

        public async void CreateAirport(Airport a)
        {
            //Dictionary<string, object> queryDict = new Dictionary<string, object>
            //{
            //    { "name", a.Name },
            //    { "code", a.Code },
            //    { "city", a.City }
            //};
            //var query = new CypherQuery("MERGE (n:Airport{name:'" + a.Name + "',city:'" + a.City + "',code:'" + a.Code + "'})",queryDict,CypherResultMode.Set,databaseName);
            //((IRawGraphClient)client).ExecuteCypherAsync(query);

            await _client.Cypher.Match("(n:Airport $a)").WithParam("a", a).ExecuteWithoutResultsAsync();
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
