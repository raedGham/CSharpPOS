using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.View
{
    public partial class StockList : Form
    {
        public StockList()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select I.ID, Description,  C.[Category Description], C.ID, [Sales Price]  from [Sales Items] as I inner join [Sitems Categories] as C on C.ID = I.CategoryID  where Description like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvDescription);
            lb.Items.Add(dgvCatID);
            lb.Items.Add(dgvCategory);
            lb.Items.Add(dgvSupplierID);
            lb.Items.Add(dgvSupplier);
            lb.Items.Add(dgvUnitID);
            lb.Items.Add(dgvUnit);
            lb.Items.Add(dgvPrice);


            MainClass.LoadData(qry, dataGridView1, lb);
            lblRecords.Text = (dataGridView1.Rows.Count - 1).ToString();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Model.AddStock addStock = new Model.AddStock();
            addStock.ShowDialog();
            // GetData();
        }

        private void StockList_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
