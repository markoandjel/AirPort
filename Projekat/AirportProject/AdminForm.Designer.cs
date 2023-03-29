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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAirportManager = new System.Windows.Forms.Button();
            this.btnFlightManager = new System.Windows.Forms.Button();
            this.btnCityManager = new System.Windows.Forms.Button();
            this.btnAirlineManager = new System.Windows.Forms.Button();
            this.cbxAirports = new System.Windows.Forms.ComboBox();
            this.lblSelectAirport = new System.Windows.Forms.Label();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAirportManager
            // 
            this.btnAirportManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAirportManager.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirportManager.ForeColor = System.Drawing.Color.White;
            this.btnAirportManager.Location = new System.Drawing.Point(653, 363);
            this.btnAirportManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAirportManager.Name = "btnAirportManager";
            this.btnAirportManager.Size = new System.Drawing.Size(240, 60);
            this.btnAirportManager.TabIndex = 5;
            this.btnAirportManager.Text = "Airport Manager";
            this.btnAirportManager.UseVisualStyleBackColor = false;
            this.btnAirportManager.Click += new System.EventHandler(this.btnAirportManager_Click);
            // 
            // btnFlightManager
            // 
            this.btnFlightManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFlightManager.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightManager.ForeColor = System.Drawing.Color.White;
            this.btnFlightManager.Location = new System.Drawing.Point(344, 363);
            this.btnFlightManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlightManager.Name = "btnFlightManager";
            this.btnFlightManager.Size = new System.Drawing.Size(240, 60);
            this.btnFlightManager.TabIndex = 5;
            this.btnFlightManager.Text = "Flight Manager";
            this.btnFlightManager.UseVisualStyleBackColor = false;
            this.btnFlightManager.Click += new System.EventHandler(this.btnFlightManager_Click);
            // 
            // btnCityManager
            // 
            this.btnCityManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCityManager.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCityManager.ForeColor = System.Drawing.Color.White;
            this.btnCityManager.Location = new System.Drawing.Point(952, 361);
            this.btnCityManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCityManager.Name = "btnCityManager";
            this.btnCityManager.Size = new System.Drawing.Size(240, 60);
            this.btnCityManager.TabIndex = 6;
            this.btnCityManager.Text = "City Manager";
            this.btnCityManager.UseVisualStyleBackColor = false;
            this.btnCityManager.Click += new System.EventHandler(this.btnCityManager_Click);
            // 
            // btnAirlineManager
            // 
            this.btnAirlineManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAirlineManager.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirlineManager.ForeColor = System.Drawing.Color.White;
            this.btnAirlineManager.Location = new System.Drawing.Point(27, 363);
            this.btnAirlineManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAirlineManager.Name = "btnAirlineManager";
            this.btnAirlineManager.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAirlineManager.Size = new System.Drawing.Size(240, 60);
            this.btnAirlineManager.TabIndex = 7;
            this.btnAirlineManager.Text = "Airline Manager";
            this.btnAirlineManager.UseVisualStyleBackColor = false;
            this.btnAirlineManager.Click += new System.EventHandler(this.btnAirlineManager_Click);
            // 
            // cbxAirports
            // 
            this.cbxAirports.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAirports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbxAirports.FormattingEnabled = true;
            this.cbxAirports.Location = new System.Drawing.Point(25, 60);
            this.cbxAirports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxAirports.Name = "cbxAirports";
            this.cbxAirports.Size = new System.Drawing.Size(733, 35);
            this.cbxAirports.TabIndex = 10;
            this.cbxAirports.SelectedIndexChanged += new System.EventHandler(this.cbxAirports_SelectedIndexChanged);
            // 
            // lblSelectAirport
            // 
            this.lblSelectAirport.AutoSize = true;
            this.lblSelectAirport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAirport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSelectAirport.Location = new System.Drawing.Point(21, 22);
            this.lblSelectAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectAirport.Name = "lblSelectAirport";
            this.lblSelectAirport.Size = new System.Drawing.Size(418, 27);
            this.lblSelectAirport.TabIndex = 11;
            this.lblSelectAirport.Text = "Please select airport from list bellow";
            // 
            // dgvMessages
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMessages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMessages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Message});
            this.dgvMessages.Location = new System.Drawing.Point(25, 103);
            this.dgvMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.RowHeadersWidth = 51;
            this.dgvMessages.Size = new System.Drawing.Size(1167, 251);
            this.dgvMessages.TabIndex = 12;
            // 
            // Message
            // 
            this.Message.HeaderText = "Messages";
            this.Message.MinimumWidth = 6;
            this.Message.Name = "Message";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(1175, -1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 50);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSelectAirport);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.dgvMessages);
            this.panel1.Controls.Add(this.cbxAirports);
            this.panel1.Controls.Add(this.btnAirlineManager);
            this.panel1.Controls.Add(this.btnCityManager);
            this.panel1.Controls.Add(this.btnFlightManager);
            this.panel1.Controls.Add(this.btnAirportManager);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(314, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 438);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 438);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(57, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(57, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "admin view";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AirportProject.Properties.Resources.admin;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(40, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 229);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(40, 377);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogOut.Size = new System.Drawing.Size(240, 60);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAirportManager;
        private System.Windows.Forms.Button btnFlightManager;
        private System.Windows.Forms.Button btnCityManager;
        private System.Windows.Forms.Button btnAirlineManager;
        private System.Windows.Forms.ComboBox cbxAirports;
        private System.Windows.Forms.Label lblSelectAirport;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
    }
}

