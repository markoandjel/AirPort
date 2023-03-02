using AirportProject.Controllers;
using AirportProject.DomainModel;
using Neo4j.Driver;
using NHibernate.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AirportProject
{
    public partial class AirportForm : Form
    {
        private AirportController _airportController;
        private CityController _cityController;
        private List<DomainModel.Airport> _listAirports=new List<DomainModel.Airport>();
        private List<City> _listCities=new List<City>();

        public AirportForm(Neo4jConnect klijent)
        {
            _airportController = new AirportController(klijent.Driver);
            _cityController = new CityController(klijent.Driver);
            InitializeComponent();
        }

        private void Airport_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void UpdateTable()
        {
            _listAirports = _airportController.GetAllAirports();
            dgvAirports.DataSource = _listAirports;
            dgvAirports.AutoResizeColumns();

            _listCities=_cityController.GetAllCities();

            dgvCities.DataSource=_listCities;
            dgvCities.AutoResizeColumns();
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            String name=tbxName.Text;
            String city=lblCitySelected.Text;
            String code=tbxCode.Text;
            if (city=="")
            {
                MessageBox.Show("Please select one city!");
                return;
            }
            Airport airport= new Airport(name,code,city);
            _airportController.CreateAirport(airport);

            _cityController.ConnectDisconnectAirport(city, true, "XXXX");

            MessageBox.Show("Successfully created airport!");

            UpdateTable();
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if(dgvAirports.SelectedCells.Count==3)
            {
                string name = dgvAirports.SelectedCells[0].Value.ToString();
                string code = dgvAirports.SelectedCells[1].Value.ToString();
                string city = dgvAirports.SelectedCells[2].Value.ToString();

                Airport a= _listAirports
                    .Where(p => p.Name == name && p.Code==code && p.City==city).First();

                _cityController.ConnectDisconnectAirport(city, false, a.Code);
                _airportController.DeleteAirport(a);


                UpdateTable();

                MessageBox.Show("Successfully deleted airport!");
            }
            else
            {
                MessageBox.Show("Please select one airport!");
            }
        }

        private void btnUpdateAirport_Click(object sender, EventArgs e)
        {
            if (dgvAirports.SelectedCells.Count==3)
            {
                string oldName = dgvAirports.SelectedCells[0].Value.ToString();
                string oldCode = dgvAirports.SelectedCells[1].Value.ToString();
                string oldCity = dgvAirports.SelectedCells[2].Value.ToString();
                string newName = tbxUpdateName.Text;
                string newCode = tbxUpdateCode.Text;
                string newCity = lblUpdateCity.Text;

                Airport newAirport  = new Airport(newName,newCode,newCity);
                Airport oldAirport = new Airport(oldName, oldCode, oldCity);
                _airportController.UpdateAirport(oldAirport,newAirport);

                if(oldCity!=newCity)
                {
                    _cityController.ConnectDisconnectAirport(oldCity, false, oldCode);
                    _cityController.ConnectDisconnectAirport(newCity, true, newCode);
                }
                

                UpdateTable();

                lblUpdateCity.Text = "";
                tbxUpdateCode.Text = "";
                tbxUpdateName.Text = "";

                MessageBox.Show("Successfully updated airport!");
            }
            else
            {
                MessageBox.Show("Please select one airport!");
            }
           var row=dgvAirports.SelectedRows;
           //row.
        }

        private void dgvAirports_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxUpdateName.Text = dgvAirports.SelectedCells[0].Value.ToString();
            tbxUpdateCode.Text = dgvAirports.SelectedCells[1].Value.ToString();
            lblUpdateCity.Text = dgvAirports.SelectedCells[2].Value.ToString();
        }

        private void btnUpdateCity_Click(object sender, EventArgs e)
        {
            if (dgvCities.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one city!");
            }
            else
            {
                lblUpdateCity.Text= dgvCities.SelectedCells[0].Value.ToString();
            }
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            if (dgvCities.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one city!");
            }
            else
            {
                lblCitySelected.Text = dgvCities.SelectedCells[0].Value.ToString();
            }
        }
    }
}
