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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePlane
            // 
            this.btnCreatePlane.Location = new System.Drawing.Point(59, 164);
            this.btnCreatePlane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreatePlane.Name = "btnCreatePlane";
            this.btnCreatePlane.Size = new System.Drawing.Size(86, 28);
            this.btnCreatePlane.TabIndex = 0;
            this.btnCreatePlane.Text = "Create Plane";
            this.btnCreatePlane.UseVisualStyleBackColor = true;
            this.btnCreatePlane.Click += new System.EventHandler(this.btnCreatePlane_Click);
            // 
            // btnDeletePlane
            // 
            this.btnDeletePlane.Location = new System.Drawing.Point(510, 227);
            this.btnDeletePlane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeletePlane.Name = "btnDeletePlane";
            this.btnDeletePlane.Size = new System.Drawing.Size(83, 32);
            this.btnDeletePlane.TabIndex = 1;
            this.btnDeletePlane.Text = "Delete Plane";
            this.btnDeletePlane.UseVisualStyleBackColor = true;
            this.btnDeletePlane.Click += new System.EventHandler(this.btnDeletePlane_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(180, 164);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 24);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Plane";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvPlane
            // 
            this.dgvPlane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlane.Location = new System.Drawing.Point(304, 17);
            this.dgvPlane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPlane.Name = "dgvPlane";
            this.dgvPlane.RowHeadersWidth = 51;
            this.dgvPlane.RowTemplate.Height = 24;
            this.dgvPlane.Size = new System.Drawing.Size(490, 192);
            this.dgvPlane.TabIndex = 3;
            // 
            // tbxManufacturer
            // 
            this.tbxManufacturer.Location = new System.Drawing.Point(167, 44);
            this.tbxManufacturer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxManufacturer.Name = "tbxManufacturer";
            this.tbxManufacturer.Size = new System.Drawing.Size(105, 20);
            this.tbxManufacturer.TabIndex = 4;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(167, 79);
            this.tbxModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(105, 20);
            this.tbxModel.TabIndex = 5;
            // 
            // tbxCode
            // 
            this.tbxCode.Location = new System.Drawing.Point(167, 116);
            this.tbxCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(105, 20);
            this.tbxCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manufacturer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Code:";
            // 
            // PlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.tbxManufacturer);
            this.Controls.Add(this.dgvPlane);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeletePlane);
            this.Controls.Add(this.btnCreatePlane);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlaneForm";
            this.Text = "PlaneForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}