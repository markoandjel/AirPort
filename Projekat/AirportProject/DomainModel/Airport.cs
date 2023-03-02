using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.DomainModel
{ 

    public class Airport
    {
        public String Name { get; set; }
        public String Code { get; set; }
        public String City { get; set; }

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


