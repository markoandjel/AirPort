namespace AirportProject
{
    partial class CityForm
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
            this.dgvCity = new System.Windows.Forms.DataGridView();
            this.btnUpdateAirport = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxCountryUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameAdd = new System.Windows.Forms.TextBox();
            this.tbxCountryAdd = new System.Windows.Forms.TextBox();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnConnectToAirports = new System.Windows.Forms.Button();
            this.btnDisconnectAirports = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).BeginInit();
            this.gbUpdate.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCity
            // 
            this.dgvCity.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCity.Location = new System.Drawing.Point(133, 22);
            this.dgvCity.Name = "dgvCity";
            this.dgvCity.RowHeadersWidth = 51;
            this.dgvCity.RowTemplate.Height = 24;
            this.dgvCity.Size = new System.Drawing.Size(534, 365);
            this.dgvCity.TabIndex = 8;
            // 
            // btnUpdateAirport
            // 
            this.btnUpdateAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateAirport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdateAirport.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAirport.Location = new System.Drawing.Point(104, 163);
            this.btnUpdateAirport.Name = "btnUpdateAirport";
            this.btnUpdateAirport.Size = new System.Drawing.Size(176, 41);
            this.btnUpdateAirport.TabIndex = 2;
            this.btnUpdateAirport.Text = "Update City";
            this.btnUpdateAirport.UseVisualStyleBackColor = false;
            this.btnUpdateAirport.Click += new System.EventHandler(this.btnUpdateAirport_Click);
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddCity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAddCity.ForeColor = System.Drawing.Color.White;
            this.btnAddCity.Location = new System.Drawing.Point(103, 163);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(176, 41);
            this.btnAddCity.TabIndex = 5;
            this.btnAddCity.Text = "Add City";
            this.btnAddCity.UseVisualStyleBackColor = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeleteCity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCity.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCity.Location = new System.Drawing.Point(341, 454);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(113, 50);
            this.btnDeleteCity.TabIndex = 6;
            this.btnDeleteCity.Text = "Delete";
            this.btnDeleteCity.UseVisualStyleBackColor = false;
            this.btnDeleteCity.Click += new System.EventHandler(this.btnDeleteCity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Country";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(127, 57);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(267, 36);
            this.tbxNameUpdate.TabIndex = 0;
            // 
            // tbxCountryUpdate
            // 
            this.tbxCountryUpdate.Location = new System.Drawing.Point(127, 112);
            this.tbxCountryUpdate.Name = "tbxCountryUpdate";
            this.tbxCountryUpdate.Size = new System.Drawing.Size(267, 36);
            this.tbxCountryUpdate.TabIndex = 1;
            // 
            // tbxNameAdd
            // 
            this.tbxNameAdd.Location = new System.Drawing.Point(126, 57);
            this.tbxNameAdd.Name = "tbxNameAdd";
            this.tbxNameAdd.Size = new System.Drawing.Size(267, 36);
            this.tbxNameAdd.TabIndex = 3;
            // 
            // tbxCountryAdd
            // 
            this.tbxCountryAdd.Location = new System.Drawing.Point(126, 112);
            this.tbxCountryAdd.Name = "tbxCountryAdd";
            this.tbxCountryAdd.Size = new System.Drawing.Size(268, 36);
            this.tbxCountryAdd.TabIndex = 4;
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.tbxCountryUpdate);
            this.gbUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbUpdate.Controls.Add(this.label2);
            this.gbUpdate.Controls.Add(this.btnUpdateAirport);
            this.gbUpdate.Controls.Add(this.label1);
            this.gbUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbUpdate.Location = new System.Drawing.Point(28, 22);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(400, 220);
            this.gbUpdate.TabIndex = 12;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update city";
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.tbxCountryAdd);
            this.gbAdd.Controls.Add(this.tbxNameAdd);
            this.gbAdd.Controls.Add(this.label4);
            this.gbAdd.Controls.Add(this.btnAddCity);
            this.gbAdd.Controls.Add(this.label3);
            this.gbAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbAdd.Location = new System.Drawing.Point(29, 261);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(400, 220);
            this.gbAdd.TabIndex = 13;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add city";
            // 
            // btnConnectToAirports
            // 
            this.btnConnectToAirports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConnectToAirports.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnConnectToAirports.ForeColor = System.Drawing.Color.White;
            this.btnConnectToAirports.Location = new System.Drawing.Point(133, 396);
            this.btnConnectToAirports.Name = "btnConnectToAirports";
            this.btnConnectToAirports.Size = new System.Drawing.Size(260, 50);
            this.btnConnectToAirports.TabIndex = 7;
            this.btnConnectToAirports.Text = "Connect to airports";
            this.btnConnectToAirports.UseVisualStyleBackColor = false;
            this.btnConnectToAirports.Click += new System.EventHandler(this.btnConnectToAirports_Click);
            // 
            // btnDisconnectAirports
            // 
            this.btnDisconnectAirports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDisconnectAirports.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDisconnectAirports.ForeColor = System.Drawing.Color.White;
            this.btnDisconnectAirports.Location = new System.Drawing.Point(399, 396);
            this.btnDisconnectAirports.Name = "btnDisconnectAirports";
            this.btnDisconnectAirports.Size = new System.Drawing.Size(268, 50);
            this.btnDisconnectAirports.TabIndex = 8;
            this.btnDisconnectAirports.Text = "Disconnect Airports";
            this.btnDisconnectAirports.UseVisualStyleBackColor = false;
            this.btnDisconnectAirports.Click += new System.EventHandler(this.btnDisconnectAirports_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDisconnectAirports);
            this.panel1.Controls.Add(this.btnConnectToAirports);
            this.panel1.Controls.Add(this.btnDeleteCity);
            this.panel1.Controls.Add(this.dgvCity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(374, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 512);
            this.panel1.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(692, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 39);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gbAdd);
            this.panel2.Controls.Add(this.gbUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 512);
            this.panel2.TabIndex = 15;
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1109, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.MinimumSize = new System.Drawing.Size(781, 491);
            this.Name = "CityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City manager";
            this.Load += new System.EventHandler(this.CityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).EndInit();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCity;
        private System.Windows.Forms.Button btnUpdateAirport;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Button btnDeleteCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.TextBox tbxCountryUpdate;
        private System.Windows.Forms.TextBox tbxNameAdd;
        private System.Windows.Forms.TextBox tbxCountryAdd;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnConnectToAirports;
        private System.Windows.Forms.Button btnDisconnectAirports;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
    }
}