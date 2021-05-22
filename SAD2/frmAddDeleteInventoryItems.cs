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


        private void frmAddDeleteInventoryItems_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void showDelete()
        {
            try
            {
                listInventory.Items.Clear();

                string query = "SELECT * FROM db_cefinal.inventory;";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string id = dataReader["inventory_id"] + "", type = dataReader["type"] + "", color = dataReader["color"] + "", weight = dataReader["weight"] + "", quantity = dataReader["quantity"] + "";

                        string[] row = { id, type, color, weight, quantity };
                        ListViewItem item = new ListViewItem(row);
                        listInventory.Items.Add(item);
                    }

                    dataReader.Close();

                    this.CloseConnection();
                }
            }
            catch (Exception err)
            {
                this.CloseConnection();
            }
        }

        private void frmAddDeleteInventoryItems_Load(object sender, EventArgs e)
        {
            showDelete();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int quantity = 0;
            ListViewItem item = listInventory.SelectedItems[0];
            string query = "SELECT quantity FROM db_cefinal.inventory where inventory_id = '" + item.Text + "';"; // Check for number of quantity

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
                CloseConnection();
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
                query = "DELETE FROM `db_cefinal`.`inventory` WHERE (`inventory_id` = '" + item.Text + "');";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
                MessageBox.Show("Success");
                showDelete();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO `db_cefinal`.`inventory` (`inventory_id`, `type`, `color`, `weight`, `quantity`)  VALUES('" + txtIDAdd.Text + "', '" + txtType.Text + "', '" + txtColor.Text + "', '" + txtWeight.Text + "', 0);";

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
            showDelete();
        }

        private void pgDelete_Click(object sender, EventArgs e)
        {

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
