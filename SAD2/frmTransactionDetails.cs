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
    public partial class frmTransactionDetails : Form
    {
        private MySqlConnection connection;
        private string server, database, uid, password;
        private int transactionID, totalAmount;


        public frmTransactionDetails(int temp)
        {
            transactionID = temp;
            InitializeComponent();
            Initialize();
        }

        private void frmTransactionDetails_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM `db_cefinal`.`sales` where transactionID = " + transactionID + ";";

            try
            {
                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string date = dataReader["DateTime"] + "",
                               name = dataReader["name"] + "",
                               id = dataReader["transactionID"] + "",
                               address = dataReader["Address"] + "",
                               contact = dataReader["ContactNumber"] + "";

                        txtTransactionNum.Text = id;
                        txtName.Text = name;
                        txtDateandTime.Text = date;
                        txtContactNum.Text = contact;
                        txtAddress.Text = address;
                        //string[] row = { id, date, name };
                        //ListViewItem item = new ListViewItem(row);
                        //listTransactionHistory.Items.Add(item);
                    }

                    dataReader.Close();

                    CloseConnection();
                }
            }catch(Exception err)
            {
                Console.WriteLine(err);
                CloseConnection();
            }

            query = "SELECT * FROM db_transactions.`" + transactionID + "`";

            try
            {
                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string id = dataReader["itemID"] + "",
                               type = dataReader["itemType"] + "",
                               color = dataReader["itemColor"] + "",
                               weight = dataReader["itemWeight"] + "",
                               quantity = dataReader["itemQuantity"] + "",
                               totalWeight = dataReader["totalWeight"] + "",
                               price = dataReader["price"] + "",
                               subtotal = dataReader["subtotal"] + "";
                        string[] row = { id, type, color, weight, quantity, totalWeight, price, subtotal};
                        ListViewItem item = new ListViewItem(row);
                        listProducts.Items.Add(item);
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

            query = "SELECT Status FROM `db_cefinal`.`sales` where transactionID = " + transactionID + ";";

            try
            {
                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        //cmbPaymentStatus.SelectedIndex = cmbPaymentStatus.FindStringExact(dataReader["Status"].ToString());
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

            query = "SELECT sum(amount) AS subtotal FROM db_payments.`" + transactionID + "`";

            try
            {
                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string total = dataReader["subtotal"] + "";
                        totalAmount = int.Parse(total);
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

            query = "SELECT sum(subtotal) AS subtotal FROM db_transactions.`" + transactionID + "`";

            try
            {
                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string total = dataReader["subtotal"] + "";
                        totalAmount = int.Parse(total) - totalAmount;
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


            if(totalAmount <= 0)
            {
                txtPaymentStatus.Text = "Paid";
                query = "UPDATE `db_cefinal`.`sales` SET `Status` = 'Paid' WHERE (`transactionID` = " + transactionID + ");";
            }
            else
            {
                txtPaymentStatus.Text = "Unpaid";
                query = "UPDATE `db_cefinal`.`sales` SET `Status` = 'Unpaid' WHERE (`transactionID` = " + transactionID + ");";
            }

            try
            {
                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteReader();

                    CloseConnection();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                CloseConnection();
            }

            double subTotal = 0;
            double totalTransactionWeight = 0;

            for (int i = 0; i < listProducts.Items.Count; i++)
            {
                totalTransactionWeight += double.Parse(listProducts.Items[i].SubItems[5].Text);
            }

            for (int i = 0; i < listProducts.Items.Count; i++)
            {
                subTotal += double.Parse(listProducts.Items[i].SubItems[7].Text);
            }

            txtTotalWeight.Text = totalTransactionWeight.ToString();
            txtSubtotal.Text = subTotal.ToString();

        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string query = "";

        //    if (cmbPaymentStatus.SelectedItem.ToString() == "Unpaid")
        //    {
        //        query = "UPDATE `db_cefinal`.`sales` SET `Status` = 'Unpaid' WHERE (`transactionID` = " + transactionID + ");";
        //    }
        //    else if (cmbPaymentStatus.SelectedItem.ToString() == "Paid")
        //    {
        //        query = "UPDATE `db_cefinal`.`sales` SET `Status` = 'Paid' WHERE (`transactionID` = " + transactionID + ");";
        //    }
            

        //    try
        //    {
        //        if (OpenConnection() == true)
        //        {
        //            MySqlCommand cmd = new MySqlCommand(query, connection);
        //            cmd.ExecuteReader();

        //            CloseConnection();
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        Console.WriteLine(err);
        //    }
        //}

        private void frmTransactionDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmTransactions temp = new frmTransactions();
            temp.Show();
            temp.Refresh();
            this.Hide();
        }

        private void listProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            frmPayment temp = new frmPayment(int.Parse(txtTransactionNum.Text));
            temp.Show();
            this.Hide();
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
