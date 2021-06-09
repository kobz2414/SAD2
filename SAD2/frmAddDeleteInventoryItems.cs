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
        private string type = "", color = "", weight = "";

        public frmAddDeleteInventoryItems()
        {
            InitializeComponent();
            Initialize();
            showColor();
            showType();
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

        public void showType()
        {
            cmbType.Items.Clear();

            string query = "SELECT typeName from db_inventory_item_types.type";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string id = dataReader["typeName"] + "";
                    cmbType.Items.Add(id);
                }

                dataReader.Close();

                CloseConnection();
            }
        }

        public void showColor()
        {
            cmbColor.Items.Clear();

            string query = "SELECT colorName from db_inventory_item_types.color";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string id = dataReader["colorName"] + "";
                    cmbColor.Items.Add(id);
                }

                dataReader.Close();

                CloseConnection();
            }
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
            if (type != "" && color != "" && weight != "")
            {
                if (!txtWeight.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Must input a valid weight");
                }else if (int.Parse(txtWeight.Text) <= 0)
                {
                    MessageBox.Show("Weight must not be equal to or less than 0");
                }
                else
                {
                    string query = "INSERT INTO `db_cefinal`.`inventory` (`inventory_id`, `type`, `color`, `weight`, `quantity`)  VALUES('" + txtIDAdd.Text + "', '" + cmbType.Text + "', '" + cmbColor.Text + "', '" + txtWeight.Text + "', 0);";

                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                    }

                    txtIDAdd.Text = "";
                    cmbColor.Text = "";
                    cmbType.Text = "";
                    txtWeight.Text = "";
                    MessageBox.Show("Success");
                    showDelete();
                }
            }
            else
            {
                MessageBox.Show("Incomplete/Invalid details");
            }
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            frmAddColor temp = new frmAddColor();
            temp.ShowDialog();
            showColor();
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT colorID from db_inventory_item_types.color WHERE colorName = '" + cmbColor.Text + "';";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string id = dataReader["colorID"] + "";
                    color = id;
                }

                dataReader.Close();
                CloseConnection();
            }

            if (type != "" && color != "" && weight != "")
            {
                txtIDAdd.Text = type + color + weight;
            }
            else
            {
                txtIDAdd.Text = "";
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            if (txtWeight.Text.All(char.IsDigit))
            {
                weight = txtWeight.Text;

                if (type != "" && color != "" && weight != "")
                {
                    txtIDAdd.Text = type + color + weight;
                }
                else
                {
                    txtIDAdd.Text = "";
                }
            }
            else
            {
                txtIDAdd.Text = "";
            }
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            frmAddType temp = new frmAddType();
            temp.ShowDialog();
            showType();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT typeID from db_inventory_item_types.type WHERE typeName = '" + cmbType.Text + "';";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string id = dataReader["typeID"] + "";
                    type = id;
                }

                dataReader.Close();
                CloseConnection();
            }

            if (type != "" && color != "" && weight != "")
            {
                txtIDAdd.Text = type + color + weight;
            }
            else
            {
                txtIDAdd.Text = "";
            }
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
