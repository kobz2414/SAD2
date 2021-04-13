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
            //if(!txtStockID.Text.All(char.IsDigit) && txtStockID.Text != "")
            //{
            //    btnCreate.Enabled = false;
            //}else
            //{
            //    btnCreate.Enabled = true;
            //}
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
