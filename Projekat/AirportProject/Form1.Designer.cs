namespace AirportProject

{
    partial class Form1
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
            this.btnGetAllAirports = new System.Windows.Forms.Button();
            this.addPassenger = new System.Windows.Forms.Button();
            this.addTicket = new System.Windows.Forms.Button();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnUpdateAirport = new System.Windows.Forms.Button();
            this.btnAirportManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(69, 78);
            this.btnAddAirport.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(140, 49);
            this.btnAddAirport.TabIndex = 0;
            this.btnAddAirport.Text = "Add Airport";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnGetAllAirports
            // 
            this.btnGetAllAirports.Location = new System.Drawing.Point(77, 198);
            this.btnGetAllAirports.Name = "btnGetAllAirports";
            this.btnGetAllAirports.Size = new System.Drawing.Size(132, 32);
            this.btnGetAllAirports.TabIndex = 1;
            this.btnGetAllAirports.Text = "Get all airports";
            this.btnGetAllAirports.UseVisualStyleBackColor = true;
            this.btnGetAllAirports.Click += new System.EventHandler(this.btnGetAllAirports_Click);
            // 
            // addPassenger
            // 
            this.addPassenger.Location = new System.Drawing.Point(489, 78);
            this.addPassenger.Margin = new System.Windows.Forms.Padding(2);
            this.addPassenger.Name = "addPassenger";
            this.addPassenger.Size = new System.Drawing.Size(140, 49);
            this.addPassenger.TabIndex = 2;
            this.addPassenger.Text = "Add Passenger";
            this.addPassenger.UseVisualStyleBackColor = true;
            this.addPassenger.Click += new System.EventHandler(this.addPassenger_Click);
            // 
            // addTicket
            // 
            this.addTicket.Location = new System.Drawing.Point(528, 181);
            this.addTicket.Margin = new System.Windows.Forms.Padding(2);
            this.addTicket.Name = "addTicket";
            this.addTicket.Size = new System.Drawing.Size(140, 49);
            this.addTicket.TabIndex = 3;
            this.addTicket.Text = "Add Ticket";
            this.addTicket.UseVisualStyleBackColor = true;
            this.addTicket.Click += new System.EventHandler(this.addTicket_Click);
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(82, 254);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(127, 23);
            this.btnDeleteAirport.TabIndex = 4;
            this.btnDeleteAirport.Text = "Delete Airport";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAirport
            // 
            this.btnUpdateAirport.Location = new System.Drawing.Point(77, 153);
            this.btnUpdateAirport.Name = "btnUpdateAirport";
            this.btnUpdateAirport.Size = new System.Drawing.Size(127, 23);
            this.btnUpdateAirport.TabIndex = 4;
            this.btnUpdateAirport.Text = "Update Airport";
            this.btnUpdateAirport.UseVisualStyleBackColor = true;
            this.btnUpdateAirport.Click += new System.EventHandler(this.btnUpdateAirport_Click);
            // 
            // btnAirportManager
            // 
            this.btnAirportManager.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAirportManager.Location = new System.Drawing.Point(259, 241);
            this.btnAirportManager.Name = "btnAirportManager";
            this.btnAirportManager.Size = new System.Drawing.Size(155, 52);
            this.btnAirportManager.TabIndex = 5;
            this.btnAirportManager.Text = "Airport Manager";
            this.btnAirportManager.UseVisualStyleBackColor = false;
            this.btnAirportManager.Click += new System.EventHandler(this.btnAirportManager_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 380);
            this.Controls.Add(this.btnAirportManager);
            this.Controls.Add(this.btnUpdateAirport);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.addTicket);
            this.Controls.Add(this.addPassenger);
            this.Controls.Add(this.btnGetAllAirports);
            this.Controls.Add(this.btnAddAirport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnGetAllAirports;
        private System.Windows.Forms.Button addPassenger;
        private System.Windows.Forms.Button addTicket;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnUpdateAirport;
        private System.Windows.Forms.Button btnAirportManager;
    }
}

