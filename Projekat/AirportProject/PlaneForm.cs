using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportProject.Controllers;
using AirportProject.DomainModel;

namespace AirportProject
{
    public partial class PlaneForm : Form
    {
        private PlaneController _planeController;
        private List<Plane> _listPlanes = new List<Plane>();
        private string _airlineName;

        public PlaneForm()
        {
            InitializeComponent();
        }

        public PlaneForm(Neo4jConnect klijent, string name)
        {
            _planeController = new PlaneController(klijent.Driver);
            _airlineName = name;
            InitializeComponent();
            this.Text = name;
            UpdateTable();
        }

        private void UpdateTable()
        {

            String[] stringArray = new String[4];
            _listPlanes = _planeController.GetAllPlanes(_airlineName);

            dgvPlane.Rows.Clear();
            dgvPlane.ColumnCount = 4;

            String[] s = { "Manufacturer", "Model", "Code", "Airline" };

            for (int i = 0; i < 4; i++)
                dgvPlane.Columns[i].Name = s[i];

            foreach (Plane plane in _listPlanes)
            {

                stringArray[0] = plane.Manufacturer;
                stringArray[1] = plane.Model;
                stringArray[2] = plane.Code;
                stringArray[3] = plane.Airline.Name;
                dgvPlane.Rows.Add(stringArray);
            }

            dgvPlane.AutoResizeColumns();
        }

        private void btnCreatePlane_Click(object sender, EventArgs e)
        {
            Plane plane = new Plane(tbxManufacturer.Text, tbxModel.Text, tbxCode.Text, new Airline(_airlineName));
            _planeController.CreatePlane(plane);
            UpdateTable();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPlane.SelectedCells.Count == 4)
            {
                Plane planeNew = new Plane(tbxManufacturer.Text, tbxModel.Text, tbxCode.Text, new Airline(_airlineName));

                Plane planeOld = new Plane(dgvPlane.SelectedCells[0].Value.ToString(),
                                           dgvPlane.SelectedCells[1].Value.ToString(),
                                           dgvPlane.SelectedCells[2].Value.ToString(),
                                           new Airline(_airlineName));

                _planeController.UpdatePlane(planeOld, planeNew);
                UpdateTable();
            }
            else
                MessageBox.Show("Morate odabrati jedan avion!"); 
        }

        private void btnDeletePlane_Click(object sender, EventArgs e)
        {
            if (dgvPlane.SelectedCells.Count == 4)
            {
                Plane plane = new Plane(dgvPlane.SelectedCells[0].Value.ToString(),
                                          dgvPlane.SelectedCells[1].Value.ToString(),
                                          dgvPlane.SelectedCells[2].Value.ToString(),
                                          new Airline(_airlineName));

                _planeController.DeletePlane(plane);
                UpdateTable();
            }
           
            else
                MessageBox.Show("Morate odabrati jedan avion!");
        }
    }
}
