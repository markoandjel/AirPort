﻿namespace AirportProject

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
            this.addPassenger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(315, 146);
            this.btnAddAirport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(187, 60);
            this.btnAddAirport.TabIndex = 0;
            this.btnAddAirport.Text = "Add Airport";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnGetAllAirports
            // 
            this.btnGetAllAirports.Location = new System.Drawing.Point(315, 255);
            this.btnGetAllAirports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetAllAirports.Name = "btnGetAllAirports";
            this.btnGetAllAirports.Size = new System.Drawing.Size(176, 39);
            this.btnGetAllAirports.TabIndex = 1;
            this.btnGetAllAirports.Text = "Get all airports";
            this.btnGetAllAirports.UseVisualStyleBackColor = true;
            this.btnGetAllAirports.Click += new System.EventHandler(this.btnGetAllAirports_Click);
            // 
            // addPassenger
            // 
            this.addPassenger.Location = new System.Drawing.Point(304, 35);
            this.addPassenger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPassenger.Name = "addPassenger";
            this.addPassenger.Size = new System.Drawing.Size(187, 60);
            this.addPassenger.TabIndex = 2;
            this.addPassenger.Text = "Add Passenger";
            this.addPassenger.UseVisualStyleBackColor = true;
            this.addPassenger.Click += new System.EventHandler(this.addPassenger_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addPassenger);
            this.Controls.Add(this.btnGetAllAirports);
            this.Controls.Add(this.btnAddAirport);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnGetAllAirports;
        private System.Windows.Forms.Button addPassenger;
    }
}

