﻿using AirportProject.Controllers;
using AirportProject.DomainModel;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AirportProject
{
    public partial class UserForm : Form
    {
        private AirportController _airportController;
        private FlightController _flightController;
        private Neo4jConnect _klijent;
        private RedisConnect redisConnect;
        private Session _session;
        private List<Flight> flights;
        private List<Ticket> tickets;
        
        public UserForm()
        {
            _klijent = new Neo4jConnect("bolt://87.250.63.38:7687", "neo4j", "bazicari");
            redisConnect = new RedisConnect("87.250.63.38:6379");
            bool connected = redisConnect.Connect();
            if (!connected)
            {
                MessageBox.Show("Connection failed!");
            }
            InitializeComponent();
        }

        public UserForm(Session session)
        {
            _klijent = new Neo4jConnect("bolt://87.250.63.38:7687", "neo4j", "bazicari");
            redisConnect = new RedisConnect("87.250.63.38:6379");
            _session = session;
            bool connected = redisConnect.Connect();
            if (!connected)
            {
                MessageBox.Show("Connection failed!");
            }
            tickets = new List<Ticket>();
            var user = _session.Username;
            IDatabase db = redisConnect.GetDatabase();
          
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvFlights.Columns.Add("Price", "Price");
            dgvFlights.Columns.Add("Departure at", "Departure at");
            dgvFlights.Columns.Add("Arrival at", "Arrival at");

            dgvTickets.Columns.Add("TicketNum", "Ticket Number");
            dgvTickets.Columns.Add("SeatNum", "Seat Number");
            dgvTickets.Columns.Add("Gate", "Gate");

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
                this.flights = flightsFrom.Where(x => x.Destination.Name==nameTo && x.Start.Name==nameFrom).ToList<Flight>();
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

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            if(dgvFlights.SelectedRows.Count!=1)
            {
                MessageBox.Show("Please select one flight");
                return;
            }
            var index = dgvFlights.SelectedRows[0].Index;
            Flight flight = flights[index];
            var broj_mesta = flight.NumOfSeats;
            var slobodna_mesta = flight.FreeSeats;
            if (slobodna_mesta != 0) {
                Ticket ticket = new Ticket(broj_mesta+100,(broj_mesta--).ToString(),"2",flight.Code,_session.Username);
                tickets.Add(ticket);
                slobodna_mesta--;
                var json = JsonConvert.SerializeObject(ticket);
                var db = redisConnect.GetDatabase();
                db.StringSet(("Ticket "+ ticket.TicketNum).ToString(), json);

                dgvFlights.SelectedRows[0].Dispose();
                dgvTickets.Rows.Add(ticket.TicketNum.ToString(),ticket.SeatNum,ticket.Gate);
            }
            else
            {
                MessageBox.Show("Nema slobodnih mesta, proverite drugi termin leta");
                return;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            IDatabase db = redisConnect.GetDatabase();
            db.KeyDelete(_session.Username + "_Session");
            this.Close();
            LogInForm forma = new LogInForm();
            forma.ShowDialog();
        }

        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTickets.Columns.Add("TicketNum", "Ticket Number");
            dgvTickets.Columns.Add("SeatNum", "Seat Number");
            dgvTickets.Columns.Add("Gate", "Gate");
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            var index = dgvTickets.SelectedRows[0].Index;
            IDatabase db = redisConnect.GetDatabase();
            db.KeyDelete("Ticket " + tickets[index].TicketNum);
            dgvTickets.SelectedRows[0].Dispose();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {      
            IDatabase db = redisConnect.GetDatabase();
            db.KeyDelete(_session.Username + "_Session");
            this.Hide();
            this.Close();
            Application.Exit();
        }

        private void cbxAirportTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }      
    }
}
