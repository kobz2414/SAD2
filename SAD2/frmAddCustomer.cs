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
    public partial class frmAddCustomer : Form
    {

        private MySqlConnection connection, connection2;
        private string server, database, database1, uid, password;
        private bool checkName = false, checkAddress = false, checkContactNumber = false;
        private int formNumber;

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                checkAddress = false;
                btnAddCustomer.Enabled = false;
            }
            else
            {
                checkAddress = true;
                if (checkName == true && checkAddress == true && checkContactNumber == true)
                {
                    btnAddCustomer.Enabled = true;
                }
            }
        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtContactNumber.Text == "")
            {
                checkContactNumber = false;
                btnAddCustomer.Enabled = false;
            }
            else
            {
                checkContactNumber = true;
                if (checkName == true && checkAddress == true && checkContactNumber == true)
                {
                    btnAddCustomer.Enabled = true;
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)   
        {
            if (txtAddress.Text == "" || txtContactNumber.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Fill up all required details information");
            }
            else if (!txtContactNumber.Text.All(char.IsDigit) || txtContactNumber.Text.Length <= 6)
            {
                MessageBox.Show("Must input a valid contact number");
            }
            else if (txtName.Text.All(char.IsDigit))
            {
                MessageBox.Show("Must input a valid name");
            }
            else
            {

                string query = "INSERT INTO `db_cefinal`.`customers` (`Name`, `Address`, `ContactNumber`) VALUES ('" + txtName.Text + "', '" + txtAddress.Text + "', '" + txtContactNumber.Text + "');";

                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                CloseConnection();

                MessageBox.Show("Profile Added");

                if (formNumber == 0)
                {
                    frmCustomers temp = new frmCustomers();
                    this.Hide();
                    temp.Show();
                }
                else
                {
                    this.Hide();
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                checkName = false;
                btnAddCustomer.Enabled = false;
            }
            else
            {
                checkName = true;
                if (checkName == true && checkAddress == true && checkContactNumber == true)
                {
                    btnAddCustomer.Enabled = true;
                }
            }
        }

        public frmAddCustomer(int temp)
        {
            formNumber = temp;
            InitializeComponent();
            Initialize();
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
            connection2 = new MySqlConnection(connectionString2);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                connection2.Open();

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
                connection2.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
