using AirportProject.Controllers;
using AirportProject.DomainModel;
using NHibernate.Event;
using NHibernate.Id;
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
        private List<Flight> _flights;
        private Airport _airport;
        public ShowFlights()
        {
            InitializeComponent();
        }
        public ShowFlights(Neo4jConnect klijent, Airport airport)
        {
            _flightController = new FlightController(klijent.Driver);
            _airport = airport;
            InitializeComponent();
        }

        private void ShowFlights_Load(object sender, EventArgs e)
        {
            dgvFlights.AutoGenerateColumns = false;
            dgvFlights.Columns.Add("Destination", "Destination");
            dgvFlights.Columns.Add("Departure", "Departure");
            dgvFlights.Columns.Add("Arrival", "Arrival");
            dgvFlights.Columns.Add("Price", "Price");
            dgvFlights.Columns.Add("FreeSeats", "FreeSeats");
            dgvFlights.Columns.Add("Seats", "Seats");
            dgvFlights.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvFlights.AutoSizeRowsMode=DataGridViewAutoSizeRowsMode.AllCells;

            _flights = _flightController.GetAllFlightsFrom(_airport);
            foreach (Flight f in _flights)
            {
                dgvFlights.Rows.Add(f.Destination.Name, f.TimeOfDeparture, f.TimeOfArival, f.Price, f.FreeSeats, f.NumOfSeats);
            }
            //dgvFlights.Columns.Add("Destination", "Destination");
            //dgvFlights.Columns[0].(flights[0].Destination.Name);
            //dgvFlights.DataSource = flights;
            //dgvFlights.Columns.RemoveAt(2);
            //dgvFlights.Columns.RemoveAt(3);
            lblAirport.Text += "departuring from " + _airport.Name.ToString();
        }
        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (dgvFlights.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one flight!");
                return;
            }
            var index = dgvFlights.SelectedRows[0].Index;
            _flightController.DeleteFlight(_flights[index]);
            _flights.RemoveAt(index);
            dgvFlights.Rows.Clear();
            foreach (Flight f in _flights)
            {
                dgvFlights.Rows.Add(f.Destination.Name, f.TimeOfDeparture, f.TimeOfArival, f.Price, f.FreeSeats, f.NumOfSeats);
            }
        }

        private void dgvFlights_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvFlights.SelectedRows.Count!=1)
            MessageBox.Show("Please select one flight!");
            else
            {
                var index = dgvFlights.SelectedRows[0].Index; //index izabranog leta

                dtpDepartureDate.Value= _flights[index].TimeOfDeparture.Date; //datum poletanja

                DateTime depTime = new DateTime();
                dtpDeparutreTime.CustomFormat="HH:mm";
                DateTime depTime2=depTime.AddHours(_flights[index].TimeOfDeparture.Hour)
                    .AddMinutes(_flights[index].TimeOfDeparture.Minute);
                dtpDeparutreTime.Text = depTime2.ToString("HH:mm"); //vreme poletanja

                dtpArrivalDate.Value = _flights[index].TimeOfArival.Date; //datum sletanja
                DateTime arrTime = new DateTime();
                dtpArrivalTime.CustomFormat = "HH:mm";
                DateTime arr2Time=arrTime.AddHours(_flights[index].TimeOfArival.Hour)
                    .AddMinutes(_flights[index].TimeOfArival.Minute);
                dtpArrivalTime.Text = arr2Time.ToString("HH:mm"); //vreme sletanja

                numFreeSeats.Value = _flights[index].FreeSeats;
                numPrice.Value= _flights[index].Price;
                numSeats.Value = _flights[index].NumOfSeats;
                label6.Text += _flights[index].Destination.Name.ToString();
            }
        }

        private void btnUpdateFlight_Click(object sender, EventArgs e)
        {
            if (dgvFlights.SelectedRows.Count != 1)
                MessageBox.Show("Please select one flight!");
            else
            {
                var index = dgvFlights.SelectedRows[0].Index; //index izabranog leta

                Flight flight = _flights[index];
                flight.FreeSeats = (int)numFreeSeats.Value;
                flight.Price = (int)numPrice.Value;
                flight.NumOfSeats = (int)numSeats.Value;

                DateTime dateDep = new DateTime(dtpDepartureDate.Value.Year,dtpDepartureDate.Value.Month,dtpDepartureDate.Value.Day
                    ,dtpDeparutreTime.Value.Hour,dtpDeparutreTime.Value.Minute,0);
                flight.TimeOfDeparture = dateDep;

                DateTime dateArr = new DateTime(dtpArrivalDate.Value.Year, dtpArrivalDate.Value.Month, dtpArrivalDate.Value.Day
                    , dtpArrivalTime.Value.Hour, dtpArrivalTime.Value.Minute, 0);
                flight.TimeOfArival = dateArr;

                _flightController.UpdateFlight(flight);

                _flights = _flightController.GetAllFlightsFrom(_airport);
                dgvFlights.Rows.Clear();
                foreach (Flight f in _flights)
                {
                    dgvFlights.Rows.Add(f.Destination.Name, f.TimeOfDeparture, f.TimeOfArival, f.Price, f.FreeSeats, f.NumOfSeats);
                }

                MessageBox.Show("Flight has been successfully updated!");
            }
        }
    }
}
