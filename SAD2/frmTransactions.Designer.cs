
namespace SAD2
{
    partial class frmTransactions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.listTransactionHistory = new System.Windows.Forms.ListView();
            this.colTransactionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDetails);
            this.groupBox1.Controls.Add(this.listTransactionHistory);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(199, 384);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(170, 32);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // listTransactionHistory
            // 
            this.listTransactionHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTransactionID,
            this.colDateTime,
            this.colCustomerName,
            this.colStatus});
            this.listTransactionHistory.FullRowSelect = true;
            this.listTransactionHistory.HideSelection = false;
            this.listTransactionHistory.Location = new System.Drawing.Point(21, 19);
            this.listTransactionHistory.Name = "listTransactionHistory";
            this.listTransactionHistory.Size = new System.Drawing.Size(526, 339);
            this.listTransactionHistory.TabIndex = 0;
            this.listTransactionHistory.UseCompatibleStateImageBehavior = false;
            this.listTransactionHistory.View = System.Windows.Forms.View.Details;
            this.listTransactionHistory.SelectedIndexChanged += new System.EventHandler(this.listTransactionHistory_SelectedIndexChanged);
            // 
            // colTransactionID
            // 
            this.colTransactionID.Text = "Transaction ID";
            this.colTransactionID.Width = 93;
            // 
            // colDateTime
            // 
            this.colDateTime.Text = "Date and Time";
            this.colDateTime.Width = 166;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Text = "Name";
            this.colCustomerName.Width = 164;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 96;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 468);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTransactions_FormClosing);
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.ListView listTransactionHistory;
        private System.Windows.Forms.ColumnHeader colTransactionID;
        private System.Windows.Forms.ColumnHeader colDateTime;
        private System.Windows.Forms.ColumnHeader colCustomerName;
        private System.Windows.Forms.ColumnHeader colStatus;
    }
}