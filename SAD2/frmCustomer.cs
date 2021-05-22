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
    public partial class frmCustomers : Form
    {

        private MySqlConnection connection;
        private string server, database, database1, uid, password;
        private int transactionID;
        public frmCustomers()
        {
            InitializeComponent();
            Initialize();
            show();
        }

        private void listCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCustomers.SelectedItems.Count < 1) return;
            ListViewItem temp = listCustomers.SelectedItems[0];
            string query = "select name, address, contactnumber from db_cefinal.customers where customerID = '" + temp.Text + "';";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string name = dataReader["name"] + "",
                           address = dataReader["address"] + "",
                           num = dataReader["contactnumber"] + "";

                    txtName.Text = name;
                    txtAddress.Text = address;
                    txtContactNumber.Text = num;

                }

                dataReader.Close();

                CloseConnection();
            }

            listTransactions.Items.Clear();

            query = "SELECT * FROM `db_cefinal`.`sales` WHERE name = '" + txtName.Text + "' ORDER BY DateTime DESC; ";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string date = dataReader["DateTime"] + "", id = dataReader["transactionID"] + "", status = dataReader["Status"] + "";
                    string[] row = { id, date, status };
                    ListViewItem item = new ListViewItem(row);
                    listTransactions.Items.Add(item);
                }

                dataReader.Close();

                CloseConnection();
            }

        }

        private void frmCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu temp = new frmMainMenu();
            this.Hide();
            temp.Show();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string title = "Delete Customer";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (listCustomers.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a customer");
                }
                else
                {
                    ListViewItem item = listCustomers.SelectedItems[0];
                    string query = "DELETE FROM `db_cefinal`.`customers` WHERE (`customerID` = '" + item.Text + "');";

                    if (OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                    }
                    CloseConnection();

                    MessageBox.Show("Profile Deleted");
                    show();

                    txtAddress.Text = "";
                    txtContactNumber.Text = "";
                    txtName.Text = "";

                    listTransactions.Items.Clear();
                }
            }
        }


        private void Initialize()
        {
            server = "localhost";
            database1 = "db_transactions";
            database = "db_cefinal";
            uid = "root";
            password = "root";
            string connectionString, connectionString2;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connectionString2 = "SERVER=" + server + ";" + "DATABASE=" + database1 + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer temp = new frmAddCustomer(0);
            temp.Show();
            this.Hide();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (listTransactions.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a transaction");
            }
            else
            {
                frmTransactionDetails temp = new frmTransactionDetails(transactionID, 1);
                temp.Show();
                this.Hide();
            }
        }

        private void listTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTransactions.SelectedItems.Count < 1) return;
            ListViewItem item = listTransactions.SelectedItems[0];
            transactionID = int.Parse(item.Text);
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

        public void show()
        {
            listCustomers.Items.Clear();

            string query = "SELECT customerID, name FROM db_cefinal.customers;";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string name = dataReader["name"] + "",
                           id = dataReader["customerID"] + "";

                    string[] row = {id, name};
                    ListViewItem item = new ListViewItem(row);
                    listCustomers.Items.Add(item);

                }

                dataReader.Close();

                CloseConnection();
            }
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}
