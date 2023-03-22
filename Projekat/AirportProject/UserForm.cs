using AirportProject.Controllers;
using AirportProject.DomainModel;
using NHibernate.Util;
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
    public partial class UserForm : Form
    {
        private AirportController _airportController;
        private FlightController _flightController;
        private Neo4jConnect _klijent;
        private RedisConnect redisConnect;
        public UserForm()
        {
            _klijent = new Neo4jConnect("bolt://87.250.63.38:7687", "neo4j", "bazicari");
            redisConnect = new RedisConnect("87.250.63.38:6379");
            bool connected = redisConnect.Connect();
            if (!connected)
            {
                MessageBox.Show("Aj dodji kasnije ne mogu se povezujem sad");
            }
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvFlights.Columns.Add("Price", "Price");
            dgvFlights.Columns.Add("Departure at", "Departure at");
            dgvFlights.Columns.Add("Arrival at", "Arrival at");

            _flightController = new FlightController(_klijent.Driver);
            _airportController = new AirportController(_klijent.Driver);
            var airports=_airportController.GetAllAirports();

            foreach(var a in airports) 
            {
                cbxAirportTo.Items.Add(a.Name);
                cbxAriportFrom.Items.Add(a.Name);
            }
        }

        private void btnCheckFlights_Click(object sender, EventArgs e)
        {
            dgvFlights.Rows.Clear();
            if (cbxAirportTo.SelectedItem == null || cbxAriportFrom.SelectedItem == null)
            {
                MessageBox.Show("Please select airport");
                return;
            }
            string nameTo = cbxAirportTo.SelectedItem.ToString();
            string nameFrom = cbxAriportFrom.SelectedItem.ToString();
            List<Airport> airports = _airportController.GetAllAirports();
            Airport a = airports.Find(x => x.Name == nameFrom);
            if(a!= null) 
            {
                List<Flight> flightsFrom = _flightController.GetAllFlightsFrom(a);
                List<Flight> flights = flightsFrom.Where(x => x.Destination.Name==nameTo && x.Start.Name==nameFrom).ToList<Flight>();
                if(flights!=null) 
                {
                    foreach (var f in flights)
                    {
                        dgvFlights.Rows.Add(f.Price, f.TimeOfDeparture.ToString(), f.TimeOfArival.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Airport does not exists");
                return;
            }



        }

        private void cbxAriportFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
