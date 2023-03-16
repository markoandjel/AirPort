using AirportProject.Controllers;
using AirportProject.DomainModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AirportProject
{
    public partial class ShowFlights : Form
    {
        private FlightController _flightController;
        private List<Flight> _flights;
        private Airport _airport;
        private bool _from;
        public ShowFlights()
        {
            InitializeComponent();
        }
        public ShowFlights(Neo4jConnect klijent, Airport airport, bool from)
        {
            _flightController = new FlightController(klijent.Driver);
            _airport = airport;
            _from = from;
            InitializeComponent();
        }

        private void ShowFlights_Load(object sender, EventArgs e)
        {
            dgvFlights.AutoGenerateColumns = false;
            if (_from)
                dgvFlights.Columns.Add("Destination", "Destination");
            else
                dgvFlights.Columns.Add("Arriving from", "Arriving from");
            dgvFlights.Columns.Add("Departure", "Departure");
            dgvFlights.Columns.Add("Arrival", "Arrival");
            dgvFlights.Columns.Add("Price", "Price");
            dgvFlights.Columns.Add("FreeSeats", "FreeSeats");
            dgvFlights.Columns.Add("Seats", "Seats");
            dgvFlights.Columns.Add("Airline", "Airline");
            dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvFlights.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            if (_from)
            {
                _flights = _flightController.GetAllFlightsFrom(_airport);
                foreach (Flight f in _flights)
                {
                    dgvFlights.Rows.Add(f.Destination.Name, f.TimeOfDeparture, f.TimeOfArival, f.Price, f.FreeSeats, f.NumOfSeats, f.AirlineCode);
                }
                lblAirport.Text += "departuring from " + _airport.Name.ToString();
            }
            else
            {
                _flights = _flightController.GetAllFlightsTo(_airport);
                foreach (Flight f in _flights)
                {
                    dgvFlights.Rows.Add(f.Start.Name, f.TimeOfDeparture, f.TimeOfArival, f.Price, f.FreeSeats, f.NumOfSeats, f.AirlineCode);
                }
                lblAirport.Text += "arriving from " + _airport.Name.ToString();
            }


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
                dgvFlights.Rows.Add(f.Destination.Name, f.TimeOfDeparture, f.TimeOfArival, f.Price, f.FreeSeats, f.NumOfSeats, f.AirlineCode);
            }
        }

        private void dgvFlights_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvFlights.SelectedRows.Count != 1)
                MessageBox.Show("Please select one flight!");
            else
            {
                var index = dgvFlights.SelectedRows[0].Index; //index izabranog leta

                dtpDepartureDate.Value = _flights[index].TimeOfDeparture.Date; //datum poletanja

                DateTime depTime = new DateTime();
                dtpDeparutreTime.CustomFormat = "HH:mm";
                DateTime depTime2 = depTime.AddHours(_flights[index].TimeOfDeparture.Hour)
                    .AddMinutes(_flights[index].TimeOfDeparture.Minute);
                dtpDeparutreTime.Text = depTime2.ToString("HH:mm"); //vreme poletanja

                dtpArrivalDate.Value = _flights[index].TimeOfArival.Date; //datum sletanja
                DateTime arrTime = new DateTime();
                dtpArrivalTime.CustomFormat = "HH:mm";
                DateTime arr2Time = arrTime.AddHours(_flights[index].TimeOfArival.Hour)
                    .AddMinutes(_flights[index].TimeOfArival.Minute);
                dtpArrivalTime.Text = arr2Time.ToString("HH:mm"); //vreme sletanja

                numFreeSeats.Value = _flights[index].FreeSeats;
                numPrice.Value = _flights[index].Price;
                numSeats.Value = _flights[index].NumOfSeats;

                lblDestination.Text += _flights[index].Destination.Name.ToString();
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

                DateTime dateDep = new DateTime(dtpDepartureDate.Value.Year, dtpDepartureDate.Value.Month, dtpDepartureDate.Value.Day
                    , dtpDeparutreTime.Value.Hour, dtpDeparutreTime.Value.Minute, 0);
                flight.TimeOfDeparture = dateDep;

                DateTime dateArr = new DateTime(dtpArrivalDate.Value.Year, dtpArrivalDate.Value.Month, dtpArrivalDate.Value.Day
                    , dtpArrivalTime.Value.Hour, dtpArrivalTime.Value.Minute, 0);
                flight.TimeOfArival = dateArr;

                _flightController.UpdateFlight(flight);

                dgvFlights.Rows.Clear();

                if (_from)
                {
                    _flights = _flightController.GetAllFlightsFrom(_airport);
                    foreach (Flight f in _flights)
                    {
                        dgvFlights.Rows.Add(f.Destination.Name, f.TimeOfDeparture, f.TimeOfArival, f.Price, f.FreeSeats, f.NumOfSeats,f.AirlineCode);
                    }
                }
                else
                {
                    _flights = _flightController.GetAllFlightsTo(_airport);
                    foreach (Flight f in _flights)
                    {
                        dgvFlights.Rows.Add(f.Start.Name, f.TimeOfDeparture, f.TimeOfArival, f.Price, f.FreeSeats, f.NumOfSeats, f.AirlineCode);
                    }
                }




                MessageBox.Show("Flight has been successfully updated!");
            }
        }
    }
}
