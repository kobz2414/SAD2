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
    public partial class frmAddEmployee : Form
    {

        private MySqlConnection connection, connection2;
        private string server, database, database1, uid, password;

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

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtContactNumber.Text == "")
            {
                checkContactNumber = false;
                btnAddEmployee.Enabled = false;
            }
            else
            {
                checkContactNumber = true;
                if (checkName == true && checkAddress == true && checkContactNumber == true)
                {
                    btnAddEmployee.Enabled = true;
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
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
                string query = "INSERT INTO `db_cefinal`.`employees` (`Name`, `Address`, `ContactNumber`) VALUES ('" + txtName.Text + "', '" + txtAddress.Text + "', '" + txtContactNumber.Text + "');";

                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                CloseConnection();

                MessageBox.Show("Profile Added");

                this.Hide();
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                checkName = false;
                btnAddEmployee.Enabled = false;
            }
            else
            {
                checkName = true;
                if (checkName == true && checkAddress == true && checkContactNumber == true)
                {
                    btnAddEmployee.Enabled = true;
                }
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                checkAddress = false;
                btnAddEmployee.Enabled = false;
            }
            else
            {
                checkAddress = true;
                if (checkName == true && checkAddress == true && checkContactNumber == true)
                {
                    btnAddEmployee.Enabled = true;
                }
            }
        }

        private bool checkName = false, checkAddress = false, checkContactNumber = false;

        public frmAddEmployee()
        {
            InitializeComponent();
            Initialize();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
