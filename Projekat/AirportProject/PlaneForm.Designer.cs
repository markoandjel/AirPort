namespace AirportProject
{
    partial class PlaneForm
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
            this.btnCreatePlane = new System.Windows.Forms.Button();
            this.btnDeletePlane = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvPlane = new System.Windows.Forms.DataGridView();
            this.tbxManufacturer = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlane)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreatePlane
            // 
            this.btnCreatePlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreatePlane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreatePlane.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlane.ForeColor = System.Drawing.Color.White;
            this.btnCreatePlane.Location = new System.Drawing.Point(265, 279);
            this.btnCreatePlane.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreatePlane.Name = "btnCreatePlane";
            this.btnCreatePlane.Size = new System.Drawing.Size(220, 48);
            this.btnCreatePlane.TabIndex = 0;
            this.btnCreatePlane.Text = "Create Plane";
            this.btnCreatePlane.UseVisualStyleBackColor = false;
            this.btnCreatePlane.Click += new System.EventHandler(this.btnCreatePlane_Click);
            // 
            // btnDeletePlane
            // 
            this.btnDeletePlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeletePlane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePlane.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlane.ForeColor = System.Drawing.Color.White;
            this.btnDeletePlane.Location = new System.Drawing.Point(133, 335);
            this.btnDeletePlane.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePlane.Name = "btnDeletePlane";
            this.btnDeletePlane.Size = new System.Drawing.Size(271, 48);
            this.btnDeletePlane.TabIndex = 1;
            this.btnDeletePlane.Text = "Delete Plane";
            this.btnDeletePlane.UseVisualStyleBackColor = false;
            this.btnDeletePlane.Click += new System.EventHandler(this.btnDeletePlane_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(25, 279);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(220, 48);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Plane";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvPlane
            // 
            this.dgvPlane.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPlane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlane.GridColor = System.Drawing.Color.LightGray;
            this.dgvPlane.Location = new System.Drawing.Point(39, 56);
            this.dgvPlane.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPlane.Name = "dgvPlane";
            this.dgvPlane.RowHeadersWidth = 51;
            this.dgvPlane.RowTemplate.Height = 24;
            this.dgvPlane.Size = new System.Drawing.Size(452, 250);
            this.dgvPlane.TabIndex = 3;
            // 
            // tbxManufacturer
            // 
            this.tbxManufacturer.Location = new System.Drawing.Point(242, 86);
            this.tbxManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.tbxManufacturer.Name = "tbxManufacturer";
            this.tbxManufacturer.Size = new System.Drawing.Size(243, 36);
            this.tbxManufacturer.TabIndex = 4;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(242, 151);
            this.tbxModel.Margin = new System.Windows.Forms.Padding(4);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(243, 36);
            this.tbxModel.TabIndex = 5;
            this.tbxModel.TextChanged += new System.EventHandler(this.tbxModel_TextChanged);
            // 
            // tbxCode
            // 
            this.tbxCode.Location = new System.Drawing.Point(242, 214);
            this.tbxCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(243, 36);
            this.tbxCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manufacturer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Code:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.dgvPlane);
            this.panel1.Controls.Add(this.btnDeletePlane);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(584, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 419);
            this.panel1.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(499, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 53);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxCode);
            this.groupBox1.Controls.Add(this.tbxModel);
            this.groupBox1.Controls.Add(this.tbxManufacturer);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnCreatePlane);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(46, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(504, 350);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create and Update";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 419);
            this.panel2.TabIndex = 12;
            // 
            // PlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1136, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlaneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaneForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlane)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePlane;
        private System.Windows.Forms.Button btnDeletePlane;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvPlane;
        private System.Windows.Forms.TextBox tbxManufacturer;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
    }
}