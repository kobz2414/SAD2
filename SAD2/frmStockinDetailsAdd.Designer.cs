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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.listCart = new System.Windows.Forms.ListView();
            this.colStockID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStockin = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.lblStockInID = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.grpStockIn = new System.Windows.Forms.GroupBox();
            this.grpItemDetails = new System.Windows.Forms.GroupBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbWeight = new System.Windows.Forms.ComboBox();
            this.btnAddDeleteItem = new System.Windows.Forms.Button();
            this.grpStockIn.SuspendLayout();
            this.grpItemDetails.SuspendLayout();
            this.grpItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(55, 261);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(172, 261);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(109, 183);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(171, 20);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(109, 217);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(171, 20);
            this.txtSubtotal.TabIndex = 7;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(50, 153);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "Weight";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(60, 85);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Type";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(60, 119);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(45, 187);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(45, 221);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // listCart
            // 
            this.listCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStockID,
            this.colType,
            this.colColor,
            this.colWeight,
            this.colQuantity,
            this.colSubtotal});
            this.listCart.FullRowSelect = true;
            this.listCart.HideSelection = false;
            this.listCart.Location = new System.Drawing.Point(23, 34);
            this.listCart.Margin = new System.Windows.Forms.Padding(2);
            this.listCart.MultiSelect = false;
            this.listCart.Name = "listCart";
            this.listCart.Size = new System.Drawing.Size(798, 340);
            this.listCart.TabIndex = 8;
            this.listCart.UseCompatibleStateImageBehavior = false;
            this.listCart.View = System.Windows.Forms.View.Details;
            this.listCart.SelectedIndexChanged += new System.EventHandler(this.listCart_SelectedIndexChanged);
            // 
            // colStockID
            // 
            this.colStockID.Text = "ID";
            // 
            // colType
            // 
            this.colType.Text = "Type";
            // 
            // colColor
            // 
            this.colColor.Text = "Color";
            // 
            // colWeight
            // 
            this.colWeight.Text = "Weight";
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Quantity";
            // 
            // colSubtotal
            // 
            this.colSubtotal.Text = "Subtotal";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(534, 547);
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
            this.btnStockin.Location = new System.Drawing.Point(699, 442);
            this.btnStockin.Margin = new System.Windows.Forms.Padding(2);
            this.btnStockin.Name = "btnStockin";
            this.btnStockin.Size = new System.Drawing.Size(122, 30);
            this.btnStockin.TabIndex = 9;
            this.btnStockin.Text = "Stock In";
            this.btnStockin.UseVisualStyleBackColor = true;
            this.btnStockin.Click += new System.EventHandler(this.btnStockin_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(699, 408);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(122, 20);
            this.txtTotal.TabIndex = 16;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(664, 411);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total";
            // 
            // txtStockID
            // 
            this.txtStockID.Enabled = false;
            this.txtStockID.Location = new System.Drawing.Point(109, 34);
            this.txtStockID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(171, 20);
            this.txtStockID.TabIndex = 1;
            this.txtStockID.TextChanged += new System.EventHandler(this.txtStockID_TextChanged);
            // 
            // lblStockInID
            // 
            this.lblStockInID.AutoSize = true;
            this.lblStockInID.Location = new System.Drawing.Point(73, 38);
            this.lblStockInID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockInID.Name = "lblStockInID";
            this.lblStockInID.Size = new System.Drawing.Size(18, 13);
            this.lblStockInID.TabIndex = 8;
            this.lblStockInID.Text = "ID";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Enabled = false;
            this.txtEmployee.Location = new System.Drawing.Point(109, 67);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(171, 20);
            this.txtEmployee.TabIndex = 2;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(62, 70);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(29, 13);
            this.lblStaff.TabIndex = 20;
            this.lblStaff.Text = "Staff";
            // 
            // grpStockIn
            // 
            this.grpStockIn.Controls.Add(this.txtEmployee);
            this.grpStockIn.Controls.Add(this.txtStockID);
            this.grpStockIn.Controls.Add(this.lblStaff);
            this.grpStockIn.Controls.Add(this.lblStockInID);
            this.grpStockIn.Location = new System.Drawing.Point(12, 12);
            this.grpStockIn.Name = "grpStockIn";
            this.grpStockIn.Size = new System.Drawing.Size(342, 118);
            this.grpStockIn.TabIndex = 22;
            this.grpStockIn.TabStop = false;
            this.grpStockIn.Text = "Stock In";
            // 
            // grpItemDetails
            // 
            this.grpItemDetails.Controls.Add(this.cmbWeight);
            this.grpItemDetails.Controls.Add(this.cmbColor);
            this.grpItemDetails.Controls.Add(this.cmbType);
            this.grpItemDetails.Controls.Add(this.lblItemID);
            this.grpItemDetails.Controls.Add(this.btnDelete);
            this.grpItemDetails.Controls.Add(this.btnAdd);
            this.grpItemDetails.Controls.Add(this.txtID);
            this.grpItemDetails.Controls.Add(this.lblWeight);
            this.grpItemDetails.Controls.Add(this.lblType);
            this.grpItemDetails.Controls.Add(this.lblColor);
            this.grpItemDetails.Controls.Add(this.lblQuantity);
            this.grpItemDetails.Controls.Add(this.lblSubtotal);
            this.grpItemDetails.Controls.Add(this.txtSubtotal);
            this.grpItemDetails.Controls.Add(this.txtQuantity);
            this.grpItemDetails.Location = new System.Drawing.Point(12, 154);
            this.grpItemDetails.Name = "grpItemDetails";
            this.grpItemDetails.Size = new System.Drawing.Size(342, 310);
            this.grpItemDetails.TabIndex = 23;
            this.grpItemDetails.TabStop = false;
            this.grpItemDetails.Text = "Item Details";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(50, 51);
            this.lblItemID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(41, 13);
            this.lblItemID.TabIndex = 14;
            this.lblItemID.Text = "Item ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(109, 47);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(171, 20);
            this.txtID.TabIndex = 1;
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.listCart);
            this.grpItems.Controls.Add(this.txtTotal);
            this.grpItems.Controls.Add(this.lblTotal);
            this.grpItems.Controls.Add(this.btnStockin);
            this.grpItems.Location = new System.Drawing.Point(378, 12);
            this.grpItems.Name = "grpItems";
            this.grpItems.Size = new System.Drawing.Size(845, 510);
            this.grpItems.TabIndex = 24;
            this.grpItems.TabStop = false;
            this.grpItems.Text = "Items";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(108, 82);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(172, 21);
            this.cmbType.TabIndex = 15;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbColor
            // 
            this.cmbColor.Enabled = false;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(108, 116);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(172, 21);
            this.cmbColor.TabIndex = 16;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // cmbWeight
            // 
            this.cmbWeight.Enabled = false;
            this.cmbWeight.FormattingEnabled = true;
            this.cmbWeight.Location = new System.Drawing.Point(108, 150);
            this.cmbWeight.Name = "cmbWeight";
            this.cmbWeight.Size = new System.Drawing.Size(172, 21);
            this.cmbWeight.TabIndex = 17;
            this.cmbWeight.SelectedIndexChanged += new System.EventHandler(this.cmbWeight_SelectedIndexChanged);
            // 
            // btnAddDeleteItem
            // 
            this.btnAddDeleteItem.Location = new System.Drawing.Point(67, 483);
            this.btnAddDeleteItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDeleteItem.Name = "btnAddDeleteItem";
            this.btnAddDeleteItem.Size = new System.Drawing.Size(232, 30);
            this.btnAddDeleteItem.TabIndex = 18;
            this.btnAddDeleteItem.Text = "Add/Delete Inventory  Items";
            this.btnAddDeleteItem.UseVisualStyleBackColor = true;
            this.btnAddDeleteItem.Click += new System.EventHandler(this.btnAddDeleteItem_Click);
            // 
            // frmStockinDetailsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 602);
            this.Controls.Add(this.btnAddDeleteItem);
            this.Controls.Add(this.grpItems);
            this.Controls.Add(this.grpItemDetails);
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
            this.grpItemDetails.ResumeLayout(false);
            this.grpItemDetails.PerformLayout();
            this.grpItems.ResumeLayout(false);
            this.grpItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.ListView listCart;
        private System.Windows.Forms.ColumnHeader colStockID;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.ColumnHeader colWeight;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader colSubtotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStockin;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.Label lblStockInID;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.GroupBox grpStockIn;
        private System.Windows.Forms.GroupBox grpItemDetails;
        private System.Windows.Forms.GroupBox grpItems;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAddDeleteItem;
        private System.Windows.Forms.ComboBox cmbWeight;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbType;
    }
}