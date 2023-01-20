using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.DomainModel
{
    public class Passenger
    {
        public string Name { get; set; }
        public int PassportNumber { get; set; }

        public Passenger()
        {
        }

        public Passenger(string name, int passportNumber)
        {
            Name = name;
            PassportNumber = passportNumber;
        }

        
    }
}
