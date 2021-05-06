
namespace SAD2
{
    partial class frmAddDeleteInventoryItems
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
            this.grpAddItems = new System.Windows.Forms.GroupBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtIDAdd = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.grpDeleteItems = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listInventory = new System.Windows.Forms.ListView();
            this.colItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpAddItems.SuspendLayout();
            this.grpDeleteItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddItems
            // 
            this.grpAddItems.Controls.Add(this.lblItemID);
            this.grpAddItems.Controls.Add(this.txtIDAdd);
            this.grpAddItems.Controls.Add(this.lblWeight);
            this.grpAddItems.Controls.Add(this.lblType);
            this.grpAddItems.Controls.Add(this.lblColor);
            this.grpAddItems.Controls.Add(this.btnAdd);
            this.grpAddItems.Controls.Add(this.txtType);
            this.grpAddItems.Controls.Add(this.txtColor);
            this.grpAddItems.Controls.Add(this.txtWeight);
            this.grpAddItems.Location = new System.Drawing.Point(12, 12);
            this.grpAddItems.Name = "grpAddItems";
            this.grpAddItems.Size = new System.Drawing.Size(500, 194);
            this.grpAddItems.TabIndex = 25;
            this.grpAddItems.TabStop = false;
            this.grpAddItems.Text = "Add Items";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(32, 29);
            this.lblItemID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(41, 13);
            this.lblItemID.TabIndex = 14;
            this.lblItemID.Text = "Item ID";
            // 
            // txtIDAdd
            // 
            this.txtIDAdd.Location = new System.Drawing.Point(82, 25);
            this.txtIDAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDAdd.Name = "txtIDAdd";
            this.txtIDAdd.Size = new System.Drawing.Size(171, 20);
            this.txtIDAdd.TabIndex = 1;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(32, 107);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "Weight";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(42, 55);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Type";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(42, 81);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(82, 144);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(82, 51);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(244, 20);
            this.txtType.TabIndex = 2;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(82, 77);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(244, 20);
            this.txtColor.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(82, 103);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(171, 20);
            this.txtWeight.TabIndex = 4;
            // 
            // grpDeleteItems
            // 
            this.grpDeleteItems.Controls.Add(this.listInventory);
            this.grpDeleteItems.Controls.Add(this.btnDelete);
            this.grpDeleteItems.Location = new System.Drawing.Point(12, 212);
            this.grpDeleteItems.Name = "grpDeleteItems";
            this.grpDeleteItems.Size = new System.Drawing.Size(500, 254);
            this.grpDeleteItems.TabIndex = 26;
            this.grpDeleteItems.TabStop = false;
            this.grpDeleteItems.Text = "Delete Items";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(193, 211);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listInventory
            // 
            this.listInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemID,
            this.colType,
            this.colColor,
            this.colWeight,
            this.colQuantity});
            this.listInventory.HideSelection = false;
            this.listInventory.Location = new System.Drawing.Point(10, 19);
            this.listInventory.Name = "listInventory";
            this.listInventory.Size = new System.Drawing.Size(480, 183);
            this.listInventory.TabIndex = 7;
            this.listInventory.UseCompatibleStateImageBehavior = false;
            this.listInventory.View = System.Windows.Forms.View.Details;
            // 
            // colItemID
            // 
            this.colItemID.Text = "ID";
            this.colItemID.Width = 65;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 130;
            // 
            // colColor
            // 
            this.colColor.Text = "Color";
            this.colColor.Width = 132;
            // 
            // colWeight
            // 
            this.colWeight.Text = "Weight";
            this.colWeight.Width = 74;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Quantity";
            this.colQuantity.Width = 65;
            // 
            // frmAddDeleteInventoryItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 475);
            this.Controls.Add(this.grpDeleteItems);
            this.Controls.Add(this.grpAddItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddDeleteInventoryItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Delete Inventory Items";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddDeleteInventoryItems_FormClosing);
            this.Load += new System.EventHandler(this.frmAddDeleteInventoryItems_Load);
            this.grpAddItems.ResumeLayout(false);
            this.grpAddItems.PerformLayout();
            this.grpDeleteItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpAddItems;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtIDAdd;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.GroupBox grpDeleteItems;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listInventory;
        private System.Windows.Forms.ColumnHeader colItemID;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.ColumnHeader colWeight;
        private System.Windows.Forms.ColumnHeader colQuantity;
    }
}