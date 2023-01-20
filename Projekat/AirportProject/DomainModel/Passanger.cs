using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.DomainModel
{
    public class Passanger
    {
        private string _name;
        private int _passportNumber;

        public string Name { get => _name; set => _name = value; }
        public int PassportNumber { get => _passportNumber; set => _passportNumber = value; }

        public Passanger()
        {
        }

        public Passanger(string name, int passportNumber)
        {
            Name = name;
            PassportNumber = passportNumber;
        }

        
    }
}
