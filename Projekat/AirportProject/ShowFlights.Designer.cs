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
            this.btnUpdateFlight = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numSeats = new System.Windows.Forms.NumericUpDown();
            this.numFreeSeats = new System.Windows.Forms.NumericUpDown();
            this.lblDestination = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreeSeats)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFlights
            // 
            this.dgvFlights.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(33, 34);
            this.dgvFlights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.RowHeadersWidth = 51;
            this.dgvFlights.Size = new System.Drawing.Size(715, 374);
            this.dgvFlights.TabIndex = 0;
            this.dgvFlights.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFlights_RowHeaderMouseDoubleClick);
            // 
            // lblAirport
            // 
            this.lblAirport.AutoSize = true;
            this.lblAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblAirport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAirport.Location = new System.Drawing.Point(28, 5);
            this.lblAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirport.Name = "lblAirport";
            this.lblAirport.Size = new System.Drawing.Size(128, 23);
            this.lblAirport.TabIndex = 1;
            this.lblAirport.Text = "List of flights ";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Location = new System.Drawing.Point(341, 96);
            this.dtpDepartureDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(415, 36);
            this.dtpDepartureDate.TabIndex = 2;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Location = new System.Drawing.Point(341, 135);
            this.dtpArrivalDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(415, 36);
            this.dtpArrivalDate.TabIndex = 3;
            // 
            // dtpDeparutreTime
            // 
            this.dtpDeparutreTime.CustomFormat = "HH:mm";
            this.dtpDeparutreTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeparutreTime.Location = new System.Drawing.Point(763, 96);
            this.dtpDeparutreTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDeparutreTime.Name = "dtpDeparutreTime";
            this.dtpDeparutreTime.ShowUpDown = true;
            this.dtpDeparutreTime.Size = new System.Drawing.Size(119, 36);
            this.dtpDeparutreTime.TabIndex = 4;
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.CustomFormat = "HH:mm";
            this.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalTime.Location = new System.Drawing.Point(763, 135);
            this.dtpArrivalTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.ShowUpDown = true;
            this.dtpArrivalTime.Size = new System.Drawing.Size(119, 36);
            this.dtpArrivalTime.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateFlight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numPrice);
            this.groupBox1.Controls.Add(this.numSeats);
            this.groupBox1.Controls.Add(this.numFreeSeats);
            this.groupBox1.Controls.Add(this.lblDestination);
            this.groupBox1.Controls.Add(this.dtpArrivalTime);
            this.groupBox1.Controls.Add(this.dtpDeparutreTime);
            this.groupBox1.Controls.Add(this.dtpArrivalDate);
            this.groupBox1.Controls.Add(this.dtpDepartureDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(29, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(900, 340);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update flight";
            // 
            // btnUpdateFlight
            // 
            this.btnUpdateFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateFlight.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFlight.ForeColor = System.Drawing.Color.White;
            this.btnUpdateFlight.Location = new System.Drawing.Point(341, 261);
            this.btnUpdateFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateFlight.Name = "btnUpdateFlight";
            this.btnUpdateFlight.Size = new System.Drawing.Size(232, 41);
            this.btnUpdateFlight.TabIndex = 15;
            this.btnUpdateFlight.Text = "Update flight";
            this.btnUpdateFlight.UseVisualStyleBackColor = false;
            this.btnUpdateFlight.Click += new System.EventHandler(this.btnUpdateFlight_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seats:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Price:";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(161, 204);
            this.numPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(133, 36);
            this.numPrice.TabIndex = 11;
            // 
            // numSeats
            // 
            this.numSeats.Location = new System.Drawing.Point(440, 204);
            this.numSeats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numSeats.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSeats.Name = "numSeats";
            this.numSeats.Size = new System.Drawing.Size(133, 36);
            this.numSeats.TabIndex = 10;
            // 
            // numFreeSeats
            // 
            this.numFreeSeats.Location = new System.Drawing.Point(748, 204);
            this.numFreeSeats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numFreeSeats.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFreeSeats.Name = "numFreeSeats";
            this.numFreeSeats.Size = new System.Drawing.Size(133, 36);
            this.numFreeSeats.TabIndex = 9;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(179, 46);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(146, 27);
            this.lblDestination.TabIndex = 8;
            this.lblDestination.Text = "Destination:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Departure date and time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arrival date and time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "FreeSeats: ";
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeleteFlight.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFlight.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFlight.Location = new System.Drawing.Point(280, 417);
            this.btnDeleteFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(243, 44);
            this.btnDeleteFlight.TabIndex = 7;
            this.btnDeleteFlight.Text = "Delete flight";
            this.btnDeleteFlight.UseVisualStyleBackColor = false;
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(755, -1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 55);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDeleteFlight);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblAirport);
            this.panel1.Controls.Add(this.dgvFlights);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(958, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 471);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 471);
            this.panel2.TabIndex = 10;
            // 
            // ShowFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1739, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShowFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowFlights";
            this.Load += new System.EventHandler(this.ShowFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreeSeats)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}