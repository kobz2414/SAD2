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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder temp = new frmOrder();
            temp.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory temp = new frmInventory();
            temp.Show();
            this.Hide();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            frmTransactions temp = new frmTransactions();
            temp.Show();
            this.Hide();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomers temp = new frmCustomers();
            temp.Show();
            this.Hide();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmEmployee temp = new frmEmployee();
            temp.Show();
            this.Hide();
        }
    }
}
