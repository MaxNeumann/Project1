using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsLibrary; 

namespace CarsSolution
{
    public partial class CarEditForm : Form
    {
        public CarInfo _newCar = new CarInfo();
        public CarDriveList _listCaDrive = new CarDriveList(); 

        public CarEditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_newCar.CarID > 0)
            {
                _newCar.UpdateCar();
            }
            else{
                _newCar.InsertCar();
                foreach (CarDriveInfo drive in _listCaDrive)
                {
                    drive.CarID = _newCar.CarID;
                    drive.InsertNewCarDrive();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarEditForm_Load(object sender, EventArgs e)
        {
            ProducingCountryList _prodList = ProducingCountryList.GetProducingCountryList();
            producingCountryListBindingSource.DataSource = _prodList;

            BrandList _brList = BrandList.GetBrandList();
            brandListBindingSource.DataSource = _brList;

            carInfoBindingSource.DataSource = _newCar;
            carDriveListBindingSource.DataSource = null;
            _listCaDrive = CarDriveList.GetCarDrive(_newCar.CarID);
            carDriveListBindingSource.DataSource = _listCaDrive;
        }

        private void producingCountryIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DriveForm _form = new DriveForm();
            if (_form.ShowDialog() == DialogResult.OK)
            {
                CarDriveInfo _drive = new CarDriveInfo();
                _drive.DriveID = _form.DriveID;
                _drive.CarID = _newCar.CarID;
                _drive.DriveName = _form.DriveName;
                _listCaDrive.Add(_drive);

                carDriveListBindingSource.DataSource = null;
                carDriveListBindingSource.DataSource = _listCaDrive;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            int driveID = (int)carDriveListDataGridView.SelectedRows[0].Cells[0].Value;
            for (int i = _listCaDrive.Count - 1; i >= 0; i--)
            {
                if (_listCaDrive[i].CarDriveID == driveID)
                {
                    _listCaDrive.RemoveAt(i);
                    break;
                }
            }

            CarDriveInfo.DeleteCarDrive(driveID);
            carDriveListBindingSource.DataSource = null;
            carDriveListBindingSource.DataSource = _listCaDrive;


        }

    }
}
