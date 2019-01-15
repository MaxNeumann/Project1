namespace CarsSolution
{
    partial class DriveForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.driveListDataGridView = new System.Windows.Forms.DataGridView();
            this.driveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.driveListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(29, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // driveListDataGridView
            // 
            this.driveListDataGridView.AllowUserToAddRows = false;
            this.driveListDataGridView.AllowUserToDeleteRows = false;
            this.driveListDataGridView.AutoGenerateColumns = false;
            this.driveListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driveListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driveIDDataGridViewTextBoxColumn,
            this.driveNameDataGridViewTextBoxColumn});
            this.driveListDataGridView.DataSource = this.driveListBindingSource;
            this.driveListDataGridView.Location = new System.Drawing.Point(29, 21);
            this.driveListDataGridView.Name = "driveListDataGridView";
            this.driveListDataGridView.ReadOnly = true;
            this.driveListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.driveListDataGridView.Size = new System.Drawing.Size(240, 150);
            this.driveListDataGridView.TabIndex = 2;
            // 
            // driveIDDataGridViewTextBoxColumn
            // 
            this.driveIDDataGridViewTextBoxColumn.DataPropertyName = "DriveID";
            this.driveIDDataGridViewTextBoxColumn.HeaderText = "DriveID";
            this.driveIDDataGridViewTextBoxColumn.Name = "driveIDDataGridViewTextBoxColumn";
            this.driveIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.driveIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // driveNameDataGridViewTextBoxColumn
            // 
            this.driveNameDataGridViewTextBoxColumn.DataPropertyName = "DriveName";
            this.driveNameDataGridViewTextBoxColumn.HeaderText = "Тип двигателя";
            this.driveNameDataGridViewTextBoxColumn.Name = "driveNameDataGridViewTextBoxColumn";
            this.driveNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveListBindingSource
            // 
            this.driveListBindingSource.DataSource = typeof(CarsLibrary.DriveInfo);
            // 
            // DriveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.driveListDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DriveForm";
            this.Text = "DriveForm";
            this.Load += new System.EventHandler(this.DriveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driveListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource driveListBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView driveListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveNameDataGridViewTextBoxColumn;
    }
}