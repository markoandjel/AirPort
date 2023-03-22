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
        private AirlineController _airlineController;
        private Neo4jConnect _klijent;
        private RedisConnect redisConnect;

        public FlightForm()
        {
            InitializeComponent();
        
        }
        public FlightForm(Neo4jConnect klijent, RedisConnect redisConnect)
        {
            _klijent = klijent;
            _flightController = new FlightController(klijent.Driver);
            _airportController = new AirportController(klijent.Driver);
            _airlineController = new AirlineController(klijent.Driver);
            InitializeComponent();
            this.redisConnect = redisConnect;
        }

        private void FlightForm_Load(object sender, EventArgs e)
        {
            dgvAirports.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dgvAirports.AutoSizeRowsMode=DataGridViewAutoSizeRowsMode.None;
            dgvAirports.DataSource=_airportController.GetAllAirports();
            dgvAirlines.DataSource=_airlineController.GetAllAirlines();
            lblAirlineCode.Text = "";
        }

        private void btnCreateFlight_Click(object sender, EventArgs e)
        {             
            Airport start=new Airport("", lblFlightFrom.Text.Substring(lblFlightFrom.Text.IndexOf(':')+1), "");
            Airport dest = new Airport("", lblFlightTo.Text.Substring(lblFlightTo.Text.IndexOf(':')+1), "");

            DateTime timeofArrival = new DateTime(dtpArival.Value.Date.Year, 
                dtpArival.Value.Date.Month, dtpArival.Value.Date.Day,
                dtpArrivalTime.Value.Hour, dtpArrivalTime.Value.Minute,0);

            DateTime timeofDeparture = new DateTime(dtpDeparture.Value.Date.Year,
                dtpDeparture.Value.Date.Month, dtpDeparture.Value.Date.Day,
                dtpDepartureTime.Value.Hour, dtpDepartureTime.Value.Minute, 0);
            int seats = ((int)numSeats.Value);
            int price = ((int)numPrice.Value);

            if (lblAirlineCode.Text == "")
            {
                MessageBox.Show("Please select Airline");
                return;
            }

            string airlineCode = lblAirlineCode.Text;

            string id= String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);

            Flight flight = new Flight(id, dest, start, seats, seats, price, timeofArrival, timeofDeparture, airlineCode); 
            _flightController.CreateFlight(flight);
            MessageBox.Show("Successfully created a flight");
        }

        private void btnSwapDestinations_Click(object sender, EventArgs e)
        {
            (lblFlightFrom.Text, lblFlightTo.Text) = (lblFlightTo.Text, lblFlightFrom.Text);

        }

        private void dgvAirports_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvAirports.SelectedCells.Count == 3 && lblFlightFrom.Text == "")
            {
                lblFlightFrom.Text = dgvAirports.SelectedCells[0].Value.ToString()+", CODE:"
                    +dgvAirports.SelectedCells[1].Value.ToString();
            }
            else if(dgvAirports.SelectedCells.Count == 3)
            {
                lblFlightTo.Text = dgvAirports.SelectedCells[0].Value.ToString() + ", CODE:"
                    + dgvAirports.SelectedCells[1].Value.ToString(); 
            }            
        }

        private void btnShowFlights_Click(object sender, EventArgs e)
        {
            if (dgvAirports.SelectedCells.Count!=3)
            {
                MessageBox.Show("Please select one airport");
                return;
            }    
            Airport airport=new Airport(dgvAirports.SelectedCells[0].Value.ToString()
                , dgvAirports.SelectedCells[1].Value.ToString()
                , dgvAirports.SelectedCells[2].Value.ToString());
            if (rbtnFrom.Checked == true)
            {
                ShowFlights showflighFormFrom = new ShowFlights(_klijent,airport,true, redisConnect);
                showflighFormFrom.ShowDialog();
            }
            else if (rbtnTo.Checked == true)
            {
                ShowFlights showflighFormTo = new ShowFlights(_klijent,airport,false, redisConnect);
                showflighFormTo.ShowDialog();
            }
        }

        private void dgvAirlines_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblAirlineCode.Text = dgvAirlines.SelectedCells[0].Value.ToString();    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
