using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.DomainModel
{
    public class Plane
    {
        private string _manufacturer;
        private string _model;
        private Airline _airline;

        public string Manufacturer { get => _manufacturer; set => _manufacturer = value; }
        public string Model { get => _model; set => _model = value; }
        public Airline Airline { get => _airline; set => _airline = value; }

        public Plane(string manufacturer, string model, Airline airline)
        {
            Manufacturer = manufacturer;
            Model = model;
            Airline = airline;
        }

       
    }
}
