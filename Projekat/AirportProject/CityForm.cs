using AirportProject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportProject.DomainModel;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace AirportProject
{
    public partial class CityForm : Form
    {
        private CityController _cityController;
        private List<City> _listCities = new List<City>();
        public CityForm(Neo4jConnect klijent)
        {
            _cityController= new CityController(klijent.Driver);
            InitializeComponent();
        }
        

        private void UpdateTable()
        {
            _listCities = _cityController.GetAllCities();
            dgvCity.DataSource = _listCities;
            dgvCity.AutoResizeColumns();
        }

        private void btnUpdateAirport_Click(object sender, EventArgs e)
        {
            if (dgvCity.SelectedCells.Count == 2)
            {
                string oldName = dgvCity.SelectedCells[0].Value.ToString();
                string oldCountry = dgvCity.SelectedCells[1].Value.ToString();
                
                string newName = tbxNameUpdate.Text;
                string newCountry = tbxCountryUpdate.Text;
               

                City newCity = new City(newName, newCountry);
                City oldCity = new City(oldName, oldCountry);
                _cityController.UpdateCity(oldCity, newCity);

                UpdateTable();

                tbxNameUpdate.Text = "";
                tbxCountryUpdate.Text = "";
               
            }
            else
            {
                MessageBox.Show("Morate odabrati jedan grad!");
            }
            //var row = dgvCity.SelectedRows;
            //row.
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            String name = tbxNameAdd.Text;
            String country = tbxCountryAdd.Text;
            
            City city = new City(name, country);
            _cityController.CreateCity(city);

            tbxNameAdd.Text = "";
            tbxCountryAdd.Text = "";

            UpdateTable();
        }

        private void btnDeleteCity_Click(object sender, EventArgs e)
        {
            if (dgvCity.SelectedCells.Count == 2)
            {
                string name = dgvCity.SelectedCells[0].Value.ToString();
                string country = dgvCity.SelectedCells[1].Value.ToString();

                City c = _listCities
                    .Where(n => n.Name == name && n.Country == country).First();
                _cityController.DeleteCity(c);

                UpdateTable();
            }
            else
            {
                MessageBox.Show("Morate odabrati jedan grad!");
            }
        }

        private void CityForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void btnConnectToAirports_Click(object sender, EventArgs e)
        {
            if (dgvCity.SelectedCells.Count == 2)
            {
                string name = dgvCity.SelectedCells[0].Value.ToString();
                _cityController.ConnectDisconnectAirport(name, true);
            }
            else
                MessageBox.Show("Morate odabrati jedan grad!");
            
        }

        private void btnDisconnectAirports_Click(object sender, EventArgs e)
        {
            if (dgvCity.SelectedCells.Count == 2)
            {
                string name = dgvCity.SelectedCells[0].Value.ToString();
                _cityController.ConnectDisconnectAirport(name, false);
            }
            else
                MessageBox.Show("Morate odabrati jedan grad!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
