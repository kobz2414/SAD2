
namespace SAD2
{
    partial class frmTransactionDetails
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
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.txtPaymentStatus = new System.Windows.Forms.TextBox();
            this.btnPayments = new System.Windows.Forms.Button();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.txtDateandTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTransactionNum = new System.Windows.Forms.TextBox();
            this.lblTransactionNumber = new System.Windows.Forms.Label();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtTotalWeight = new System.Windows.Forms.TextBox();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.listProducts = new System.Windows.Forms.ListView();
            this.cartID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartTotalWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.txtPaymentStatus);
            this.grpCustomerDetails.Controls.Add(this.btnPayments);
            this.grpCustomerDetails.Controls.Add(this.lblPaymentStatus);
            this.grpCustomerDetails.Controls.Add(this.txtDateandTime);
            this.grpCustomerDetails.Controls.Add(this.lblTime);
            this.grpCustomerDetails.Controls.Add(this.txtTransactionNum);
            this.grpCustomerDetails.Controls.Add(this.lblTransactionNumber);
            this.grpCustomerDetails.Controls.Add(this.txtContactNum);
            this.grpCustomerDetails.Controls.Add(this.lblContactNumber);
            this.grpCustomerDetails.Controls.Add(this.txtAddress);
            this.grpCustomerDetails.Controls.Add(this.lblAddress);
            this.grpCustomerDetails.Controls.Add(this.txtName);
            this.grpCustomerDetails.Controls.Add(this.lblName);
            this.grpCustomerDetails.Location = new System.Drawing.Point(17, 12);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(577, 227);
            this.grpCustomerDetails.TabIndex = 1;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details";
            // 
            // txtPaymentStatus
            // 
            this.txtPaymentStatus.Enabled = false;
            this.txtPaymentStatus.Location = new System.Drawing.Point(158, 187);
            this.txtPaymentStatus.Name = "txtPaymentStatus";
            this.txtPaymentStatus.Size = new System.Drawing.Size(121, 20);
            this.txtPaymentStatus.TabIndex = 22;
            this.txtPaymentStatus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(285, 186);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(107, 23);
            this.btnPayments.TabIndex = 16;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(66, 190);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(81, 13);
            this.lblPaymentStatus.TabIndex = 14;
            this.lblPaymentStatus.Text = "Payment Status";
            // 
            // txtDateandTime
            // 
            this.txtDateandTime.Enabled = false;
            this.txtDateandTime.Location = new System.Drawing.Point(158, 31);
            this.txtDateandTime.Name = "txtDateandTime";
            this.txtDateandTime.Size = new System.Drawing.Size(192, 20);
            this.txtDateandTime.TabIndex = 13;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(70, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 13);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Date and Time";
            // 
            // txtTransactionNum
            // 
            this.txtTransactionNum.Enabled = false;
            this.txtTransactionNum.Location = new System.Drawing.Point(158, 62);
            this.txtTransactionNum.Name = "txtTransactionNum";
            this.txtTransactionNum.Size = new System.Drawing.Size(373, 20);
            this.txtTransactionNum.TabIndex = 1;
            // 
            // lblTransactionNumber
            // 
            this.lblTransactionNumber.AutoSize = true;
            this.lblTransactionNumber.Location = new System.Drawing.Point(44, 66);
            this.lblTransactionNumber.Name = "lblTransactionNumber";
            this.lblTransactionNumber.Size = new System.Drawing.Size(103, 13);
            this.lblTransactionNumber.TabIndex = 10;
            this.lblTransactionNumber.Text = "Transaction Number";
            // 
            // txtContactNum
            // 
            this.txtContactNum.Enabled = false;
            this.txtContactNum.Location = new System.Drawing.Point(158, 155);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(192, 20);
            this.txtContactNum.TabIndex = 4;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(63, 159);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 8;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(158, 124);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(373, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(102, 128);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(158, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(373, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(112, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(440, 570);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(154, 20);
            this.txtSubtotal.TabIndex = 20;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(388, 573);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 19;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.Enabled = false;
            this.txtTotalWeight.Location = new System.Drawing.Point(440, 544);
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.Size = new System.Drawing.Size(154, 20);
            this.txtTotalWeight.TabIndex = 18;
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.Location = new System.Drawing.Point(366, 547);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(68, 13);
            this.lblTotalWeight.TabIndex = 17;
            this.lblTotalWeight.Text = "Total Weight";
            // 
            // listProducts
            // 
            this.listProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cartID,
            this.cartType,
            this.cartColor,
            this.cartWeight,
            this.cartQuantity,
            this.cartTotalWeight,
            this.cartPrice,
            this.cartSubtotal});
            this.listProducts.FullRowSelect = true;
            this.listProducts.HideSelection = false;
            this.listProducts.Location = new System.Drawing.Point(17, 262);
            this.listProducts.Margin = new System.Windows.Forms.Padding(2);
            this.listProducts.MultiSelect = false;
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(577, 267);
            this.listProducts.TabIndex = 21;
            this.listProducts.UseCompatibleStateImageBehavior = false;
            this.listProducts.View = System.Windows.Forms.View.Details;
            // 
            // cartID
            // 
            this.cartID.Text = "ID";
            this.cartID.Width = 65;
            // 
            // cartType
            // 
            this.cartType.Text = "Type";
            this.cartType.Width = 75;
            // 
            // cartColor
            // 
            this.cartColor.Text = "Color";
            this.cartColor.Width = 105;
            // 
            // cartWeight
            // 
            this.cartWeight.Text = "Weight";
            this.cartWeight.Width = 63;
            // 
            // cartQuantity
            // 
            this.cartQuantity.Text = "Quantity";
            this.cartQuantity.Width = 61;
            // 
            // cartTotalWeight
            // 
            this.cartTotalWeight.Text = "Total Weight";
            this.cartTotalWeight.Width = 76;
            // 
            // cartPrice
            // 
            this.cartPrice.Text = "Price";
            this.cartPrice.Width = 56;
            // 
            // cartSubtotal
            // 
            this.cartSubtotal.Text = "Subtotal";
            this.cartSubtotal.Width = 62;
            // 
            // frmTransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 611);
            this.Controls.Add(this.listProducts);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtTotalWeight);
            this.Controls.Add(this.lblTotalWeight);
            this.Controls.Add(this.grpCustomerDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTransactionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTransactionDetails_FormClosing);
            this.Load += new System.EventHandler(this.frmTransactionDetails_Load);
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.TextBox txtDateandTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTransactionNum;
        private System.Windows.Forms.Label lblTransactionNumber;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.ListView listProducts;
        private System.Windows.Forms.ColumnHeader cartID;
        private System.Windows.Forms.ColumnHeader cartType;
        private System.Windows.Forms.ColumnHeader cartColor;
        private System.Windows.Forms.ColumnHeader cartWeight;
        private System.Windows.Forms.ColumnHeader cartQuantity;
        private System.Windows.Forms.ColumnHeader cartTotalWeight;
        private System.Windows.Forms.ColumnHeader cartPrice;
        private System.Windows.Forms.ColumnHeader cartSubtotal;
        private System.Windows.Forms.TextBox txtPaymentStatus;
        private System.Windows.Forms.Button btnPayments;
    }
}