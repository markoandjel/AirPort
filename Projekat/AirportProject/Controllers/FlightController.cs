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
        public FlightController(){ }
        public FlightController(IDriver driver)
        {
            _driver = driver;
        }
        public void CreateFlight(Flight f)
        {
            string query = "MATCH (a1:Airport),(a2:Airport) WHERE a1.code=\"INI\" AND a2.code=\"IST\" " +
                "MERGE (a1)-[r:FLIGHT {test:\"test2\"}]->(a2)";
            var session = _driver.Session(conf => conf
            .WithDefaultAccessMode(AccessMode.Write)
            .WithDatabase("airport"))
            .Run(query);

            string test = "Test2";
            //new
            //{
            //    code = f.Code,
            //    destinationCode = f.Destination.Code,
            //    timeofdeparture = f.TimeOfDeparture,
            //    timeofarival = f.TimeOfArival,
            //    numofseats = f.NumOfSeats,
            //    numfreesteats = f.FreeSeats,
            //    price = f.Price,
            //    startCode=f.Start.Code,
            //    timeinminutes=(f.TimeOfArival-f.TimeOfDeparture).TotalMinutes               
            //});
        }
    }
}
