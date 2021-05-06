namespace SAD2
{
    partial class frmStockinDetailsAdd
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStockin = new System.Windows.Forms.Button();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.lblStockInID = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.grpStockIn = new System.Windows.Forms.GroupBox();
            this.txtDateandTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnAddDeleteItem = new System.Windows.Forms.Button();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.listCart = new System.Windows.Forms.ListView();
            this.cartID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cartTotalWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTotalWeight = new System.Windows.Forms.TextBox();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.listProduct = new System.Windows.Forms.ListView();
            this.colInventoryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpStockIn.SuspendLayout();
            this.grpCart.SuspendLayout();
            this.grpInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(542, 547);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStockin
            // 
            this.btnStockin.Location = new System.Drawing.Point(515, 351);
            this.btnStockin.Margin = new System.Windows.Forms.Padding(2);
            this.btnStockin.Name = "btnStockin";
            this.btnStockin.Size = new System.Drawing.Size(122, 30);
            this.btnStockin.TabIndex = 9;
            this.btnStockin.Text = "Stock In";
            this.btnStockin.UseVisualStyleBackColor = true;
            this.btnStockin.Click += new System.EventHandler(this.btnStockin_Click);
            // 
            // txtStockID
            // 
            this.txtStockID.Enabled = false;
            this.txtStockID.Location = new System.Drawing.Point(109, 35);
            this.txtStockID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(171, 20);
            this.txtStockID.TabIndex = 1;
            this.txtStockID.TextChanged += new System.EventHandler(this.txtStockID_TextChanged);
            // 
            // lblStockInID
            // 
            this.lblStockInID.AutoSize = true;
            this.lblStockInID.Location = new System.Drawing.Point(73, 39);
            this.lblStockInID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockInID.Name = "lblStockInID";
            this.lblStockInID.Size = new System.Drawing.Size(18, 13);
            this.lblStockInID.TabIndex = 8;
            this.lblStockInID.Text = "ID";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Enabled = false;
            this.txtEmployee.Location = new System.Drawing.Point(109, 60);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(171, 20);
            this.txtEmployee.TabIndex = 2;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(62, 64);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(29, 13);
            this.lblStaff.TabIndex = 20;
            this.lblStaff.Text = "Staff";
            // 
            // grpStockIn
            // 
            this.grpStockIn.Controls.Add(this.txtDateandTime);
            this.grpStockIn.Controls.Add(this.lblTime);
            this.grpStockIn.Controls.Add(this.txtEmployee);
            this.grpStockIn.Controls.Add(this.txtStockID);
            this.grpStockIn.Controls.Add(this.lblStaff);
            this.grpStockIn.Controls.Add(this.lblStockInID);
            this.grpStockIn.Location = new System.Drawing.Point(12, 12);
            this.grpStockIn.Name = "grpStockIn";
            this.grpStockIn.Size = new System.Drawing.Size(1232, 103);
            this.grpStockIn.TabIndex = 22;
            this.grpStockIn.TabStop = false;
            this.grpStockIn.Text = "Stock In";
            // 
            // txtDateandTime
            // 
            this.txtDateandTime.Enabled = false;
            this.txtDateandTime.Location = new System.Drawing.Point(964, 35);
            this.txtDateandTime.Name = "txtDateandTime";
            this.txtDateandTime.Size = new System.Drawing.Size(249, 20);
            this.txtDateandTime.TabIndex = 22;
            this.txtDateandTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDateandTime.TextChanged += new System.EventHandler(this.txtDateandTime_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1050, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 13);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "Date and Time";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // btnAddDeleteItem
            // 
            this.btnAddDeleteItem.Location = new System.Drawing.Point(16, 317);
            this.btnAddDeleteItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDeleteItem.Name = "btnAddDeleteItem";
            this.btnAddDeleteItem.Size = new System.Drawing.Size(232, 30);
            this.btnAddDeleteItem.TabIndex = 18;
            this.btnAddDeleteItem.Text = "Add/Delete Inventory  Items";
            this.btnAddDeleteItem.UseVisualStyleBackColor = true;
            this.btnAddDeleteItem.Click += new System.EventHandler(this.btnAddDeleteItem_Click);
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.txtQuantity);
            this.grpCart.Controls.Add(this.lblQuantity);
            this.grpCart.Controls.Add(this.listCart);
            this.grpCart.Controls.Add(this.btnStockin);
            this.grpCart.Controls.Add(this.txtTotalWeight);
            this.grpCart.Controls.Add(this.lblTotalWeight);
            this.grpCart.Controls.Add(this.btnAdd);
            this.grpCart.Controls.Add(this.btnRemove);
            this.grpCart.Location = new System.Drawing.Point(588, 121);
            this.grpCart.Name = "grpCart";
            this.grpCart.Size = new System.Drawing.Size(656, 405);
            this.grpCart.TabIndex = 24;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Cart";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(70, 321);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(169, 20);
            this.txtQuantity.TabIndex = 14;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(18, 325);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Quantity";
            // 
            // listCart
            // 
            this.listCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cartID,
            this.cartType,
            this.cartColor,
            this.cartWeight,
            this.cartQuantity,
            this.cartTotalWeight});
            this.listCart.FullRowSelect = true;
            this.listCart.HideSelection = false;
            this.listCart.Location = new System.Drawing.Point(21, 30);
            this.listCart.Margin = new System.Windows.Forms.Padding(2);
            this.listCart.MultiSelect = false;
            this.listCart.Name = "listCart";
            this.listCart.Size = new System.Drawing.Size(616, 282);
            this.listCart.TabIndex = 14;
            this.listCart.UseCompatibleStateImageBehavior = false;
            this.listCart.View = System.Windows.Forms.View.Details;
            this.listCart.SelectedIndexChanged += new System.EventHandler(this.listCart_SelectedIndexChanged_1);
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
            this.cartColor.Width = 121;
            // 
            // cartWeight
            // 
            this.cartWeight.Text = "Weight";
            this.cartWeight.Width = 89;
            // 
            // cartQuantity
            // 
            this.cartQuantity.Text = "Quantity";
            this.cartQuantity.Width = 90;
            // 
            // cartTotalWeight
            // 
            this.cartTotalWeight.Text = "Total Weight";
            this.cartTotalWeight.Width = 105;
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.Enabled = false;
            this.txtTotalWeight.Location = new System.Drawing.Point(483, 321);
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.Size = new System.Drawing.Size(154, 20);
            this.txtTotalWeight.TabIndex = 5;
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.Location = new System.Drawing.Point(409, 325);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(68, 13);
            this.lblTotalWeight.TabIndex = 4;
            this.lblTotalWeight.Text = "Total Weight";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(245, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(245, 351);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 28);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpInventory
            // 
            this.grpInventory.Controls.Add(this.listProduct);
            this.grpInventory.Controls.Add(this.btnAddDeleteItem);
            this.grpInventory.Location = new System.Drawing.Point(12, 121);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(570, 405);
            this.grpInventory.TabIndex = 23;
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
            this.listProduct.Location = new System.Drawing.Point(16, 30);
            this.listProduct.Margin = new System.Windows.Forms.Padding(2);
            this.listProduct.Name = "listProduct";
            this.listProduct.Size = new System.Drawing.Size(539, 283);
            this.listProduct.TabIndex = 13;
            this.listProduct.UseCompatibleStateImageBehavior = false;
            this.listProduct.View = System.Windows.Forms.View.Details;
            this.listProduct.SelectedIndexChanged += new System.EventHandler(this.listProduct_SelectedIndexChanged);
            // 
            // colInventoryID
            // 
            this.colInventoryID.Text = "ID";
            this.colInventoryID.Width = 55;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 132;
            // 
            // colColor
            // 
            this.colColor.Text = "Color";
            this.colColor.Width = 114;
            // 
            // colWeight
            // 
            this.colWeight.Text = "Weight";
            this.colWeight.Width = 76;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Quantity";
            this.colQuantity.Width = 73;
            // 
            // colTotalWeight
            // 
            this.colTotalWeight.Text = "Total Weight";
            this.colTotalWeight.Width = 78;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmStockinDetailsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 602);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.grpInventory);
            this.Controls.Add(this.grpStockIn);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmStockinDetailsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock In Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStockinDetailsAdd_FormClosing);
            this.Load += new System.EventHandler(this.frmStockinDetailsAdd_Load);
            this.grpStockIn.ResumeLayout(false);
            this.grpStockIn.PerformLayout();
            this.grpCart.ResumeLayout(false);
            this.grpCart.PerformLayout();
            this.grpInventory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStockin;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.Label lblStockInID;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.GroupBox grpStockIn;
        private System.Windows.Forms.Button btnAddDeleteItem;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ListView listCart;
        private System.Windows.Forms.ColumnHeader cartID;
        private System.Windows.Forms.ColumnHeader cartType;
        private System.Windows.Forms.ColumnHeader cartColor;
        private System.Windows.Forms.ColumnHeader cartWeight;
        private System.Windows.Forms.ColumnHeader cartQuantity;
        private System.Windows.Forms.ColumnHeader cartTotalWeight;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.ListView listProduct;
        private System.Windows.Forms.ColumnHeader colInventoryID;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.ColumnHeader colWeight;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader colTotalWeight;
        private System.Windows.Forms.TextBox txtDateandTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}