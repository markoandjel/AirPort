using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.DomainModel
{
    public class Airline
    {
        private string _name;
        private List<Flight> _flights;

        public string Name { get => _name; set => _name = value; }
        public List<Flight> Flights { get => _flights; set => _flights = value; }

        public Airline() { }

        public Airline(string name, List<Flight> flights)
        {
            Name = name;
            Flights = flights;
            
        }
        public Airline(string name)
        {
            Name = name;

        }
    }
}
