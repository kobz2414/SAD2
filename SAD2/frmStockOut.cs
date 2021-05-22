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
    public partial class frmStockOut : Form
    {
        public frmStockOut()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmStockOutDetails temp = new frmStockOutDetails();
            temp.ShowDialog();
        }

        private void frmStockOut_Load(object sender, EventArgs e)
        {

        }
    }
}
