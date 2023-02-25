namespace AirportProject
{
    partial class ShowFlights
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
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.lblAirport = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDeparutreTime = new System.Windows.Forms.DateTimePicker();
            this.dtpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.numFreeSeats = new System.Windows.Forms.NumericUpDown();
            this.numSeats = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateFlight = new System.Windows.Forms.Button();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFreeSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFlights
            // 
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(449, 77);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.Size = new System.Drawing.Size(562, 304);
            this.dgvFlights.TabIndex = 0;
            this.dgvFlights.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFlights_RowHeaderMouseDoubleClick);
            // 
            // lblAirport
            // 
            this.lblAirport.AutoSize = true;
            this.lblAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirport.Location = new System.Drawing.Point(445, 48);
            this.lblAirport.Name = "lblAirport";
            this.lblAirport.Size = new System.Drawing.Size(102, 20);
            this.lblAirport.TabIndex = 1;
            this.lblAirport.Text = "List of flights ";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Location = new System.Drawing.Point(145, 78);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDepartureDate.TabIndex = 2;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Location = new System.Drawing.Point(145, 115);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(200, 20);
            this.dtpArrivalDate.TabIndex = 3;
            // 
            // dtpDeparutreTime
            // 
            this.dtpDeparutreTime.CustomFormat = "HH:mm";
            this.dtpDeparutreTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeparutreTime.Location = new System.Drawing.Point(351, 78);
            this.dtpDeparutreTime.Name = "dtpDeparutreTime";
            this.dtpDeparutreTime.ShowUpDown = true;
            this.dtpDeparutreTime.Size = new System.Drawing.Size(57, 20);
            this.dtpDeparutreTime.TabIndex = 4;
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.CustomFormat = "HH:mm";
            this.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalTime.Location = new System.Drawing.Point(351, 115);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.ShowUpDown = true;
            this.dtpArrivalTime.Size = new System.Drawing.Size(57, 20);
            this.dtpArrivalTime.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateFlight);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numPrice);
            this.groupBox1.Controls.Add(this.numSeats);
            this.groupBox1.Controls.Add(this.numFreeSeats);
            this.groupBox1.Controls.Add(this.lblDestination);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpArrivalTime);
            this.groupBox1.Controls.Add(this.dtpDeparutreTime);
            this.groupBox1.Controls.Add(this.dtpArrivalDate);
            this.groupBox1.Controls.Add(this.dtpDepartureDate);
            this.groupBox1.Location = new System.Drawing.Point(29, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 276);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update flight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Departure date and time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arrival date and time:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(24, 51);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(63, 13);
            this.lblDestination.TabIndex = 8;
            this.lblDestination.Text = "Destination:";
            // 
            // numFreeSeats
            // 
            this.numFreeSeats.Location = new System.Drawing.Point(341, 168);
            this.numFreeSeats.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFreeSeats.Name = "numFreeSeats";
            this.numFreeSeats.Size = new System.Drawing.Size(64, 20);
            this.numFreeSeats.TabIndex = 9;
            // 
            // numSeats
            // 
            this.numSeats.Location = new System.Drawing.Point(194, 166);
            this.numSeats.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSeats.Name = "numSeats";
            this.numSeats.Size = new System.Drawing.Size(64, 20);
            this.numSeats.TabIndex = 10;
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(64, 168);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(64, 20);
            this.numPrice.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seats:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "FreeSeats: ";
            // 
            // btnUpdateFlight
            // 
            this.btnUpdateFlight.Location = new System.Drawing.Point(154, 237);
            this.btnUpdateFlight.Name = "btnUpdateFlight";
            this.btnUpdateFlight.Size = new System.Drawing.Size(86, 33);
            this.btnUpdateFlight.TabIndex = 15;
            this.btnUpdateFlight.Text = "Update flight";
            this.btnUpdateFlight.UseVisualStyleBackColor = true;
            this.btnUpdateFlight.Click += new System.EventHandler(this.btnUpdateFlight_Click);
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.Location = new System.Drawing.Point(689, 387);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(98, 36);
            this.btnDeleteFlight.TabIndex = 7;
            this.btnDeleteFlight.Text = "Delete flight";
            this.btnDeleteFlight.UseVisualStyleBackColor = true;
            // 
            // ShowFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.btnDeleteFlight);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAirport);
            this.Controls.Add(this.dgvFlights);
            this.Name = "ShowFlights";
            this.Text = "ShowFlights";
            this.Load += new System.EventHandler(this.ShowFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFreeSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.Label lblAirport;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.DateTimePicker dtpDeparutreTime;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateFlight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numSeats;
        private System.Windows.Forms.NumericUpDown numFreeSeats;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteFlight;
    }
}