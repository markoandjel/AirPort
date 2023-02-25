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
        private Neo4jConnect _klijent;

        public FlightForm()
        {
            InitializeComponent();
        
        }
        public FlightForm(Neo4jConnect klijent)
        {
            _klijent = klijent;
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
            Airport start=new Airport("", lblFlightFrom.Text.Substring(lblFlightFrom.Text.IndexOf(':')+1), "");
            Airport dest = new Airport("", lblFlightTo.Text.Substring(lblFlightTo.Text.IndexOf(':')+1), "");

            DateTime timeofArrival = new DateTime(dtpArival.Value.Date.Year, 
                dtpArival.Value.Date.Month, dtpArival.Value.Date.Day,
                dtpArrivalTime.Value.Hour, dtpArrivalTime.Value.Minute,0);            

            DateTime timeofDeparture = dtpDeparture.Value.Date;
            timeofDeparture.AddHours(dtpDepartureTime.Value.Hour);
            timeofDeparture.AddMinutes(dtpDepartureTime.Value.Minute);
            int seats = ((int)numSeats.Value);
            int price = ((int)numPrice.Value);

            Flight flight = new Flight("asdf", dest, start, seats, seats, price, timeofArrival, timeofDeparture); 
            _flightController.CreateFlight(flight);
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
            Airport airport=new Airport(dgvAirports.SelectedCells[0].Value.ToString()
                , dgvAirports.SelectedCells[1].Value.ToString()
                , dgvAirports.SelectedCells[2].Value.ToString());
            if (rbtnFrom.Checked == true)
            {
                ShowFlights showflighFormFrom = new ShowFlights(_klijent,airport,true);
                showflighFormFrom.ShowDialog();
            }
            else if (rbtnTo.Checked == true)
            {
                ShowFlights showflighFormTo = new ShowFlights(_klijent,airport,false);
                showflighFormTo.ShowDialog();
            }
        }
    }
}
