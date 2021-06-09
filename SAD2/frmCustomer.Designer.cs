
namespace SAD2
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.grpCustomerTransactions = new System.Windows.Forms.GroupBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.listTransactions = new System.Windows.Forms.ListView();
            this.colTransactionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCustomerList = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listCustomers = new System.Windows.Forms.ListView();
            this.colCustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCustomerInformation.SuspendLayout();
            this.grpCustomerTransactions.SuspendLayout();
            this.grpCustomerList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Controls.Add(this.txtContactNumber);
            this.grpCustomerInformation.Controls.Add(this.txtAddress);
            this.grpCustomerInformation.Controls.Add(this.txtName);
            this.grpCustomerInformation.Controls.Add(this.label3);
            this.grpCustomerInformation.Controls.Add(this.label2);
            this.grpCustomerInformation.Controls.Add(this.label1);
            this.grpCustomerInformation.Location = new System.Drawing.Point(264, 12);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Size = new System.Drawing.Size(518, 119);
            this.grpCustomerInformation.TabIndex = 0;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Customer Information";
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
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(21, 359);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(96, 27);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(123, 359);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(96, 27);
            this.btnDeleteCustomer.TabIndex = 3;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // grpCustomerTransactions
            // 
            this.grpCustomerTransactions.Controls.Add(this.btnDetails);
            this.grpCustomerTransactions.Controls.Add(this.listTransactions);
            this.grpCustomerTransactions.Location = new System.Drawing.Point(264, 137);
            this.grpCustomerTransactions.Name = "grpCustomerTransactions";
            this.grpCustomerTransactions.Size = new System.Drawing.Size(518, 315);
            this.grpCustomerTransactions.TabIndex = 1;
            this.grpCustomerTransactions.TabStop = false;
            this.grpCustomerTransactions.Text = "Previous Transactions";
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(400, 234);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(112, 27);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // listTransactions
            // 
            this.listTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTransactionID,
            this.colDateTime,
            this.colStatus});
            this.listTransactions.FullRowSelect = true;
            this.listTransactions.HideSelection = false;
            this.listTransactions.Location = new System.Drawing.Point(6, 19);
            this.listTransactions.Name = "listTransactions";
            this.listTransactions.Size = new System.Drawing.Size(506, 201);
            this.listTransactions.TabIndex = 1;
            this.listTransactions.UseCompatibleStateImageBehavior = false;
            this.listTransactions.View = System.Windows.Forms.View.Details;
            this.listTransactions.SelectedIndexChanged += new System.EventHandler(this.listTransactions_SelectedIndexChanged);
            // 
            // colTransactionID
            // 
            this.colTransactionID.Text = "Transaction ID";
            this.colTransactionID.Width = 180;
            // 
            // colDateTime
            // 
            this.colDateTime.Text = "Date & Time";
            this.colDateTime.Width = 192;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 126;
            // 
            // grpCustomerList
            // 
            this.grpCustomerList.Controls.Add(this.btnUpdate);
            this.grpCustomerList.Controls.Add(this.btnDeleteCustomer);
            this.grpCustomerList.Controls.Add(this.listCustomers);
            this.grpCustomerList.Controls.Add(this.btnAddCustomer);
            this.grpCustomerList.Location = new System.Drawing.Point(18, 12);
            this.grpCustomerList.Name = "grpCustomerList";
            this.grpCustomerList.Size = new System.Drawing.Size(240, 440);
            this.grpCustomerList.TabIndex = 1;
            this.grpCustomerList.TabStop = false;
            this.grpCustomerList.Text = "Customer List";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(78, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 27);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Info";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listCustomers
            // 
            this.listCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCustomerID,
            this.colName});
            this.listCustomers.FullRowSelect = true;
            this.listCustomers.HideSelection = false;
            this.listCustomers.Location = new System.Drawing.Point(6, 24);
            this.listCustomers.Name = "listCustomers";
            this.listCustomers.Size = new System.Drawing.Size(228, 321);
            this.listCustomers.TabIndex = 0;
            this.listCustomers.UseCompatibleStateImageBehavior = false;
            this.listCustomers.View = System.Windows.Forms.View.Details;
            this.listCustomers.SelectedIndexChanged += new System.EventHandler(this.listCustomers_SelectedIndexChanged);
            // 
            // colCustomerID
            // 
            this.colCustomerID.Text = "ID";
            this.colCustomerID.Width = 44;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 177;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.grpCustomerTransactions);
            this.Controls.Add(this.grpCustomerList);
            this.Controls.Add(this.grpCustomerInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomers_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            this.grpCustomerTransactions.ResumeLayout(false);
            this.grpCustomerList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerInformation;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.GroupBox grpCustomerTransactions;
        private System.Windows.Forms.GroupBox grpCustomerList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listCustomers;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListView listTransactions;
        private System.Windows.Forms.ColumnHeader colTransactionID;
        private System.Windows.Forms.ColumnHeader colDateTime;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colCustomerID;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnUpdate;
    }
}