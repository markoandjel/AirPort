using AirportProject.Controllers;
using AirportProject.DomainModel;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace AirportProject
{
    public partial class AdminForm : Form
    {
        private Neo4jConnect _klijent;
        private RedisConnect redisConnect;
        public AdminForm()
        {
            //InitializeComponent();
            _klijent = new Neo4jConnect("bolt://87.250.63.38:7687", "neo4j","bazicari");
            redisConnect = new RedisConnect("87.250.63.38:6379");
            bool connected = redisConnect.Connect();
            if (!connected)
            {
                MessageBox.Show("Aj dodji kasnije ne mogu se povezujem sad");
            }
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //String databaseName = "airport";
            //string url = "http://localhost:7474/" + databaseName;
            //string username = "neo4j";
            //string password = "password";
            //_client = new GraphClient(new Uri(url), username, password);
            //_client.ConnectAsync();
            //_klijent = new Neo4jConnect("bolt://localhost:7687", "neo4j", "password");

            AirportController a = new AirportController(_klijent.Driver);
            var airports=a.GetAllAirports();
            foreach(var p in airports)
            {
                cbxAirports.Items.Add(p.Name);
            }
            dgvMessages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addPassenger_Click(object sender, EventArgs e)
        {
            String name = "Marko Andjelkovic";
            int passport = 22315543;
            Passenger passenger = new Passenger(name, passport);
            PassengerController p = new PassengerController(_klijent.Driver);
            p.CreatePassenger(passenger);

        }

        private void addTicket_Click(object sender, EventArgs e)
        {
            //int number = 12;
            //string seatnum = "22";
            //string gate = "5";
            //string fcode = "2344";
            //string passenger = "Marko Andjelkovic";
            //Flight flight= new Flight();
            //Ticket ticket = new Ticket(number,seatnum, gate, fcode,passenger);  
            //TicketController t = new TicketController(_klijent.Driver);
            //t.createTicket(ticket);
        }

     

        private void btnAirportManager_Click(object sender, EventArgs e)
        {
            AirportForm airportForm=new AirportForm(_klijent);
            airportForm.ShowDialog();
        }

        private void btnFlightManager_Click(object sender, EventArgs e)
        {
            FlightForm flighForm = new FlightForm(_klijent,redisConnect);
            flighForm.ShowDialog();
        }

        private void btnCityManager_Click(object sender, EventArgs e)
        {
            CityForm cityForm = new CityForm(_klijent);
            cityForm.ShowDialog();
        }

        private void btnAirlineManager_Click(object sender, EventArgs e)
        {
            AirlineForm airlineForm=new AirlineForm(_klijent);
            airlineForm.ShowDialog();
        }

        private void cbxAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMessages.Rows.Clear();
            ISubscriber p = redisConnect.PubSub();

            p.UnsubscribeAll();

            AirportController a = new AirportController(_klijent.Driver);
            var airports = a.GetAllAirports();
            Airport selectAirport = airports.Find(x => x.Name == cbxAirports.SelectedItem.ToString());

            FlightController flights = new FlightController(_klijent.Driver);

            foreach (var v in flights.GetAllFlightsFrom(selectAirport))
            {
                string j = v.Code;
                p.Subscribe(j, (channel, message) =>
                {
                    dgvMessages.Invoke(new Action(() => { dgvMessages.Rows.Add(message);}));
                });
            }

            foreach (var v in flights.GetAllFlightsTo(selectAirport))
            {
                string j = v.Code;
                p.Subscribe(j, (channel, message) =>
                {
                    dgvMessages.Invoke(new Action(() => { dgvMessages.Rows.Add(message); }));
                });
            }
        }
    }
}
