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
    public partial class frmPaymentDetails : Form
    {
        private MySqlConnection connection;
        private string server, database, uid, password;
        private string Date, transactionID;

        public frmPaymentDetails(string temp, string id)
        {
            Date = temp;
            transactionID = id;
            InitializeComponent();
            Initialize();
        }

        private void frmPaymentDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPayment temp = new frmPayment(int.Parse(transactionID));
            temp.Show();
            this.Hide();
        }

        private void frmPaymentDetails_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM `db_payments`.`" + transactionID + "` where Date = '" + Date + "';";

            try
            {
                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string date = dataReader["Date"] + "",
                               mode = dataReader["ModeOfPayment"] + "",
                               num = dataReader["AccountNumber"] + "",
                               name = dataReader["AccountName"] + "",
                               amount = dataReader["Amount"] + "";

                        txtAccountName.Text = name;
                        txtAccountNumber.Text = num;
                        txtAmount.Text = amount;
                        txtDateandTime.Text = date;
                        txtModeOfPayment.Text = mode;
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
    }
}
