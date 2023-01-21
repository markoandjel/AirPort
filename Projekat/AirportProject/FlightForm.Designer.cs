namespace AirportProject
{
    partial class FlightForm
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
            this.dgvAirports = new System.Windows.Forms.DataGridView();
            this.btnCreateFlight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFlightTo = new System.Windows.Forms.Label();
            this.lblFlightFrom = new System.Windows.Forms.Label();
            this.labela1 = new System.Windows.Forms.Label();
            this.btnSwapDestinations = new System.Windows.Forms.Button();
            this.lblListOf = new System.Windows.Forms.Label();
            this.btnShowAirports = new System.Windows.Forms.Button();
            this.btnShowFlights = new System.Windows.Forms.Button();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtpArival = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAirports
            // 
            this.dgvAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirports.Location = new System.Drawing.Point(447, 78);
            this.dgvAirports.Name = "dgvAirports";
            this.dgvAirports.Size = new System.Drawing.Size(315, 288);
            this.dgvAirports.TabIndex = 0;
            this.dgvAirports.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAirports_RowHeaderMouseDoubleClick);
            // 
            // btnCreateFlight
            // 
            this.btnCreateFlight.Location = new System.Drawing.Point(124, 356);
            this.btnCreateFlight.Name = "btnCreateFlight";
            this.btnCreateFlight.Size = new System.Drawing.Size(105, 37);
            this.btnCreateFlight.TabIndex = 1;
            this.btnCreateFlight.Text = "Create Flight";
            this.btnCreateFlight.UseVisualStyleBackColor = true;
            this.btnCreateFlight.Click += new System.EventHandler(this.btnCreateFlight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flight to:";
            // 
            // lblFlightTo
            // 
            this.lblFlightTo.AutoSize = true;
            this.lblFlightTo.Location = new System.Drawing.Point(97, 164);
            this.lblFlightTo.Name = "lblFlightTo";
            this.lblFlightTo.Size = new System.Drawing.Size(0, 13);
            this.lblFlightTo.TabIndex = 3;
            // 
            // lblFlightFrom
            // 
            this.lblFlightFrom.AutoSize = true;
            this.lblFlightFrom.Location = new System.Drawing.Point(97, 103);
            this.lblFlightFrom.Name = "lblFlightFrom";
            this.lblFlightFrom.Size = new System.Drawing.Size(0, 13);
            this.lblFlightFrom.TabIndex = 5;
            // 
            // labela1
            // 
            this.labela1.AutoSize = true;
            this.labela1.Location = new System.Drawing.Point(25, 103);
            this.labela1.Name = "labela1";
            this.labela1.Size = new System.Drawing.Size(58, 13);
            this.labela1.TabIndex = 4;
            this.labela1.Text = "Flight form:";
            // 
            // btnSwapDestinations
            // 
            this.btnSwapDestinations.Location = new System.Drawing.Point(78, 128);
            this.btnSwapDestinations.Name = "btnSwapDestinations";
            this.btnSwapDestinations.Size = new System.Drawing.Size(121, 23);
            this.btnSwapDestinations.TabIndex = 6;
            this.btnSwapDestinations.Text = "Swap Destinations";
            this.btnSwapDestinations.UseVisualStyleBackColor = true;
            this.btnSwapDestinations.Click += new System.EventHandler(this.btnSwapDestinations_Click);
            // 
            // lblListOf
            // 
            this.lblListOf.AutoSize = true;
            this.lblListOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOf.Location = new System.Drawing.Point(546, 55);
            this.lblListOf.Name = "lblListOf";
            this.lblListOf.Size = new System.Drawing.Size(130, 20);
            this.lblListOf.TabIndex = 4;
            this.lblListOf.Text = "List of all Airports";
            // 
            // btnShowAirports
            // 
            this.btnShowAirports.Location = new System.Drawing.Point(483, 384);
            this.btnShowAirports.Name = "btnShowAirports";
            this.btnShowAirports.Size = new System.Drawing.Size(105, 37);
            this.btnShowAirports.TabIndex = 1;
            this.btnShowAirports.Text = "Show Airports";
            this.btnShowAirports.UseVisualStyleBackColor = true;
            this.btnShowAirports.Click += new System.EventHandler(this.btnCreateFlight_Click);
            // 
            // btnShowFlights
            // 
            this.btnShowFlights.Location = new System.Drawing.Point(624, 384);
            this.btnShowFlights.Name = "btnShowFlights";
            this.btnShowFlights.Size = new System.Drawing.Size(105, 37);
            this.btnShowFlights.TabIndex = 1;
            this.btnShowFlights.Text = "Show Flights";
            this.btnShowFlights.UseVisualStyleBackColor = true;
            this.btnShowFlights.Click += new System.EventHandler(this.btnCreateFlight_Click);
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.Location = new System.Drawing.Point(124, 211);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(200, 20);
            this.dtpDeparture.TabIndex = 7;
            // 
            // dtpArival
            // 
            this.dtpArival.Location = new System.Drawing.Point(124, 257);
            this.dtpArival.Name = "dtpArival";
            this.dtpArival.Size = new System.Drawing.Size(200, 20);
            this.dtpArival.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time of departure:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time of arival:";
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpArival);
            this.Controls.Add(this.dtpDeparture);
            this.Controls.Add(this.btnSwapDestinations);
            this.Controls.Add(this.lblFlightFrom);
            this.Controls.Add(this.lblListOf);
            this.Controls.Add(this.labela1);
            this.Controls.Add(this.lblFlightTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowFlights);
            this.Controls.Add(this.btnShowAirports);
            this.Controls.Add(this.btnCreateFlight);
            this.Controls.Add(this.dgvAirports);
            this.Name = "FlightForm";
            this.Text = "FlightForm";
            this.Load += new System.EventHandler(this.FlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAirports;
        private System.Windows.Forms.Button btnCreateFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFlightTo;
        private System.Windows.Forms.Label lblFlightFrom;
        private System.Windows.Forms.Label labela1;
        private System.Windows.Forms.Button btnSwapDestinations;
        private System.Windows.Forms.Label lblListOf;
        private System.Windows.Forms.Button btnShowAirports;
        private System.Windows.Forms.Button btnShowFlights;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.DateTimePicker dtpArival;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}