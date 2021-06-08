using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.ListViewItem;

namespace SAD2
{
    public partial class frmStockinDetailsAdd : Form
    {
        private MySqlConnection connection;
        private string server, database, uid, password;
        private string itemTotalWeight;
        private double totalWeight = 0;
        private List<string> employees = new List<string>();
        private static readonly Random getrandom = new Random();

        public frmStockinDetailsAdd()
        {
            InitializeComponent();
            Initialize();
            showEmployeeProfiles();
            show();
            checkStockID();
        }

        public void checkStockID()
        {
            string stockInID = GetRandomNumber(400000000, 699999999).ToString();
            string checkDuplicate = "SELECT CASE WHEN EXISTS ( SELECT recordID FROM db_cefinal.stockrecordhistory WHERE recordID = '" + stockInID + "') THEN 'TRUE' ELSE 'FALSE' END as recordID;";
            string temp2 = "";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(checkDuplicate, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                string temp = dataReader["recordID"].ToString();
                if (temp == "FALSE")
                {
                    txtStockInID.Text = stockInID;
                }
                else if (temp == "TRUE")
                {
                    CloseConnection();
                    dataReader.Close();
                    checkStockID();
                }
                dataReader.Close();
                CloseConnection();
            }
        }

        public int GetRandomNumber(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }

        public void showEmployeeProfiles()
        {
            cmbEmployees.Items.Clear();

            string query = "SELECT employeeID, name, address from db_cefinal.employees";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string id = dataReader["employeeID"] + "", name = dataReader["name"] + "", address = dataReader["address"] + "";
                    employees.Add(name);
                    cmbEmployees.Items.Add(id + " - " + name + " - " + address);

                }

                dataReader.Close();

                CloseConnection();
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

        private void frmStockinDetailsAdd_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void frmStockinDetailsAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStockRecordHistory temp = new frmStockRecordHistory();
            temp.Show();
            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void txtDateandTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDateandTime.Text = DateTime.Now.ToString("dddd, MMMM-dd-yyyy hh:mm:ss");
        }

        private void btnAddDeleteItem_Click(object sender, EventArgs e)
        {
            frmAddDeleteInventoryItems temp = new frmAddDeleteInventoryItems();
            temp.ShowDialog();
            show();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (listProduct.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select an item");
            }else if (!txtQuantity.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please input a numeric value (Quantity)");
            }
            else
            {
                ListViewItem item = listProduct.SelectedItems[0];

                if (int.Parse(txtQuantity.Text) <= 0)
                {
                    MessageBox.Show("Must not be less than or equal to 0");
                }
                else
                {
                    int weight = int.Parse(item.SubItems[3].Text);
                    int quantity = int.Parse(txtQuantity.Text);
                    itemTotalWeight = (quantity * weight).ToString();

                    string itemID = item.Text;
                    bool check = false;

                    foreach (ListViewItem eachItem in listCart.Items)
                        if (eachItem.SubItems[0].Text == itemID)
                        {
                            int temp = int.Parse(eachItem.SubItems[4].Text);
                            int updatedTemp = temp + quantity;
                            eachItem.SubItems[4].Text = (updatedTemp).ToString();
                            eachItem.SubItems[5].Text = (updatedTemp * weight).ToString();
                            check = true;
                        }

                    if (check == false)
                    {
                        string[] row = { item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, txtQuantity.Text, itemTotalWeight};
                        var listViewItem = new ListViewItem(row);
                        listCart.Items.Add(listViewItem);
                    }

                    totalWeight = 0;

                    for (int i = 0; i < listCart.Items.Count; i++)
                    {
                        totalWeight += double.Parse(listCart.Items[i].SubItems[5].Text);
                    }

                    txtTotalWeight.Text = totalWeight.ToString();
                    txtQuantity.Text = "";
                    btnRemove.Enabled = false;
                    btnAdd.Enabled = false;
                    txtQuantity.Enabled = false;
                }
            }
        }

        private void listProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProduct.SelectedItems.Count < 1)
            {
                btnAdd.Enabled = false;
                txtQuantity.Enabled = false;

                txtQuantity.Text = "";
            }
            else
            {
                ListViewItem item = listProduct.SelectedItems[0];
                btnAdd.Enabled = true;
                txtQuantity.Enabled = true;
                String itemID = item.Text;
            }
        }

        private void listCart_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listCart.SelectedItems.Count < 1)
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
            try
            {
                if (listCart.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an item");
                }
                else
                {
                    ListViewItem item = listCart.SelectedItems[0];

                    txtQuantity.Text = "";

                    item.Remove();
                    totalWeight = 0;

                    for (int i = 0; i < listCart.Items.Count; i++)
                    {
                        totalWeight += double.Parse(listCart.Items[i].SubItems[5].Text);
                    }

                    txtTotalWeight.Text = totalWeight.ToString();

                    btnRemove.Enabled = false;
                    btnAdd.Enabled = false;
                    txtQuantity.Enabled = false;

                }
            }
            catch (Exception err)
            {

            }
        }

        private void txtStockOutID_TextChanged(object sender, EventArgs e)
        {
           
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

        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployees.Text == "")
            {

                btnStockin.Enabled = false;
            }
            else
            {
                btnStockin.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmStockRecordHistory temp = new frmStockRecordHistory();
            temp.Show();
            this.Hide();
        }

        private void btnStockin_Click(object sender, EventArgs e)
        {
            if (listCart.Items.Count == 0)
            {
                MessageBox.Show("Please input items to cart");
            }
            else
            {


                string query = "INSERT INTO `db_cefinal`.`stockin` (`stockin_id`, `date`, `staff`) VALUES(" + txtStockInID.Text + ", now(), '" + employees[int.Parse(cmbEmployees.SelectedIndex.ToString())] + "');" +
                           "create table `db_stockindetails`.`" + txtStockInID.Text + "`(itemID varchar(255) not null, itemType varchar(255), itemColor varchar(255), itemWeight int, itemQuantity int, subtotal int, primary key (itemID));" +
                           "INSERT INTO `db_cefinal`.`stockrecordhistory` (`recordID`, `date`, `person`, `action`) VALUES(" + txtStockInID.Text + ", now(), '" + employees[int.Parse(cmbEmployees.SelectedIndex.ToString())] + "', 'Stock In');";

                foreach (ListViewItem eachItem in listCart.Items)
                {
                    query = query + "insert into `db_stockindetails`.`" + txtStockInID.Text + "`(itemID, itemType, itemColor, itemWeight, itemQuantity, subtotal) values('" + int.Parse(eachItem.SubItems[0].Text) + "','" +
                    eachItem.SubItems[1].Text + "','" + eachItem.SubItems[2].Text + "','" + int.Parse(eachItem.SubItems[3].Text) + "','" + int.Parse(eachItem.SubItems[4].Text) + "','" + int.Parse(eachItem.SubItems[5].Text) + "');" +
                    "INSERT INTO `db_cefinal`.`inventory`(inventory_id, type, color, weight, quantity) VALUES('" + int.Parse(eachItem.SubItems[0].Text) + "','" +
                    eachItem.SubItems[1].Text + "','" + eachItem.SubItems[2].Text + "','" + int.Parse(eachItem.SubItems[3].Text) + "','" + int.Parse(eachItem.SubItems[4].Text) + "')" +
                    " ON DUPLICATE KEY UPDATE quantity = quantity + " + int.Parse(eachItem.SubItems[4].Text) + ";";
                }

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }

                MessageBox.Show("Success");
                frmStockRecordHistory temp = new frmStockRecordHistory();
                temp.Show();
                this.Hide();
            }
        }

    }
}
