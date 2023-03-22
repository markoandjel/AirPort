using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.DomainModel
{
    public class Flight
    {
        private string _code;
        private Airport _destination;
        private Airport _start;
        private int _numOfSeats;
        private int _freeSeats;
        private int _price;
        private int _timeInMinutes;
        private DateTime _timeOfDeparture;
        private DateTime _timeOfArival;
        private string _airlineCode;

        public string AirlineCode { get => _airlineCode; set=>_airlineCode = value; }
        public string Code { get => _code; set => _code = value; }
        public Airport Destination { get => _destination; set => _destination = value; }
        public Airport Start { get => _start; set => _start = value; }
        public int NumOfSeats { get => _numOfSeats; set => _numOfSeats = value; }
        public int FreeSeats { get => _freeSeats; set => _freeSeats = value; }
        public int Price { get => _price; set => _price = value; }
        public int TimeInMinutes { get => _timeInMinutes; set => _timeInMinutes = value; }
        public DateTime TimeOfDeparture { get => _timeOfDeparture; set => _timeOfDeparture = value; }
        public DateTime TimeOfArival { get => _timeOfArival; set => _timeOfArival = value; }

        public Flight()
        {
        }

        public Flight(string code, Airport destination, Airport start, int numOfSeats, int freeSeats, int price,DateTime timeOfArival, DateTime timeOfDeparture, string airlineCode )
        {
            Price=price; 
            TimeInMinutes= (timeOfArival - timeOfDeparture).Minutes;
            NumOfSeats= numOfSeats;
            Code= code;
            Destination= destination;
            Start= start;
            FreeSeats= freeSeats;
            TimeOfArival= timeOfArival;
            TimeOfDeparture= timeOfDeparture;
            AirlineCode= airlineCode;
        }

        public Flight DeepCopy()
        {
            return (Flight)this.MemberwiseClone();
        }

       
    }
}
