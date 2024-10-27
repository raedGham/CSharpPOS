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
            string qry = "Select I.ID, I.Description,  I.CategoryID,C.[Category Description] ,I.[Prefered Supplier ID] ,S.SupplierName ,I.[Avail Qty], I.UnitID,U.Description, [Unit Price], [Sales Price]  from [stock Items] as I " +
                       "inner join [Stock Categories] as C on I.CategoryID = C.ID  " +
                       "left join [Suppliers] as S on I.[Prefered Supplier ID]= S.ID  " +
                        "inner join [Units] as U on  I.UnitID = U.ID " + 
                         "where I.Description like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvDescription);
            lb.Items.Add(dgvCatID);
            lb.Items.Add(dgvCategory);
            lb.Items.Add(dgvSupplierID);
            lb.Items.Add(dgvSupplier);
            lb.Items.Add(dgvQty);
            lb.Items.Add(dgvUnitID);
            lb.Items.Add(dgvUnit);
            lb.Items.Add(dgvUnitPrice);
            lb.Items.Add(dgvSalesPrice);


            MainClass.LoadData(qry, dataGridView1, lb);
            lblRecords.Text = (dataGridView1.Rows.Count - 1).ToString();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Model.AddStock addStock = new Model.AddStock();
            addStock.ShowDialog();
            GetData();
        }

        private void StockList_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
