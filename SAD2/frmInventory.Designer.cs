namespace SAD2
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.listProduct = new System.Windows.Forms.ListView();
            this.colInventoryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.grpItemHistory = new System.Windows.Forms.GroupBox();
            this.lblStockOut = new System.Windows.Forms.Label();
            this.lblStockIn = new System.Windows.Forms.Label();
            this.listProductStockOut = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listProductStockIn = new System.Windows.Forms.ListView();
            this.colStockRecordID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateAndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRecordWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRecordQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStock = new System.Windows.Forms.Button();
            this.grpInventory.SuspendLayout();
            this.grpItemHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProduct
            // 
            this.listProduct.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colInventoryID,
            this.colType,
            this.colColor,
            this.colWeight,
            this.colQuantity,
            this.colSubtotal});
            this.listProduct.FullRowSelect = true;
            this.listProduct.HideSelection = false;
            this.listProduct.Location = new System.Drawing.Point(22, 64);
            this.listProduct.Margin = new System.Windows.Forms.Padding(2);
            this.listProduct.MultiSelect = false;
            this.listProduct.Name = "listProduct";
            this.listProduct.Size = new System.Drawing.Size(900, 186);
            this.listProduct.TabIndex = 12;
            this.listProduct.UseCompatibleStateImageBehavior = false;
            this.listProduct.View = System.Windows.Forms.View.Details;
            this.listProduct.SelectedIndexChanged += new System.EventHandler(this.listProduct_SelectedIndexChanged);
            // 
            // colInventoryID
            // 
            this.colInventoryID.Text = "ID";
            this.colInventoryID.Width = 118;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 139;
            // 
            // colColor
            // 
            this.colColor.Text = "Color";
            this.colColor.Width = 156;
            // 
            // colWeight
            // 
            this.colWeight.Text = "Weight (kg)";
            this.colWeight.Width = 121;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Quantity";
            this.colQuantity.Width = 149;
            // 
            // colSubtotal
            // 
            this.colSubtotal.Text = "Subtotal";
            this.colSubtotal.Width = 210;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "HD",
            "MB",
            "PP"});
            this.cmbType.Location = new System.Drawing.Point(56, 30);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(182, 21);
            this.cmbType.TabIndex = 13;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "BLACK",
            "BLUE",
            "GREEN",
            "RED",
            "TRANSPARENT",
            "WHITE",
            "YELLOW"});
            this.cmbColor.Location = new System.Drawing.Point(295, 30);
            this.cmbColor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(135, 21);
            this.cmbColor.TabIndex = 14;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(486, 29);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(84, 22);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(574, 29);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 22);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(21, 34);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Type";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(260, 34);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 20;
            this.lblColor.Text = "Color";
            // 
            // grpInventory
            // 
            this.grpInventory.Controls.Add(this.listProduct);
            this.grpInventory.Controls.Add(this.lblColor);
            this.grpInventory.Controls.Add(this.btnClear);
            this.grpInventory.Controls.Add(this.lblType);
            this.grpInventory.Controls.Add(this.cmbType);
            this.grpInventory.Controls.Add(this.cmbColor);
            this.grpInventory.Controls.Add(this.btnFilter);
            this.grpInventory.Location = new System.Drawing.Point(17, 12);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(944, 268);
            this.grpInventory.TabIndex = 21;
            this.grpInventory.TabStop = false;
            this.grpInventory.Text = "Inventory";
            // 
            // grpItemHistory
            // 
            this.grpItemHistory.Controls.Add(this.lblStockOut);
            this.grpItemHistory.Controls.Add(this.lblStockIn);
            this.grpItemHistory.Controls.Add(this.listProductStockOut);
            this.grpItemHistory.Controls.Add(this.listProductStockIn);
            this.grpItemHistory.Location = new System.Drawing.Point(17, 286);
            this.grpItemHistory.Name = "grpItemHistory";
            this.grpItemHistory.Size = new System.Drawing.Size(944, 250);
            this.grpItemHistory.TabIndex = 22;
            this.grpItemHistory.TabStop = false;
            this.grpItemHistory.Text = "Item History";
            // 
            // lblStockOut
            // 
            this.lblStockOut.AutoSize = true;
            this.lblStockOut.Location = new System.Drawing.Point(676, 27);
            this.lblStockOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockOut.Name = "lblStockOut";
            this.lblStockOut.Size = new System.Drawing.Size(55, 13);
            this.lblStockOut.TabIndex = 22;
            this.lblStockOut.Text = "Stock Out";
            // 
            // lblStockIn
            // 
            this.lblStockIn.AutoSize = true;
            this.lblStockIn.Location = new System.Drawing.Point(218, 27);
            this.lblStockIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockIn.Name = "lblStockIn";
            this.lblStockIn.Size = new System.Drawing.Size(47, 13);
            this.lblStockIn.TabIndex = 21;
            this.lblStockIn.Text = "Stock In";
            // 
            // listProductStockOut
            // 
            this.listProductStockOut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listProductStockOut.HideSelection = false;
            this.listProductStockOut.Location = new System.Drawing.Point(477, 46);
            this.listProductStockOut.Margin = new System.Windows.Forms.Padding(2);
            this.listProductStockOut.Name = "listProductStockOut";
            this.listProductStockOut.Size = new System.Drawing.Size(453, 187);
            this.listProductStockOut.TabIndex = 13;
            this.listProductStockOut.UseCompatibleStateImageBehavior = false;
            this.listProductStockOut.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item ID";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date and Time";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Weight (kg)";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Action";
            this.columnHeader5.Width = 92;
            // 
            // listProductStockIn
            // 
            this.listProductStockIn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStockRecordID,
            this.colDateAndTime,
            this.colRecordWeight,
            this.colRecordQuantity,
            this.colAction});
            this.listProductStockIn.HideSelection = false;
            this.listProductStockIn.Location = new System.Drawing.Point(15, 46);
            this.listProductStockIn.Margin = new System.Windows.Forms.Padding(2);
            this.listProductStockIn.Name = "listProductStockIn";
            this.listProductStockIn.Size = new System.Drawing.Size(453, 187);
            this.listProductStockIn.TabIndex = 12;
            this.listProductStockIn.UseCompatibleStateImageBehavior = false;
            this.listProductStockIn.View = System.Windows.Forms.View.Details;
            // 
            // colStockRecordID
            // 
            this.colStockRecordID.Text = "Item ID";
            this.colStockRecordID.Width = 73;
            // 
            // colDateAndTime
            // 
            this.colDateAndTime.Text = "Date and Time";
            this.colDateAndTime.Width = 125;
            // 
            // colRecordWeight
            // 
            this.colRecordWeight.Text = "Weight (kg)";
            this.colRecordWeight.Width = 76;
            // 
            // colRecordQuantity
            // 
            this.colRecordQuantity.Text = "Quantity";
            this.colRecordQuantity.Width = 79;
            // 
            // colAction
            // 
            this.colAction.Text = "Action";
            this.colAction.Width = 92;
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(408, 554);
            this.btnStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(162, 30);
            this.btnStock.TabIndex = 22;
            this.btnStock.Text = "Stock In/Stock Records";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 603);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.grpItemHistory);
            this.Controls.Add(this.grpInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInventory_FormClosing);
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.grpInventory.ResumeLayout(false);
            this.grpInventory.PerformLayout();
            this.grpItemHistory.ResumeLayout(false);
            this.grpItemHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listProduct;
        private System.Windows.Forms.ColumnHeader colInventoryID;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.ColumnHeader colWeight;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader colSubtotal;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.GroupBox grpItemHistory;
        private System.Windows.Forms.ListView listProductStockIn;
        private System.Windows.Forms.ColumnHeader colStockRecordID;
        private System.Windows.Forms.ColumnHeader colDateAndTime;
        private System.Windows.Forms.ColumnHeader colRecordWeight;
        private System.Windows.Forms.ColumnHeader colRecordQuantity;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.ColumnHeader colAction;
        private System.Windows.Forms.ListView listProductStockOut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblStockOut;
        private System.Windows.Forms.Label lblStockIn;
    }
}