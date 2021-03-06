
namespace SAD2
{
    partial class frmStockOutDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockOutDetails));
            this.grpStockIn = new System.Windows.Forms.GroupBox();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.txtStockOutID = new System.Windows.Forms.TextBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblStockOutID = new System.Windows.Forms.Label();
            this.grpInventoryItems = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listInventory = new System.Windows.Forms.ListView();
            this.colItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemTotalWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpStockOutItems = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.listStockOutItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpStockIn.SuspendLayout();
            this.grpInventoryItems.SuspendLayout();
            this.grpStockOutItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStockIn
            // 
            this.grpStockIn.Controls.Add(this.cmbEmployees);
            this.grpStockIn.Controls.Add(this.txtStockOutID);
            this.grpStockIn.Controls.Add(this.lblStaff);
            this.grpStockIn.Controls.Add(this.lblStockOutID);
            this.grpStockIn.Location = new System.Drawing.Point(12, 12);
            this.grpStockIn.Name = "grpStockIn";
            this.grpStockIn.Size = new System.Drawing.Size(618, 118);
            this.grpStockIn.TabIndex = 23;
            this.grpStockIn.TabStop = false;
            this.grpStockIn.Text = "Stock In";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(112, 34);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(171, 21);
            this.cmbEmployees.TabIndex = 21;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbEmployees_SelectedIndexChanged);
            // 
            // txtStockOutID
            // 
            this.txtStockOutID.Enabled = false;
            this.txtStockOutID.Location = new System.Drawing.Point(112, 64);
            this.txtStockOutID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockOutID.Name = "txtStockOutID";
            this.txtStockOutID.Size = new System.Drawing.Size(171, 20);
            this.txtStockOutID.TabIndex = 1;
            this.txtStockOutID.TextChanged += new System.EventHandler(this.txtStockOutID_TextChanged);
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(65, 38);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(29, 13);
            this.lblStaff.TabIndex = 20;
            this.lblStaff.Text = "Staff";
            this.lblStaff.Click += new System.EventHandler(this.lblStaff_Click);
            // 
            // lblStockOutID
            // 
            this.lblStockOutID.AutoSize = true;
            this.lblStockOutID.Location = new System.Drawing.Point(25, 68);
            this.lblStockOutID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockOutID.Name = "lblStockOutID";
            this.lblStockOutID.Size = new System.Drawing.Size(69, 13);
            this.lblStockOutID.TabIndex = 8;
            this.lblStockOutID.Text = "Stock Out ID";
            // 
            // grpInventoryItems
            // 
            this.grpInventoryItems.Controls.Add(this.btnAdd);
            this.grpInventoryItems.Controls.Add(this.txtQuantity);
            this.grpInventoryItems.Controls.Add(this.lblQuantity);
            this.grpInventoryItems.Controls.Add(this.label1);
            this.grpInventoryItems.Controls.Add(this.listInventory);
            this.grpInventoryItems.Location = new System.Drawing.Point(12, 136);
            this.grpInventoryItems.Name = "grpInventoryItems";
            this.grpInventoryItems.Size = new System.Drawing.Size(618, 370);
            this.grpInventoryItems.TabIndex = 24;
            this.grpInventoryItems.TabStop = false;
            this.grpInventoryItems.Text = "Inventory";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(491, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(440, 290);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(153, 20);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(388, 293);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // listInventory
            // 
            this.listInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemID,
            this.colItemType,
            this.colItemColor,
            this.colItemWeight,
            this.colItemQuantity,
            this.colItemTotalWeight});
            this.listInventory.FullRowSelect = true;
            this.listInventory.HideSelection = false;
            this.listInventory.Location = new System.Drawing.Point(25, 33);
            this.listInventory.Name = "listInventory";
            this.listInventory.Size = new System.Drawing.Size(568, 237);
            this.listInventory.TabIndex = 0;
            this.listInventory.UseCompatibleStateImageBehavior = false;
            this.listInventory.View = System.Windows.Forms.View.Details;
            this.listInventory.SelectedIndexChanged += new System.EventHandler(this.listInventory_SelectedIndexChanged);
            // 
            // colItemID
            // 
            this.colItemID.Text = "Item ID";
            this.colItemID.Width = 91;
            // 
            // colItemType
            // 
            this.colItemType.Text = "Type";
            this.colItemType.Width = 95;
            // 
            // colItemColor
            // 
            this.colItemColor.Text = "Color";
            this.colItemColor.Width = 97;
            // 
            // colItemWeight
            // 
            this.colItemWeight.Text = "Weight (kg)";
            this.colItemWeight.Width = 98;
            // 
            // colItemQuantity
            // 
            this.colItemQuantity.Text = "Quantity";
            this.colItemQuantity.Width = 85;
            // 
            // colItemTotalWeight
            // 
            this.colItemTotalWeight.Text = "Total Weight";
            this.colItemTotalWeight.Width = 97;
            // 
            // grpStockOutItems
            // 
            this.grpStockOutItems.Controls.Add(this.btnRemove);
            this.grpStockOutItems.Controls.Add(this.txtTotal);
            this.grpStockOutItems.Controls.Add(this.lblTotal);
            this.grpStockOutItems.Controls.Add(this.btnStockOut);
            this.grpStockOutItems.Controls.Add(this.listStockOutItems);
            this.grpStockOutItems.Location = new System.Drawing.Point(636, 12);
            this.grpStockOutItems.Name = "grpStockOutItems";
            this.grpStockOutItems.Size = new System.Drawing.Size(614, 494);
            this.grpStockOutItems.TabIndex = 25;
            this.grpStockOutItems.TabStop = false;
            this.grpStockOutItems.Text = "Items";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(25, 414);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 27);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(477, 410);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(116, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(443, 414);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total";
            // 
            // btnStockOut
            // 
            this.btnStockOut.Enabled = false;
            this.btnStockOut.Location = new System.Drawing.Point(491, 441);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(102, 27);
            this.btnStockOut.TabIndex = 5;
            this.btnStockOut.Text = "Stock Out";
            this.btnStockOut.UseVisualStyleBackColor = true;
            this.btnStockOut.Click += new System.EventHandler(this.button2_Click);
            // 
            // listStockOutItems
            // 
            this.listStockOutItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listStockOutItems.FullRowSelect = true;
            this.listStockOutItems.HideSelection = false;
            this.listStockOutItems.Location = new System.Drawing.Point(25, 34);
            this.listStockOutItems.Name = "listStockOutItems";
            this.listStockOutItems.Size = new System.Drawing.Size(568, 360);
            this.listStockOutItems.TabIndex = 1;
            this.listStockOutItems.UseCompatibleStateImageBehavior = false;
            this.listStockOutItems.View = System.Windows.Forms.View.Details;
            this.listStockOutItems.SelectedIndexChanged += new System.EventHandler(this.listStockOutItems_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item ID";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Color";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Weight (kg)";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            this.columnHeader5.Width = 94;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total Weight";
            this.columnHeader6.Width = 100;
            // 
            // frmStockOutDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 521);
            this.Controls.Add(this.grpStockOutItems);
            this.Controls.Add(this.grpInventoryItems);
            this.Controls.Add(this.grpStockIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStockOutDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Out Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStockOutDetails_FormClosing);
            this.Load += new System.EventHandler(this.frmStockOutDetails_Load);
            this.grpStockIn.ResumeLayout(false);
            this.grpStockIn.PerformLayout();
            this.grpInventoryItems.ResumeLayout(false);
            this.grpInventoryItems.PerformLayout();
            this.grpStockOutItems.ResumeLayout(false);
            this.grpStockOutItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStockIn;
        private System.Windows.Forms.TextBox txtStockOutID;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblStockOutID;
        private System.Windows.Forms.GroupBox grpInventoryItems;
        private System.Windows.Forms.ListView listInventory;
        private System.Windows.Forms.GroupBox grpStockOutItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colItemID;
        private System.Windows.Forms.ColumnHeader colItemType;
        private System.Windows.Forms.ColumnHeader colItemColor;
        private System.Windows.Forms.ColumnHeader colItemWeight;
        private System.Windows.Forms.ColumnHeader colItemQuantity;
        private System.Windows.Forms.ColumnHeader colItemTotalWeight;
        private System.Windows.Forms.ListView listStockOutItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbEmployees;
    }
}