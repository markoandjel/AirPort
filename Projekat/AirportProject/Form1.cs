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

namespace AirportProject
{
    public partial class Form1 : Form
    {
        public DatabaseConection _connector;
        
        public Form1()
        {   
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
            
        }

        private void btnGetAllAirports_Click(object sender, EventArgs e)
        {
            List<Airport> listAirports = new List<Airport>();
            AirportController A = new AirportController();
            listAirports=A.GetAllAirports();
        }
    }
}
