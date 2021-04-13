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

        public frmStockinDetailsAdd(string id, string staff)
        {
            InitializeComponent();
            Initialize();
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

        private void show()
        {
            listCart.Items.Clear();

            string query = "SELECT stockin_details_id AS id, type, color, weight, quantity FROM stockin_details WHERE stockin_id=" + txtStockID.Text + ";";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string id = dataReader["id"] + "", type = dataReader["type"] + "", color = dataReader["color"] + "", weight = dataReader["weight"] + "", quantity = dataReader["quantity"] + "", subtotal = (Int32.Parse(weight) * Int32.Parse(quantity)).ToString();
                    string[] row = { id, type, color, weight, quantity, subtotal };
                    ListViewItem item = new ListViewItem(row);
                    listCart.Items.Add(item);
                }

                dataReader.Close();

                this.CloseConnection();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string query = "INSERT INTO stockin_details(type, color, weight, quantity, stockin_id) VALUES('" + txtType.Text + "', '" + txtColor.Text + "', " + txtWeight.Text + ", " + txtQuantity.Text + ", " + txtStockID.Text + ");";

            //if (this.OpenConnection() == true)
            //{
            //    MySqlCommand cmd = new MySqlCommand(query, connection);
            //    cmd.ExecuteNonQuery();
            //    this.CloseConnection();
            //}
            //show();
            string id = txtID.Text;
            string type = txtType.Text;
            string color = txtColor.Text;
            string weight = txtWeight.Text;
            string quantity = txtQuantity.Text;
            string subtotal = txtSubtotal.Text;
            double total = 0;

            if (txtID.Text != "" && txtType.Text != "" && txtColor.Text != "" && txtWeight.Text != "" && txtQuantity.Text != "")
            {
                string[] row = { id, type, color, weight, quantity, subtotal };
                ListViewItem item = new ListViewItem(row);
                listCart.Items.Add(item);

                txtID.Text = "";
                txtType.Text = "";
                txtColor.Text = "";
                txtWeight.Text = "";
                txtQuantity.Text = "";
                txtSubtotal.Text = "";

                for (int i = 0; i < listCart.Items.Count; i++)
                {
                    total += double.Parse(listCart.Items[i].SubItems[5].Text);
                }

                txtTotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Please input the complete details");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string query = "DELETE FROM stockin_details WHERE stockin_details_id=" + listCart.SelectedItems[0].SubItems[0].Text + ";";

            //if (this.OpenConnection() == true)
            //{
            //    MySqlCommand cmd = new MySqlCommand(query, connection);
            //    cmd.ExecuteNonQuery();
            //    this.CloseConnection();
            //}
            //show();

            try
            {
                if (listCart.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an item");
                }
                else
                {
                    ListViewItem item = listCart.SelectedItems[0];
                    item.Remove();

                    txtID.Text = "";
                    txtType.Text = "";
                    txtColor.Text = "";
                    txtWeight.Text = "";
                    txtQuantity.Text = "";
                    txtSubtotal.Text = "";
                    double total = 0;

                    for (int i = 0; i < listCart.Items.Count; i++)
                    {
                        total += double.Parse(listCart.Items[i].SubItems[5].Text);
                    }

                    txtTotal.Text = total.ToString();
                }
            }
            catch (Exception err)
            {

            }
        }

        private void frmStockinDetailsAdd_Load(object sender, EventArgs e)
        {

        }

        private void txtStockID_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.All(char.IsDigit))
            {
                if (txtQuantity.Text != "" && txtWeight.Text != "" && txtWeight.Text.All(char.IsDigit))
                {
                    txtSubtotal.Text = (int.Parse(txtQuantity.Text) * int.Parse(txtWeight.Text)).ToString();
                }
                else
                {
                    txtSubtotal.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a numeric value");
                txtQuantity.Text = "";
            }
            
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            if (txtWeight.Text.All(char.IsDigit))
            {
                if (txtQuantity.Text != "" && txtWeight.Text != "" && txtQuantity.Text.All(char.IsDigit))
                {
                    txtSubtotal.Text = (int.Parse(txtQuantity.Text) * int.Parse(txtWeight.Text)).ToString();
                }
                else
                {
                    txtSubtotal.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a numeric value");
                txtWeight.Text = "";
            }
        }

        private void frmStockinDetailsAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStockRecordHistory temp = new frmStockRecordHistory();
            temp.Show();
            this.Hide();
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
