namespace AirportProject
{
    partial class AirportForm
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
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.dgvAirports = new System.Windows.Forms.DataGridView();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnUpdateAirport = new System.Windows.Forms.Button();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.tbxUpdateCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxUpdateAirport = new System.Windows.Forms.GroupBox();
            this.lblUpdateCity = new System.Windows.Forms.Label();
            this.gbxAddAirport = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCitySelected = new System.Windows.Forms.Label();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.dgvCities = new System.Windows.Forms.DataGridView();
            this.btnUpdateCity = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).BeginInit();
            this.gbxUpdateAirport.SuspendLayout();
            this.gbxAddAirport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddAirport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAirport.ForeColor = System.Drawing.Color.White;
            this.btnAddAirport.Location = new System.Drawing.Point(140, 237);
            this.btnAddAirport.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(274, 49);
            this.btnAddAirport.TabIndex = 0;
            this.btnAddAirport.Text = "Add Airport";
            this.btnAddAirport.UseVisualStyleBackColor = false;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // dgvAirports
            // 
            this.dgvAirports.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirports.Location = new System.Drawing.Point(115, 36);
            this.dgvAirports.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAirports.Name = "dgvAirports";
            this.dgvAirports.RowHeadersWidth = 51;
            this.dgvAirports.Size = new System.Drawing.Size(428, 593);
            this.dgvAirports.TabIndex = 2;
            this.dgvAirports.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAirports_RowHeaderMouseDoubleClick);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(140, 53);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(347, 36);
            this.tbxName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 57);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 27);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(45, 113);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(58, 27);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(21, 168);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(77, 27);
            this.lblCode.TabIndex = 6;
            this.lblCode.Text = "Code";
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeleteAirport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAirport.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAirport.Location = new System.Drawing.Point(192, 646);
            this.btnDeleteAirport.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(278, 49);
            this.btnDeleteAirport.TabIndex = 0;
            this.btnDeleteAirport.Text = "Delete Airport";
            this.btnDeleteAirport.UseVisualStyleBackColor = false;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnUpdateAirport
            // 
            this.btnUpdateAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateAirport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAirport.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAirport.Location = new System.Drawing.Point(126, 237);
            this.btnUpdateAirport.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateAirport.Name = "btnUpdateAirport";
            this.btnUpdateAirport.Size = new System.Drawing.Size(274, 49);
            this.btnUpdateAirport.TabIndex = 0;
            this.btnUpdateAirport.Text = "Update Airport";
            this.btnUpdateAirport.UseVisualStyleBackColor = false;
            this.btnUpdateAirport.Click += new System.EventHandler(this.btnUpdateAirport_Click);
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(126, 53);
            this.tbxUpdateName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(350, 36);
            this.tbxUpdateName.TabIndex = 3;
            // 
            // tbxUpdateCode
            // 
            this.tbxUpdateCode.Location = new System.Drawing.Point(129, 164);
            this.tbxUpdateCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUpdateCode.Name = "tbxUpdateCode";
            this.tbxUpdateCode.Size = new System.Drawing.Size(347, 36);
            this.tbxUpdateCode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Code";
            // 
            // gbxUpdateAirport
            // 
            this.gbxUpdateAirport.Controls.Add(this.lblUpdateCity);
            this.gbxUpdateAirport.Controls.Add(this.label2);
            this.gbxUpdateAirport.Controls.Add(this.label1);
            this.gbxUpdateAirport.Controls.Add(this.tbxUpdateCode);
            this.gbxUpdateAirport.Controls.Add(this.tbxUpdateName);
            this.gbxUpdateAirport.Controls.Add(this.btnUpdateAirport);
            this.gbxUpdateAirport.Controls.Add(this.label3);
            this.gbxUpdateAirport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdateAirport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbxUpdateAirport.Location = new System.Drawing.Point(11, 12);
            this.gbxUpdateAirport.Margin = new System.Windows.Forms.Padding(4);
            this.gbxUpdateAirport.Name = "gbxUpdateAirport";
            this.gbxUpdateAirport.Padding = new System.Windows.Forms.Padding(4);
            this.gbxUpdateAirport.Size = new System.Drawing.Size(486, 347);
            this.gbxUpdateAirport.TabIndex = 7;
            this.gbxUpdateAirport.TabStop = false;
            this.gbxUpdateAirport.Text = "UpdateAirport";
            // 
            // lblUpdateCity
            // 
            this.lblUpdateCity.AutoSize = true;
            this.lblUpdateCity.Location = new System.Drawing.Point(126, 113);
            this.lblUpdateCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateCity.Name = "lblUpdateCity";
            this.lblUpdateCity.Size = new System.Drawing.Size(173, 27);
            this.lblUpdateCity.TabIndex = 7;
            this.lblUpdateCity.Text = "lblUpdateCity";
            this.lblUpdateCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbxAddAirport
            // 
            this.gbxAddAirport.Controls.Add(this.lblCitySelected);
            this.gbxAddAirport.Controls.Add(this.lblCode);
            this.gbxAddAirport.Controls.Add(this.lblCity);
            this.gbxAddAirport.Controls.Add(this.lblName);
            this.gbxAddAirport.Controls.Add(this.tbxCode);
            this.gbxAddAirport.Controls.Add(this.tbxName);
            this.gbxAddAirport.Controls.Add(this.btnAddAirport);
            this.gbxAddAirport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddAirport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbxAddAirport.Location = new System.Drawing.Point(0, 370);
            this.gbxAddAirport.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAddAirport.Name = "gbxAddAirport";
            this.gbxAddAirport.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAddAirport.Size = new System.Drawing.Size(498, 316);
            this.gbxAddAirport.TabIndex = 8;
            this.gbxAddAirport.TabStop = false;
            this.gbxAddAirport.Text = "Add Airport";
            this.gbxAddAirport.Enter += new System.EventHandler(this.gbxAddAirport_Enter);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 709);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 38);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCitySelected
            // 
            this.lblCitySelected.AutoSize = true;
            this.lblCitySelected.Location = new System.Drawing.Point(138, 113);
            this.lblCitySelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCitySelected.Name = "lblCitySelected";
            this.lblCitySelected.Size = new System.Drawing.Size(187, 27);
            this.lblCitySelected.TabIndex = 7;
            this.lblCitySelected.Text = "lblCitySelected";
            // 
            // tbxCode
            // 
            this.tbxCode.Location = new System.Drawing.Point(140, 164);
            this.tbxCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(347, 36);
            this.tbxCode.TabIndex = 5;
            // 
            // dgvCities
            // 
            this.dgvCities.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCities.Location = new System.Drawing.Point(571, 36);
            this.dgvCities.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCities.Name = "dgvCities";
            this.dgvCities.RowHeadersWidth = 51;
            this.dgvCities.Size = new System.Drawing.Size(452, 593);
            this.dgvCities.TabIndex = 9;
            // 
            // btnUpdateCity
            // 
            this.btnUpdateCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateCity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCity.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCity.Location = new System.Drawing.Point(571, 694);
            this.btnUpdateCity.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCity.Name = "btnUpdateCity";
            this.btnUpdateCity.Size = new System.Drawing.Size(447, 49);
            this.btnUpdateCity.TabIndex = 10;
            this.btnUpdateCity.Text = "Update airport with city property";
            this.btnUpdateCity.UseVisualStyleBackColor = false;
            this.btnUpdateCity.Click += new System.EventHandler(this.btnUpdateCity_Click);
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddCity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCity.ForeColor = System.Drawing.Color.White;
            this.btnAddCity.Location = new System.Drawing.Point(571, 637);
            this.btnAddCity.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(447, 49);
            this.btnAddCity.TabIndex = 11;
            this.btnAddCity.Text = "Add city property to new airport";
            this.btnAddCity.UseVisualStyleBackColor = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(1030, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 53);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvAirports);
            this.panel1.Controls.Add(this.btnUpdateCity);
            this.panel1.Controls.Add(this.btnAddCity);
            this.panel1.Controls.Add(this.btnDeleteAirport);
            this.panel1.Controls.Add(this.dgvCities);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(426, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 761);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.gbxUpdateAirport);
            this.panel2.Controls.Add(this.gbxAddAirport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 761);
            this.panel2.TabIndex = 14;
            // 
            // AirportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1497, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AirportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirportForm";
            this.Load += new System.EventHandler(this.Airport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).EndInit();
            this.gbxUpdateAirport.ResumeLayout(false);
            this.gbxUpdateAirport.PerformLayout();
            this.gbxAddAirport.ResumeLayout(false);
            this.gbxAddAirport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.DataGridView dgvAirports;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnUpdateAirport;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.TextBox tbxUpdateCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxUpdateAirport;
        private System.Windows.Forms.GroupBox gbxAddAirport;
        private System.Windows.Forms.Label lblUpdateCity;
        private System.Windows.Forms.Label lblCitySelected;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.DataGridView dgvCities;
        private System.Windows.Forms.Button btnUpdateCity;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
    }
}