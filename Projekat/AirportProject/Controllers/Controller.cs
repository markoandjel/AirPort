using AirportProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.Controllers
{
    public class Controller
    {
        private static readonly Controller instance = new Controller();
        private static readonly DatabaseConection  _connector;
        static Controller()
        {
            string s = "bolt://localhost:7687/Airport";
            _connector = new DatabaseConection(new Uri(s), "neo4j", "grgeci007");
        }
        protected Controller()
        {
            
        }

        public static Controller Instance
        {
            get
            {
                return instance;
            }
        }

        public static DatabaseConection Connector => _connector;
    }
}
