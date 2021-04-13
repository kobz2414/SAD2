
namespace SAD2
{
    partial class frmStockRecordDetails
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
            this.frmDetails = new System.Windows.Forms.GroupBox();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtDateAndTime = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.lblStockID = new System.Windows.Forms.Label();
            this.listItems = new System.Windows.Forms.ListView();
            this.colStockID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStockType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStockColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStockWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStockQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStockSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frmDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmDetails
            // 
            this.frmDetails.Controls.Add(this.txtAction);
            this.frmDetails.Controls.Add(this.txtEmployee);
            this.frmDetails.Controls.Add(this.txtDateAndTime);
            this.frmDetails.Controls.Add(this.txtID);
            this.frmDetails.Controls.Add(this.lblAction);
            this.frmDetails.Controls.Add(this.lblEmployee);
            this.frmDetails.Controls.Add(this.lblDateAndTime);
            this.frmDetails.Controls.Add(this.lblStockID);
            this.frmDetails.Location = new System.Drawing.Point(29, 21);
            this.frmDetails.Name = "frmDetails";
            this.frmDetails.Size = new System.Drawing.Size(659, 188);
            this.frmDetails.TabIndex = 0;
            this.frmDetails.TabStop = false;
            this.frmDetails.Text = "Details";
            // 
            // txtAction
            // 
            this.txtAction.Enabled = false;
            this.txtAction.Location = new System.Drawing.Point(119, 131);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(192, 20);
            this.txtAction.TabIndex = 7;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Enabled = false;
            this.txtEmployee.Location = new System.Drawing.Point(119, 100);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(306, 20);
            this.txtEmployee.TabIndex = 6;
            // 
            // txtDateAndTime
            // 
            this.txtDateAndTime.Enabled = false;
            this.txtDateAndTime.Location = new System.Drawing.Point(119, 69);
            this.txtDateAndTime.Name = "txtDateAndTime";
            this.txtDateAndTime.Size = new System.Drawing.Size(306, 20);
            this.txtDateAndTime.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(119, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(306, 20);
            this.txtID.TabIndex = 4;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(70, 135);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(37, 13);
            this.lblAction.TabIndex = 3;
            this.lblAction.Text = "Action";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(54, 104);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(53, 13);
            this.lblEmployee.TabIndex = 2;
            this.lblEmployee.Text = "Employee";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Location = new System.Drawing.Point(30, 73);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(77, 13);
            this.lblDateAndTime.TabIndex = 1;
            this.lblDateAndTime.Text = "Date and Time";
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Location = new System.Drawing.Point(89, 42);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(18, 13);
            this.lblStockID.TabIndex = 0;
            this.lblStockID.Text = "ID";
            // 
            // listItems
            // 
            this.listItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStockID,
            this.colStockType,
            this.colStockColor,
            this.colStockWeight,
            this.colStockQuantity,
            this.colStockSubtotal});
            this.listItems.HideSelection = false;
            this.listItems.Location = new System.Drawing.Point(29, 227);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(659, 269);
            this.listItems.TabIndex = 1;
            this.listItems.UseCompatibleStateImageBehavior = false;
            this.listItems.View = System.Windows.Forms.View.Details;
            // 
            // colStockID
            // 
            this.colStockID.Text = "Stock ID";
            this.colStockID.Width = 104;
            // 
            // colStockType
            // 
            this.colStockType.Text = "Type";
            this.colStockType.Width = 98;
            // 
            // colStockColor
            // 
            this.colStockColor.Text = "Color";
            this.colStockColor.Width = 99;
            // 
            // colStockWeight
            // 
            this.colStockWeight.Text = "Weight";
            this.colStockWeight.Width = 99;
            // 
            // colStockQuantity
            // 
            this.colStockQuantity.Text = "Quantity";
            this.colStockQuantity.Width = 118;
            // 
            // colStockSubtotal
            // 
            this.colStockSubtotal.Text = "Subtotal";
            this.colStockSubtotal.Width = 133;
            // 
            // frmStockRecordDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 528);
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.frmDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStockRecordDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Record Details";
            this.Load += new System.EventHandler(this.frmStockRecordDetails_Load);
            this.frmDetails.ResumeLayout(false);
            this.frmDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox frmDetails;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.TextBox txtDateAndTime;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.ListView listItems;
        private System.Windows.Forms.ColumnHeader colStockID;
        private System.Windows.Forms.ColumnHeader colStockType;
        private System.Windows.Forms.ColumnHeader colStockColor;
        private System.Windows.Forms.ColumnHeader colStockWeight;
        private System.Windows.Forms.ColumnHeader colStockQuantity;
        private System.Windows.Forms.ColumnHeader colStockSubtotal;
    }
}