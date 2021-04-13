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
    public partial class frmTransactions : Form
    {
        private MySqlConnection connection;
        private string server, database, uid, password;
        private string transactionID;

        public frmTransactions()
        {
            InitializeComponent();
            Initialize();
            show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (listTransactionHistory.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a transaction");
            }
            else
            {
                frmTransactionDetails temp = new frmTransactionDetails(transactionID);
                temp.Show();
                this.Hide();
            }

            
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {

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

        private void listTransactionHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTransactionHistory.SelectedItems.Count < 1) return;
            ListViewItem item = listTransactionHistory.SelectedItems[0];
            transactionID = item.Text;

        }

        private void frmTransactions_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu temp = new frmMainMenu();
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
            listTransactionHistory.Items.Clear();

            string query = "SELECT * FROM `db_cefinal`.`sales` order by DateTime Desc;";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string date = dataReader["DateTime"] + "", name = dataReader["name"] + "", id = dataReader["transactionID"] + "", status = dataReader["Status"] + "";
                    string[] row = {id, date, name, status};
                    ListViewItem item = new ListViewItem(row);
                    listTransactionHistory.Items.Add(item);
                }

                dataReader.Close();

                CloseConnection();
            }
        }
    }
}
