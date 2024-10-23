using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmFiles : Form
    {
        public frmFiles()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
        }

        private void btnListClient_Click(object sender, EventArgs e)
        {

            View.ClientsList frm = new View.ClientsList();
            frm.Show();
        }

        private void frmFiles_Load(object sender, EventArgs e)
        {

        }

        private void btnListDelivery_Click(object sender, EventArgs e)
        {
            View.staffList frm = new View.staffList();
            frm.Show();
        }

        private void btnListSupplier_Click(object sender, EventArgs e)
        {
            View.SupplierList frm = new View.SupplierList();
            frm.Show();
        }
    }
}
