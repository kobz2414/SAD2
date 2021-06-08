
namespace SAD2
{
    partial class frmOrder
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
            this.components = new System.ComponentModel.Container();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProfile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.listProduct = new System.Windows.Forms.ListView();
            this.colInventoryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.listCart = new System.Windows.Forms.ListView();
            this.cartID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartTotalWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTotalWeight = new System.Windows.Forms.TextBox();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpCustomerDetails.SuspendLayout();
            this.grpInventory.SuspendLayout();
            this.grpCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.btnCustomer);
            this.grpCustomerDetails.Controls.Add(this.label2);
            this.grpCustomerDetails.Controls.Add(this.cmbProfile);
            this.grpCustomerDetails.Controls.Add(this.label1);
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
            this.grpCustomerDetails.Location = new System.Drawing.Point(12, 12);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(1232, 203);
            this.grpCustomerDetails.TabIndex = 0;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(419, 51);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(112, 23);
            this.btnCustomer.TabIndex = 19;
            this.btnCustomer.Text = "Add Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer*";
            // 
            // cmbProfile
            // 
            this.cmbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfile.FormattingEnabled = true;
            this.cmbProfile.Location = new System.Drawing.Point(158, 51);
            this.cmbProfile.Name = "cmbProfile";
            this.cmbProfile.Size = new System.Drawing.Size(255, 21);
            this.cmbProfile.TabIndex = 17;
            this.cmbProfile.SelectedIndexChanged += new System.EventHandler(this.cmbProfile_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "* - Required";
            // 
            // txtDateandTime
            // 
            this.txtDateandTime.Enabled = false;
            this.txtDateandTime.Location = new System.Drawing.Point(954, 42);
            this.txtDateandTime.Name = "txtDateandTime";
            this.txtDateandTime.Size = new System.Drawing.Size(249, 20);
            this.txtDateandTime.TabIndex = 13;
            this.txtDateandTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDateandTime.TextChanged += new System.EventHandler(this.txtDateandTime_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1040, 26);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 13);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Date and Time";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // txtTransactionNum
            // 
            this.txtTransactionNum.Enabled = false;
            this.txtTransactionNum.Location = new System.Drawing.Point(158, 22);
            this.txtTransactionNum.Name = "txtTransactionNum";
            this.txtTransactionNum.Size = new System.Drawing.Size(255, 20);
            this.txtTransactionNum.TabIndex = 1;
            this.txtTransactionNum.TextChanged += new System.EventHandler(this.txtTransactionNum_TextChanged);
            // 
            // lblTransactionNumber
            // 
            this.lblTransactionNumber.AutoSize = true;
            this.lblTransactionNumber.Location = new System.Drawing.Point(43, 26);
            this.lblTransactionNumber.Name = "lblTransactionNumber";
            this.lblTransactionNumber.Size = new System.Drawing.Size(106, 13);
            this.lblTransactionNumber.TabIndex = 10;
            this.lblTransactionNumber.Text = "Transaction Number ";
            // 
            // txtContactNum
            // 
            this.txtContactNum.Enabled = false;
            this.txtContactNum.Location = new System.Drawing.Point(158, 139);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(192, 20);
            this.txtContactNum.TabIndex = 4;
            this.txtContactNum.TextChanged += new System.EventHandler(this.txtContactNum_TextChanged);
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(65, 143);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 8;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(158, 110);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(373, 20);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(104, 114);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(158, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(373, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(114, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // grpInventory
            // 
            this.grpInventory.Controls.Add(this.listProduct);
            this.grpInventory.Location = new System.Drawing.Point(12, 221);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(492, 352);
            this.grpInventory.TabIndex = 1;
            this.grpInventory.TabStop = false;
            this.grpInventory.Text = "Inventory";
            // 
            // listProduct
            // 
            this.listProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colInventoryID,
            this.colType,
            this.colColor,
            this.colWeight,
            this.colQuantity,
            this.colTotalWeight});
            this.listProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.listProduct.FullRowSelect = true;
            this.listProduct.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listProduct.HideSelection = false;
            this.listProduct.Location = new System.Drawing.Point(20, 26);
            this.listProduct.Margin = new System.Windows.Forms.Padding(2);
            this.listProduct.MultiSelect = false;
            this.listProduct.Name = "listProduct";
            this.listProduct.Size = new System.Drawing.Size(452, 234);
            this.listProduct.TabIndex = 13;
            this.listProduct.UseCompatibleStateImageBehavior = false;
            this.listProduct.View = System.Windows.Forms.View.Details;
            this.listProduct.SelectedIndexChanged += new System.EventHandler(this.listProduct_SelectedIndexChanged);
            // 
            // colInventoryID
            // 
            this.colInventoryID.Text = "ID";
            this.colInventoryID.Width = 51;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 95;
            // 
            // colColor
            // 
            this.colColor.Text = "Color";
            this.colColor.Width = 85;
            // 
            // colWeight
            // 
            this.colWeight.Text = "Weight (kg)";
            this.colWeight.Width = 68;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Quantity";
            this.colQuantity.Width = 53;
            // 
            // colTotalWeight
            // 
            this.colTotalWeight.Text = "Total Weight (kg)";
            this.colTotalWeight.Width = 96;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(82, 309);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(141, 20);
            this.txtPrice.TabIndex = 16;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(21, 313);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 13);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Unit Price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(82, 277);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(141, 20);
            this.txtQuantity.TabIndex = 14;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(28, 281);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(247, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.txtPrice);
            this.grpCart.Controls.Add(this.lblPrice);
            this.grpCart.Controls.Add(this.txtSubtotal);
            this.grpCart.Controls.Add(this.lblSubtotal);
            this.grpCart.Controls.Add(this.txtQuantity);
            this.grpCart.Controls.Add(this.lblQuantity);
            this.grpCart.Controls.Add(this.listCart);
            this.grpCart.Controls.Add(this.txtTotalWeight);
            this.grpCart.Controls.Add(this.lblTotalWeight);
            this.grpCart.Controls.Add(this.btnAdd);
            this.grpCart.Controls.Add(this.btnRemove);
            this.grpCart.Location = new System.Drawing.Point(510, 221);
            this.grpCart.Name = "grpCart";
            this.grpCart.Size = new System.Drawing.Size(734, 352);
            this.grpCart.TabIndex = 2;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Cart";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(562, 309);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(154, 20);
            this.txtSubtotal.TabIndex = 16;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(510, 313);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 15;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // listCart
            // 
            this.listCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cartID,
            this.cartType,
            this.cartColor,
            this.cartWeight,
            this.cartQuantity,
            this.cartTotalWeight,
            this.cartUnitPrice,
            this.cartSubtotal});
            this.listCart.FullRowSelect = true;
            this.listCart.HideSelection = false;
            this.listCart.Location = new System.Drawing.Point(19, 26);
            this.listCart.Margin = new System.Windows.Forms.Padding(2);
            this.listCart.MultiSelect = false;
            this.listCart.Name = "listCart";
            this.listCart.Size = new System.Drawing.Size(697, 234);
            this.listCart.TabIndex = 14;
            this.listCart.UseCompatibleStateImageBehavior = false;
            this.listCart.View = System.Windows.Forms.View.Details;
            this.listCart.SelectedIndexChanged += new System.EventHandler(this.listCart_SelectedIndexChanged);
            // 
            // cartID
            // 
            this.cartID.Text = "ID";
            this.cartID.Width = 65;
            // 
            // cartType
            // 
            this.cartType.Text = "Type";
            this.cartType.Width = 132;
            // 
            // cartColor
            // 
            this.cartColor.Text = "Color";
            this.cartColor.Width = 126;
            // 
            // cartWeight
            // 
            this.cartWeight.Text = "Weight (kg)";
            this.cartWeight.Width = 75;
            // 
            // cartQuantity
            // 
            this.cartQuantity.Text = "Quantity";
            this.cartQuantity.Width = 52;
            // 
            // cartTotalWeight
            // 
            this.cartTotalWeight.Text = "Total Weight (kg)";
            this.cartTotalWeight.Width = 98;
            // 
            // cartUnitPrice
            // 
            this.cartUnitPrice.Text = "Unit Price";
            this.cartUnitPrice.Width = 64;
            // 
            // cartSubtotal
            // 
            this.cartSubtotal.Text = "Subtotal";
            this.cartSubtotal.Width = 79;
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.Enabled = false;
            this.txtTotalWeight.Location = new System.Drawing.Point(562, 277);
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.Size = new System.Drawing.Size(154, 20);
            this.txtTotalWeight.TabIndex = 5;
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.Location = new System.Drawing.Point(488, 281);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(68, 13);
            this.lblTotalWeight.TabIndex = 4;
            this.lblTotalWeight.Text = "Total Weight";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(247, 306);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 28);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(518, 592);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(227, 28);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 643);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.grpInventory);
            this.Controls.Add(this.grpCustomerDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.grpInventory.ResumeLayout(false);
            this.grpCart.ResumeLayout(false);
            this.grpCart.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listProduct;
        private System.Windows.Forms.ColumnHeader colInventoryID;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.ColumnHeader colWeight;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader colTotalWeight;
        private System.Windows.Forms.ListView listCart;
        private System.Windows.Forms.ColumnHeader cartID;
        private System.Windows.Forms.ColumnHeader cartType;
        private System.Windows.Forms.ColumnHeader cartColor;
        private System.Windows.Forms.ColumnHeader cartWeight;
        private System.Windows.Forms.ColumnHeader cartQuantity;
        private System.Windows.Forms.ColumnHeader cartSubtotal;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ColumnHeader cartTotalWeight;
        private System.Windows.Forms.ColumnHeader cartUnitPrice;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProfile;
        private System.Windows.Forms.Button btnCustomer;
    }
}