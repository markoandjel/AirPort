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
            var session = _driver.Session(conf => conf
            .WithDefaultAccessMode(AccessMode.Write)
            .WithDatabase("airport"))
            .Run("MERGE (f:Flight {name: $name,city: $city,code: $code})", 
            new
            {
                code = f.Code,
                destination = f.Destination,
                timeofdeparture = f.TimeOfDeparture,
                timeofarival = f.TimeOfArival,
                numofseats = f.NumOfSeats,
                numfreesteats = f.FreeSeats,
                price = f.Price,
                start=f.Start,
                timeinminutes=(f.TimeOfArival-f.TimeOfDeparture).TotalMinutes               
            });

        }
    }
}
