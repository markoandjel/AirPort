namespace AirportProject
{
    partial class CityForm
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
            this.dgvCity = new System.Windows.Forms.DataGridView();
            this.btnUpdateAirport = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxCountryUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameAdd = new System.Windows.Forms.TextBox();
            this.tbxCountryAdd = new System.Windows.Forms.TextBox();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).BeginInit();
            this.gbUpdate.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCity
            // 
            this.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCity.Location = new System.Drawing.Point(445, 14);
            this.dgvCity.Name = "dgvCity";
            this.dgvCity.RowHeadersWidth = 51;
            this.dgvCity.RowTemplate.Height = 24;
            this.dgvCity.Size = new System.Drawing.Size(284, 365);
            this.dgvCity.TabIndex = 8;
            // 
            // btnUpdateAirport
            // 
            this.btnUpdateAirport.Location = new System.Drawing.Point(156, 127);
            this.btnUpdateAirport.Name = "btnUpdateAirport";
            this.btnUpdateAirport.Size = new System.Drawing.Size(107, 44);
            this.btnUpdateAirport.TabIndex = 1;
            this.btnUpdateAirport.Text = "Update City";
            this.btnUpdateAirport.UseVisualStyleBackColor = true;
            this.btnUpdateAirport.Click += new System.EventHandler(this.btnUpdateAirport_Click);
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(157, 119);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(107, 44);
            this.btnAddCity.TabIndex = 2;
            this.btnAddCity.Text = "Add City";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.Location = new System.Drawing.Point(533, 385);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(107, 44);
            this.btnDeleteCity.TabIndex = 3;
            this.btnDeleteCity.Text = "Delete";
            this.btnDeleteCity.UseVisualStyleBackColor = true;
            this.btnDeleteCity.Click += new System.EventHandler(this.btnDeleteCity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Country";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(104, 34);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(215, 22);
            this.tbxNameUpdate.TabIndex = 0;
            // 
            // tbxCountryUpdate
            // 
            this.tbxCountryUpdate.Location = new System.Drawing.Point(104, 80);
            this.tbxCountryUpdate.Name = "tbxCountryUpdate";
            this.tbxCountryUpdate.Size = new System.Drawing.Size(215, 22);
            this.tbxCountryUpdate.TabIndex = 0;
            // 
            // tbxNameAdd
            // 
            this.tbxNameAdd.Location = new System.Drawing.Point(105, 25);
            this.tbxNameAdd.Name = "tbxNameAdd";
            this.tbxNameAdd.Size = new System.Drawing.Size(215, 22);
            this.tbxNameAdd.TabIndex = 2;
            // 
            // tbxCountryAdd
            // 
            this.tbxCountryAdd.Location = new System.Drawing.Point(105, 73);
            this.tbxCountryAdd.Name = "tbxCountryAdd";
            this.tbxCountryAdd.Size = new System.Drawing.Size(215, 22);
            this.tbxCountryAdd.TabIndex = 3;
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.tbxCountryUpdate);
            this.gbUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbUpdate.Controls.Add(this.label2);
            this.gbUpdate.Controls.Add(this.btnUpdateAirport);
            this.gbUpdate.Controls.Add(this.label1);
            this.gbUpdate.Location = new System.Drawing.Point(40, 14);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(354, 200);
            this.gbUpdate.TabIndex = 12;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update city";
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.tbxCountryAdd);
            this.gbAdd.Controls.Add(this.tbxNameAdd);
            this.gbAdd.Controls.Add(this.label4);
            this.gbAdd.Controls.Add(this.btnAddCity);
            this.gbAdd.Controls.Add(this.label3);
            this.gbAdd.Location = new System.Drawing.Point(40, 240);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(354, 189);
            this.gbAdd.TabIndex = 13;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add city";
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 444);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.btnDeleteCity);
            this.Controls.Add(this.dgvCity);
            this.MaximumSize = new System.Drawing.Size(781, 491);
            this.MinimumSize = new System.Drawing.Size(781, 491);
            this.Name = "CityForm";
            this.Text = "City manager";
            this.Load += new System.EventHandler(this.CityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).EndInit();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCity;
        private System.Windows.Forms.Button btnUpdateAirport;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Button btnDeleteCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.TextBox tbxCountryUpdate;
        private System.Windows.Forms.TextBox tbxNameAdd;
        private System.Windows.Forms.TextBox tbxCountryAdd;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.GroupBox gbAdd;
    }
}