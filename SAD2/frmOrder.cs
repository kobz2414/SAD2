using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAD2
{
    public partial class frmOrder : Form
    {
        private MySqlConnection connection, connection2;
        private string server, database, database1, uid, password;
        private string itemSubtotal, itemTotalWeight, itemPrice;
        private double subTotal = 0, totalWeight = 0;
        private bool checkNum = false, checkContact = false, checkName = false, checkAdd = false;


        public frmOrder()
        {
            InitializeComponent();
            Initialize();
            show();
            showCustomerProfiles();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listProduct.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                if (txtQuantity.Text != "" && txtQuantity.Text != "0")
                {
                    ListViewItem item = listProduct.SelectedItems[0];

                    int qty1 = int.Parse(item.SubItems[4].Text);
                    int qty2 = int.Parse(txtQuantity.Text);

                    if (qty1 - qty2 < 0)
                    {
                        MessageBox.Show("Must not be more or less than what is available");
                    }
                    else if (txtPrice.Text == "")
                    {
                        MessageBox.Show("Please input price");
                    }
                    else
                    {
                        itemPrice = txtPrice.Text;
                        itemTotalWeight = item.SubItems[5].Text;

                        int output = qty1 - qty2;
                        item.SubItems[4].Text = output.ToString();

                        int price = int.Parse(itemPrice);
                        int weight = int.Parse(item.SubItems[3].Text);
                        int qty3 = int.Parse(item.SubItems[4].Text);
                        item.SubItems[5].Text = (weight * qty3).ToString();

                        itemTotalWeight = (qty2 * weight).ToString();
                        itemSubtotal = (price * int.Parse(itemTotalWeight)).ToString();

                        string itemID = item.Text;

                        bool check = false;

                        foreach (ListViewItem eachItem in listCart.Items)
                            if (eachItem.SubItems[0].Text == itemID)
                            {
                                int temp = int.Parse(eachItem.SubItems[4].Text);
                                int updatedTemp = temp + qty2;
                                eachItem.SubItems[4].Text = (updatedTemp).ToString();
                                eachItem.SubItems[5].Text = (updatedTemp * weight).ToString();
                                eachItem.SubItems[7].Text = (price * (updatedTemp * weight)).ToString();
                                check = true;
                            }

                        if (check == false)
                        {
                            string[] row = { item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, txtQuantity.Text, itemTotalWeight, itemPrice, itemSubtotal };
                            var listViewItem = new ListViewItem(row);
                            listCart.Items.Add(listViewItem);
                        }

                        //if (int.Parse(item.SubItems[5].Text) == 0)
                        //{
                        //    item.Remove();
                        //}

                        subTotal = 0;
                        totalWeight = 0;

                        for (int i = 0; i < listCart.Items.Count; i++)
                        {
                            totalWeight += double.Parse(listCart.Items[i].SubItems[5].Text);
                        }

                        for (int i = 0; i < listCart.Items.Count; i++)
                        {
                            subTotal += double.Parse(listCart.Items[i].SubItems[7].Text);
                        }

                        txtTotalWeight.Text = totalWeight.ToString();
                        txtSubtotal.Text = subTotal.ToString();
                        txtQuantity.Text = "";
                        txtPrice.Text = "";
                        btnRemove.Enabled = false;
                        btnAdd.Enabled = false;
                        txtPrice.Enabled = false;
                        txtQuantity.Enabled = false;
                    }
                }
            }
            
        }


        private void listProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProduct.SelectedItems.Count < 1)
            {
                btnAdd.Enabled = false;
                txtPrice.Enabled = false;
                txtQuantity.Enabled = false;

                txtPrice.Text = "";
                txtQuantity.Text = "";
            }
            else
            {
                ListViewItem item = listProduct.SelectedItems[0];

                if(int.Parse(item.SubItems[4].Text) != 0)
                {
                    btnAdd.Enabled = true;

                    txtPrice.Enabled = true;
                    txtQuantity.Enabled = true;

                    txtQuantity.Text = item.SubItems[4].Text;
                    String itemID = item.Text;

                    foreach (ListViewItem eachItem in listCart.Items)
                    {
                        if (eachItem.SubItems[0].Text == itemID)
                        {
                            txtPrice.Enabled = false;
                            txtPrice.Text = eachItem.SubItems[6].Text;
                            break;
                        }
                        else
                        {
                            txtPrice.Enabled = true;
                            txtPrice.Text = "";
                        }
                    }
                }
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if(txtAddress.Text == "")
            {
                checkAdd = false;
            }
            else
            {
                checkAdd = true;
                if (checkNum == true && checkContact == true && checkName == true && checkAdd == true)
                {
                    btnAccept.Enabled = true;
                }
            }
        }

        private void txtDateandTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (listCart.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an item");
                }
                else
                {
                    ListViewItem item = listCart.SelectedItems[0];

                    int qty = int.Parse(item.SubItems[4].Text);
                    string itemID = item.Text;

                    txtPrice.Enabled = true;
                    txtPrice.Text = "";
                    txtQuantity.Text = "";

                    bool check = false;

                    foreach (ListViewItem eachItem in listProduct.Items)
                        if (eachItem.SubItems[0].Text == itemID)
                        {
                            int temp = int.Parse(eachItem.SubItems[4].Text);
                            int weight = int.Parse(eachItem.SubItems[3].Text);
                            eachItem.SubItems[4].Text = (temp + qty).ToString();
                            eachItem.SubItems[5].Text = ((temp + qty) * weight).ToString();
                            check = true;
                        }
                    if(check == false)
                    {
                        string[] row = { item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text };
                        var listViewItem = new ListViewItem(row);
                        listProduct.Items.Add(listViewItem);
                    }

                    item.Remove();

                    subTotal = 0;
                    totalWeight = 0;

                    for (int i = 0; i < listCart.Items.Count; i++)
                    {
                        totalWeight += double.Parse(listCart.Items[i].SubItems[5].Text);
                    }

                    for (int i = 0; i < listCart.Items.Count; i++)
                    {
                        subTotal += double.Parse(listCart.Items[i].SubItems[7].Text);
                    }

                    txtTotalWeight.Text = totalWeight.ToString();
                    txtSubtotal.Text = subTotal.ToString();

                    btnRemove.Enabled = false;
                    btnAdd.Enabled = false;
                    txtPrice.Enabled = false;
                    txtQuantity.Enabled = false;

                }
            }
            catch (Exception err)
            {

            }
            
        }

        private void cmbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int space1 = cmbProfile.SelectedItem.ToString().IndexOf(' ');
            string firstPart = cmbProfile.SelectedItem.ToString().Substring(0, space1);

            string query = "SELECT * FROM db_cefinal.customers where customerID = '" + firstPart + "';";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string name = dataReader["name"] + "",
                           address = dataReader["address"] + "",
                           number = dataReader["contactnumber"] + "";

                    txtName.Text = name;
                    txtAddress.Text = address;
                    txtContactNum.Text = number;

                }

                dataReader.Close();

                CloseConnection();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer temp = new frmAddCustomer(1);
            temp.ShowDialog();
            showCustomerProfiles();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

            if(txtName.Text == "")
            {
                checkName = false;
            }
            else
            {
                checkName = true;
                if (checkNum == true && checkContact == true && checkName == true && checkAdd == true)
                {
                    btnAccept.Enabled = true;
                }
            }
        }

        private void listCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            txtPrice.Enabled = false;
            txtQuantity.Enabled = false;
            txtPrice.Text = "";
            txtQuantity.Text = "";

            listProduct.SelectedItems.Clear();

            if (listCart.SelectedItems.Count < 1)
            {
                btnRemove.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
            }
        }

        private void txtTransactionNum_TextChanged(object sender, EventArgs e)
        {
            if (!txtTransactionNum.Text.All(char.IsDigit))
            {
                
                btnAccept.Enabled = false;
                checkNum = false;
                lblTransactionNumberPrompt.Text = "Must enter all in digits";
            }
            else
            {

                try
                {
                    string checkDuplicate = "SELECT CASE WHEN EXISTS ( SELECT transactionID FROM `db_cefinal`.`sales` WHERE transactionID = '" + txtTransactionNum.Text + "') THEN 'TRUE' ELSE 'FALSE' END as transactionID;";

                    if (OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(checkDuplicate, connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        while (dataReader.Read())
                        {
                            string temp = dataReader["transactionID"].ToString();
                            if (temp == "TRUE")
                            {
                                btnAccept.Enabled = false;
                                checkNum = false;
                                lblTransactionNumberPrompt.Text = "Duplicate Transaction Number";
                            }
                            else
                            {
                                checkNum = true;
                                if (checkNum == true)
                                {
                                    lblTransactionNumberPrompt.Text = "   ";
                                    if(checkContact == true && checkName == true && checkAdd == true)
                                    {
                                        btnAccept.Enabled = true;
                                    }
                                }
                            }
                        }
                        CloseConnection();
                    }
                }
                catch (Exception err)
                {
                    CloseConnection();
                }
            }
        }

        private void txtContactNum_TextChanged(object sender, EventArgs e)
        {
            if (txtContactNum.Text == "")
            {
                btnAccept.Enabled = false;
                checkContact = false;
            }
            else if (!txtContactNum.Text.All(char.IsDigit))
            {
                btnAccept.Enabled = false;
                checkContact = false;
            }
            else
            {
                checkContact = true;
                if (checkNum == true && checkContact == true && checkName == true && checkAdd == true)
                {
                    btnAccept.Enabled = true;
                }
            }
        }

        private void frmOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                frmMainMenu temp = new frmMainMenu();
                frmOrder temp2 = new frmOrder();
                temp.Show();
                temp2.Hide();
            }
            else
            {
                e.Cancel = true;
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

        public void show()
        {
            listProduct.Items.Clear();

            string query = "SELECT inventory_id AS id, type, color, SUM(weight) AS weight, SUM(quantity) AS quantity FROM inventory GROUP BY type, color, weight;";

            if (OpenConnection() == true)
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

                CloseConnection();
            }
        }

        public void showCustomerProfiles()
        {
            cmbProfile.Items.Clear();

            string query = "SELECT customerID, name, address from db_cefinal.customers";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string id = dataReader["customerID"] + "", name = dataReader["name"] + "", address = dataReader["address"] + "";

                    cmbProfile.Items.Add(id + " - " + name + " - " + address);

                }

                dataReader.Close();

                CloseConnection();
            }
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDateandTime.Text = DateTime.Now.ToString("dddd, MMMM-dd-yyyy hh:mm:ss");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            if (listCart.Items.Count == 0)
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


                    //Sales
                    string query = "insert into sales(transactionID, DateTime, Name, Address, ContactNumber, Status) values('" + txtTransactionNum.Text + "', now() ,'" + txtName.Text + "','" + txtAddress.Text + "','" + txtContactNum.Text + "', 'Unpaid');" +
                         "insert into stockrecordhistory(recordID, date, person, action) values('" + txtTransactionNum.Text + "', now(),'" + txtName.Text + "','Stock Out');";

                    //New table in transactions database
                    string queryTransaction = "";
                    queryTransaction = "create table `" + txtTransactionNum.Text + "`(itemID int not null, itemType varchar(255), itemColor varchar(255), itemWeight int, itemQuantity int, totalWeight int, price int, subtotal int, primary" +
                        " key (itemID));";

                    //New table in transactions database
                    queryTransaction += "CREATE TABLE `db_payments`.`" + txtTransactionNum.Text + "` (paymentID int not null AUTO_INCREMENT, Date varchar(255), ModeOfPayment varchar(255), AccountNumber int, AccountName varchar(255), Amount int, primary" +
                        " key (paymentID)) ENGINE = InnoDB AUTO_INCREMENT = 0;";

                    //Add items from cart to database
                    foreach (ListViewItem eachItem in listCart.Items)
                    {
                        queryTransaction = queryTransaction + "insert into `" + txtTransactionNum.Text + "`(itemID, itemType, itemColor, itemWeight, itemQuantity, totalWeight, price, subtotal) values('" + int.Parse(eachItem.SubItems[0].Text) + "','" +
                        eachItem.SubItems[1].Text + "','" + eachItem.SubItems[2].Text + "','" + int.Parse(eachItem.SubItems[3].Text) + "','" + int.Parse(eachItem.SubItems[4].Text) + "','" + int.Parse(eachItem.SubItems[5].Text) + "','" + int.Parse(eachItem.SubItems[6].Text) + "','" + int.Parse(eachItem.SubItems[7].Text) + "');" +
                        "UPDATE `db_cefinal`.`inventory` SET quantity = quantity - " + int.Parse(eachItem.SubItems[4].Text) + " WHERE (`inventory_id` = '" + eachItem.SubItems[0].Text + "');";
                    }

                    if (OpenConnection() == true)
                    {
                        MySqlCommand cmd2 = new MySqlCommand(queryTransaction, connection2);
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                    }


                    CloseConnection();

                    MessageBox.Show("Order added to cart");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                    CloseConnection();
                }

            frmMainMenu temp = new frmMainMenu();
            temp.Show();
            this.Hide();
            }
        }
    }
}
