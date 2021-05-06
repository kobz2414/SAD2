
namespace SAD2
{
    partial class frmPayment
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
            this.listPayments = new System.Windows.Forms.ListView();
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModeOfPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblTotalAmountPaid = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.txtRemainingBalance = new System.Windows.Forms.TextBox();
            this.lblRemainingBalance = new System.Windows.Forms.Label();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.txtTransactionNum = new System.Windows.Forms.TextBox();
            this.lblTransactionNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPayments
            // 
            this.listPayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colModeOfPayment,
            this.colAmount});
            this.listPayments.FullRowSelect = true;
            this.listPayments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listPayments.HideSelection = false;
            this.listPayments.Location = new System.Drawing.Point(20, 129);
            this.listPayments.Name = "listPayments";
            this.listPayments.Size = new System.Drawing.Size(500, 224);
            this.listPayments.TabIndex = 0;
            this.listPayments.UseCompatibleStateImageBehavior = false;
            this.listPayments.View = System.Windows.Forms.View.Details;
            this.listPayments.SelectedIndexChanged += new System.EventHandler(this.listPayments_SelectedIndexChanged);
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 147;
            // 
            // colModeOfPayment
            // 
            this.colModeOfPayment.Text = "Mode of Payment";
            this.colModeOfPayment.Width = 192;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Amount";
            this.colAmount.Width = 154;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(20, 370);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(111, 23);
            this.btnAddPayment.TabIndex = 1;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(137, 370);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblTotalAmountPaid
            // 
            this.lblTotalAmountPaid.AutoSize = true;
            this.lblTotalAmountPaid.Location = new System.Drawing.Point(293, 373);
            this.lblTotalAmountPaid.Name = "lblTotalAmountPaid";
            this.lblTotalAmountPaid.Size = new System.Drawing.Size(94, 13);
            this.lblTotalAmountPaid.TabIndex = 3;
            this.lblTotalAmountPaid.Text = "Total Amount Paid";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Enabled = false;
            this.txtAmountPaid.Location = new System.Drawing.Point(393, 370);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(127, 20);
            this.txtAmountPaid.TabIndex = 4;
            // 
            // txtRemainingBalance
            // 
            this.txtRemainingBalance.Enabled = false;
            this.txtRemainingBalance.Location = new System.Drawing.Point(393, 396);
            this.txtRemainingBalance.Name = "txtRemainingBalance";
            this.txtRemainingBalance.Size = new System.Drawing.Size(127, 20);
            this.txtRemainingBalance.TabIndex = 6;
            this.txtRemainingBalance.TextChanged += new System.EventHandler(this.txtRemainingBalance_TextChanged);
            // 
            // lblRemainingBalance
            // 
            this.lblRemainingBalance.AutoSize = true;
            this.lblRemainingBalance.Location = new System.Drawing.Point(288, 399);
            this.lblRemainingBalance.Name = "lblRemainingBalance";
            this.lblRemainingBalance.Size = new System.Drawing.Size(99, 13);
            this.lblRemainingBalance.TabIndex = 5;
            this.lblRemainingBalance.Text = "Remaining Balance";
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.txtTransactionNum);
            this.grpCustomerDetails.Controls.Add(this.lblTransactionNumber);
            this.grpCustomerDetails.Controls.Add(this.txtName);
            this.grpCustomerDetails.Controls.Add(this.lblName);
            this.grpCustomerDetails.Location = new System.Drawing.Point(20, 16);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(500, 98);
            this.grpCustomerDetails.TabIndex = 7;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details";
            // 
            // txtTransactionNum
            // 
            this.txtTransactionNum.Enabled = false;
            this.txtTransactionNum.Location = new System.Drawing.Point(158, 25);
            this.txtTransactionNum.Name = "txtTransactionNum";
            this.txtTransactionNum.Size = new System.Drawing.Size(258, 20);
            this.txtTransactionNum.TabIndex = 1;
            // 
            // lblTransactionNumber
            // 
            this.lblTransactionNumber.AutoSize = true;
            this.lblTransactionNumber.Location = new System.Drawing.Point(44, 29);
            this.lblTransactionNumber.Name = "lblTransactionNumber";
            this.lblTransactionNumber.Size = new System.Drawing.Size(103, 13);
            this.lblTransactionNumber.TabIndex = 10;
            this.lblTransactionNumber.Text = "Transaction Number";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(158, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(112, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 438);
            this.Controls.Add(this.grpCustomerDetails);
            this.Controls.Add(this.txtRemainingBalance);
            this.Controls.Add(this.lblRemainingBalance);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.lblTotalAmountPaid);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.listPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPayment_FormClosing);
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPayments;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblTotalAmountPaid;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.TextBox txtRemainingBalance;
        private System.Windows.Forms.Label lblRemainingBalance;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.TextBox txtTransactionNum;
        private System.Windows.Forms.Label lblTransactionNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colModeOfPayment;
        private System.Windows.Forms.ColumnHeader colAmount;
    }
}