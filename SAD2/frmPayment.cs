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
    public partial class frmPayment : Form
    {

        private MySqlConnection connection;
        private string server, database, uid, password;
        public int transactionID, totalPaid, outstandingBalance;
        private string paymentDate;

        public frmPayment(int ID)
        {
            transactionID = ID;
            InitializeComponent();
            Initialize();
            show();
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

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            frmAddPayment temp = new frmAddPayment(transactionID);
            temp.Show();
            this.Hide();
        }

        private void frmPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmTransactionDetails temp = new frmTransactionDetails(transactionID);
            temp.Show();
            this.Hide();
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

        private void txtRemainingBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            

            if (listPayments.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a payment");
            }
            else
            {
                frmPaymentDetails temp = new frmPaymentDetails(paymentDate, transactionID.ToString());
                temp.Show();
                this.Hide();
            }
        }

        private void listPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPayments.SelectedItems.Count < 1) return;
            ListViewItem item = listPayments.SelectedItems[0];
            paymentDate = item.Text;
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

        private void frmPayment_Load(object sender, EventArgs e)
        {
            string query = "SELECT transactionID, name FROM `db_cefinal`.`sales` where transactionID = " + transactionID + ";";

            try
            {
                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string name = dataReader["name"] + "",
                               id = dataReader["transactionID"] + "";

                        txtTransactionNum.Text = id;
                        txtName.Text = name;
                    }

                    dataReader.Close();

                    CloseConnection();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                CloseConnection();
            }

            query = "SELECT * FROM db_payments.`" + transactionID + "`";

            try
            {
                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string date = dataReader["date"] + "",
                               mode = dataReader["mode"] + "",
                               amount = dataReader["amount"] + "";
                        string[] row = { date, mode, amount};
                        ListViewItem item = new ListViewItem(row);
                        listPayments.Items.Add(item);
                    }

                    dataReader.Close();

                    CloseConnection();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("here" + err);
                CloseConnection();
            }

            query = "SELECT sum(amount) AS subtotal FROM db_payments.`" + transactionID + "`";

            try
            {
                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string total = dataReader["subtotal"] + "";
                        totalPaid = int.Parse(total);
                        txtAmountPaid.Text = totalPaid.ToString();
                    }

                    dataReader.Close();

                    CloseConnection();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                CloseConnection();
            }

            query = "SELECT sum(subtotal) AS subtotal FROM db_transactions.`" + transactionID + "`";

            try
            {
                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string total = dataReader["subtotal"] + "";
                        outstandingBalance = int.Parse(total) - totalPaid;
                        txtRemainingBalance.Text = (outstandingBalance).ToString();

                        if(int.Parse(txtRemainingBalance.Text) <= 0)
                        {
                            btnAddPayment.Enabled = false;
                        }
                    }

                    dataReader.Close();

                    CloseConnection();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                CloseConnection();
            }
        }


        public void show()
        {
            listPayments.Items.Clear();

            string query = "SELECT * FROM db_payments.`" + transactionID.ToString() + "` order by Date Desc;";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string date = dataReader["Date"] + "", ModeOfPayment = dataReader["ModeOfPayment"] + "", Amount = dataReader["Amount"] + "";
                    string[] row = {date, ModeOfPayment, Amount};
                    ListViewItem item = new ListViewItem(row);
                    listPayments.Items.Add(item);
                }

                dataReader.Close();

                CloseConnection();
            }
        }
    }
}
