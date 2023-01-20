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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;

namespace AirportProject.Controllers
{
    public class Neo4jConnect
    {
        private IDriver _driver;
        public Neo4jConnect()
        {

        }
        public Neo4jConnect(string url, string username, string password)
        {
            _driver = GraphDatabase.Driver(url, AuthTokens.Basic(username, password));
            _driver.Session();
        } 

        public IDriver Driver
        {
            get{return _driver;}
            set { _driver = value; }
        }
    }
}
