using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsLibrary; 

namespace CarsSolution
{
    public partial class DriveForm : Form
    {
        public DriveForm()
        {
            InitializeComponent();
        }

        public int DriveID = 0;
        public string DriveName = "";
        private void DriveForm_Load(object sender, EventArgs e)
        {
            driveListBindingSource.DataSource = DriveList.GetDriveList();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DriveID = (int)driveListDataGridView.SelectedRows[0].Cells[0].Value;
            DriveName = driveListDataGridView.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        } 

    }
}
