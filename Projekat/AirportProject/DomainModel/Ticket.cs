using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.DomainModel
{
    public class Ticket
    {
        public int TicketNum { get; set; }
        public string SeatNum { get; set; }
        public string Gate { get; set; }
        public string FlightCode { get; set; }
        public string PassangerName { get; set; }

        public Ticket()
        {
        }

        public Ticket(int ticketNum, string seatNum, string gate, string flightCode, string passangerName)
        {
            TicketNum = ticketNum;
            SeatNum = seatNum;
            Gate = gate;
            FlightCode = flightCode;
            PassangerName = passangerName;
        }

        
    }
}
