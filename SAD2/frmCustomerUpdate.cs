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
    public partial class frmCustomerUpdate : Form
    {

        private MySqlConnection connection;
        private string server, database, database1, uid, password;
        private string userID;
        public frmCustomerUpdate(string id)
        {
            userID = id;
            InitializeComponent();
            Initialize();
            show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void show()
        {
            string query = "select name, address, contactnumber from db_cefinal.customers where customerID = '" + userID + "';";

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

        }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(txtAddress.Text == "" || txtContactNumber.Text == "" || txtName.Text == "")
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
                string query = "UPDATE `db_cefinal`.`customers` SET `Name` = '" + txtName.Text + "', `Address` = '" + txtAddress.Text + "', `ContactNumber` = '" + txtContactNumber.Text + "' WHERE (`customerID` = '" + userID + "');";

                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                CloseConnection();

                MessageBox.Show("Profile Updated");
                this.Hide();
            }
        }

        private void grpCustomerInformation_Enter(object sender, EventArgs e)
        {

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


        private void frmCustomerUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
