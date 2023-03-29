namespace AirportProject
{
    partial class UserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.cbxAriportFrom = new System.Windows.Forms.ComboBox();
            this.cbxAirportTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckFlights = new System.Windows.Forms.Button();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTickets
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgvTickets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTickets.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Location = new System.Drawing.Point(624, 100);
            this.dgvTickets.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.RowHeadersWidth = 51;
            this.dgvTickets.Size = new System.Drawing.Size(427, 399);
            this.dgvTickets.TabIndex = 0;
            this.dgvTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellContentClick);
            // 
            // cbxAriportFrom
            // 
            this.cbxAriportFrom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbxAriportFrom.FormattingEnabled = true;
            this.cbxAriportFrom.Location = new System.Drawing.Point(94, 113);
            this.cbxAriportFrom.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAriportFrom.Name = "cbxAriportFrom";
            this.cbxAriportFrom.Size = new System.Drawing.Size(223, 35);
            this.cbxAriportFrom.TabIndex = 1;
            this.cbxAriportFrom.SelectedIndexChanged += new System.EventHandler(this.cbxAriportFrom_SelectedIndexChanged);
            // 
            // cbxAirportTo
            // 
            this.cbxAirportTo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbxAirportTo.FormattingEnabled = true;
            this.cbxAirportTo.Location = new System.Drawing.Point(383, 113);
            this.cbxAirportTo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAirportTo.Name = "cbxAirportTo";
            this.cbxAirportTo.Size = new System.Drawing.Size(209, 35);
            this.cbxAirportTo.TabIndex = 2;
            this.cbxAirportTo.SelectedIndexChanged += new System.EventHandler(this.cbxAirportTo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "My tickets:";
            // 
            // btnCheckFlights
            // 
            this.btnCheckFlights.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCheckFlights.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckFlights.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckFlights.ForeColor = System.Drawing.Color.Blue;
            this.btnCheckFlights.Location = new System.Drawing.Point(126, 173);
            this.btnCheckFlights.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckFlights.Name = "btnCheckFlights";
            this.btnCheckFlights.Size = new System.Drawing.Size(425, 39);
            this.btnCheckFlights.TabIndex = 6;
            this.btnCheckFlights.Text = "Check for available flights";
            this.btnCheckFlights.UseVisualStyleBackColor = false;
            this.btnCheckFlights.Click += new System.EventHandler(this.btnCheckFlights_Click);
            // 
            // dgvFlights
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgvFlights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFlights.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(45, 314);
            this.dgvFlights.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.RowHeadersWidth = 51;
            this.dgvFlights.Size = new System.Drawing.Size(548, 185);
            this.dgvFlights.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Available flights:";
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTicket.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTicket.ForeColor = System.Drawing.Color.Blue;
            this.btnAddTicket.Location = new System.Drawing.Point(240, 524);
            this.btnAddTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(198, 40);
            this.btnAddTicket.TabIndex = 9;
            this.btnAddTicket.Text = "Buy ticket";
            this.btnAddTicket.UseVisualStyleBackColor = false;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDeleteTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTicket.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTicket.ForeColor = System.Drawing.Color.Blue;
            this.btnDeleteTicket.Location = new System.Drawing.Point(744, 526);
            this.btnDeleteTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(210, 38);
            this.btnDeleteTicket.TabIndex = 10;
            this.btnDeleteTicket.Text = "Delete ticket";
            this.btnDeleteTicket.UseVisualStyleBackColor = false;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Blue;
            this.btnLogOut.Location = new System.Drawing.Point(13, 13);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(156, 36);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1063, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 48);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1106, 591);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnDeleteTicket);
            this.Controls.Add(this.btnAddTicket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.btnCheckFlights);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAirportTo);
            this.Controls.Add(this.cbxAriportFrom);
            this.Controls.Add(this.dgvTickets);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.ComboBox cbxAriportFrom;
        private System.Windows.Forms.ComboBox cbxAirportTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckFlights;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
    }
}