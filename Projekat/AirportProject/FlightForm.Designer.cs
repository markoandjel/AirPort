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
            this.btnShowFlights = new System.Windows.Forms.Button();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtpArival = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numSeats = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.dtpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.rbtnFrom = new System.Windows.Forms.RadioButton();
            this.rbtnTo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvAirlines = new System.Windows.Forms.DataGridView();
            this.label98 = new System.Windows.Forms.Label();
            this.lblAirlineCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlines)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAirports
            // 
            this.dgvAirports.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirports.GridColor = System.Drawing.Color.LightGray;
            this.dgvAirports.Location = new System.Drawing.Point(52, 94);
            this.dgvAirports.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAirports.Name = "dgvAirports";
            this.dgvAirports.RowHeadersWidth = 51;
            this.dgvAirports.Size = new System.Drawing.Size(432, 354);
            this.dgvAirports.TabIndex = 0;
            this.dgvAirports.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAirports_RowHeaderMouseDoubleClick);
            // 
            // btnCreateFlight
            // 
            this.btnCreateFlight.Location = new System.Drawing.Point(142, 382);
            this.btnCreateFlight.Name = "btnCreateFlight";
            this.btnCreateFlight.Size = new System.Drawing.Size(133, 46);
            this.btnCreateFlight.TabIndex = 1;
            this.btnCreateFlight.Text = "Create flight";
            this.btnCreateFlight.UseVisualStyleBackColor = true;
            this.btnCreateFlight.Click += new System.EventHandler(this.btnCreateFlight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flight to:";
            // 
            // lblFlightTo
            // 
            this.lblFlightTo.AutoSize = true;
            this.lblFlightTo.Location = new System.Drawing.Point(129, 202);
            this.lblFlightTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightTo.Name = "lblFlightTo";
            this.lblFlightTo.Size = new System.Drawing.Size(0, 16);
            this.lblFlightTo.TabIndex = 3;
            // 
            // lblFlightFrom
            // 
            this.lblFlightFrom.AutoSize = true;
            this.lblFlightFrom.Location = new System.Drawing.Point(129, 127);
            this.lblFlightFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightFrom.Name = "lblFlightFrom";
            this.lblFlightFrom.Size = new System.Drawing.Size(0, 16);
            this.lblFlightFrom.TabIndex = 5;
            // 
            // labela1
            // 
            this.labela1.AutoSize = true;
            this.labela1.Location = new System.Drawing.Point(33, 127);
            this.labela1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labela1.Name = "labela1";
            this.labela1.Size = new System.Drawing.Size(71, 16);
            this.labela1.TabIndex = 4;
            this.labela1.Text = "Flight form:";
            // 
            // btnSwapDestinations
            // 
            this.btnSwapDestinations.Location = new System.Drawing.Point(104, 158);
            this.btnSwapDestinations.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwapDestinations.Name = "btnSwapDestinations";
            this.btnSwapDestinations.Size = new System.Drawing.Size(161, 28);
            this.btnSwapDestinations.TabIndex = 6;
            this.btnSwapDestinations.Text = "Swap Destinations";
            this.btnSwapDestinations.UseVisualStyleBackColor = true;
            this.btnSwapDestinations.Click += new System.EventHandler(this.btnSwapDestinations_Click);
            // 
            // lblListOf
            // 
            this.lblListOf.AutoSize = true;
            this.lblListOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOf.Location = new System.Drawing.Point(193, 65);
            this.lblListOf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListOf.Name = "lblListOf";
            this.lblListOf.Size = new System.Drawing.Size(159, 25);
            this.lblListOf.TabIndex = 4;
            this.lblListOf.Text = "List of all Airports";
            // 
            // btnShowFlights
            // 
            this.btnShowFlights.Location = new System.Drawing.Point(16, 479);
            this.btnShowFlights.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowFlights.Name = "btnShowFlights";
            this.btnShowFlights.Size = new System.Drawing.Size(214, 46);
            this.btnShowFlights.TabIndex = 1;
            this.btnShowFlights.Text = "Show flights";
            this.btnShowFlights.UseVisualStyleBackColor = true;
            this.btnShowFlights.Click += new System.EventHandler(this.btnShowFlights_Click);
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.Location = new System.Drawing.Point(165, 260);
            this.dtpDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(231, 22);
            this.dtpDeparture.TabIndex = 7;
            // 
            // dtpArival
            // 
            this.dtpArival.Location = new System.Drawing.Point(165, 316);
            this.dtpArival.Margin = new System.Windows.Forms.Padding(4);
            this.dtpArival.Name = "dtpArival";
            this.dtpArival.Size = new System.Drawing.Size(231, 22);
            this.dtpArival.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time of departure:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time of arival:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price in €";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seats";
            // 
            // numSeats
            // 
            this.numSeats.Location = new System.Drawing.Point(110, 347);
            this.numSeats.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSeats.Name = "numSeats";
            this.numSeats.Size = new System.Drawing.Size(133, 22);
            this.numSeats.TabIndex = 12;
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(110, 321);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(133, 22);
            this.numPrice.TabIndex = 13;
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.CustomFormat = "HH:mm";
            this.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalTime.Location = new System.Drawing.Point(405, 318);
            this.dtpArrivalTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.ShowUpDown = true;
            this.dtpArrivalTime.Size = new System.Drawing.Size(73, 22);
            this.dtpArrivalTime.TabIndex = 7;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.CustomFormat = "HH:mm";
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureTime.Location = new System.Drawing.Point(405, 260);
            this.dtpDepartureTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.ShowUpDown = true;
            this.dtpDepartureTime.Size = new System.Drawing.Size(73, 22);
            this.dtpDepartureTime.TabIndex = 7;
            // 
            // rbtnFrom
            // 
            this.rbtnFrom.AutoSize = true;
            this.rbtnFrom.Checked = true;
            this.rbtnFrom.Location = new System.Drawing.Point(253, 469);
            this.rbtnFrom.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFrom.Name = "rbtnFrom";
            this.rbtnFrom.Size = new System.Drawing.Size(274, 31);
            this.rbtnFrom.TabIndex = 14;
            this.rbtnFrom.TabStop = true;
            this.rbtnFrom.Text = "From selected airport";
            this.rbtnFrom.UseVisualStyleBackColor = true;
            // 
            // rbtnTo
            // 
            this.rbtnTo.AutoSize = true;
            this.rbtnTo.Location = new System.Drawing.Point(253, 508);
            this.rbtnTo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnTo.Name = "rbtnTo";
            this.rbtnTo.Size = new System.Drawing.Size(245, 31);
            this.rbtnTo.TabIndex = 15;
            this.rbtnTo.Text = "To selected airport";
            this.rbtnTo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(916, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "List of all Airlines";
            // 
            // dgvAirlines
            // 
            this.dgvAirlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirlines.Location = new System.Drawing.Point(906, 50);
            this.dgvAirlines.Name = "dgvAirlines";
            this.dgvAirlines.Size = new System.Drawing.Size(147, 316);
            this.dgvAirlines.TabIndex = 16;
            this.dgvAirlines.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAirlines_RowHeaderMouseDoubleClick);
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(25, 296);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(69, 13);
            this.label98.TabIndex = 18;
            this.label98.Text = "Airline Code: ";
            // 
            // lblAirlineCode
            // 
            this.lblAirlineCode.AutoSize = true;
            this.lblAirlineCode.Location = new System.Drawing.Point(121, 296);
            this.lblAirlineCode.Name = "lblAirlineCode";
            this.lblAirlineCode.Size = new System.Drawing.Size(35, 13);
            this.lblAirlineCode.TabIndex = 19;
            this.lblAirlineCode.Text = "label7";
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 457);
            this.Controls.Add(this.lblAirlineCode);
            this.Controls.Add(this.label98);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvAirlines);
            this.Controls.Add(this.rbtnTo);
            this.Controls.Add(this.rbtnFrom);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numSeats);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpArival);
            this.Controls.Add(this.dtpDepartureTime);
            this.Controls.Add(this.dtpArrivalTime);
            this.Controls.Add(this.dtpDeparture);
            this.Controls.Add(this.btnSwapDestinations);
            this.Controls.Add(this.lblFlightFrom);
            this.Controls.Add(this.labela1);
            this.Controls.Add(this.lblFlightTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateFlight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FlightForm";
            this.Text = "FlightForm";
            this.Load += new System.EventHandler(this.FlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlines)).EndInit();
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
        private System.Windows.Forms.Button btnShowFlights;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSeats;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        public System.Windows.Forms.DateTimePicker dtpArival;
        private System.Windows.Forms.RadioButton rbtnFrom;
        private System.Windows.Forms.RadioButton rbtnTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvAirlines;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label lblAirlineCode;
    }
}