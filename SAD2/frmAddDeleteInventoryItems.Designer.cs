
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDeleteInventoryItems));
            this.grpAddItems = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtIDAdd = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.grpDeleteItems = new System.Windows.Forms.GroupBox();
            this.listInventory = new System.Windows.Forms.ListView();
            this.colItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.grpAddItems.SuspendLayout();
            this.grpDeleteItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddItems
            // 
            this.grpAddItems.Controls.Add(this.label1);
            this.grpAddItems.Controls.Add(this.cmbColor);
            this.grpAddItems.Controls.Add(this.cmbType);
            this.grpAddItems.Controls.Add(this.lblItemID);
            this.grpAddItems.Controls.Add(this.txtIDAdd);
            this.grpAddItems.Controls.Add(this.lblWeight);
            this.grpAddItems.Controls.Add(this.lblType);
            this.grpAddItems.Controls.Add(this.lblColor);
            this.grpAddItems.Controls.Add(this.btnAdd);
            this.grpAddItems.Controls.Add(this.txtWeight);
            this.grpAddItems.Location = new System.Drawing.Point(12, 12);
            this.grpAddItems.Name = "grpAddItems";
            this.grpAddItems.Size = new System.Drawing.Size(308, 194);
            this.grpAddItems.TabIndex = 25;
            this.grpAddItems.TabStop = false;
            this.grpAddItems.Text = "Add Items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "* - Required";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(82, 74);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(171, 21);
            this.cmbColor.TabIndex = 16;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(82, 48);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(171, 21);
            this.cmbType.TabIndex = 15;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(32, 26);
            this.lblItemID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(41, 13);
            this.lblItemID.TabIndex = 14;
            this.lblItemID.Text = "Item ID";
            // 
            // txtIDAdd
            // 
            this.txtIDAdd.Enabled = false;
            this.txtIDAdd.Location = new System.Drawing.Point(82, 22);
            this.txtIDAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDAdd.Name = "txtIDAdd";
            this.txtIDAdd.Size = new System.Drawing.Size(171, 20);
            this.txtIDAdd.TabIndex = 1;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(28, 104);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(45, 13);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "Weight*";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(38, 52);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 13);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Type*";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(38, 78);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(35, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color*";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 150);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(82, 100);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(171, 20);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
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
            // listInventory
            // 
            this.listInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemID,
            this.colType,
            this.colColor,
            this.colWeight,
            this.colQuantity});
            this.listInventory.FullRowSelect = true;
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
            this.colWeight.Text = "Weight (kg)";
            this.colWeight.Width = 74;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Quantity";
            this.colQuantity.Width = 65;
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
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(340, 67);
            this.btnAddType.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(162, 35);
            this.btnAddType.TabIndex = 15;
            this.btnAddType.Text = "Add Type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(340, 110);
            this.btnAddColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(162, 35);
            this.btnAddColor.TabIndex = 27;
            this.btnAddColor.Text = "Add Color";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // frmAddDeleteInventoryItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 475);
            this.Controls.Add(this.btnAddColor);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.grpDeleteItems);
            this.Controls.Add(this.grpAddItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.GroupBox grpDeleteItems;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listInventory;
        private System.Windows.Forms.ColumnHeader colItemID;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.ColumnHeader colWeight;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
    }
}