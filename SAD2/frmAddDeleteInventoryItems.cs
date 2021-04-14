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
    public partial class frmAddDeleteInventoryItems : Form
    {
        private MySqlConnection connection;
        private string server, database, uid, password;

        public frmAddDeleteInventoryItems()
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

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColor.Text != "")
            {
                cmbWeight.Enabled = true;
            }
            else
            {
                cmbWeight.Enabled = false;
            }

            try
            {
                cmbWeight.Items.Clear();

                string query = "SELECT DISTINCT weight FROM db_cefinal.products where type = '" + cmbType.Text + "' and color = '" + cmbColor.Text + "';";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    cmbWeight.Text = "";
                    txtIDAdd.Text = "";

                    while (dataReader.Read())
                    {
                        cmbWeight.Items.Add(dataReader["weight"]);
                    }

                    dataReader.Close();

                    this.CloseConnection();
                }
            }
            catch (Exception err)
            {

            }
        }

        private void cmbWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT itemid FROM db_cefinal.products where type = '" + cmbType.Text + "' and color = '" + cmbColor.Text + "' and weight = '" + cmbWeight.Text + "';";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        txtID.Text = dataReader["itemid"].ToString();
                    }

                    dataReader.Close();

                    this.CloseConnection();
                }
            }
            catch (Exception err)
            {

            }
        }

        private void frmAddDeleteInventoryItems_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmAddDeleteInventoryItems_Load(object sender, EventArgs e)
        {
            try
            {
                cmbType.Items.Clear();

                string query = "SELECT DISTINCT type FROM db_cefinal.products;";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        cmbType.Items.Add(dataReader["type"]);
                    }

                    dataReader.Close();

                    this.CloseConnection();
                }
            }
            catch (Exception err)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int quantity = 0;
            bool ifExists = false;
            string query = "SELECT quantity FROM db_cefinal.inventory where inventory_id = '" + txtID.Text + "';"; // Check for number of quantity

            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        quantity = int.Parse(dataReader["quantity"].ToString());
                    }

                    dataReader.Close();

                    this.CloseConnection();
                }
            }
            catch(Exception err)
            {

            }

            //query = "SELECT EXISTS(SELECT quantity FROM `db_cefinal`.`inventory` WHERE inventory_id = '" + txtID.Text + "') as quantity;"; // Check if item exists

            //try
            //{
            //    if (this.OpenConnection() == true)
            //    {
            //        MySqlCommand cmd = new MySqlCommand(query, connection);
            //        MySqlDataReader dataReader = cmd.ExecuteReader();

            //        while (dataReader.Read())
            //        {
            //            ifExists = dataReader["quantity"].ToString() == "1" ? true : false;
            //        }

            //        dataReader.Close();

            //        this.CloseConnection();
            //    }
            //}
            //catch (Exception err)
            //{

            //}

            //if (ifExists)
            //{
            //    MessageBox.Show("Cannot delete item with a quantity of 1 or more");
            //}
            //else 
            
            if(quantity > 0)
            {
                MessageBox.Show("Cannot delete item with a quantity of 1 or more");
            }
            else
            {
                query = "DELETE FROM `db_cefinal`.`products` WHERE (`itemID` = '" + txtID.Text + "');" +
                    "DELETE FROM `db_cefinal`.`inventory` WHERE (`inventory_id` = '" + txtID.Text + "');";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }

                cmbType.Text = "";
                cmbColor.Text = "";
                cmbColor.Enabled = false;
                cmbWeight.Text = "";
                cmbWeight.Enabled = false;
                txtID.Text = "";
                MessageBox.Show("Success");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO `db_cefinal`.`products` (`itemID`, `type`, `color`, `weight`) VALUES('" + txtIDAdd.Text + "', '" + txtType.Text + "', '" + txtColor.Text + "', '" + txtWeight.Text + "');";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }

            txtIDAdd.Text = "";
            txtType.Text = "";
            txtColor.Text = "";
            txtWeight.Text = "";
            MessageBox.Show("Success");

            this.Close();
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


        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.Text != "")
            {
                cmbColor.Enabled = true;
            }
            else
            {
                cmbColor.Enabled = false;
            }

            try
            {
                cmbColor.Items.Clear();

                string query = "SELECT DISTINCT color FROM db_cefinal.products where type = '" + cmbType.Text + "';";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    cmbColor.Text = "";
                    cmbWeight.Text = "";
                    txtIDAdd.Text = "";
                    cmbWeight.Enabled = false;

                    while (dataReader.Read())
                    {
                        cmbColor.Items.Add(dataReader["color"]);
                    }

                    dataReader.Close();

                    this.CloseConnection();
                }
            }
            catch (Exception err)
            {

            }
        }
    }
}
