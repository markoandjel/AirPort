using AirportProject.DomainModel;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.Controllers
{
    public class TicketController:Neo4jConnect
    {
        private readonly IDriver _driver;

        public TicketController()
        {

        }

        public TicketController(IDriver driver)
        {
            _driver = driver;
        }   

        public void createTicket(Ticket t)
        {
            var session = _driver.Session(conf => conf
                .WithDefaultAccessMode(AccessMode.Write)
                .WithDatabase("airport"))
                .Run("CREATE (t:Ticket {Number: $ticket_Number,Seat: $seat_Number,Gate=$gate,flight_code = $flight_code,passenger = $passenger_Name})", new { ticket_Number = t.TicketNum, seat_Number = t.SeatNum, gate = t.Gate,flight_Code = t.FlightCode,passanger_Name = t.PassangerName});
        }
    }
}
