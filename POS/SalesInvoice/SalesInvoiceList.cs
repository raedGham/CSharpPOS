using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.SalesInvoice
{
    public partial class SalesInvoiceList : Form
    {
        public SalesInvoiceList()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SalesInvoice addInvoice = new SalesInvoice();
            addInvoice.ShowDialog();
            GetData();
        }


        public void GetData()
        {
            string qry = "Select * from [Sales Invoice] ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvInvDate);
            lb.Items.Add(dgvInvTime);
            lb.Items.Add(dgvTotal);
            lb.Items.Add(dgvPaid);
            lb.Items.Add(dgvDiscount);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvDeliveryID);
            lb.Items.Add(dgvDeliveryTime);
            lb.Items.Add(dgvClientID);
            lb.Items.Add(dgvPrinted);
            lb.Items.Add(dgvCashIN);
            lb.Items.Add(dgvCashOUT);
            lb.Items.Add(dgvSlipWI);
            lb.Items.Add(dgvDelivered);
            MainClass.LoadData(qry, dataGridView1, lb);

            lblRecords.Text = (dataGridView1.Rows.Count - 1).ToString();
        }

        private void SalesInvoiceList_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
