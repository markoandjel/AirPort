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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAirports
            // 
            this.dgvAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirports.Location = new System.Drawing.Point(366, 50);
            this.dgvAirports.Name = "dgvAirports";
            this.dgvAirports.Size = new System.Drawing.Size(517, 316);
            this.dgvAirports.TabIndex = 0;
            this.dgvAirports.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAirports_RowHeaderMouseDoubleClick);
            // 
            // btnCreateFlight
            // 
            this.btnCreateFlight.Location = new System.Drawing.Point(129, 382);
            this.btnCreateFlight.Name = "btnCreateFlight";
            this.btnCreateFlight.Size = new System.Drawing.Size(100, 37);
            this.btnCreateFlight.TabIndex = 1;
            this.btnCreateFlight.Text = "Create flight";
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
            this.lblListOf.Location = new System.Drawing.Point(558, 27);
            this.lblListOf.Name = "lblListOf";
            this.lblListOf.Size = new System.Drawing.Size(130, 20);
            this.lblListOf.TabIndex = 4;
            this.lblListOf.Text = "List of all Airports";
            // 
            // btnShowFlights
            // 
            this.btnShowFlights.Location = new System.Drawing.Point(499, 382);
            this.btnShowFlights.Name = "btnShowFlights";
            this.btnShowFlights.Size = new System.Drawing.Size(119, 37);
            this.btnShowFlights.TabIndex = 1;
            this.btnShowFlights.Text = "Show flights";
            this.btnShowFlights.UseVisualStyleBackColor = true;
            this.btnShowFlights.Click += new System.EventHandler(this.btnShowFlights_Click);
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.Location = new System.Drawing.Point(124, 211);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(174, 20);
            this.dtpDeparture.TabIndex = 7;
            // 
            // dtpArival
            // 
            this.dtpArival.Location = new System.Drawing.Point(124, 257);
            this.dtpArival.Name = "dtpArival";
            this.dtpArival.Size = new System.Drawing.Size(174, 20);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price in €";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seats";
            // 
            // numSeats
            // 
            this.numSeats.Location = new System.Drawing.Point(129, 333);
            this.numSeats.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSeats.Name = "numSeats";
            this.numSeats.Size = new System.Drawing.Size(100, 20);
            this.numSeats.TabIndex = 12;
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(129, 307);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(100, 20);
            this.numPrice.TabIndex = 13;
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.CustomFormat = "HH:mm";
            this.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalTime.Location = new System.Drawing.Point(304, 258);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.ShowUpDown = true;
            this.dtpArrivalTime.Size = new System.Drawing.Size(56, 20);
            this.dtpArrivalTime.TabIndex = 7;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.CustomFormat = "HH:mm";
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureTime.Location = new System.Drawing.Point(304, 211);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.ShowUpDown = true;
            this.dtpDepartureTime.Size = new System.Drawing.Size(56, 20);
            this.dtpDepartureTime.TabIndex = 7;
            // 
            // rbtnFrom
            // 
            this.rbtnFrom.AutoSize = true;
            this.rbtnFrom.Checked = true;
            this.rbtnFrom.Location = new System.Drawing.Point(642, 382);
            this.rbtnFrom.Name = "rbtnFrom";
            this.rbtnFrom.Size = new System.Drawing.Size(123, 17);
            this.rbtnFrom.TabIndex = 14;
            this.rbtnFrom.TabStop = true;
            this.rbtnFrom.Text = "From selected airport";
            this.rbtnFrom.UseVisualStyleBackColor = true;
            // 
            // rbtnTo
            // 
            this.rbtnTo.AutoSize = true;
            this.rbtnTo.Location = new System.Drawing.Point(642, 405);
            this.rbtnTo.Name = "rbtnTo";
            this.rbtnTo.Size = new System.Drawing.Size(113, 17);
            this.rbtnTo.TabIndex = 15;
            this.rbtnTo.Text = "To selected airport";
            this.rbtnTo.UseVisualStyleBackColor = true;
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
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
            this.Controls.Add(this.lblListOf);
            this.Controls.Add(this.labela1);
            this.Controls.Add(this.lblFlightTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowFlights);
            this.Controls.Add(this.btnCreateFlight);
            this.Controls.Add(this.dgvAirports);
            this.Name = "FlightForm";
            this.Text = "FlightForm";
            this.Load += new System.EventHandler(this.FlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
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
    }
}