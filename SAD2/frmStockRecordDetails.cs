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
    public partial class frmStockRecordDetails : Form
    {
        private MySqlConnection connection;
        private string server, database, uid, password;
        private string action, id;

        public frmStockRecordDetails(string id, string action)
        {
            this.action = action;
            this.id = id;
            InitializeComponent();
            Initialize();
        }

        private void frmStockRecordDetails_Load(object sender, EventArgs e)
        {
            string query = "";

            if (action == "Stock In")
            {
                query = "SELECT * FROM `db_cefinal`.`stockin` where stockin_id = " + id + ";";
                txtAction.Text = "Stock In";

                try
                {
                    if (OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        while (dataReader.Read())
                        {
                            string id = dataReader["stockin_id"] + "",
                                   date = dataReader["date"] + "",
                                   staff = dataReader["staff"] + "";

                            txtID.Text = id;
                            txtDateAndTime.Text = date;
                            txtEmployee.Text = staff;
                            lblEmployee.Text = "        Staff";
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
            else if(action == "Stock Out")
            {
                query = "SELECT * FROM `db_cefinal`.`stockout` where stockOutID = " + id + ";";
                txtAction.Text = "Stock Out";

                try
                {
                    if (OpenConnection() == true)   
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        while (dataReader.Read())
                        {
                            string id = dataReader["stockOutID"] + "",
                                   date = dataReader["DateTime"] + "",
                                   staff = dataReader["Name"] + "";

                            txtID.Text = id;
                            txtDateAndTime.Text = date;
                            txtEmployee.Text = staff;
                            lblEmployee.Text = "        Staff";
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
            else if (action == "Sale")
            {
                query = "SELECT * FROM `db_cefinal`.`sales` where transactionID = " + id + ";";
                txtAction.Text = "Sale";

                try
                {
                    if (OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        while (dataReader.Read())
                        {
                            string id = dataReader["transactionID"] + "",
                                   date = dataReader["DateTime"] + "",
                                   customerID = dataReader["customerID"] + "";

                            dataReader.Close();

                            query = "SELECT Name FROM `db_cefinal`.`customers` where customerID = '" + customerID + "';";
                            string customerName = "";
                            cmd = new MySqlCommand(query, connection);
                            dataReader = cmd.ExecuteReader();

                            while (dataReader.Read())
                            {
                                customerName = dataReader["Name"] + "";
                            }

                            txtID.Text = id;
                            txtDateAndTime.Text = date;
                            txtEmployee.Text = customerName;
                            lblEmployee.Text = "   Sold To";
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



            if (action == "Stock In")
            {
                query = "SELECT * FROM db_stockindetails.`" + id + "`";
                try
                {
                    if (OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        listItems.Columns[5].Text = "totalWeight";

                        while (dataReader.Read())
                        {
                            string id = dataReader["itemID"] + "",
                                   type = dataReader["itemType"] + "",
                                   color = dataReader["itemColor"] + "",
                                   weight = dataReader["itemWeight"] + "",
                                   quantity = dataReader["itemQuantity"] + "",
                                   subtotal = dataReader["subtotal"] + "";
                            string[] row = { id, type, color, weight, quantity, subtotal };
                            ListViewItem item = new ListViewItem(row);
                            listItems.Items.Add(item);
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
            else if (action == "Sale")
            {
                query = "SELECT * FROM db_transactions.`" + id + "`";
                try
                {
                    if (OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        listItems.Columns[5].Text = "Total Weight";

                        while (dataReader.Read())
                        {
                            string id = dataReader["itemID"] + "",
                                   type = dataReader["itemType"] + "",
                                   color = dataReader["itemColor"] + "",
                                   weight = dataReader["itemWeight"] + "",
                                   quantity = dataReader["itemQuantity"] + "",
                                   totalWeight = dataReader["totalWeight"] + "";
                            string[] row = { id, type, color, weight, quantity, totalWeight};
                            ListViewItem item = new ListViewItem(row);
                            listItems.Items.Add(item);
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
            else if (action == "Stock Out")
            {
                query = "SELECT * FROM db_stockoutdetails.`" + id + "`;";
                txtAction.Text = "Sale";

                try
                {
                    if (OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        listItems.Columns[5].Text = "totalWeight";

                        while (dataReader.Read())
                        {
                            string id = dataReader["itemID"] + "",
                                   type = dataReader["itemType"] + "",
                                   color = dataReader["itemColor"] + "",
                                   weight = dataReader["itemWeight"] + "",
                                   quantity = dataReader["itemQuantity"] + "",
                                   subtotal = dataReader["totalWeight"] + "";
                            string[] row = { id, type, color, weight, quantity, subtotal };
                            ListViewItem item = new ListViewItem(row);
                            listItems.Items.Add(item);
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
