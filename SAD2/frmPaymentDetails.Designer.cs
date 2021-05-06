
namespace SAD2
{
    partial class frmPaymentDetails
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
            this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
            this.txtDateandTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtModeOfPayment = new System.Windows.Forms.TextBox();
            this.lblModeOfPayment = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.grpPaymentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPaymentDetails
            // 
            this.grpPaymentDetails.Controls.Add(this.txtDateandTime);
            this.grpPaymentDetails.Controls.Add(this.lblTime);
            this.grpPaymentDetails.Controls.Add(this.txtModeOfPayment);
            this.grpPaymentDetails.Controls.Add(this.lblModeOfPayment);
            this.grpPaymentDetails.Controls.Add(this.txtAmount);
            this.grpPaymentDetails.Controls.Add(this.lblAmount);
            this.grpPaymentDetails.Controls.Add(this.txtAccountName);
            this.grpPaymentDetails.Controls.Add(this.lblName);
            this.grpPaymentDetails.Controls.Add(this.txtAccountNumber);
            this.grpPaymentDetails.Controls.Add(this.lblAccountNumber);
            this.grpPaymentDetails.Location = new System.Drawing.Point(16, 15);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Size = new System.Drawing.Size(520, 197);
            this.grpPaymentDetails.TabIndex = 2;
            this.grpPaymentDetails.TabStop = false;
            this.grpPaymentDetails.Text = "Payment Details";
            // 
            // txtDateandTime
            // 
            this.txtDateandTime.Enabled = false;
            this.txtDateandTime.Location = new System.Drawing.Point(158, 31);
            this.txtDateandTime.Name = "txtDateandTime";
            this.txtDateandTime.Size = new System.Drawing.Size(192, 20);
            this.txtDateandTime.TabIndex = 13;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(70, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 13);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Date and Time";
            // 
            // txtModeOfPayment
            // 
            this.txtModeOfPayment.Enabled = false;
            this.txtModeOfPayment.Location = new System.Drawing.Point(158, 62);
            this.txtModeOfPayment.Name = "txtModeOfPayment";
            this.txtModeOfPayment.Size = new System.Drawing.Size(313, 20);
            this.txtModeOfPayment.TabIndex = 1;
            // 
            // lblModeOfPayment
            // 
            this.lblModeOfPayment.AutoSize = true;
            this.lblModeOfPayment.Location = new System.Drawing.Point(57, 66);
            this.lblModeOfPayment.Name = "lblModeOfPayment";
            this.lblModeOfPayment.Size = new System.Drawing.Size(90, 13);
            this.lblModeOfPayment.TabIndex = 10;
            this.lblModeOfPayment.Text = "Mode of Payment";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(158, 155);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(192, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(104, 159);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Enabled = false;
            this.txtAccountName.Location = new System.Drawing.Point(158, 124);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(313, 20);
            this.txtAccountName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(112, 128);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Enabled = false;
            this.txtAccountNumber.Location = new System.Drawing.Point(158, 93);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(313, 20);
            this.txtAccountNumber.TabIndex = 2;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(60, 97);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(87, 13);
            this.lblAccountNumber.TabIndex = 4;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // frmPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 226);
            this.Controls.Add(this.grpPaymentDetails);
            this.Name = "frmPaymentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPaymentDetails_FormClosing);
            this.Load += new System.EventHandler(this.frmPaymentDetails_Load);
            this.grpPaymentDetails.ResumeLayout(false);
            this.grpPaymentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPaymentDetails;
        private System.Windows.Forms.TextBox txtDateandTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtModeOfPayment;
        private System.Windows.Forms.Label lblModeOfPayment;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountNumber;
    }
}