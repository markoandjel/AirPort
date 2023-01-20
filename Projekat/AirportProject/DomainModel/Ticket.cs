using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.DomainModel
{
    public class Ticket
    {
<<<<<<< HEAD
        public int TicketNum { get; set; }
        public string SeatNum { get; set; }
        public string Gate { get; set; }
        public string FlightCode { get; set; }
        public string PassangerName { get; set; }
=======
        private int _ticketNum;
        private string _seatNum;
        private string _gate;
        private Flight _flightCode;
        private string _passangerName;

        public int TicketNum { get => _ticketNum; set => _ticketNum = value; }
        public string SeatNum { get => _seatNum; set => _seatNum = value; }
        public string Gate { get => _gate; set => _gate = value; }
        public Flight FlightCode { get => _flightCode; set => _flightCode = value; }
        public string PassangerName { get => _passangerName; set => _passangerName = value; }
>>>>>>> c50863486bc646f0af288a1cdf987f6d29803a0b

        public Ticket()
        {
        }

        public Ticket(int ticketNum, string seatNum, string gate, Flight flightCode, string passangerName)
        {
            TicketNum = ticketNum;
            SeatNum = seatNum;
            Gate = gate;
            FlightCode = flightCode;
            PassangerName = passangerName;
        }

        
    }
}
