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
    public partial class frmSell : Form
    {
        public frmSell()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            SalesInvoice.SalesInvoice addSales = new SalesInvoice.SalesInvoice();
            addSales.ShowDialog();
        }

        private void btnListClient_Click(object sender, EventArgs e)
        {
            SalesInvoice.SalesInvoiceList listSales = new SalesInvoice.SalesInvoiceList();
            listSales.ShowDialog();
        }
    }
}
