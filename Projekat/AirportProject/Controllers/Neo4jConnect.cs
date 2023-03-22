using Neo4j.Driver;

namespace AirportProject.Controllers
{
    public class Neo4jConnect
    {
        protected IDriver _driver;
        protected ISession _session;
        public Neo4jConnect()
        {

        }
        public Neo4jConnect(string url, string username, string password)
        {
            _driver = GraphDatabase.Driver(url, AuthTokens.Basic(username, password));
            _session=_driver.Session(conf => conf
            .WithDatabase("neo4j"));
        } 

        public IDriver Driver
        {
            get{return _driver;}
            set { _driver = value; }
        }
    }
}
