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

namespace SAD2
{
    public partial class frmStockRecordHistory : Form
    {
        private MySqlConnection connection;
        private string server, database, uid, password;
        private string transaction_id, transaction_action;

        public frmStockRecordHistory()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

            if (listStockRecord.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                frmStockRecordDetails temp = new frmStockRecordDetails(transaction_id, transaction_action);
                temp.ShowDialog();
            }
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            frmStockinAdd temp = new frmStockinAdd();
            temp.Show();
            this.Hide();
        }



        public void load()
        {
            //string query = "select * from `db_cefinal`.`stockin`;";

            //if (this.OpenConnection() == true)
            //{
            //    MySqlCommand cmd = new MySqlCommand(query, connection);
            //    MySqlDataReader dataReader = cmd.ExecuteReader();

            //    while (dataReader.Read())
            //    {
            //        string id = dataReader["stockin_id"] + "",
            //                date = dataReader["date"] + "",
            //                staff = dataReader["staff"] + "",
            //                action = "Stock In";

            //        string[] row = { id, date, staff, action };
            //        ListViewItem grid = new ListViewItem(row);
            //        listStockRecord.Items.Add(grid);
            //    }

            //    dataReader.Close();

            //    this.CloseConnection();
            //}

            //// Stock Out
            //query = "select transactionID, DateTime, Name FROM `db_cefinal`.`sales`;";

            //if (this.OpenConnection() == true)
            //{
            //    MySqlCommand cmd = new MySqlCommand(query, connection);
            //    MySqlDataReader dataReader = cmd.ExecuteReader();

            //    while (dataReader.Read())
            //    {
            //        string id = dataReader["transactionID"] + "",
            //                date = dataReader["DateTime"] + "",
            //                staff = dataReader["Name"] + "",
            //                action = "Stock Out";

            //        string[] row = { id, date, staff, action };
            //        ListViewItem grid = new ListViewItem(row);
            //        listStockRecord.Items.Add(grid);
            //    }

            //    dataReader.Close();

            //    this.CloseConnection();


            string query = "SELECT * FROM `db_cefinal`.`stockrecordhistory` order by date desc";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string id = dataReader["recordID"] + "",
                            date = dataReader["date"] + "",
                            staff = dataReader["person"] + "",
                            action = dataReader["action"] + "";

                    string[] row = { id, date, staff, action };
                    ListViewItem grid = new ListViewItem(row);
                    listStockRecord.Items.Add(grid);
                }

                dataReader.Close();

                this.CloseConnection();
            }

        }
        class ListViewItemComparer : IComparer
        {
            private int col;
            private SortOrder order;
            public ListViewItemComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }
            public ListViewItemComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }
            public int Compare(object x, object y)
            {
                int returnVal;
                // Determine whether the type being compared is a date type.  
                try
                {
                    // Parse the two objects passed as a parameter as a DateTime.  
                    System.DateTime firstDate =
                            DateTime.Parse(((ListViewItem)x).SubItems[col].Text);
                    System.DateTime secondDate =
                            DateTime.Parse(((ListViewItem)y).SubItems[col].Text);
                    // Compare the two dates.  
                    returnVal = DateTime.Compare(firstDate, secondDate);
                }
                // If neither compared object has a valid date format, compare  
                // as a string.  
                catch
                {
                    // Compare the two items as a string.  
                    returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                ((ListViewItem)y).SubItems[col].Text);
                }
                // Determine whether the sort order is descending.  
                if (order == SortOrder.Descending)
                    // Invert the value returned by String.Compare.  
                    returnVal *= -1;
                return returnVal;
            }
        }

        private void frmStockRecordHistory_Load(object sender, EventArgs e)
        {
            listStockRecord.Items.Clear();
            load();
            //Stock In
            
        }

        private void frmStockRecordHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmInventory temp = new frmInventory();
            this.Hide();
            temp.Show();
        }

        private void listStockRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listStockRecord.SelectedItems.Count < 1) return;
            ListViewItem item = listStockRecord.SelectedItems[0];
            transaction_id = item.Text;
            transaction_action = item.SubItems[3].Text;
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
