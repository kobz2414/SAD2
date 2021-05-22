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
    public partial class frmStockinAdd : Form
    {
        private MySqlConnection connection;
        private string server, database, uid, password;
        public string id, employee;
        private bool checkStockInID = true, checkDuplicateStockID = true;

        public frmStockinAdd()
        {
            InitializeComponent();
            Initialize();
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

        private void frmStockinAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStockRecordHistory temp = new frmStockRecordHistory();
            temp.Show();
            this.Hide();
        }

        private void txtStockID_TextChanged(object sender, EventArgs e)
        {
            if (!txtStockID.Text.All(char.IsDigit) && txtStockID.Text != "")
            {
                if (checkStockInID == true)
                {
                    MessageBox.Show("Enter all numeric value");
                }
                checkStockInID = false;
                btnCreate.Enabled = false;
            }
            else
            {
                try
                {
                    string checkDuplicate = "SELECT CASE WHEN EXISTS ( SELECT stockin_id FROM `db_cefinal`.`stockin` WHERE stockin_id = '" + txtStockID.Text + "') THEN 'TRUE' ELSE 'FALSE' END as stockin_id;";

                    if (OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(checkDuplicate, connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        while (dataReader.Read())
                        {
                            string temp = dataReader["stockin_id"].ToString();
                            if (temp == "TRUE")
                            {
                                btnCreate.Enabled = false;
                                
                                if (checkDuplicateStockID == true)
                                {
                                    MessageBox.Show("Duplicate Transaction Number");
                                }

                                checkDuplicateStockID = false;
                            }
                            else
                            {
                                checkDuplicateStockID = true;
                                checkStockInID = true;
                                btnCreate.Enabled = true;
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

        private void txtEmployee_TextChanged(object sender, EventArgs e)
        {
            //if (txtEmployee.Text.All(char.IsDigit) && txtEmployee.Text != "")
            //{
            //    btnCreate.Enabled = false;
            //    MessageBox.Show("Must not be a number");
            //}
            //else
            //{
            //    btnCreate.Enabled = true;
            //}
        }

        private void frmStockinAdd_Load(object sender, EventArgs e)
        {

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmStockinDetailsAdd = new frmStockinDetailsAdd(txtStockID.Text, txtEmployee.Text);
            frmStockinDetailsAdd.Show();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmStockRecordHistory temp = new frmStockRecordHistory();
            temp.Show();
            this.Hide();
        }
    }
}
