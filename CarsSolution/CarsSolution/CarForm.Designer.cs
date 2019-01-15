namespace CarsSolution
{
    partial class CarForm
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
            this.carListDataGridView = new System.Windows.Forms.DataGridView();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carReleaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producingCountryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.brandListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carListDataGridView
            // 
            this.carListDataGridView.AllowUserToAddRows = false;
            this.carListDataGridView.AllowUserToDeleteRows = false;
            this.carListDataGridView.AutoGenerateColumns = false;
            this.carListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIDDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.carReleaseDateDataGridViewTextBoxColumn,
            this.carAgeDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.producingCountryNameDataGridViewTextBoxColumn});
            this.carListDataGridView.DataSource = this.carListBindingSource;
            this.carListDataGridView.Location = new System.Drawing.Point(177, 12);
            this.carListDataGridView.Name = "carListDataGridView";
            this.carListDataGridView.ReadOnly = true;
            this.carListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carListDataGridView.Size = new System.Drawing.Size(447, 214);
            this.carListDataGridView.TabIndex = 0;
            this.carListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carListDataGridView_CellContentClick);
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            this.carIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.carIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            this.carNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            this.carNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carReleaseDateDataGridViewTextBoxColumn
            // 
            this.carReleaseDateDataGridViewTextBoxColumn.DataPropertyName = "CarReleaseDate";
            this.carReleaseDateDataGridViewTextBoxColumn.HeaderText = "Дата сборки";
            this.carReleaseDateDataGridViewTextBoxColumn.Name = "carReleaseDateDataGridViewTextBoxColumn";
            this.carReleaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carAgeDataGridViewTextBoxColumn
            // 
            this.carAgeDataGridViewTextBoxColumn.DataPropertyName = "CarAge";
            this.carAgeDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.carAgeDataGridViewTextBoxColumn.Name = "carAgeDataGridViewTextBoxColumn";
            this.carAgeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "Брэнд";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            this.brandNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // producingCountryNameDataGridViewTextBoxColumn
            // 
            this.producingCountryNameDataGridViewTextBoxColumn.DataPropertyName = "ProducingCountryName";
            this.producingCountryNameDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.producingCountryNameDataGridViewTextBoxColumn.Name = "producingCountryNameDataGridViewTextBoxColumn";
            this.producingCountryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carListBindingSource
            // 
            this.carListBindingSource.DataSource = typeof(CarsLibrary.CarInfo);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.brandListBindingSource;
            this.comboBox1.DisplayMember = "BrandName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "BrandID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // brandListBindingSource
            // 
            this.brandListBindingSource.DataSource = typeof(CarsLibrary.BrandInfo);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(418, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Заменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 326);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.carListDataGridView);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carListDataGridView;
        private System.Windows.Forms.BindingSource carListBindingSource;
        private System.Windows.Forms.BindingSource brandListBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carReleaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producingCountryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}