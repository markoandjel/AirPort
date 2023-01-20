namespace AirportProject

{
    partial class Form1
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
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnGetAllAirports = new System.Windows.Forms.Button();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnUpdateAirport = new System.Windows.Forms.Button();
            this.btnCreateFlight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(67, 80);
            this.btnAddAirport.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(118, 38);
            this.btnAddAirport.TabIndex = 0;
            this.btnAddAirport.Text = "Add Airport";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnGetAllAirports
            // 
            this.btnGetAllAirports.Location = new System.Drawing.Point(58, 135);
            this.btnGetAllAirports.Name = "btnGetAllAirports";
            this.btnGetAllAirports.Size = new System.Drawing.Size(132, 32);
            this.btnGetAllAirports.TabIndex = 1;
            this.btnGetAllAirports.Text = "Get all airports";
            this.btnGetAllAirports.UseVisualStyleBackColor = true;
            this.btnGetAllAirports.Click += new System.EventHandler(this.btnGetAllAirports_Click);
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(58, 242);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(143, 23);
            this.btnDeleteAirport.TabIndex = 2;
            this.btnDeleteAirport.Text = "Delete airport";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnUpdateAirport
            // 
            this.btnUpdateAirport.Location = new System.Drawing.Point(67, 190);
            this.btnUpdateAirport.Name = "btnUpdateAirport";
            this.btnUpdateAirport.Size = new System.Drawing.Size(123, 23);
            this.btnUpdateAirport.TabIndex = 3;
            this.btnUpdateAirport.Text = "update airport";
            this.btnUpdateAirport.UseVisualStyleBackColor = true;
            this.btnUpdateAirport.Click += new System.EventHandler(this.btnUpdateAirport_Click);
            // 
            // btnCreateFlight
            // 
            this.btnCreateFlight.Location = new System.Drawing.Point(334, 94);
            this.btnCreateFlight.Name = "btnCreateFlight";
            this.btnCreateFlight.Size = new System.Drawing.Size(131, 35);
            this.btnCreateFlight.TabIndex = 4;
            this.btnCreateFlight.Text = "create Flight";
            this.btnCreateFlight.UseVisualStyleBackColor = true;
            this.btnCreateFlight.Click += new System.EventHandler(this.btnCreateFlight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCreateFlight);
            this.Controls.Add(this.btnUpdateAirport);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.btnGetAllAirports);
            this.Controls.Add(this.btnAddAirport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnGetAllAirports;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnUpdateAirport;
        private System.Windows.Forms.Button btnCreateFlight;
    }
}

