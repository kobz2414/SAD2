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
    public partial class frmAddType : Form
    {

        private MySqlConnection connection;
        private string server, database, uid, password;
        public frmAddType()
        {
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtType.Text == "")
            {
                MessageBox.Show("Please input name of type");
            }
            else
            {
                string query = "INSERT INTO `db_inventory_item_types`.`type` (`typeName`)  VALUES('" + txtType.Text + "');";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }

                MessageBox.Show("Success");
                this.Hide();
            }
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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

        private void frmAddType_Load(object sender, EventArgs e)
        {

        }
    }
}
