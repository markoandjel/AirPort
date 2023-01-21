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
            .Run("MATCH (a1:Airport),(a2:Airport) WHERE a1.code=\"$codeStart\" AND a2.code=\"$codeDest\" " +
                "MERGE (a1)-[r:FLIGHT_TO {code:$code,price:$price,freeseats:$freeseats,numofseats:$numofseats," +
                "timeofdeparture=$timeofdeparture,timeofarival=$timeofarival}]->(a2)",
                new
                {
                    codeStart = f.Start.Code.ToString(),
                    codeDest = f.Destination.Code.ToString(),
                    code = f.Code.ToString(),
                    price = f.Price.ToString(),
                    freeseats = f.FreeSeats.ToString(),
                    numofseats = f.NumOfSeats.ToString(),
                    timeofdeparture = f.TimeOfDeparture.ToString(),
                    timeofarival = f.TimeOfArival.ToString()
                });


            //Dictionary<string, object> queryDict = new Dictionary<string, object>();
            //queryDict.Add("code", f.Code);
            //queryDict.Add("price", f.Price);
            //queryDict.Add("codeDestination", f.Destination.Code);
            //queryDict.Add("codeStart", f.Start.Code);
            //queryDict.Add("freeseats", f.FreeSeats);
            //queryDict.Add("numofseats", f.NumOfSeats);
            //queryDict.Add("timeofarival", f.TimeOfArival);
            //queryDict.Add("timeofdeparture", f.TimeOfDeparture);


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
