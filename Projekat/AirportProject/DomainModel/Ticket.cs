using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.DomainModel
{
    public class Ticket
    {
        private int _ticketNum;
        private string _seatNum;
        private string _gate;
        private string _flightCode;
        private string _passangerName;

        public int TicketNum { get => _ticketNum; set => _ticketNum = value; }
        public string SeatNum { get => _seatNum; set => _seatNum = value; }
        public string Gate { get => _gate; set => _gate = value; }
        public string FlightCode { get => _flightCode; set => _flightCode = value; }
        public string PassangerName { get => _passangerName; set => _passangerName = value; }

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
