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
    public partial class frmEmployee : Form
    {
        private MySqlConnection connection, connection2;
        private string server, database, uid, password;

        private void Initialize()
        {
            server = "localhost";
            database = "db_cefinal";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

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

        private void listCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEmployee.SelectedItems.Count < 1)
            {
                txtName.Text = "";
                txtAddress.Text = "";
                txtContactNumber.Text = "";
            }
            else
            {
                ListViewItem temp = listEmployee.SelectedItems[0];
                string query = "select name, address, contactnumber from db_cefinal.employees where employeeID = '" + temp.Text + "';";

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
        }

        public frmEmployee()
        {
            InitializeComponent();
            Initialize();
            show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee temp = new frmAddEmployee();
            temp.ShowDialog();
            show();
        }

        public void show()
        {
            listEmployee.Items.Clear();

            string query = "SELECT * FROM db_cefinal.employees;";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string name = dataReader["name"] + "",
                           id = dataReader["employeeID"] + "",
                           address = dataReader["address"] + "",
                           contactnumber = dataReader["contactnumber"] + "";

                    string[] row = { id, name, address, contactnumber };
                    ListViewItem item = new ListViewItem(row);
                    listEmployee.Items.Add(item);

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
