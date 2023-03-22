using AirportProject.Controllers;
using AirportProject.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportProject
{
    public partial class AirlineForm : Form
    {

        private Neo4jConnect _klijent;
        private AirlineController _airlineController;
        private PlaneController _planeController;
        private List<Airline> _listAirlines = new List<Airline>();

        public AirlineForm(Neo4jConnect klijent)
        {
            _klijent = klijent;
            _airlineController = new AirlineController(klijent.Driver);
            _planeController = new PlaneController(klijent.Driver);
            InitializeComponent();
            UpdateTable();
        }

        private void UpdateTable()
        {
            _listAirlines = _airlineController.GetAllAirlines();
            dgvAirline.DataSource = _listAirlines ;
            dgvAirline.AutoResizeColumns();
        }

        private void btnUpdateAirline_Click(object sender, EventArgs e)
        {
            if (dgvAirline.SelectedCells.Count == 1)
            {
                string oldName = dgvAirline.SelectedCells[0].Value.ToString();
      

                string newName = tbxNameUpdate.Text;
                


                Airline newAirline = new Airline(newName);
               Airline oldAirline = new Airline(oldName);
                _airlineController.UpdateAirline(oldAirline, newAirline);

                UpdateTable();

                tbxNameUpdate.Text = "";
               
            }
            else
            {
                MessageBox.Show("Morate odabrati jednu avio kompaniju!");
            }
        }

        private void btnAddAirline_Click(object sender, EventArgs e)
        {
            String name = tbxNameAdd.Text;

            Airline airline = new Airline(name);
            _airlineController.CreateAirline(airline);

            tbxNameAdd.Text = "";

            UpdateTable();
        }

        private void btnDeleteAirline_Click(object sender, EventArgs e)
        {
            if (dgvAirline.SelectedCells.Count == 1)
            {
                string name = dgvAirline.SelectedCells[0].Value.ToString();

                Airline a = _listAirlines
                    .Where(n => n.Name == name).First();
                _airlineController.DeleteAirline(a);

                UpdateTable();
            }
            else
            {
                MessageBox.Show("Morate odabrati jednu avio kompaniju!");
            }
        }

        private void btnShowEditPlanes_Click(object sender, EventArgs e)
        {
            if (dgvAirline.SelectedCells.Count == 1)
            {
                string name = dgvAirline.SelectedCells[0].Value.ToString();
                PlaneForm planeForm = new PlaneForm(_klijent,name);
                planeForm.ShowDialog();

            }

            else
            {
                MessageBox.Show("Morate odabrati jednu avio kompaniju!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
