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
    public partial class frmInventory : Form
    {
        private MySqlConnection connection;
        private string server, database, uid, password;

        public frmInventory()
        {
            InitializeComponent();
            Initialize();
            show();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbColor.Text = "";
            cmbType.Text = "";
            show();
        }

        private void btnStockRecordDetails_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStockRecordHistory temp = new frmStockRecordHistory();
            temp.Show();
            this.Hide();
        }

        private void listProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            listProductStockIn.Items.Clear();
            listProductStockOut.Items.Clear();

            //Stock In
            string query = "select stockin_id, date from `db_cefinal`.`stockin` order by date desc;";

            List<string> stockin_id = new List<string>();
            List<string> stockin_date = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                int count = 0;

                while (dataReader.Read())
                {
                    stockin_id.Add(dataReader["stockin_id"].ToString());
                    stockin_date.Add(dataReader["date"].ToString());
                    count++;
                }

                dataReader.Close();

                this.CloseConnection();
            }

            if (listProduct.SelectedItems.Count < 1) return;
            ListViewItem item_in = listProduct.SelectedItems[0];

            for (int x = 0; x < stockin_id.Count; x++)
            {

                query = "select * from `db_stockindetails`.`" + stockin_id[x] + "` where itemID = '" + item_in.Text + "';";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string id = dataReader["itemID"] + "", date = stockin_date[x] + "", weight = dataReader["itemWeight"] + "", quantity = dataReader["itemQuantity"] + "", action = "Stock In";
                        string[] row = { id, date, weight, quantity, action };
                        ListViewItem grid = new ListViewItem(row);
                        listProductStockIn.Items.Add(grid);
                    }

                    dataReader.Close();

                    this.CloseConnection();
                }
            }

            // Stock Out
            query = "select transactionID, DateTime from `db_cefinal`.`sales` order by Datetime desc;";

            List<string> stockout_id = new List<string>();
            List<string> stockout_date = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                int count = 0;

                while (dataReader.Read())
                {
                    stockout_id.Add(dataReader["transactionID"].ToString());
                    stockout_date.Add(dataReader["DateTime"].ToString());

                    //Console.WriteLine(stockout_id[count]);
                    //Console.WriteLine(stockout_date[count]);
                    count++;
                }

                dataReader.Close();

                this.CloseConnection();
            }


            if (listProduct.SelectedItems.Count < 1) return;
            ListViewItem item_out = listProduct.SelectedItems[0];

            for (int x = 0; x < stockout_id.Count; x++)
            {
                
                query = "select * from `db_transactions`.`" + stockout_id[x] + "` where itemID = '" + item_out.Text + "';";
                if (this.OpenConnection() == true)
                {

                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        while (dataReader.Read())
                        {
                            string id = dataReader["itemID"] + "", date = stockout_date[x] + "", weight = dataReader["itemWeight"] + "", quantity = dataReader["itemQuantity"] + "", action = "Stock Out";
                            string[] row = { id, date, weight, quantity, action };
                            ListViewItem grid = new ListViewItem(row);
                            listProductStockOut.Items.Add(grid);
                        }

                        dataReader.Close();

                        this.CloseConnection();
                    }
                    catch (Exception err)
                    {

                    }
                }

            }
        }

        private void frmInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu temp = new frmMainMenu();
            temp.Show();
            this.Hide();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {

        }

        public void show()
        {
            listProduct.Items.Clear();

            string query = "SELECT inventory_id AS id, type, color, SUM(weight) AS weight, SUM(quantity) AS quantity FROM inventory GROUP BY type, color, weight;";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string id = dataReader["id"] + "", type = dataReader["type"] + "", color = dataReader["color"] + "", weight = dataReader["weight"] + "", quantity = dataReader["quantity"] + "", subtotal = (Int32.Parse(weight) * Int32.Parse(quantity)).ToString();

                    string[] row = { id, type, color, weight, quantity, subtotal };
                    ListViewItem item = new ListViewItem(row);
                    listProduct.Items.Add(item);
                    
                }

                dataReader.Close();

                this.CloseConnection();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            listProduct.Items.Clear();

            string query = "SELECT inventory_id AS id, type, color, SUM(weight) AS weight, SUM(quantity) AS quantity FROM inventory WHERE type='" + cmbType.Text + "' AND color='" + cmbColor.Text + "' GROUP BY type, color, weight;";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string id = dataReader["id"] + "", type = dataReader["type"] + "", color = dataReader["color"] + "", weight = dataReader["weight"] + "", quantity = dataReader["quantity"] + "", subtotal = (Int32.Parse(weight) * Int32.Parse(quantity)).ToString();
                    string[] row = { id, type, color, weight, quantity, subtotal };
                    ListViewItem item = new ListViewItem(row);
                    listProduct.Items.Add(item);
                }

                dataReader.Close();

                this.CloseConnection();

            }
        }
    }
}
