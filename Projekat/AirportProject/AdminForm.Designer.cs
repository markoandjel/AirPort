namespace AirportProject

{
    partial class AdminForm
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
            this.addPassenger = new System.Windows.Forms.Button();
            this.addTicket = new System.Windows.Forms.Button();
            this.btnAirportManager = new System.Windows.Forms.Button();
            this.btnFlightManager = new System.Windows.Forms.Button();
            this.btnCityManager = new System.Windows.Forms.Button();
            this.btnAirlineManager = new System.Windows.Forms.Button();
            this.PubSubRedis = new System.Windows.Forms.Button();
            this.cbxAirports = new System.Windows.Forms.ComboBox();
            this.lblSelectAirport = new System.Windows.Forms.Label();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // addPassenger
            // 
            this.addPassenger.Location = new System.Drawing.Point(73, 398);
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
            this.addTicket.Location = new System.Drawing.Point(232, 398);
            this.addTicket.Margin = new System.Windows.Forms.Padding(2);
            this.addTicket.Name = "addTicket";
            this.addTicket.Size = new System.Drawing.Size(140, 49);
            this.addTicket.TabIndex = 3;
            this.addTicket.Text = "Add Ticket";
            this.addTicket.UseVisualStyleBackColor = true;
            this.addTicket.Click += new System.EventHandler(this.addTicket_Click);
            // 
            // btnAirportManager
            // 
            this.btnAirportManager.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAirportManager.Location = new System.Drawing.Point(31, 196);
            this.btnAirportManager.Name = "btnAirportManager";
            this.btnAirportManager.Size = new System.Drawing.Size(155, 52);
            this.btnAirportManager.TabIndex = 5;
            this.btnAirportManager.Text = "Airport Manager";
            this.btnAirportManager.UseVisualStyleBackColor = false;
            this.btnAirportManager.Click += new System.EventHandler(this.btnAirportManager_Click);
            // 
            // btnFlightManager
            // 
            this.btnFlightManager.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFlightManager.Location = new System.Drawing.Point(31, 254);
            this.btnFlightManager.Name = "btnFlightManager";
            this.btnFlightManager.Size = new System.Drawing.Size(155, 52);
            this.btnFlightManager.TabIndex = 5;
            this.btnFlightManager.Text = "Flight Manager";
            this.btnFlightManager.UseVisualStyleBackColor = false;
            this.btnFlightManager.Click += new System.EventHandler(this.btnFlightManager_Click);
            // 
            // btnCityManager
            // 
            this.btnCityManager.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCityManager.Location = new System.Drawing.Point(31, 139);
            this.btnCityManager.Margin = new System.Windows.Forms.Padding(2);
            this.btnCityManager.Name = "btnCityManager";
            this.btnCityManager.Size = new System.Drawing.Size(155, 52);
            this.btnCityManager.TabIndex = 6;
            this.btnCityManager.Text = "City Manager";
            this.btnCityManager.UseVisualStyleBackColor = false;
            this.btnCityManager.Click += new System.EventHandler(this.btnCityManager_Click);
            // 
            // btnAirlineManager
            // 
            this.btnAirlineManager.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAirlineManager.Location = new System.Drawing.Point(31, 83);
            this.btnAirlineManager.Margin = new System.Windows.Forms.Padding(2);
            this.btnAirlineManager.Name = "btnAirlineManager";
            this.btnAirlineManager.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAirlineManager.Size = new System.Drawing.Size(155, 52);
            this.btnAirlineManager.TabIndex = 7;
            this.btnAirlineManager.Text = "Airline Manager";
            this.btnAirlineManager.UseVisualStyleBackColor = false;
            this.btnAirlineManager.Click += new System.EventHandler(this.btnAirlineManager_Click);
            // 
            // PubSubRedis
            // 
            this.PubSubRedis.Location = new System.Drawing.Point(412, 400);
            this.PubSubRedis.Name = "PubSubRedis";
            this.PubSubRedis.Size = new System.Drawing.Size(156, 45);
            this.PubSubRedis.TabIndex = 8;
            this.PubSubRedis.Text = "PubSubRedis";
            this.PubSubRedis.UseVisualStyleBackColor = true;
            this.PubSubRedis.Click += new System.EventHandler(this.PubSubRedis_Click);
            // 
            // cbxAirports
            // 
            this.cbxAirports.FormattingEnabled = true;
            this.cbxAirports.Location = new System.Drawing.Point(345, 100);
            this.cbxAirports.Name = "cbxAirports";
            this.cbxAirports.Size = new System.Drawing.Size(223, 21);
            this.cbxAirports.TabIndex = 10;
            this.cbxAirports.SelectedIndexChanged += new System.EventHandler(this.cbxAirports_SelectedIndexChanged);
            // 
            // lblSelectAirport
            // 
            this.lblSelectAirport.AutoSize = true;
            this.lblSelectAirport.Location = new System.Drawing.Point(342, 84);
            this.lblSelectAirport.Name = "lblSelectAirport";
            this.lblSelectAirport.Size = new System.Drawing.Size(173, 13);
            this.lblSelectAirport.TabIndex = 11;
            this.lblSelectAirport.Text = "Please select airport from list bellow";
            // 
            // dgvMessages
            // 
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Message});
            this.dgvMessages.Location = new System.Drawing.Point(345, 156);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.Size = new System.Drawing.Size(592, 150);
            this.dgvMessages.TabIndex = 12;
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 472);
            this.Controls.Add(this.dgvMessages);
            this.Controls.Add(this.lblSelectAirport);
            this.Controls.Add(this.cbxAirports);
            this.Controls.Add(this.PubSubRedis);
            this.Controls.Add(this.btnAirlineManager);
            this.Controls.Add(this.btnCityManager);
            this.Controls.Add(this.btnFlightManager);
            this.Controls.Add(this.btnAirportManager);
            this.Controls.Add(this.addTicket);
            this.Controls.Add(this.addPassenger);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addPassenger;
        private System.Windows.Forms.Button addTicket;
        private System.Windows.Forms.Button btnAirportManager;
        private System.Windows.Forms.Button btnFlightManager;
        private System.Windows.Forms.Button btnCityManager;
        private System.Windows.Forms.Button btnAirlineManager;
        private System.Windows.Forms.Button PubSubRedis;
        private System.Windows.Forms.ComboBox cbxAirports;
        private System.Windows.Forms.Label lblSelectAirport;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
    }
}

