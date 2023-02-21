using AirportProject.DomainModel;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.Controllers
{
    public class FlightController
    {
        private readonly IDriver _driver;
        private readonly ISession _session;
        public FlightController(){ }
        public FlightController(IDriver driver)
        {
            _driver = driver;
            _session=_driver.Session(conf =>
            conf.WithDatabase("neo4j"));
        }
        public void CreateFlight(Flight f)
        {
            Query query = new Query(string.Format("MATCH (a1: Airport),(a2: Airport) WHERE a1.code=\"{0}\" AND a2.code=\"{1}\" " +
                "MERGE (a1)-[r:FLIGHT {{ code:\"{2}\",departure:\"{3}\",arival:\"{4}\",price:\"{5}\",freepassengers:\"{6}\",seats:\"{7}\"}}]->(a2) RETURN r",
                f.Start.Code,f.Destination.Code,f.Code,f.TimeOfDeparture.ToString(), f.TimeOfArival.ToString(), f.Price, f.FreeSeats, f.NumOfSeats));
            _session.Run(query);
        }
    }
}
