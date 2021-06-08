using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD2
{
    public partial class frmAddPayment : Form
    {
        private MySqlConnection connection;
        private string server, database, uid, password;
        private bool checkNameCash = false, checkAmountCash = false, 
                     checkNameBank = false, checkAccountNumberBank = false, checkAmountBank = false, 
                     checkChequeNumber = false, checkAmountCheque = false;
        private int transactionID;

        public frmAddPayment(int temp)
        {
            transactionID = temp;
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "db_cefinal";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtAccountNumber.Text == "")
            {
                checkAccountNumberBank = false;
                btnPayBank.Enabled = false;
            }
            else
            {
                checkAccountNumberBank = true;
                if (checkNameBank == true && checkAccountNumberBank == true && checkAmountBank == true)
                {
                    btnPayBank.Enabled = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "")
            {
                checkNameBank = false;
                btnPayBank.Enabled = false;
            }
            else
            {
                checkNameBank = true;
                if (checkNameBank == true && checkAccountNumberBank == true && checkAmountBank == true)
                {
                    btnPayBank.Enabled = true;
                }
            }
        }

        private void txtAmountBank_TextChanged(object sender, EventArgs e)
        {
            if (txtAmountBank.Text == "")
            {
                checkAmountBank = false;
                btnPayBank.Enabled = false;
            }
            else
            {
                checkAmountBank = true;
                if (checkNameBank == true && checkAccountNumberBank == true && checkAmountBank == true)
                {
                    btnPayBank.Enabled = true;
                }
            }
        }

        private void frmAddPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                frmPayment temp = new frmPayment(transactionID);
                frmAddPayment temp2 = new frmAddPayment(transactionID);
                temp.Show();
                temp2.Hide();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txtChequeNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtChequeNumber.Text == "")
            {
                checkChequeNumber = false;
                btnPayCheque.Enabled = false;
            }
            else
            {
                checkChequeNumber = true;
                if (checkChequeNumber == true && checkAmountCheque == true)
                {
                    btnPayCheque.Enabled = true;
                }
            }
        }

        private void txtAmountCheque_TextChanged(object sender, EventArgs e)
        {
            if (txtAmountCheque.Text == "")
            {
                checkAmountCheque = false;
                btnPayCheque.Enabled = false;
            }
            else
            {
                checkAmountCheque = true;
                if (checkChequeNumber == true && checkAmountCheque == true)
                {
                    btnPayCheque.Enabled = true;
                }
            }
        }

        private void btnPayCheque_Click(object sender, EventArgs e)
        {
            if (!txtChequeNumber.Text.All(char.IsDigit))
            {

                MessageBox.Show("Please input a numeric value (Cheque Number)");
            }
            else if (!txtAmountCheque.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please input a numeric value (Amount)");
            }
            else
            {
                string query = "INSERT INTO `db_payments`.`" + transactionID + "` (`Date`, `ModeOfPayment`, `AccountNumber`, `Amount`) VALUES(now(), 'Cheque', '" + txtChequeNumber.Text + "', '" + txtAmountCheque.Text + "');";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }

                MessageBox.Show("Success");
                frmPayment temp = new frmPayment(transactionID);
                this.Hide();
                temp.Show();
            }
        }

        private void btnPayCash_Click(object sender, EventArgs e)
        {
            if (!txtAmountCash.Text.All(char.IsDigit))
            {

                MessageBox.Show("Please input a numeric value (Amount)");
            }
            else if (txtName.Text == "")
            {

                MessageBox.Show("Please input name");
            }
            else
            {

                string query = "INSERT INTO `db_payments`.`" + transactionID + "` (`Date`, `ModeOfPayment`, `AccountName`, `Amount`) VALUES(now(), 'Cash', '" + txtName.Text + "', '" + txtAmountCash.Text + "');";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }

                MessageBox.Show("Success");
                frmPayment temp = new frmPayment(transactionID);
                this.Hide();
                temp.Show();
            }
        }


        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmountCash.Text == "")
            {
                checkAmountCash = false;
                btnPayCash.Enabled = false;
            }
            else
            {
                checkAmountCash = true;
                if (checkNameCash == true && checkAmountCash == true)
                {
                    btnPayCash.Enabled = true;
                }
            }
        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDateandTime.Text = DateTime.Now.ToString("dddd, MMMM-dd-yyyy hh:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!txtAccountNumber.Text.All(char.IsDigit))
            {

                MessageBox.Show("Please input a numeric value (Account Number)");
            }
            else if (!txtAmountBank.Text.All(char.IsDigit))
            {

                MessageBox.Show("Please input a numeric value (Amount)");
            }
            else if (txtAccountName.Text == "")
            {

                MessageBox.Show("Please input a account name");
            }
            else
            {
                string query = "INSERT INTO `db_payments`.`" + transactionID + "` (`Date`, `ModeOfPayment`, `AccountNumber`, `AccountName`, `Amount`) VALUES(now(), 'Bank', '" + txtAccountNumber.Text + "', '" + txtAccountName.Text + "', '" + txtAmountBank.Text + "');";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }

                MessageBox.Show("Success");
                frmPayment temp = new frmPayment(transactionID);
                this.Hide();
                temp.Show();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                checkNameCash = false;
                btnPayCash.Enabled = false;
            }
            else
            {
                checkNameCash = true;
                if (checkNameCash == true && checkAmountCash == true)
                {
                    btnPayCash.Enabled = true;
                }
            }
        }
    }
}
