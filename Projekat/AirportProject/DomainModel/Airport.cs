using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.DomainModel
{ 

    public class Airport
    {
        private String _name;
        private String _code;
        private String _city;

        public String Name { get => _name; set => _name = value; }
        public String Code { get => _code; set => _code = value; }
        public String City { get => _city; set => _city = value; }

        public Airport()
        {
        }

        public Airport(String name, String code, String city)
        {
            Name = name;
            Code = code;
            City = city;

        }

        
    }

}


