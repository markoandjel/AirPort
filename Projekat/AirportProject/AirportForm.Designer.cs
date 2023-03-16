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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnUpdateAirport = new System.Windows.Forms.Button();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.tbxUpdateCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxUpdateAirport = new System.Windows.Forms.GroupBox();
            this.gbxAddAirport = new System.Windows.Forms.GroupBox();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.dgvAirports = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxUpdateAirport.SuspendLayout();
            this.gbxAddAirport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddAirport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAirport.ForeColor = System.Drawing.Color.White;
            this.btnAddAirport.Location = new System.Drawing.Point(126, 229);
            this.btnAddAirport.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(133, 39);
            this.btnAddAirport.TabIndex = 0;
            this.btnAddAirport.Text = "Add Airport";
            this.btnAddAirport.UseVisualStyleBackColor = false;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(101, 63);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(230, 36);
            this.tbxName.TabIndex = 3;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(101, 117);
            this.tbxCity.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(230, 36);
            this.tbxCity.TabIndex = 4;
            // 
            // tbxCode
            // 
            this.tbxCode.Location = new System.Drawing.Point(101, 170);
            this.tbxCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(230, 36);
            this.tbxCode.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(11, 72);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 27);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(27, 126);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(58, 27);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(8, 179);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(77, 27);
            this.lblCode.TabIndex = 6;
            this.lblCode.Text = "Code";
            // 
            // btnUpdateAirport
            // 
            this.btnUpdateAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateAirport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAirport.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAirport.Location = new System.Drawing.Point(121, 229);
            this.btnUpdateAirport.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateAirport.Name = "btnUpdateAirport";
            this.btnUpdateAirport.Size = new System.Drawing.Size(133, 39);
            this.btnUpdateAirport.TabIndex = 0;
            this.btnUpdateAirport.Text = "Update Airport";
            this.btnUpdateAirport.UseVisualStyleBackColor = false;
            this.btnUpdateAirport.Click += new System.EventHandler(this.btnUpdateAirport_Click);
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(101, 63);
            this.tbxUpdateName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(225, 36);
            this.tbxUpdateName.TabIndex = 3;
            // 
            // tbxUpdateCity
            // 
            this.tbxUpdateCity.Location = new System.Drawing.Point(101, 117);
            this.tbxUpdateCity.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUpdateCity.Name = "tbxUpdateCity";
            this.tbxUpdateCity.Size = new System.Drawing.Size(225, 36);
            this.tbxUpdateCity.TabIndex = 4;
            // 
            // tbxUpdateCode
            // 
            this.tbxUpdateCode.Location = new System.Drawing.Point(101, 170);
            this.tbxUpdateCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUpdateCode.Name = "tbxUpdateCode";
            this.tbxUpdateCode.Size = new System.Drawing.Size(225, 36);
            this.tbxUpdateCode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Code";
            // 
            // gbxUpdateAirport
            // 
            this.gbxUpdateAirport.BackColor = System.Drawing.SystemColors.Control;
            this.gbxUpdateAirport.Controls.Add(this.label3);
            this.gbxUpdateAirport.Controls.Add(this.label2);
            this.gbxUpdateAirport.Controls.Add(this.label1);
            this.gbxUpdateAirport.Controls.Add(this.tbxUpdateCode);
            this.gbxUpdateAirport.Controls.Add(this.tbxUpdateName);
            this.gbxUpdateAirport.Controls.Add(this.btnUpdateAirport);
            this.gbxUpdateAirport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxUpdateAirport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdateAirport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbxUpdateAirport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbxUpdateAirport.Location = new System.Drawing.Point(44, 13);
            this.gbxUpdateAirport.Margin = new System.Windows.Forms.Padding(4);
            this.gbxUpdateAirport.Name = "gbxUpdateAirport";
            this.gbxUpdateAirport.Padding = new System.Windows.Forms.Padding(4);
            this.gbxUpdateAirport.Size = new System.Drawing.Size(357, 297);
            this.gbxUpdateAirport.TabIndex = 7;
            this.gbxUpdateAirport.TabStop = false;
            this.gbxUpdateAirport.Text = "UpdateAirport";
            // 
            // gbxAddAirport
            // 
            this.gbxAddAirport.Controls.Add(this.lblCitySelected);
            this.gbxAddAirport.BackColor = System.Drawing.SystemColors.Control;
            this.gbxAddAirport.Controls.Add(this.lblCode);
            this.gbxAddAirport.Controls.Add(this.lblCity);
            this.gbxAddAirport.Controls.Add(this.lblName);
            this.gbxAddAirport.Controls.Add(this.tbxCode);
            this.gbxAddAirport.Controls.Add(this.tbxName);
            this.gbxAddAirport.Controls.Add(this.btnAddAirport);
            this.gbxAddAirport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddAirport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbxAddAirport.Location = new System.Drawing.Point(44, 315);
            this.gbxAddAirport.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAddAirport.Name = "gbxAddAirport";
            this.gbxAddAirport.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAddAirport.Size = new System.Drawing.Size(357, 297);
            this.gbxAddAirport.TabIndex = 8;
            this.gbxAddAirport.TabStop = false;
            this.gbxAddAirport.Text = "Add Airport";
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeleteAirport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAirport.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAirport.Location = new System.Drawing.Point(226, 544);
            this.btnDeleteAirport.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(136, 39);
            this.btnDeleteAirport.TabIndex = 0;
            this.btnDeleteAirport.Text = "Delete Airport";
            this.btnDeleteAirport.UseVisualStyleBackColor = false;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // dgvAirports
            // 
            this.dgvAirports.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirports.GridColor = System.Drawing.Color.LightGray;
            this.dgvAirports.Location = new System.Drawing.Point(36, 46);
            this.dgvAirports.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAirports.Name = "dgvAirports";
            this.dgvAirports.RowHeadersWidth = 51;
            this.dgvAirports.Size = new System.Drawing.Size(473, 475);
            this.dgvAirports.TabIndex = 2;
            this.dgvAirports.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAirports_RowHeaderMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.dgvAirports);
            this.panel1.Controls.Add(this.btnDeleteAirport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(449, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 612);
            this.panel1.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(515, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AirportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(993, 612);
            this.Controls.Add(this.gbxAddAirport);
            this.Controls.Add(this.gbxUpdateAirport);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AirportForm";
            this.Text = "AirportForm";
            this.Load += new System.EventHandler(this.Airport_Load);
            this.gbxUpdateAirport.ResumeLayout(false);
            this.gbxUpdateAirport.PerformLayout();
            this.gbxAddAirport.ResumeLayout(false);
            this.gbxAddAirport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCode;
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
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.DataGridView dgvAirports;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
    }
}