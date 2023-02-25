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
    public partial class ShowFlights : Form
    {
        private FlightController _flightController;
        private Airport _airport;
        public ShowFlights()
        {
            InitializeComponent();
        }
        public ShowFlights(Neo4jConnect klijent,Airport airport)
        {
            _flightController=new FlightController(klijent.Driver);
            _airport = airport;
            InitializeComponent();
        }

        private void ShowFlights_Load(object sender, EventArgs e)
        {
           _flightController.GetAllFlightsFrom(_airport);
        }
    }
}
