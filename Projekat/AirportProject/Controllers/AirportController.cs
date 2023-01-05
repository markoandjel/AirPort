using AirportProject.DomainModel;
using AirportProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AirportProject.Controllers;
using Neo4j.Driver;
using System.Windows.Forms;

namespace AirportProject.Controllers
{
    public class AirportController:Controller
    {
        public void CreateAirport(Airport a)
        {

            var session = Connector.Driver.Session();
            try
            {
                session.Run("MERGE(a:Airport{city:$city, name:$name, code:$code })", new { name=a.Name, code=a.Code, city=a.City });
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            session.Dispose();
        }
    }
}
