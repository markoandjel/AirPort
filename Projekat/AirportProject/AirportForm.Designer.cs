namespace AirportProject
{
    partial class AirportForm
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
            this.dgvAirports = new System.Windows.Forms.DataGridView();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnUpdateAirport = new System.Windows.Forms.Button();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.tbxUpdateCity = new System.Windows.Forms.TextBox();
            this.tbxUpdateCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxUpdateAirport = new System.Windows.Forms.GroupBox();
            this.gbxAddAirport = new System.Windows.Forms.GroupBox();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).BeginInit();
            this.gbxUpdateAirport.SuspendLayout();
            this.gbxAddAirport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(105, 134);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(100, 32);
            this.btnAddAirport.TabIndex = 0;
            this.btnAddAirport.Text = "Add Airport";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // dgvAirports
            // 
            this.dgvAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirports.Location = new System.Drawing.Point(314, 25);
            this.dgvAirports.Name = "dgvAirports";
            this.dgvAirports.Size = new System.Drawing.Size(447, 385);
            this.dgvAirports.TabIndex = 2;
            this.dgvAirports.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAirports_RowHeaderMouseDoubleClick);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(90, 15);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(149, 20);
            this.tbxName.TabIndex = 3;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(88, 53);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(149, 20);
            this.tbxCity.TabIndex = 4;
            // 
            // tbxCode
            // 
            this.tbxCode.Location = new System.Drawing.Point(90, 89);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(149, 20);
            this.tbxCode.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(20, 56);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(20, 92);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 6;
            this.lblCode.Text = "Code";
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(530, 426);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(102, 32);
            this.btnDeleteAirport.TabIndex = 0;
            this.btnDeleteAirport.Text = "Delete Airport";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnUpdateAirport
            // 
            this.btnUpdateAirport.Location = new System.Drawing.Point(105, 153);
            this.btnUpdateAirport.Name = "btnUpdateAirport";
            this.btnUpdateAirport.Size = new System.Drawing.Size(100, 32);
            this.btnUpdateAirport.TabIndex = 0;
            this.btnUpdateAirport.Text = "Update Airport";
            this.btnUpdateAirport.UseVisualStyleBackColor = true;
            this.btnUpdateAirport.Click += new System.EventHandler(this.btnUpdateAirport_Click);
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(76, 32);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(163, 20);
            this.tbxUpdateName.TabIndex = 3;
            // 
            // tbxUpdateCity
            // 
            this.tbxUpdateCity.Location = new System.Drawing.Point(74, 70);
            this.tbxUpdateCity.Name = "tbxUpdateCity";
            this.tbxUpdateCity.Size = new System.Drawing.Size(163, 20);
            this.tbxUpdateCity.TabIndex = 4;
            // 
            // tbxUpdateCode
            // 
            this.tbxUpdateCode.Location = new System.Drawing.Point(76, 106);
            this.tbxUpdateCode.Name = "tbxUpdateCode";
            this.tbxUpdateCode.Size = new System.Drawing.Size(163, 20);
            this.tbxUpdateCode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Code";
            // 
            // gbxUpdateAirport
            // 
            this.gbxUpdateAirport.Controls.Add(this.label3);
            this.gbxUpdateAirport.Controls.Add(this.label2);
            this.gbxUpdateAirport.Controls.Add(this.label1);
            this.gbxUpdateAirport.Controls.Add(this.tbxUpdateCode);
            this.gbxUpdateAirport.Controls.Add(this.tbxUpdateCity);
            this.gbxUpdateAirport.Controls.Add(this.tbxUpdateName);
            this.gbxUpdateAirport.Controls.Add(this.btnUpdateAirport);
            this.gbxUpdateAirport.Location = new System.Drawing.Point(27, 25);
            this.gbxUpdateAirport.Name = "gbxUpdateAirport";
            this.gbxUpdateAirport.Size = new System.Drawing.Size(261, 205);
            this.gbxUpdateAirport.TabIndex = 7;
            this.gbxUpdateAirport.TabStop = false;
            this.gbxUpdateAirport.Text = "UpdateAirport";
            // 
            // gbxAddAirport
            // 
            this.gbxAddAirport.Controls.Add(this.lblCode);
            this.gbxAddAirport.Controls.Add(this.lblCity);
            this.gbxAddAirport.Controls.Add(this.lblName);
            this.gbxAddAirport.Controls.Add(this.tbxCode);
            this.gbxAddAirport.Controls.Add(this.tbxCity);
            this.gbxAddAirport.Controls.Add(this.tbxName);
            this.gbxAddAirport.Controls.Add(this.btnAddAirport);
            this.gbxAddAirport.Location = new System.Drawing.Point(27, 260);
            this.gbxAddAirport.Name = "gbxAddAirport";
            this.gbxAddAirport.Size = new System.Drawing.Size(261, 186);
            this.gbxAddAirport.TabIndex = 8;
            this.gbxAddAirport.TabStop = false;
            this.gbxAddAirport.Text = "Add Airport";
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Location = new System.Drawing.Point(382, 422);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(64, 40);
            this.btnRefreshTable.TabIndex = 9;
            this.btnRefreshTable.Text = "Refresh Table";
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // AirportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 484);
            this.Controls.Add(this.btnRefreshTable);
            this.Controls.Add(this.gbxAddAirport);
            this.Controls.Add(this.gbxUpdateAirport);
            this.Controls.Add(this.dgvAirports);
            this.Controls.Add(this.btnDeleteAirport);
            this.Name = "AirportForm";
            this.Text = "AirportForm";
            this.Load += new System.EventHandler(this.Airport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).EndInit();
            this.gbxUpdateAirport.ResumeLayout(false);
            this.gbxUpdateAirport.PerformLayout();
            this.gbxAddAirport.ResumeLayout(false);
            this.gbxAddAirport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.DataGridView dgvAirports;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnUpdateAirport;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.TextBox tbxUpdateCity;
        private System.Windows.Forms.TextBox tbxUpdateCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxUpdateAirport;
        private System.Windows.Forms.GroupBox gbxAddAirport;
        private System.Windows.Forms.Button btnRefreshTable;
    }
}