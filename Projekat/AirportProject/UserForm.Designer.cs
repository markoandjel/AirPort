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
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.cbxAriportFrom = new System.Windows.Forms.ComboBox();
            this.cbxAirportTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckFlights = new System.Windows.Forms.Button();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTickets
            // 
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Location = new System.Drawing.Point(468, 81);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.Size = new System.Drawing.Size(320, 324);
            this.dgvTickets.TabIndex = 0;
            // 
            // cbxAriportFrom
            // 
            this.cbxAriportFrom.FormattingEnabled = true;
            this.cbxAriportFrom.Location = new System.Drawing.Point(84, 92);
            this.cbxAriportFrom.Name = "cbxAriportFrom";
            this.cbxAriportFrom.Size = new System.Drawing.Size(168, 21);
            this.cbxAriportFrom.TabIndex = 1;
            this.cbxAriportFrom.SelectedIndexChanged += new System.EventHandler(this.cbxAriportFrom_SelectedIndexChanged);
            // 
            // cbxAirportTo
            // 
            this.cbxAirportTo.FormattingEnabled = true;
            this.cbxAirportTo.Location = new System.Drawing.Point(287, 92);
            this.cbxAirportTo.Name = "cbxAirportTo";
            this.cbxAirportTo.Size = new System.Drawing.Size(158, 21);
            this.cbxAirportTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "My tickets:";
            // 
            // btnCheckFlights
            // 
            this.btnCheckFlights.Location = new System.Drawing.Point(180, 138);
            this.btnCheckFlights.Name = "btnCheckFlights";
            this.btnCheckFlights.Size = new System.Drawing.Size(163, 23);
            this.btnCheckFlights.TabIndex = 6;
            this.btnCheckFlights.Text = "Check for available flights";
            this.btnCheckFlights.UseVisualStyleBackColor = true;
            this.btnCheckFlights.Click += new System.EventHandler(this.btnCheckFlights_Click);
            // 
            // dgvFlights
            // 
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(34, 255);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.Size = new System.Drawing.Size(411, 150);
            this.dgvFlights.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Available flights:";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.btnCheckFlights);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAirportTo);
            this.Controls.Add(this.cbxAriportFrom);
            this.Controls.Add(this.dgvTickets);
            this.Name = "UserForm";
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
    }
}