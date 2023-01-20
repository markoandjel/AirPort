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
<<<<<<< HEAD
            this.addPassenger = new System.Windows.Forms.Button();
            this.addTicket = new System.Windows.Forms.Button();
=======
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnUpdateAirport = new System.Windows.Forms.Button();
            this.btnCreateFlight = new System.Windows.Forms.Button();
>>>>>>> c50863486bc646f0af288a1cdf987f6d29803a0b
            this.SuspendLayout();
            // 
            // btnAddAirport
            // 
<<<<<<< HEAD
            this.btnAddAirport.Location = new System.Drawing.Point(315, 146);
            this.btnAddAirport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(187, 60);
=======
            this.btnAddAirport.Location = new System.Drawing.Point(67, 80);
            this.btnAddAirport.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(118, 38);
>>>>>>> c50863486bc646f0af288a1cdf987f6d29803a0b
            this.btnAddAirport.TabIndex = 0;
            this.btnAddAirport.Text = "Add Airport";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnGetAllAirports
            // 
<<<<<<< HEAD
            this.btnGetAllAirports.Location = new System.Drawing.Point(315, 255);
            this.btnGetAllAirports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.btnGetAllAirports.Location = new System.Drawing.Point(58, 135);
>>>>>>> c50863486bc646f0af288a1cdf987f6d29803a0b
            this.btnGetAllAirports.Name = "btnGetAllAirports";
            this.btnGetAllAirports.Size = new System.Drawing.Size(176, 39);
            this.btnGetAllAirports.TabIndex = 1;
            this.btnGetAllAirports.Text = "Get all airports";
            this.btnGetAllAirports.UseVisualStyleBackColor = true;
            this.btnGetAllAirports.Click += new System.EventHandler(this.btnGetAllAirports_Click);
            // 
<<<<<<< HEAD
            // addPassenger
            // 
            this.addPassenger.Location = new System.Drawing.Point(304, 35);
            this.addPassenger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPassenger.Name = "addPassenger";
            this.addPassenger.Size = new System.Drawing.Size(187, 60);
            this.addPassenger.TabIndex = 2;
            this.addPassenger.Text = "Add Passenger";
            this.addPassenger.UseVisualStyleBackColor = true;
            this.addPassenger.Click += new System.EventHandler(this.addPassenger_Click);
            // 
            // addTicket
            // 
            this.addTicket.Location = new System.Drawing.Point(530, 50);
            this.addTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTicket.Name = "addTicket";
            this.addTicket.Size = new System.Drawing.Size(187, 60);
            this.addTicket.TabIndex = 3;
            this.addTicket.Text = "Add Ticket";
            this.addTicket.UseVisualStyleBackColor = true;
            this.addTicket.Click += new System.EventHandler(this.addTicket_Click);
=======
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(58, 242);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(143, 23);
            this.btnDeleteAirport.TabIndex = 2;
            this.btnDeleteAirport.Text = "Delete airport";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnUpdateAirport
            // 
            this.btnUpdateAirport.Location = new System.Drawing.Point(67, 190);
            this.btnUpdateAirport.Name = "btnUpdateAirport";
            this.btnUpdateAirport.Size = new System.Drawing.Size(123, 23);
            this.btnUpdateAirport.TabIndex = 3;
            this.btnUpdateAirport.Text = "update airport";
            this.btnUpdateAirport.UseVisualStyleBackColor = true;
            this.btnUpdateAirport.Click += new System.EventHandler(this.btnUpdateAirport_Click);
            // 
            // btnCreateFlight
            // 
            this.btnCreateFlight.Location = new System.Drawing.Point(334, 94);
            this.btnCreateFlight.Name = "btnCreateFlight";
            this.btnCreateFlight.Size = new System.Drawing.Size(131, 35);
            this.btnCreateFlight.TabIndex = 4;
            this.btnCreateFlight.Text = "create Flight";
            this.btnCreateFlight.UseVisualStyleBackColor = true;
            this.btnCreateFlight.Click += new System.EventHandler(this.btnCreateFlight_Click);
>>>>>>> c50863486bc646f0af288a1cdf987f6d29803a0b
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addTicket);
            this.Controls.Add(this.addPassenger);
            this.Controls.Add(this.btnGetAllAirports);
            this.Controls.Add(this.btnAddAirport);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCreateFlight);
            this.Controls.Add(this.btnUpdateAirport);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.btnGetAllAirports);
            this.Controls.Add(this.btnAddAirport);
            this.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> c50863486bc646f0af288a1cdf987f6d29803a0b
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnGetAllAirports;
<<<<<<< HEAD
        private System.Windows.Forms.Button addPassenger;
        private System.Windows.Forms.Button addTicket;
=======
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnUpdateAirport;
        private System.Windows.Forms.Button btnCreateFlight;
>>>>>>> c50863486bc646f0af288a1cdf987f6d29803a0b
    }
}

