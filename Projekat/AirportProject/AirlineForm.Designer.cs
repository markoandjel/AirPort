namespace AirportProject
{
    partial class AirlineForm
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
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.tbxNameAdd = new System.Windows.Forms.TextBox();
            this.btnAddAirline = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdateAirline = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAirline = new System.Windows.Forms.Button();
            this.dgvAirline = new System.Windows.Forms.DataGridView();
            this.btnShowEditPlanes = new System.Windows.Forms.Button();
            this.gbAdd.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirline)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.tbxNameAdd);
            this.gbAdd.Controls.Add(this.btnAddAirline);
            this.gbAdd.Controls.Add(this.label3);
            this.gbAdd.Location = new System.Drawing.Point(12, 218);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(354, 138);
            this.gbAdd.TabIndex = 17;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add airline";
            // 
            // tbxNameAdd
            // 
            this.tbxNameAdd.Location = new System.Drawing.Point(102, 41);
            this.tbxNameAdd.Name = "tbxNameAdd";
            this.tbxNameAdd.Size = new System.Drawing.Size(215, 22);
            this.tbxNameAdd.TabIndex = 2;
            // 
            // btnAddAirline
            // 
            this.btnAddAirline.Location = new System.Drawing.Point(156, 69);
            this.btnAddAirline.Name = "btnAddAirline";
            this.btnAddAirline.Size = new System.Drawing.Size(107, 44);
            this.btnAddAirline.TabIndex = 2;
            this.btnAddAirline.Text = "Add Airline";
            this.btnAddAirline.UseVisualStyleBackColor = true;
            this.btnAddAirline.Click += new System.EventHandler(this.btnAddAirline_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbUpdate.Controls.Add(this.btnUpdateAirline);
            this.gbUpdate.Controls.Add(this.label1);
            this.gbUpdate.Location = new System.Drawing.Point(10, 12);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(354, 156);
            this.gbUpdate.TabIndex = 16;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update airline";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(104, 40);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(215, 22);
            this.tbxNameUpdate.TabIndex = 0;
            // 
            // btnUpdateAirline
            // 
            this.btnUpdateAirline.Location = new System.Drawing.Point(158, 81);
            this.btnUpdateAirline.Name = "btnUpdateAirline";
            this.btnUpdateAirline.Size = new System.Drawing.Size(107, 44);
            this.btnUpdateAirline.TabIndex = 1;
            this.btnUpdateAirline.Text = "Update Airline";
            this.btnUpdateAirline.UseVisualStyleBackColor = true;
            this.btnUpdateAirline.Click += new System.EventHandler(this.btnUpdateAirline_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // btnDeleteAirline
            // 
            this.btnDeleteAirline.Location = new System.Drawing.Point(413, 382);
            this.btnDeleteAirline.Name = "btnDeleteAirline";
            this.btnDeleteAirline.Size = new System.Drawing.Size(107, 44);
            this.btnDeleteAirline.TabIndex = 14;
            this.btnDeleteAirline.Text = "Delete";
            this.btnDeleteAirline.UseVisualStyleBackColor = true;
            this.btnDeleteAirline.Click += new System.EventHandler(this.btnDeleteAirline_Click);
            // 
            // dgvAirline
            // 
            this.dgvAirline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirline.Location = new System.Drawing.Point(372, 12);
            this.dgvAirline.Name = "dgvAirline";
            this.dgvAirline.RowHeadersWidth = 51;
            this.dgvAirline.RowTemplate.Height = 24;
            this.dgvAirline.Size = new System.Drawing.Size(285, 344);
            this.dgvAirline.TabIndex = 15;
            // 
            // btnShowEditPlanes
            // 
            this.btnShowEditPlanes.Location = new System.Drawing.Point(539, 381);
            this.btnShowEditPlanes.Name = "btnShowEditPlanes";
            this.btnShowEditPlanes.Size = new System.Drawing.Size(97, 45);
            this.btnShowEditPlanes.TabIndex = 18;
            this.btnShowEditPlanes.Text = "Show/Edit Planes";
            this.btnShowEditPlanes.UseVisualStyleBackColor = true;
            this.btnShowEditPlanes.Click += new System.EventHandler(this.btnShowEditPlanes_Click);
            // 
            // AirlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 540);
            this.Controls.Add(this.btnShowEditPlanes);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.btnDeleteAirline);
            this.Controls.Add(this.dgvAirline);
            this.Name = "AirlineForm";
            this.Text = "Airline Manager";
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.TextBox tbxNameAdd;
        private System.Windows.Forms.Button btnAddAirline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Button btnUpdateAirline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAirline;
        private System.Windows.Forms.DataGridView dgvAirline;
        private System.Windows.Forms.Button btnShowEditPlanes;
    }
}