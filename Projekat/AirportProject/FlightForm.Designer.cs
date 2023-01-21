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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAirports
            // 
            this.dgvAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirports.Location = new System.Drawing.Point(376, 78);
            this.dgvAirports.Name = "dgvAirports";
            this.dgvAirports.Size = new System.Drawing.Size(371, 288);
            this.dgvAirports.TabIndex = 0;
            // 
            // btnCreateFlight
            // 
            this.btnCreateFlight.Location = new System.Drawing.Point(111, 166);
            this.btnCreateFlight.Name = "btnCreateFlight";
            this.btnCreateFlight.Size = new System.Drawing.Size(105, 37);
            this.btnCreateFlight.TabIndex = 1;
            this.btnCreateFlight.Text = "Create Flight";
            this.btnCreateFlight.UseVisualStyleBackColor = true;
            this.btnCreateFlight.Click += new System.EventHandler(this.btnCreateFlight_Click);
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateFlight);
            this.Controls.Add(this.dgvAirports);
            this.Name = "FlightForm";
            this.Text = "FlightForm";
            this.Load += new System.EventHandler(this.FlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAirports;
        private System.Windows.Forms.Button btnCreateFlight;
    }
}