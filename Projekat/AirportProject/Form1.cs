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
            String name = "Helsinki Airport";
            String code = "HEL";
            String city = "Helsinki";
            Airport airport = new Airport(name, code, city);
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
            List<Airport> listAirports = new List<Airport>();
            AirportController A = new AirportController(_klijent.Driver);
            listAirports=A.GetAllAirports();
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            String name = "Helsinki Airport";
            String code = "HEL";
            String city = "Helsinki";
            Airport airport = new Airport(name, code, city);
            AirportController A = new AirportController(_klijent.Driver);
            A.DeleteAirport(airport);
        }

        private void btnUpdateAirport_Click(object sender, EventArgs e)
        {
            String name = "Helsinki Airport";
            String code = "HEL";
            String city = "Helsinki";
            Airport airport = new Airport(name, code, city);
            name = "flkadjsflka";
            code = "HEL";
            city = "nalkjSjkla";
            Airport airport2 = new Airport(name, code, city);
            AirportController A = new AirportController(_klijent.Driver);
            A.UpdateAirport(airport, airport2);
        }

        private void btnCreateFlight_Click(object sender, EventArgs e)
        {
            String name = "Helsinki Airport";
            String code = "HEL";
            String city = "Helsinki";
            Airport airport = new Airport(name, code, city);
            name = "Dubai International Airport";
            code = "DXB";
            city = "Dubai";
            Airport airport2 = new Airport(name, code, city);

            Flight flight= new Flight("sdfa",airport,airport2,180,40,340,new DateTime(2023,1,20,13,55,55));

            FlightController F = new FlightController(_klijent.Driver);
            F.CreateFlight(flight);
        }
    }
}
