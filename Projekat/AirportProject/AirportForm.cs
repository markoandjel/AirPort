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
        private List<DomainModel.Airport> _listAirports=new List<DomainModel.Airport>();

        public AirportForm(Neo4jConnect klijent)
        {
            _airportController = new AirportController(klijent.Driver);
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
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            String name=tbxName.Text;
            String city=tbxCity.Text;
            String code=tbxCode.Text;
            Airport airport= new Airport(name,code,city);
            _airportController.CreateAirport(airport);

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
                _airportController.DeleteAirport(a);

                UpdateTable();
            }
            else
            {
                MessageBox.Show("Morate odabrati jedan aerodrom!");
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
                string newCity = tbxUpdateCity.Text;

                Airport newAirport  = new Airport(newName,newCode,newCity);
                Airport oldAirport = new Airport(oldName, oldCode, oldCity);
                _airportController.UpdateAirport(oldAirport,newAirport);

                UpdateTable();

                tbxUpdateCity.Text = "";
                tbxUpdateCode.Text = "";
                tbxUpdateName.Text = "";
            }
            else
            {
                MessageBox.Show("Morate odabrati jedan aerodrom!");
            }
           var row=dgvAirports.SelectedRows;
           //row.
        }

        private void dgvAirports_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxUpdateName.Text = dgvAirports.SelectedCells[0].Value.ToString();
            tbxUpdateCode.Text = dgvAirports.SelectedCells[1].Value.ToString();
            tbxUpdateCity.Text = dgvAirports.SelectedCells[2].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
