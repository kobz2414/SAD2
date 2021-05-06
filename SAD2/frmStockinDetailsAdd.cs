using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace SAD2
{
    public partial class frmStockinDetailsAdd : Form
    {
        private MySqlConnection connection;
        private string server, database, uid, password;
        private string itemTotalWeight;
        private double totalWeight = 0;

        public frmStockinDetailsAdd(string id, string staff)
        {
            InitializeComponent();
            Initialize();
            show();
            txtStockID.Text = id;
            txtEmployee.Text = staff;
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

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    //string query = "INSERT INTO stockin_details(type, color, weight, quantity, stockin_id) VALUES('" + txtType.Text + "', '" + txtColor.Text + "', " + txtWeight.Text + ", " + txtQuantity.Text + ", " + txtStockID.Text + ");";

        //    //if (this.OpenConnection() == true)
        //    //{
        //    //    MySqlCommand cmd = new MySqlCommand(query, connection);
        //    //    cmd.ExecuteNonQuery();
        //    //    this.CloseConnection();
        //    //}
        //    //show();
        //    string id = txtID.Text;
        //    string type = cmbType.Text;
        //    string color = cmbColor.Text;
        //    string weight = cmbWeight.Text;
        //    string quantity = txtQuantity.Text;
        //    string subtotal = txtSubtotal.Text;
        //    double total = 0;

        //    if (id != "" && type != "" && color != "" && weight != "" && quantity != "")
        //    {
        //        string[] row = { id, type, color, weight, quantity, subtotal };
        //        ListViewItem item = new ListViewItem(row);
        //        listCart.Items.Add(item);

        //        txtID.Text = "";
        //        cmbType.Text = "";
        //        cmbColor.Text = "";
        //        cmbWeight.Text = "";
        //        txtQuantity.Text = "";
        //        txtSubtotal.Text = "";

        //        for (int i = 0; i < listCart.Items.Count; i++)
        //        {
        //            total += double.Parse(listCart.Items[i].SubItems[5].Text);
        //        }

        //        txtTotal.Text = total.ToString();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please input the complete details");
        //    }

        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    //string query = "DELETE FROM stockin_details WHERE stockin_details_id=" + listCart.SelectedItems[0].SubItems[0].Text + ";";

        //    //if (this.OpenConnection() == true)
        //    //{
        //    //    MySqlCommand cmd = new MySqlCommand(query, connection);
        //    //    cmd.ExecuteNonQuery();
        //    //    this.CloseConnection();
        //    //}
        //    //show();

        //    try
        //    {
        //        if (listCart.SelectedItems.Count == 0)
        //        {
        //            MessageBox.Show("Please select an item");
        //        }
        //        else
        //        {
        //            ListViewItem item = listCart.SelectedItems[0];
        //            item.Remove();

        //            txtID.Text = "";
        //            cmbType.Text = "";
        //            cmbColor.Text = "";
        //            cmbWeight.Text = "";
        //            txtQuantity.Text = "";
        //            txtSubtotal.Text = "";
        //            double total = 0;

        //            for (int i = 0; i < listCart.Items.Count; i++)
        //            {
        //                total += double.Parse(listCart.Items[i].SubItems[5].Text);
        //            }

        //            txtTotal.Text = total.ToString();
        //        }
        //    }
        //    catch (Exception err)
        //    {

        //    }
        //}

        private void frmStockinDetailsAdd_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    cmbType.Items.Clear();

            //    string query = "SELECT DISTINCT type FROM db_cefinal.products;";

            //    if (this.OpenConnection() == true)
            //    {
            //        MySqlCommand cmd = new MySqlCommand(query, connection);
            //        MySqlDataReader dataReader = cmd.ExecuteReader();

            //        while (dataReader.Read())
            //        {
            //            cmbType.Items.Add(dataReader["type"]);
            //        }

            //        dataReader.Close();

            //        this.CloseConnection();
            //    }
            //}
            //catch (Exception err)
            //{

            //}

            timer1.Enabled = true;
        }

        private void txtStockID_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
        }

        //private void txtQuantity_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtQuantity.Text.All(char.IsDigit))
        //    {
        //        if (txtQuantity.Text != "" && cmbWeight.Text != "" && cmbWeight.Text.All(char.IsDigit))
        //        {
        //            txtSubtotal.Text = (int.Parse(txtQuantity.Text) * int.Parse(cmbWeight.Text)).ToString();
        //        }
        //        else
        //        {
        //            txtSubtotal.Text = "";
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter a numeric value");
        //        txtQuantity.Text = "";
        //    }
            
        //}

        //private void txtWeight_TextChanged(object sender, EventArgs e)
        //{
        //    if (cmbWeight.Text.All(char.IsDigit))
        //    {
        //        if (txtQuantity.Text != "" && cmbWeight.Text != "" && txtQuantity.Text.All(char.IsDigit))
        //        {
        //            txtSubtotal.Text = (int.Parse(txtQuantity.Text) * int.Parse(cmbWeight.Text)).ToString();
        //        }
        //        else
        //        {
        //            txtSubtotal.Text = "";
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter a numeric value");
        //        cmbWeight.Text = "";
        //    }
        //}

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

        //private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbType.Text != "")
        //    {
        //        cmbColor.Enabled = true;
        //    }
        //    else {
        //        cmbColor.Enabled = false;
        //    }

        //    try
        //    {
        //        cmbColor.Items.Clear();

        //        string query = "SELECT DISTINCT color FROM db_cefinal.products where type = '" + cmbType.Text + "';";

        //        if (this.OpenConnection() == true)
        //        {
        //            MySqlCommand cmd = new MySqlCommand(query, connection);
        //            MySqlDataReader dataReader = cmd.ExecuteReader();
        //            cmbColor.Text = "";
        //            cmbWeight.Text = "";
        //            txtID.Text = "";
        //            cmbWeight.Enabled = false;

        //            while (dataReader.Read())
        //            {
        //                cmbColor.Items.Add(dataReader["color"]);
        //            }

        //            dataReader.Close();

        //            this.CloseConnection();
        //        }
        //    }
        //    catch (Exception err)
        //    {

        //    }
        //}

        //private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbColor.Text != "")
        //    {
        //        cmbWeight.Enabled = true;
        //    }
        //    else
        //    {
        //        cmbWeight.Enabled = false;
        //    }

        //    try
        //    {
        //        cmbWeight.Items.Clear();

        //        string query = "SELECT DISTINCT weight FROM db_cefinal.products where type = '" + cmbType.Text +"' and color = '" + cmbColor.Text + "';";

        //        if (this.OpenConnection() == true)
        //        {
        //            MySqlCommand cmd = new MySqlCommand(query, connection);
        //            MySqlDataReader dataReader = cmd.ExecuteReader();
        //            cmbWeight.Text = "";
        //            txtID.Text = "";

        //            while (dataReader.Read())
        //            {
        //                cmbWeight.Items.Add(dataReader["weight"]);
        //            }

        //            dataReader.Close();

        //            this.CloseConnection();
        //        }
        //    }
        //    catch (Exception err)
        //    {

        //    }
        //}

        //private void cmbWeight_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string query = "SELECT itemid FROM db_cefinal.products where type = '" + cmbType.Text + "' and color = '" + cmbColor.Text + "' and weight = '" + cmbWeight.Text + "';";

        //        if (this.OpenConnection() == true)
        //        {
        //            MySqlCommand cmd = new MySqlCommand(query, connection);
        //            MySqlDataReader dataReader = cmd.ExecuteReader();

        //            while (dataReader.Read())
        //            {
        //                txtID.Text = dataReader["itemid"].ToString();
        //            }

        //            dataReader.Close();

        //            this.CloseConnection();
        //        }
        //    }
        //    catch (Exception err)
        //    {

        //    }
        //}

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
            }
            else
            {
                //if (txtQuantity.Text != "" && txtQuantity.Text != "0")
                //{
                    ListViewItem item = listProduct.SelectedItems[0];

                    //int qty1 = int.Parse(item.SubItems[4].Text);
                    //int qty2 = int.Parse(txtQuantity.Text);

                    if (int.Parse(txtQuantity.Text) <= 0)
                    {
                        MessageBox.Show("Must not be less than or equal to 0");
                    }
                    else
                    {
                        //itemTotalWeight = item.SubItems[5].Text;

                        //item.SubItems[4].Text = txtQuantity.Text;

                        //int price = int.Parse(itemPrice);
                        int weight = int.Parse(item.SubItems[3].Text);
                        int quantity = int.Parse(txtQuantity.Text);
                        itemTotalWeight = (quantity * weight).ToString();
                        //item.SubItems[5].Text = itemTotalWeight.ToString();
                        //itemSubtotal = (price * int.Parse(itemTotalWeight)).ToString();

                        string itemID = item.Text;
                        bool check = false;

                        foreach (ListViewItem eachItem in listCart.Items)
                            if (eachItem.SubItems[0].Text == itemID)
                            {
                                int temp = int.Parse(eachItem.SubItems[4].Text);
                                int updatedTemp = temp + quantity;
                                eachItem.SubItems[4].Text = (updatedTemp).ToString();
                                eachItem.SubItems[5].Text = (updatedTemp * weight).ToString();
                                //eachItem.SubItems[7].Text = (price * (updatedTemp * weight)).ToString();
                                check = true;
                            }

                        if (check == false)
                        {
                            string[] row = { item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, txtQuantity.Text, itemTotalWeight};
                            var listViewItem = new ListViewItem(row);
                            listCart.Items.Add(listViewItem);
                        }

                        //if (int.Parse(item.SubItems[5].Text) == 0)
                        //{
                        //    item.Remove();
                        //}

                        //subTotal = 0;
                        totalWeight = 0;

                        for (int i = 0; i < listCart.Items.Count; i++)
                        {
                            totalWeight += double.Parse(listCart.Items[i].SubItems[5].Text);
                        }

                        //for (int i = 0; i < listCart.Items.Count; i++)
                        //{
                        //    subTotal += double.Parse(listCart.Items[i].SubItems[7].Text);
                        //}

                        txtTotalWeight.Text = totalWeight.ToString();
                        //txtSubtotal.Text = subTotal.ToString();
                        txtQuantity.Text = "";
                        //txtPrice.Text = "";
                        btnRemove.Enabled = false;
                        btnAdd.Enabled = false;
                        //txtPrice.Enabled = false;
                        txtQuantity.Enabled = false;
                    }
                //}
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

                //if (int.Parse(item.SubItems[4].Text) != 0)
                //{
                    btnAdd.Enabled = true;

                    txtQuantity.Enabled = true;

                    //txtQuantity.Text = item.SubItems[4].Text;
                    String itemID = item.Text;

                    //foreach (ListViewItem eachItem in listCart.Items)
                    //{
                    //    if (eachItem.SubItems[0].Text == itemID)
                    //    {
                    //        txtPrice.Enabled = false;
                    //        txtPrice.Text = eachItem.SubItems[6].Text;
                    //        break;
                    //    }
                    //    else
                    //    {
                    //        txtPrice.Enabled = true;
                    //        txtPrice.Text = "";
                    //    }
                    //}
                //}
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

                    //int qty = int.Parse(item.SubItems[4].Text);
                    //string itemID = item.Text;

                    //txtPrice.Enabled = true;
                    //txtPrice.Text = "";
                    txtQuantity.Text = "";

                    //bool check = false;

                    //foreach (ListViewItem eachItem in listProduct.Items)
                    //    if (eachItem.SubItems[0].Text == itemID)
                    //    {
                    //        int temp = int.Parse(eachItem.SubItems[4].Text);
                    //        int weight = int.Parse(eachItem.SubItems[3].Text);
                    //        eachItem.SubItems[4].Text = (temp + qty).ToString();
                    //        eachItem.SubItems[5].Text = ((temp + qty) * weight).ToString();
                    //        check = true;
                    //    }
                    //if (check == false)
                    //{
                    //    string[] row = { item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text };
                    //    var listViewItem = new ListViewItem(row);
                    //    listProduct.Items.Add(listViewItem);
                    //}

                    item.Remove();

                    //subTotal = 0;
                    totalWeight = 0;

                    for (int i = 0; i < listCart.Items.Count; i++)
                    {
                        totalWeight += double.Parse(listCart.Items[i].SubItems[5].Text);
                    }

                    //for (int i = 0; i < listCart.Items.Count; i++)
                    //{
                    //    subTotal += double.Parse(listCart.Items[i].SubItems[7].Text);
                    //}

                    txtTotalWeight.Text = totalWeight.ToString();
                    //txtSubtotal.Text = subTotal.ToString();

                    btnRemove.Enabled = false;
                    btnAdd.Enabled = false;
                    //txtPrice.Enabled = false;
                    txtQuantity.Enabled = false;

                }
            }
            catch (Exception err)
            {

            }
        }

        private void listCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListViewItem item1 = listCart.SelectedItems[0];
            //txtID.Text = item1.SubItems[0].Text;
            //txtType.Text = item1.SubItems[1].Text;
            //txtColor.Text = item1.SubItems[2].Text;
            //txtWeight.Text = item1.SubItems[3].Text;
            //txtQuantity.Text = item1.SubItems[4].Text;
            //txtSubtotal.Text = item1.SubItems[5].Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmStockRecordHistory temp = new frmStockRecordHistory();
            temp.Show();
            this.Hide();
        }

        private void btnStockin_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO `db_cefinal`.`stockin` (`stockin_id`, `date`, `staff`) VALUES(" + txtStockID.Text + ", now(), '" + txtEmployee.Text + "');" +
                           "create table `db_stockindetails`.`" + txtStockID.Text + "`(itemID int not null, itemType varchar(255), itemColor varchar(255), itemWeight int, itemQuantity int, subtotal int, primary key (itemID));" +
                           "INSERT INTO `db_cefinal`.`stockrecordhistory` (`recordID`, `date`, `person`, `action`) VALUES(" + txtStockID.Text + ", now(), '" + txtEmployee.Text + "', 'Stock In');";
            
            foreach (ListViewItem eachItem in listCart.Items)
            {
                query = query + "insert into `db_stockindetails`.`" + txtStockID.Text + "`(itemID, itemType, itemColor, itemWeight, itemQuantity, subtotal) values('" + int.Parse(eachItem.SubItems[0].Text) + "','" +
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
            this.Close();
        }

    }
}
