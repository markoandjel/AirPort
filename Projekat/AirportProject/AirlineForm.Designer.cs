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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbAdd.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirline)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.tbxNameAdd);
            this.gbAdd.Controls.Add(this.btnAddAirline);
            this.gbAdd.Controls.Add(this.label3);
            this.gbAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.gbAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbAdd.Location = new System.Drawing.Point(9, 230);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(354, 166);
            this.gbAdd.TabIndex = 17;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add airline";
            // 
            // tbxNameAdd
            // 
            this.tbxNameAdd.Location = new System.Drawing.Point(103, 62);
            this.tbxNameAdd.Name = "tbxNameAdd";
            this.tbxNameAdd.Size = new System.Drawing.Size(232, 36);
            this.tbxNameAdd.TabIndex = 2;
            // 
            // btnAddAirline
            // 
            this.btnAddAirline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddAirline.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAddAirline.ForeColor = System.Drawing.Color.White;
            this.btnAddAirline.Location = new System.Drawing.Point(67, 104);
            this.btnAddAirline.Name = "btnAddAirline";
            this.btnAddAirline.Size = new System.Drawing.Size(223, 44);
            this.btnAddAirline.TabIndex = 3;
            this.btnAddAirline.Text = "Add Airline";
            this.btnAddAirline.UseVisualStyleBackColor = false;
            this.btnAddAirline.Click += new System.EventHandler(this.btnAddAirline_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbUpdate.Controls.Add(this.btnUpdateAirline);
            this.gbUpdate.Controls.Add(this.label1);
            this.gbUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.gbUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbUpdate.Location = new System.Drawing.Point(9, 30);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(354, 166);
            this.gbUpdate.TabIndex = 16;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update airline";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(105, 62);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(232, 36);
            this.tbxNameUpdate.TabIndex = 0;
            // 
            // btnUpdateAirline
            // 
            this.btnUpdateAirline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateAirline.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdateAirline.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAirline.Location = new System.Drawing.Point(67, 104);
            this.btnUpdateAirline.Name = "btnUpdateAirline";
            this.btnUpdateAirline.Size = new System.Drawing.Size(223, 44);
            this.btnUpdateAirline.TabIndex = 1;
            this.btnUpdateAirline.Text = "Update Airline";
            this.btnUpdateAirline.UseVisualStyleBackColor = false;
            this.btnUpdateAirline.Click += new System.EventHandler(this.btnUpdateAirline_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // btnDeleteAirline
            // 
            this.btnDeleteAirline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeleteAirline.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAirline.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAirline.Location = new System.Drawing.Point(28, 394);
            this.btnDeleteAirline.Name = "btnDeleteAirline";
            this.btnDeleteAirline.Size = new System.Drawing.Size(107, 44);
            this.btnDeleteAirline.TabIndex = 14;
            this.btnDeleteAirline.Text = "Delete";
            this.btnDeleteAirline.UseVisualStyleBackColor = false;
            this.btnDeleteAirline.Click += new System.EventHandler(this.btnDeleteAirline_Click);
            // 
            // dgvAirline
            // 
            this.dgvAirline.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAirline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirline.GridColor = System.Drawing.Color.LightGray;
            this.dgvAirline.Location = new System.Drawing.Point(28, 33);
            this.dgvAirline.Name = "dgvAirline";
            this.dgvAirline.RowHeadersWidth = 51;
            this.dgvAirline.RowTemplate.Height = 24;
            this.dgvAirline.Size = new System.Drawing.Size(358, 339);
            this.dgvAirline.TabIndex = 15;
            // 
            // btnShowEditPlanes
            // 
            this.btnShowEditPlanes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowEditPlanes.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnShowEditPlanes.ForeColor = System.Drawing.Color.White;
            this.btnShowEditPlanes.Location = new System.Drawing.Point(149, 394);
            this.btnShowEditPlanes.Name = "btnShowEditPlanes";
            this.btnShowEditPlanes.Size = new System.Drawing.Size(237, 45);
            this.btnShowEditPlanes.TabIndex = 18;
            this.btnShowEditPlanes.Text = "Show/Edit Planes";
            this.btnShowEditPlanes.UseVisualStyleBackColor = false;
            this.btnShowEditPlanes.Click += new System.EventHandler(this.btnShowEditPlanes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnShowEditPlanes);
            this.panel1.Controls.Add(this.btnDeleteAirline);
            this.panel1.Controls.Add(this.dgvAirline);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(400, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 460);
            this.panel1.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(392, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 40);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.gbAdd);
            this.panel2.Controls.Add(this.gbUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 460);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(9, 416);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 38);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AirlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(825, 460);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AirlineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Manager";
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirline)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
    }
}