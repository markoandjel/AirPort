using AirportProject.DomainModel;
using Neo4j.Driver;
using Newtonsoft.Json;

namespace AirportProject.Controllers
{
    public class TicketController : Neo4jConnect
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
                .WithDatabase("neo4j"))
                .Run("CREATE (t:Ticket {Number: $ticket_Number,Seat: $seat_Number,Gate=$gate,flight_code = $flight_code,passenger = $passenger_Name})", new { ticket_Number = t.TicketNum, seat_Number = t.SeatNum, gate = t.Gate, flight_Code = t.FlightCode, passanger_Name = t.PassangerName });
        }

        public void deleteTicket(Ticket t)
        {
            var session = _driver.Session(conf => conf
            .WithDatabase("airport"));
            var res = session.Run("MATCH (t:Ticket {Number:$ticket_Number}) Delete t", new { ticket_Number = t.TicketNum });
        }

        public Ticket getTicket(Ticket t)
        {
            Ticket ticket = new Ticket();
            var session = _driver.Session(conf => conf
            .WithDatabase("airport"));
            string query = "MATCH (t:Ticket {Number: $ticket_Number}) RETURN ticket";
            var res = session.ExecuteRead(tx =>
            {
                var cursor = tx.Run(query, new { ticket_Number = t.TicketNum });
                return cursor;
            });
            var node = JsonConvert.SerializeObject(res.As<INode>().Properties);
            ticket = JsonConvert.DeserializeObject<Ticket>(node);

            return ticket;

        }

        public void updateTicket(Ticket oldTicket, Ticket newTicket)
        {

        }
    }
}
