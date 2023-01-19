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
using AirportProject.Controllers;
using Neo4jClient;

namespace AirportProject
{
    public partial class Form1 : Form
    {
        private IGraphClient _client;
        private Neo4jConnect _klijent;

        public Form1()
        {
            _klijent = new Neo4jConnect();
            InitializeComponent();
        }


        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            String name = "Helsinki Airport";
            String code = "HEL";
            String city = "Helsinki";
            Airport airport = new Airport(name, code, city);
            AirportController A = new AirportController();
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
            
        }

        private void btnGetAllAirports_Click(object sender, EventArgs e)
        {
            List<Airport> listAirports = new List<Airport>();
            AirportController A = new AirportController();
            listAirports=A.GetAllAirports();
        }
    }
}
