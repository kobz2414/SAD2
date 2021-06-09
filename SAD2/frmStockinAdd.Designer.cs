namespace SAD2
{
    partial class frmStockinAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockinAdd));
            this.lblStaff = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.lblStockInID = new System.Windows.Forms.Label();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(67, 65);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(29, 13);
            this.lblStaff.TabIndex = 25;
            this.lblStaff.Text = "Staff";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(111, 61);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(196, 20);
            this.txtEmployee.TabIndex = 2;
            this.txtEmployee.TextChanged += new System.EventHandler(this.txtEmployee_TextChanged);
            // 
            // lblStockInID
            // 
            this.lblStockInID.AutoSize = true;
            this.lblStockInID.Location = new System.Drawing.Point(35, 32);
            this.lblStockInID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockInID.Name = "lblStockInID";
            this.lblStockInID.Size = new System.Drawing.Size(61, 13);
            this.lblStockInID.TabIndex = 23;
            this.lblStockInID.Text = "Stock In ID";
            // 
            // txtStockID
            // 
            this.txtStockID.Location = new System.Drawing.Point(111, 28);
            this.txtStockID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(196, 20);
            this.txtStockID.TabIndex = 1;
            this.txtStockID.TextChanged += new System.EventHandler(this.txtStockID_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(130, 102);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(208, 102);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(74, 25);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Accept";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmStockinAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 158);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.lblStockInID);
            this.Controls.Add(this.txtStockID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmStockinAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Stock In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStockinAdd_FormClosing);
            this.Load += new System.EventHandler(this.frmStockinAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label lblStockInID;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
    }
}