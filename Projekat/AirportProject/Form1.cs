using AirportProject.DomainModel;
using AirportProject.Controllers;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Neo4jClient;

namespace AirportProject
{
    public partial class Form1 : Form
    {
        private Neo4jConnect _klijent;

        public Form1()
        {
            _klijent = new Neo4jConnect("bolt://localhost:7687", "neo4j","password");
            InitializeComponent();
        }


        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            String name = "Sofia Airport";
            String code = "SO";
            String city = "Sofia";
            DomainModel.Airport airport = new DomainModel.Airport(name, code, city);
            AirportController A = new AirportController(_klijent.Driver);
            A.CreateAirport(airport);
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

        }

        private void btnGetAllAirports_Click(object sender, EventArgs e)
        {
            List<DomainModel.Airport> listAirports = new List<DomainModel.Airport>();
            AirportController A = new AirportController(_klijent.Driver);
            listAirports=A.GetAllAirports();
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

        private void btnUpdateAirport_Click(object sender, EventArgs e)
        {
            String name = "Sofia Airport";
            String code = "SO";
            String city = "Sofia";
            DomainModel.Airport airport = new DomainModel.Airport(name, code, city);
            AirportController A = new AirportController(_klijent.Driver);
            A.UpdateAirport(airport, new DomainModel.Airport("Belgrade Airport","BGD","Belgrade"));
        }

        private void btnAirportManager_Click(object sender, EventArgs e)
        {
            AirportForm airportForm=new AirportForm(_klijent);
            airportForm.ShowDialog();
        }

        private void btnFlightManager_Click(object sender, EventArgs e)
        {
            FlightForm flighForm = new FlightForm(_klijent);
            flighForm.ShowDialog();
        }

        private void btnCityManager_Click(object sender, EventArgs e)
        {
            CityForm cityForm = new CityForm(_klijent);
            cityForm.ShowDialog();
        }
    }
}
