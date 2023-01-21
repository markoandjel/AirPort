using AirportProject.Controllers;
using AirportProject.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportProject
{
    public partial class FlightForm : Form
    {
        private FlightController _flightController;
        private AirportController _airportController;

        public FlightForm()
        {
            InitializeComponent();
        
        }
        public FlightForm(Neo4jConnect klijent)
        {
            _flightController = new FlightController(klijent.Driver);
            _airportController = new AirportController(klijent.Driver);
            InitializeComponent();
        }

        private void FlightForm_Load(object sender, EventArgs e)
        {
            dgvAirports.DataSource=_airportController.GetAllAirports();
        }

        private void btnCreateFlight_Click(object sender, EventArgs e)
        {
            Airport start=new Airport("Konstantin Veliki","SIN","Nis");
            Airport dest = new Airport("Nikola Tesla", "BEG", "Belgrade");
            DateTime timeofArival=new DateTime(2023,1,21,13,4,0);
            DateTime timeOfDeparture = new DateTime(2023, 1, 23, 13, 4, 0);
            Flight flight = new Flight("asdf", dest, start, 10, 2, 130, timeofArival, timeOfDeparture); 
            _flightController.CreateFlight(flight);
        }
    }
}
