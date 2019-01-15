using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsLibrary; 

namespace CarsSolution
{
    public partial class CarForm : Form
    {
        CarList _carList = new CarList(); 
        public CarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            RefreshCarList(); 
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            BrandList brandList = BrandList.GetBrandList();
            brandListBindingSource.DataSource = brandList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarEditForm newForm = new CarEditForm();
            newForm.ShowDialog();
            RefreshCarList();
        }
        void RefreshCarList()
        {
            int BrID = (int)comboBox1.SelectedValue;

            _carList = CarList.GetDefaultCarList(BrID, textBox1.Text);
            carListBindingSource.DataSource = null;
            carListBindingSource.DataSource = _carList;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void carListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int caID = (int)carListDataGridView.SelectedRows[0].Cells[0].Value;

            foreach (CarInfo car in _carList)
            {
                if (car.CarID == caID)
                {
                    car.DeleteCar();
                }
            }
            RefreshCarList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int caID = (int)carListDataGridView.SelectedRows[0].Cells[0].Value;

            CarEditForm newForm = new CarEditForm();
            foreach (CarInfo car in _carList)
            {
                if (car.CarID == caID)
                {
                    car.GetCar(caID);
                    newForm._newCar = car;
                    if (newForm.ShowDialog() == DialogResult.OK)
                    {
                        newForm._newCar.UpdateCar();
                    }
                }

            }
            RefreshCarList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RefreshCarList();
        }


    }
}
