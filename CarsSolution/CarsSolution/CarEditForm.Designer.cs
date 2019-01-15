namespace CarsSolution
{
    partial class CarEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.carDriveListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.producingCountryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carReleaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.brandIDComboBox = new System.Windows.Forms.ComboBox();
            this.carNameTextBox = new System.Windows.Forms.TextBox();
            this.producingCountryIDComboBox = new System.Windows.Forms.ComboBox();
            this.carDriveListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.carDriveListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producingCountryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDriveListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // carDriveListBindingSource
            // 
            this.carDriveListBindingSource.DataSource = typeof(CarsLibrary.CarDriveInfo);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(249, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(665, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // producingCountryListBindingSource
            // 
            this.producingCountryListBindingSource.DataSource = typeof(CarsLibrary.ProducingCountryList);
            // 
            // brandListBindingSource
            // 
            this.brandListBindingSource.DataSource = typeof(CarsLibrary.BrandList);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата сборки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Наименование:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Страна:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Бренд:";
            // 
            // carInfoBindingSource
            // 
            this.carInfoBindingSource.DataSource = typeof(CarsLibrary.CarInfo);
            // 
            // carReleaseDateDateTimePicker
            // 
            this.carReleaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carInfoBindingSource, "CarReleaseDate", true));
            this.carReleaseDateDateTimePicker.Location = new System.Drawing.Point(249, 27);
            this.carReleaseDateDateTimePicker.Name = "carReleaseDateDateTimePicker";
            this.carReleaseDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.carReleaseDateDateTimePicker.TabIndex = 14;
            // 
            // brandIDComboBox
            // 
            this.brandIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carInfoBindingSource, "BrandID", true));
            this.brandIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carInfoBindingSource, "BrandID", true));
            this.brandIDComboBox.DataSource = this.brandListBindingSource;
            this.brandIDComboBox.DisplayMember = "BrandName";
            this.brandIDComboBox.FormattingEnabled = true;
            this.brandIDComboBox.Location = new System.Drawing.Point(249, 156);
            this.brandIDComboBox.Name = "brandIDComboBox";
            this.brandIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.brandIDComboBox.TabIndex = 15;
            this.brandIDComboBox.ValueMember = "BrandID";
            // 
            // carNameTextBox
            // 
            this.carNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carInfoBindingSource, "CarName", true));
            this.carNameTextBox.Location = new System.Drawing.Point(249, 69);
            this.carNameTextBox.Name = "carNameTextBox";
            this.carNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.carNameTextBox.TabIndex = 16;
            // 
            // producingCountryIDComboBox
            // 
            this.producingCountryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carInfoBindingSource, "ProducingCountryID", true));
            this.producingCountryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carInfoBindingSource, "ProducingCountryID", true));
            this.producingCountryIDComboBox.DataSource = this.producingCountryListBindingSource;
            this.producingCountryIDComboBox.DisplayMember = "ProducingCountryName";
            this.producingCountryIDComboBox.FormattingEnabled = true;
            this.producingCountryIDComboBox.Location = new System.Drawing.Point(249, 115);
            this.producingCountryIDComboBox.Name = "producingCountryIDComboBox";
            this.producingCountryIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.producingCountryIDComboBox.TabIndex = 17;
            this.producingCountryIDComboBox.ValueMember = "ProducingCountryID";
            // 
            // carDriveListDataGridView
            // 
            this.carDriveListDataGridView.AllowUserToAddRows = false;
            this.carDriveListDataGridView.AllowUserToDeleteRows = false;
            this.carDriveListDataGridView.AutoGenerateColumns = false;
            this.carDriveListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDriveListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.carDriveListDataGridView.DataSource = this.carDriveListBindingSource;
            this.carDriveListDataGridView.Location = new System.Drawing.Point(515, 27);
            this.carDriveListDataGridView.Name = "carDriveListDataGridView";
            this.carDriveListDataGridView.ReadOnly = true;
            this.carDriveListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carDriveListDataGridView.Size = new System.Drawing.Size(212, 150);
            this.carDriveListDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CarDriveID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CarDriveID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DriveID";
            this.dataGridViewTextBoxColumn2.HeaderText = "DriveID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CarID";
            this.dataGridViewTextBoxColumn3.HeaderText = "CarID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DriveName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Двигатель:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // CarEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 323);
            this.Controls.Add(this.carDriveListDataGridView);
            this.Controls.Add(this.producingCountryIDComboBox);
            this.Controls.Add(this.carNameTextBox);
            this.Controls.Add(this.brandIDComboBox);
            this.Controls.Add(this.carReleaseDateDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CarEditForm";
            this.Text = "CarEditForm";
            this.Load += new System.EventHandler(this.CarEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carDriveListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producingCountryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDriveListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource carInfoBindingSource;
        private System.Windows.Forms.BindingSource brandListBindingSource;
        private System.Windows.Forms.BindingSource producingCountryListBindingSource;
        private System.Windows.Forms.BindingSource carDriveListBindingSource;
        private System.Windows.Forms.DateTimePicker carReleaseDateDateTimePicker;
        private System.Windows.Forms.ComboBox brandIDComboBox;
        private System.Windows.Forms.TextBox carNameTextBox;
        private System.Windows.Forms.ComboBox producingCountryIDComboBox;
        private System.Windows.Forms.DataGridView carDriveListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}