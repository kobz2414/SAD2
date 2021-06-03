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
    public partial class frmStockOutDetails : Form
    {

        private MySqlConnection connection, connection2;
        private string server, database, database1, uid, password;
        private double totalWeight = 0;
        private string itemSubtotal, itemTotalWeight, itemPrice;

        public frmStockOutDetails()
        {
            InitializeComponent();
            Initialize();
            show();
        }

        public void show()
        {
            listInventory.Items.Clear();

            string query = "SELECT inventory_id AS id, type, color, SUM(weight) AS weight, SUM(quantity) AS quantity FROM inventory GROUP BY type, color, weight;";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string id = dataReader["id"] + "", type = dataReader["type"] + "", color = dataReader["color"] + "", weight = dataReader["weight"] + "", quantity = dataReader["quantity"] + "", totalWeight = (Int32.Parse(weight) * Int32.Parse(quantity)).ToString();

                    string[] row = { id, type, color, weight, quantity, totalWeight};
                    ListViewItem item = new ListViewItem(row);
                    listInventory.Items.Add(item);

                }

                dataReader.Close();

                CloseConnection();
            }
        }

        private void listInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listInventory.SelectedItems.Count < 1)
            {
                txtQuantity.Enabled = false;
                btnAdd.Enabled = false;

                txtQuantity.Text = "";
            }
            else
            {
                ListViewItem item = listInventory.SelectedItems[0];

                if (int.Parse(item.SubItems[4].Text) != 0)
                {
                    txtQuantity.Enabled = true;
                    btnAdd.Enabled = true;
                    txtQuantity.Text = item.SubItems[4].Text;
                    String itemID = item.Text;
                }
                else
                {
                    txtQuantity.Enabled = false;
                    btnAdd.Enabled = false;
                }
            }
        }

        private void listStockOutItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            txtQuantity.Enabled = false;
            txtQuantity.Text = "";

            listInventory.SelectedItems.Clear();

            if (listStockOutItems.SelectedItems.Count < 1)
            {
                btnRemove.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listStockOutItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                ListViewItem item = listStockOutItems.SelectedItems[0];

                int qty = int.Parse(item.SubItems[4].Text);
                string itemID = item.Text;

                txtQuantity.Text = "";

                bool check = false;

                foreach (ListViewItem eachItem in listInventory.Items)
                    if (eachItem.SubItems[0].Text == itemID)
                    {
                        int temp = int.Parse(eachItem.SubItems[4].Text);
                        int weight = int.Parse(eachItem.SubItems[3].Text);
                        eachItem.SubItems[4].Text = (temp + qty).ToString();
                        eachItem.SubItems[5].Text = ((temp + qty) * weight).ToString();
                        check = true;
                    }
                if (check == false)
                {
                    string[] row = { item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text };
                    var listViewItem = new ListViewItem(row);
                    listInventory.Items.Add(listViewItem);
                }

                item.Remove();

                totalWeight = 0;

                for (int i = 0; i < listStockOutItems.Items.Count; i++)
                {
                    totalWeight += double.Parse(listStockOutItems.Items[i].SubItems[5].Text);
                }

                txtTotal.Text = totalWeight.ToString();

                btnRemove.Enabled = false;
                btnAdd.Enabled = false;
                txtQuantity.Enabled = false;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!txtQuantity.Text.All(char.IsDigit))
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listInventory.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select an item");
                btnAdd.Enabled = false;
            }
            else
            {
                if (txtQuantity.Text != "" && txtQuantity.Text != "0")
                {
                    ListViewItem item = listInventory.SelectedItems[0];

                    int qty1 = int.Parse(item.SubItems[4].Text);
                    int qty2 = int.Parse(txtQuantity.Text);

                    if (qty1 - qty2 < 0)
                    {
                        MessageBox.Show("Must not be more or less than what is available");
                    }
                    else
                    {
                        itemTotalWeight = item.SubItems[5].Text;

                        int output = qty1 - qty2;
                        item.SubItems[4].Text = output.ToString();

                        int weight = int.Parse(item.SubItems[3].Text);
                        int qty3 = int.Parse(item.SubItems[4].Text);
                        item.SubItems[5].Text = (weight * qty3).ToString();

                        itemTotalWeight = (qty2 * weight).ToString();

                        string itemID = item.Text;

                        bool check = false;

                        foreach (ListViewItem eachItem in listStockOutItems.Items)
                            if (eachItem.SubItems[0].Text == itemID)
                            {
                                int temp = int.Parse(eachItem.SubItems[4].Text);
                                int updatedTemp = temp + qty2;
                                eachItem.SubItems[4].Text = (updatedTemp).ToString();
                                eachItem.SubItems[5].Text = (updatedTemp * weight).ToString();
                                check = true;
                            }

                        if (check == false)
                        {
                            string[] row = { item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, txtQuantity.Text, itemTotalWeight, itemPrice, itemSubtotal };
                            var listViewItem = new ListViewItem(row);
                            listStockOutItems.Items.Add(listViewItem);
                        }

                        //if (int.Parse(item.SubItems[5].Text) == 0)
                        //{
                        //    item.Remove();
                        //}

                        totalWeight = 0;

                        for (int i = 0; i < listStockOutItems.Items.Count; i++)
                        {
                            totalWeight += double.Parse(listStockOutItems.Items[i].SubItems[5].Text);
                        }

                        txtTotal.Text = totalWeight.ToString();
                        btnRemove.Enabled = false;
                        txtQuantity.Enabled = false;
                        txtQuantity.Text = "";
                        btnAdd.Enabled = false;
                    }
                }
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (listStockOutItems.Items.Count == 0)
            {
                MessageBox.Show("Please input items to cart");
            }
            else
            {
                try
                {
                    //string checkDuplicate = "SELECT CASE WHEN EXISTS ( SELECT transactionID FROM `db_cefinal`.`sales` WHERE transactionID = '" + txtTransactionNum.Text + "') THEN 'TRUE' ELSE 'FALSE' END as transactionID;";

                    //if (OpenConnection() == true)
                    //{
                    //    MySqlCommand cmd = new MySqlCommand(checkDuplicate, connection);
                    //    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //    while (dataReader.Read())
                    //    {
                    //        string temp = dataReader["transactionID"].ToString();
                    //        if (temp == "TRUE")
                    //        {
                    //            MessageBox.Show("Duplicate Transaction Number");
                    //        }
                    //    }
                    //    CloseConnection();
                    //}

                    string queryTransaction = "";
                    //Sales
                    queryTransaction = "insert into stockout(stockOutID, DateTime, Name) values('" + txtStockOutID.Text + "', now() ,'" + txtEmployee.Text + "');" +
                         "insert into stockrecordhistory(recordID, date, person, action) values('" + txtStockOutID.Text + "', now(),'" + txtEmployee.Text + "','Stock Out');";

                    //New table in transactions database
                    
                    queryTransaction = queryTransaction + "create table `db_stockoutdetails`.`" + txtStockOutID.Text + "`(itemID int not null, itemType varchar(255), itemColor varchar(255), itemWeight int, itemQuantity int, totalWeight int, primary" +
                        " key (itemID));";

                    //Add items from cart to database
                    foreach (ListViewItem eachItem in listStockOutItems.Items)
                    {
                        queryTransaction = queryTransaction + "insert into `db_stockoutdetails`.`" + txtStockOutID.Text + "`(itemID, itemType, itemColor, itemWeight, itemQuantity, totalWeight) values('" + int.Parse(eachItem.SubItems[0].Text) + "','" +
                        eachItem.SubItems[1].Text + "','" + eachItem.SubItems[2].Text + "','" + int.Parse(eachItem.SubItems[3].Text) + "','" + int.Parse(eachItem.SubItems[4].Text) + "','" + int.Parse(eachItem.SubItems[5].Text) + "');" +
                        "UPDATE `db_cefinal`.`inventory` SET quantity = quantity - " + int.Parse(eachItem.SubItems[4].Text) + " WHERE (`inventory_id` = '" + eachItem.SubItems[0].Text + "');";
                    }

                    if (OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(queryTransaction, connection);
                        cmd.ExecuteNonQuery();  
                    }


                    CloseConnection();

                    MessageBox.Show("Success");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                    CloseConnection();
                }

                frmStockRecordHistory temp = new frmStockRecordHistory();
                temp.Show();
                this.Hide();
            }
        }

        private void frmStockOutDetails_Load(object sender, EventArgs e)
        {

        }

        private void frmStockOutDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStockRecordHistory temp = new frmStockRecordHistory();
            temp.Show();
            this.Hide();
        }
    }
}
