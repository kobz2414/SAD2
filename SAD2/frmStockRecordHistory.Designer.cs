
namespace SAD2
{
    partial class frmStockRecordHistory
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
            this.grpStockRecord = new System.Windows.Forms.GroupBox();
            this.listStockRecord = new System.Windows.Forms.ListView();
            this.colStockInOutID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateAndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.grpStockRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStockRecord
            // 
            this.grpStockRecord.Controls.Add(this.listStockRecord);
            this.grpStockRecord.Controls.Add(this.btnDetails);
            this.grpStockRecord.Location = new System.Drawing.Point(12, 12);
            this.grpStockRecord.Name = "grpStockRecord";
            this.grpStockRecord.Size = new System.Drawing.Size(864, 397);
            this.grpStockRecord.TabIndex = 0;
            this.grpStockRecord.TabStop = false;
            this.grpStockRecord.Text = "Stock Record";
            // 
            // listStockRecord
            // 
            this.listStockRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStockInOutID,
            this.colDateAndTime,
            this.colEmployee,
            this.colAction});
            this.listStockRecord.FullRowSelect = true;
            this.listStockRecord.HideSelection = false;
            this.listStockRecord.Location = new System.Drawing.Point(20, 27);
            this.listStockRecord.Name = "listStockRecord";
            this.listStockRecord.Size = new System.Drawing.Size(824, 321);
            this.listStockRecord.TabIndex = 0;
            this.listStockRecord.UseCompatibleStateImageBehavior = false;
            this.listStockRecord.View = System.Windows.Forms.View.Details;
            this.listStockRecord.SelectedIndexChanged += new System.EventHandler(this.listStockRecord_SelectedIndexChanged);
            // 
            // colStockInOutID
            // 
            this.colStockInOutID.Text = "Stock In/Out ID";
            this.colStockInOutID.Width = 216;
            // 
            // colDateAndTime
            // 
            this.colDateAndTime.Text = "Date and Time";
            this.colDateAndTime.Width = 232;
            // 
            // colEmployee
            // 
            this.colEmployee.Text = "Employee/Sold to";
            this.colEmployee.Width = 225;
            // 
            // colAction
            // 
            this.colAction.Text = "Action";
            this.colAction.Width = 137;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(731, 355);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(113, 30);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.Location = new System.Drawing.Point(300, 429);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(141, 30);
            this.btnStockIn.TabIndex = 1;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.Location = new System.Drawing.Point(447, 429);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(141, 30);
            this.btnStockOut.TabIndex = 2;
            this.btnStockOut.Text = "Stock Out";
            this.btnStockOut.UseVisualStyleBackColor = true;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // frmStockRecordHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 480);
            this.Controls.Add(this.btnStockOut);
            this.Controls.Add(this.btnStockIn);
            this.Controls.Add(this.grpStockRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStockRecordHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Record History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStockRecordHistory_FormClosing);
            this.Load += new System.EventHandler(this.frmStockRecordHistory_Load);
            this.grpStockRecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStockRecord;
        private System.Windows.Forms.ListView listStockRecord;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.ColumnHeader colStockInOutID;
        private System.Windows.Forms.ColumnHeader colDateAndTime;
        private System.Windows.Forms.ColumnHeader colEmployee;
        private System.Windows.Forms.ColumnHeader colAction;
        private System.Windows.Forms.Button btnStockOut;
    }
}