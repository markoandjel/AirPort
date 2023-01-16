using AirportProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Neo4jClient;
using Neo4jClient.Cypher;
using System.Windows.Forms;

namespace AirportProject.Controllers
{
    public class Neo4jConnect
    {
        protected String databaseName;
        protected GraphClient client;
        protected Neo4jConnect()
        {
            databaseName = "airport";
            string url = "http://localhost:7474/"+databaseName;
            string username = "neo4j";
            string password = "password";
            client = new GraphClient(new Uri(url), username, password);
            try
            {
                client.ConnectAsync();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public GraphClient Client
        {
            get
            {
                return client;
            }
        }
    }
}
