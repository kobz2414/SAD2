namespace SAD2
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.grpCustomerList = new System.Windows.Forms.GroupBox();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.listEmployee = new System.Windows.Forms.ListView();
            this.colCustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCustomerList.SuspendLayout();
            this.grpCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerList
            // 
            this.grpCustomerList.Controls.Add(this.btnUpdateEmployee);
            this.grpCustomerList.Controls.Add(this.btnDeleteEmployee);
            this.grpCustomerList.Controls.Add(this.listEmployee);
            this.grpCustomerList.Controls.Add(this.btnAddEmployee);
            this.grpCustomerList.Location = new System.Drawing.Point(17, 13);
            this.grpCustomerList.Name = "grpCustomerList";
            this.grpCustomerList.Size = new System.Drawing.Size(583, 213);
            this.grpCustomerList.TabIndex = 3;
            this.grpCustomerList.TabStop = false;
            this.grpCustomerList.Text = "Employee List";
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(466, 126);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(96, 27);
            this.btnUpdateEmployee.TabIndex = 4;
            this.btnUpdateEmployee.Text = "Update Info";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(466, 93);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(96, 27);
            this.btnDeleteEmployee.TabIndex = 3;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // listEmployee
            // 
            this.listEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCustomerID,
            this.colName});
            this.listEmployee.FullRowSelect = true;
            this.listEmployee.HideSelection = false;
            this.listEmployee.Location = new System.Drawing.Point(21, 21);
            this.listEmployee.MultiSelect = false;
            this.listEmployee.Name = "listEmployee";
            this.listEmployee.Size = new System.Drawing.Size(431, 171);
            this.listEmployee.TabIndex = 0;
            this.listEmployee.UseCompatibleStateImageBehavior = false;
            this.listEmployee.View = System.Windows.Forms.View.Details;
            this.listEmployee.SelectedIndexChanged += new System.EventHandler(this.listCustomers_SelectedIndexChanged);
            // 
            // colCustomerID
            // 
            this.colCustomerID.Text = "ID";
            this.colCustomerID.Width = 44;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 174;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(466, 60);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(96, 27);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Controls.Add(this.txtContactNumber);
            this.grpCustomerInformation.Controls.Add(this.txtAddress);
            this.grpCustomerInformation.Controls.Add(this.txtName);
            this.grpCustomerInformation.Controls.Add(this.label3);
            this.grpCustomerInformation.Controls.Add(this.label2);
            this.grpCustomerInformation.Controls.Add(this.label1);
            this.grpCustomerInformation.Location = new System.Drawing.Point(17, 232);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Size = new System.Drawing.Size(583, 123);
            this.grpCustomerInformation.TabIndex = 2;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Employee Information";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Enabled = false;
            this.txtContactNumber.Location = new System.Drawing.Point(111, 78);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(178, 20);
            this.txtContactNumber.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(111, 51);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(294, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(111, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 20);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 369);
            this.Controls.Add(this.grpCustomerList);
            this.Controls.Add(this.grpCustomerInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployee_FormClosing);
            this.grpCustomerList.ResumeLayout(false);
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerList;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.ListView listEmployee;
        private System.Windows.Forms.ColumnHeader colCustomerID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.GroupBox grpCustomerInformation;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}