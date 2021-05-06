
namespace SAD2
{
    partial class frmAddPayment
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
            this.tabPayment = new System.Windows.Forms.TabControl();
            this.tabCash = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPayCash = new System.Windows.Forms.Button();
            this.txtAmountCash = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabBankTransfer = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmountBank = new System.Windows.Forms.TextBox();
            this.btnPayBank = new System.Windows.Forms.Button();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.tabCheque = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPayCheque = new System.Windows.Forms.Button();
            this.txtAmountCheque = new System.Windows.Forms.TextBox();
            this.lblChequeNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChequeNumber = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.txtDateandTime = new System.Windows.Forms.TextBox();
            this.tabPayment.SuspendLayout();
            this.tabCash.SuspendLayout();
            this.tabBankTransfer.SuspendLayout();
            this.tabCheque.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPayment
            // 
            this.tabPayment.Controls.Add(this.tabCash);
            this.tabPayment.Controls.Add(this.tabBankTransfer);
            this.tabPayment.Controls.Add(this.tabCheque);
            this.tabPayment.Location = new System.Drawing.Point(12, 72);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.SelectedIndex = 0;
            this.tabPayment.Size = new System.Drawing.Size(416, 197);
            this.tabPayment.TabIndex = 0;
            // 
            // tabCash
            // 
            this.tabCash.Controls.Add(this.label1);
            this.tabCash.Controls.Add(this.btnPayCash);
            this.tabCash.Controls.Add(this.txtAmountCash);
            this.tabCash.Controls.Add(this.lblName);
            this.tabCash.Controls.Add(this.lblAmount);
            this.tabCash.Controls.Add(this.txtName);
            this.tabCash.Location = new System.Drawing.Point(4, 22);
            this.tabCash.Name = "tabCash";
            this.tabCash.Padding = new System.Windows.Forms.Padding(3);
            this.tabCash.Size = new System.Drawing.Size(408, 171);
            this.tabCash.TabIndex = 0;
            this.tabCash.Text = "Cash";
            this.tabCash.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "* - Required";
            // 
            // btnPayCash
            // 
            this.btnPayCash.Enabled = false;
            this.btnPayCash.Location = new System.Drawing.Point(69, 97);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(75, 23);
            this.btnPayCash.TabIndex = 29;
            this.btnPayCash.Text = "Pay";
            this.btnPayCash.UseVisualStyleBackColor = true;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayCash_Click);
            // 
            // txtAmountCash
            // 
            this.txtAmountCash.Location = new System.Drawing.Point(69, 45);
            this.txtAmountCash.Name = "txtAmountCash";
            this.txtAmountCash.Size = new System.Drawing.Size(145, 20);
            this.txtAmountCash.TabIndex = 28;
            this.txtAmountCash.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Name*";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(20, 49);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(47, 13);
            this.lblAmount.TabIndex = 26;
            this.lblAmount.Text = "Amount*";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 20);
            this.txtName.TabIndex = 25;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // tabBankTransfer
            // 
            this.tabBankTransfer.Controls.Add(this.label2);
            this.tabBankTransfer.Controls.Add(this.label5);
            this.tabBankTransfer.Controls.Add(this.txtAmountBank);
            this.tabBankTransfer.Controls.Add(this.btnPayBank);
            this.tabBankTransfer.Controls.Add(this.txtAccountName);
            this.tabBankTransfer.Controls.Add(this.lblAccountNumber);
            this.tabBankTransfer.Controls.Add(this.lblAccountName);
            this.tabBankTransfer.Controls.Add(this.txtAccountNumber);
            this.tabBankTransfer.Location = new System.Drawing.Point(4, 22);
            this.tabBankTransfer.Name = "tabBankTransfer";
            this.tabBankTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tabBankTransfer.Size = new System.Drawing.Size(408, 171);
            this.tabBankTransfer.TabIndex = 1;
            this.tabBankTransfer.Text = "Bank Transfer";
            this.tabBankTransfer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "* - Required";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Amount*";
            // 
            // txtAmountBank
            // 
            this.txtAmountBank.Location = new System.Drawing.Point(121, 73);
            this.txtAmountBank.Name = "txtAmountBank";
            this.txtAmountBank.Size = new System.Drawing.Size(159, 20);
            this.txtAmountBank.TabIndex = 35;
            this.txtAmountBank.TextChanged += new System.EventHandler(this.txtAmountBank_TextChanged);
            // 
            // btnPayBank
            // 
            this.btnPayBank.Enabled = false;
            this.btnPayBank.Location = new System.Drawing.Point(121, 128);
            this.btnPayBank.Name = "btnPayBank";
            this.btnPayBank.Size = new System.Drawing.Size(75, 23);
            this.btnPayBank.TabIndex = 34;
            this.btnPayBank.Text = "Pay";
            this.btnPayBank.UseVisualStyleBackColor = true;
            this.btnPayBank.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(121, 45);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(256, 20);
            this.txtAccountName.TabIndex = 33;
            this.txtAccountName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(28, 21);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(91, 13);
            this.lblAccountNumber.TabIndex = 32;
            this.lblAccountNumber.Text = "Account Number*";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(37, 49);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(82, 13);
            this.lblAccountName.TabIndex = 31;
            this.lblAccountName.Text = "Account Name*";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(121, 17);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(159, 20);
            this.txtAccountNumber.TabIndex = 30;
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tabCheque
            // 
            this.tabCheque.Controls.Add(this.label3);
            this.tabCheque.Controls.Add(this.btnPayCheque);
            this.tabCheque.Controls.Add(this.txtAmountCheque);
            this.tabCheque.Controls.Add(this.lblChequeNumber);
            this.tabCheque.Controls.Add(this.label4);
            this.tabCheque.Controls.Add(this.txtChequeNumber);
            this.tabCheque.Location = new System.Drawing.Point(4, 22);
            this.tabCheque.Name = "tabCheque";
            this.tabCheque.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheque.Size = new System.Drawing.Size(408, 171);
            this.tabCheque.TabIndex = 2;
            this.tabCheque.Text = "Cheque";
            this.tabCheque.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "* - Required";
            // 
            // btnPayCheque
            // 
            this.btnPayCheque.Enabled = false;
            this.btnPayCheque.Location = new System.Drawing.Point(118, 97);
            this.btnPayCheque.Name = "btnPayCheque";
            this.btnPayCheque.Size = new System.Drawing.Size(75, 23);
            this.btnPayCheque.TabIndex = 39;
            this.btnPayCheque.Text = "Pay";
            this.btnPayCheque.UseVisualStyleBackColor = true;
            this.btnPayCheque.Click += new System.EventHandler(this.btnPayCheque_Click);
            // 
            // txtAmountCheque
            // 
            this.txtAmountCheque.Location = new System.Drawing.Point(118, 45);
            this.txtAmountCheque.Name = "txtAmountCheque";
            this.txtAmountCheque.Size = new System.Drawing.Size(136, 20);
            this.txtAmountCheque.TabIndex = 38;
            this.txtAmountCheque.TextChanged += new System.EventHandler(this.txtAmountCheque_TextChanged);
            // 
            // lblChequeNumber
            // 
            this.lblChequeNumber.AutoSize = true;
            this.lblChequeNumber.Location = new System.Drawing.Point(28, 21);
            this.lblChequeNumber.Name = "lblChequeNumber";
            this.lblChequeNumber.Size = new System.Drawing.Size(88, 13);
            this.lblChequeNumber.TabIndex = 37;
            this.lblChequeNumber.Text = "Cheque Number*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Amount*";
            // 
            // txtChequeNumber
            // 
            this.txtChequeNumber.Location = new System.Drawing.Point(118, 17);
            this.txtChequeNumber.Name = "txtChequeNumber";
            this.txtChequeNumber.Size = new System.Drawing.Size(222, 20);
            this.txtChequeNumber.TabIndex = 35;
            this.txtChequeNumber.TextChanged += new System.EventHandler(this.txtChequeNumber_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(182, 18);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 13);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "Date and Time";
            // 
            // txtDateandTime
            // 
            this.txtDateandTime.Enabled = false;
            this.txtDateandTime.Location = new System.Drawing.Point(96, 34);
            this.txtDateandTime.Name = "txtDateandTime";
            this.txtDateandTime.Size = new System.Drawing.Size(249, 20);
            this.txtDateandTime.TabIndex = 24;
            this.txtDateandTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 281);
            this.Controls.Add(this.tabPayment);
            this.Controls.Add(this.txtDateandTime);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddPayment_FormClosing);
            this.Load += new System.EventHandler(this.frmAddPayment_Load);
            this.tabPayment.ResumeLayout(false);
            this.tabCash.ResumeLayout(false);
            this.tabCash.PerformLayout();
            this.tabBankTransfer.ResumeLayout(false);
            this.tabBankTransfer.PerformLayout();
            this.tabCheque.ResumeLayout(false);
            this.tabCheque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPayment;
        private System.Windows.Forms.TabPage tabCash;
        private System.Windows.Forms.TabPage tabBankTransfer;
        private System.Windows.Forms.TabPage tabCheque;
        private System.Windows.Forms.TextBox txtAmountCash;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtDateandTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnPayCash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountBank;
        private System.Windows.Forms.Button btnPayBank;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnPayCheque;
        private System.Windows.Forms.TextBox txtAmountCheque;
        private System.Windows.Forms.Label lblChequeNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChequeNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}