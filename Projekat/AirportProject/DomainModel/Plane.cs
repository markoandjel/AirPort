using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AirportProject.DomainModel
{
    public class Plane
    {
        private string _manufacturer;
        private string _model;
       
        private string _code;
        private Airline _airline;

        public string Manufacturer { get => _manufacturer; set => _manufacturer = value; }
        public string Model { get => _model; set => _model = value; }
        public Airline Airline { get => _airline; set => _airline = value; }
        public string Code {get=>_code; set => _code = value; }

        public Plane(string manufacturer, string model, string code, Airline airline)
        {
            Manufacturer = manufacturer;
            Model = model;
            Code = code;
            Airline = airline;
        }

       
    }
}
