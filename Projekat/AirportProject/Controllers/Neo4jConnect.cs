using AirportProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Neo4jClient;
using Neo4j.Driver;
using Neo4jClient.Cypher;
using System.Windows.Forms;

namespace AirportProject.Controllers
{
    public class Neo4jConnect
    {
        private IDriver _driver;
        public Neo4jConnect()
        {
            
        }
        public Task InitDriverAsync(string url, string username, string password)
        {
            string databaseName = "airport";
            _driver = GraphDatabase.Driver(url + "/" + databaseName, AuthTokens.Basic(username, password));

            return Task.CompletedTask;
        }
        public Task CloseDriver()
        {
            return _driver !=null ? _driver.CloseAsync() : Task.CompletedTask;
        }

        public IDriver Driver
        {
            get{return _driver;}
            set { _driver = value; }
        }
    }
}
