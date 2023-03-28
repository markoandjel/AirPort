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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlines)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAirports
            // 
            this.dgvAirports.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirports.Location = new System.Drawing.Point(18, 59);
            this.dgvAirports.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAirports.Name = "dgvAirports";
            this.dgvAirports.RowHeadersWidth = 51;
            this.dgvAirports.Size = new System.Drawing.Size(613, 389);
            this.dgvAirports.TabIndex = 0;
            this.dgvAirports.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAirports_RowHeaderMouseDoubleClick);
            // 
            // btnCreateFlight
            // 
            this.btnCreateFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreateFlight.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFlight.ForeColor = System.Drawing.Color.White;
            this.btnCreateFlight.Location = new System.Drawing.Point(40, 434);
            this.btnCreateFlight.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateFlight.Name = "btnCreateFlight";
            this.btnCreateFlight.Size = new System.Drawing.Size(262, 38);
            this.btnCreateFlight.TabIndex = 1;
            this.btnCreateFlight.Text = "Create flight";
            this.btnCreateFlight.UseVisualStyleBackColor = false;
            this.btnCreateFlight.Click += new System.EventHandler(this.btnCreateFlight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(4, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flight to:";
            // 
            // lblFlightTo
            // 
            this.lblFlightTo.AutoSize = true;
            this.lblFlightTo.Location = new System.Drawing.Point(147, 142);
            this.lblFlightTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightTo.Name = "lblFlightTo";
            this.lblFlightTo.Size = new System.Drawing.Size(126, 27);
            this.lblFlightTo.TabIndex = 3;
            this.lblFlightTo.Text = "lblFlightTo";
            // 
            // lblFlightFrom
            // 
            this.lblFlightFrom.AutoSize = true;
            this.lblFlightFrom.Location = new System.Drawing.Point(147, 30);
            this.lblFlightFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightFrom.Name = "lblFlightFrom";
            this.lblFlightFrom.Size = new System.Drawing.Size(147, 27);
            this.lblFlightFrom.TabIndex = 5;
            this.lblFlightFrom.Text = "lblflightfrom";
            // 
            // labela1
            // 
            this.labela1.AutoSize = true;
            this.labela1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labela1.Location = new System.Drawing.Point(4, 30);
            this.labela1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labela1.Name = "labela1";
            this.labela1.Size = new System.Drawing.Size(135, 27);
            this.labela1.TabIndex = 4;
            this.labela1.Text = "Flight from:";
            // 
            // btnSwapDestinations
            // 
            this.btnSwapDestinations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSwapDestinations.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwapDestinations.ForeColor = System.Drawing.Color.White;
            this.btnSwapDestinations.Location = new System.Drawing.Point(40, 83);
            this.btnSwapDestinations.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwapDestinations.Name = "btnSwapDestinations";
            this.btnSwapDestinations.Size = new System.Drawing.Size(262, 38);
            this.btnSwapDestinations.TabIndex = 6;
            this.btnSwapDestinations.Text = "Swap Destinations";
            this.btnSwapDestinations.UseVisualStyleBackColor = false;
            this.btnSwapDestinations.Click += new System.EventHandler(this.btnSwapDestinations_Click);
            // 
            // lblListOf
            // 
            this.lblListOf.AutoSize = true;
            this.lblListOf.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblListOf.Location = new System.Drawing.Point(200, 19);
            this.lblListOf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListOf.Name = "lblListOf";
            this.lblListOf.Size = new System.Drawing.Size(199, 27);
            this.lblListOf.TabIndex = 4;
            this.lblListOf.Text = "List of all Airports";
            // 
            // btnShowFlights
            // 
            this.btnShowFlights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowFlights.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFlights.ForeColor = System.Drawing.Color.White;
            this.btnShowFlights.Location = new System.Drawing.Point(71, 465);
            this.btnShowFlights.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowFlights.Name = "btnShowFlights";
            this.btnShowFlights.Size = new System.Drawing.Size(198, 46);
            this.btnShowFlights.TabIndex = 1;
            this.btnShowFlights.Text = "Show flights";
            this.btnShowFlights.UseVisualStyleBackColor = false;
            this.btnShowFlights.Click += new System.EventHandler(this.btnShowFlights_Click);
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeparture.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpDeparture.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpDeparture.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpDeparture.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.dtpDeparture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeparture.Location = new System.Drawing.Point(232, 190);
            this.dtpDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(422, 32);
            this.dtpDeparture.TabIndex = 7;
            // 
            // dtpArival
            // 
            this.dtpArival.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArival.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dtpArival.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpArival.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtpArival.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArival.Location = new System.Drawing.Point(232, 234);
            this.dtpArival.Margin = new System.Windows.Forms.Padding(4);
            this.dtpArival.Name = "dtpArival";
            this.dtpArival.Size = new System.Drawing.Size(422, 32);
            this.dtpArival.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(4, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time of departure:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(4, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time of arival:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(4, 336);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price in €";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(4, 383);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seats";
            // 
            // numSeats
            // 
            this.numSeats.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSeats.Location = new System.Drawing.Point(136, 378);
            this.numSeats.Margin = new System.Windows.Forms.Padding(4);
            this.numSeats.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSeats.Name = "numSeats";
            this.numSeats.Size = new System.Drawing.Size(208, 32);
            this.numSeats.TabIndex = 12;
            // 
            // numPrice
            // 
            this.numPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.Location = new System.Drawing.Point(136, 331);
            this.numPrice.Margin = new System.Windows.Forms.Padding(4);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(208, 32);
            this.numPrice.TabIndex = 13;
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArrivalTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtpArrivalTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpArrivalTime.CustomFormat = "HH:mm";
            this.dtpArrivalTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalTime.Location = new System.Drawing.Point(676, 234);
            this.dtpArrivalTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.ShowUpDown = true;
            this.dtpArrivalTime.Size = new System.Drawing.Size(80, 32);
            this.dtpArrivalTime.TabIndex = 7;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepartureTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtpDepartureTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtpDepartureTime.CustomFormat = "HH:mm";
            this.dtpDepartureTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureTime.Location = new System.Drawing.Point(676, 190);
            this.dtpDepartureTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.ShowUpDown = true;
            this.dtpDepartureTime.Size = new System.Drawing.Size(80, 32);
            this.dtpDepartureTime.TabIndex = 7;
            // 
            // rbtnFrom
            // 
            this.rbtnFrom.AutoSize = true;
            this.rbtnFrom.Checked = true;
            this.rbtnFrom.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbtnFrom.Location = new System.Drawing.Point(295, 456);
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
            this.rbtnTo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbtnTo.Location = new System.Drawing.Point(295, 489);
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
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(659, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "List of all Airlines";
            // 
            // dgvAirlines
            // 
            this.dgvAirlines.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAirlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirlines.Location = new System.Drawing.Point(657, 59);
            this.dgvAirlines.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAirlines.Name = "dgvAirlines";
            this.dgvAirlines.RowHeadersWidth = 51;
            this.dgvAirlines.Size = new System.Drawing.Size(196, 389);
            this.dgvAirlines.TabIndex = 16;
            this.dgvAirlines.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAirlines_RowHeaderMouseDoubleClick);
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label98.Location = new System.Drawing.Point(4, 285);
            this.label98.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(166, 27);
            this.label98.TabIndex = 18;
            this.label98.Text = "Airline Code: ";
            // 
            // lblAirlineCode
            // 
            this.lblAirlineCode.AutoSize = true;
            this.lblAirlineCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAirlineCode.Location = new System.Drawing.Point(178, 285);
            this.lblAirlineCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirlineCode.Name = "lblAirlineCode";
            this.lblAirlineCode.Size = new System.Drawing.Size(84, 27);
            this.lblAirlineCode.TabIndex = 19;
            this.lblAirlineCode.Text = "label7";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgvAirlines);
            this.panel1.Controls.Add(this.rbtnTo);
            this.panel1.Controls.Add(this.rbtnFrom);
            this.panel1.Controls.Add(this.lblListOf);
            this.panel1.Controls.Add(this.btnShowFlights);
            this.panel1.Controls.Add(this.dgvAirports);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(783, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 534);
            this.panel1.TabIndex = 20;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(890, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 42);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.dtpDeparture);
            this.panel2.Controls.Add(this.lblAirlineCode);
            this.panel2.Controls.Add(this.label98);
            this.panel2.Controls.Add(this.numPrice);
            this.panel2.Controls.Add(this.numSeats);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpArival);
            this.panel2.Controls.Add(this.dtpDepartureTime);
            this.panel2.Controls.Add(this.dtpArrivalTime);
            this.panel2.Controls.Add(this.btnSwapDestinations);
            this.panel2.Controls.Add(this.lblFlightFrom);
            this.panel2.Controls.Add(this.labela1);
            this.panel2.Controls.Add(this.lblFlightTo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCreateFlight);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 534);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(494, 25);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 38);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightForm";
            this.Load += new System.EventHandler(this.FlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlines)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}