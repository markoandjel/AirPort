using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.DomainModel
{
    public class City
    {
        private String _name;
        private String _country;

        public String Name { get => _name; set => _name = value; }
        public String Country { get => _country; set => _country = value; }

        public City()
        { 
        }

        public City(string name, string country)
        {
            Name = name;
            Country = country;
        }

       
    }
}
