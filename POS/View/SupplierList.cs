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

namespace POS.View
{
    public partial class SupplierList : Form
    {
        public SupplierList()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select ID, SupplierName, Address, phone, SupplyType from Suplliers where SupplierName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvAddress);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvSupply);

            MainClass.LoadData(qry, dataGridView1, lb);
            lblRecords.Text = (dataGridView1.Rows.Count - 1).ToString();
        }
        private void SuppliersList_Load(object sender, EventArgs e)
        {
            GetData();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Model.AddSupplier addSupplier = new Model.AddSupplier();
            addSupplier.ShowDialog();
            GetData();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                Model.AddClient frm = new Model.AddClient();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvID"].Value);
                frm.txtName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.txtAddress.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvAddress"].Value);
                frm.txtPhone.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvPhone"].Value);
                frm.ShowDialog();
                GetData();

            }

            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvID"].Value);
                DialogResult result = MessageBox.Show("هل تريد محي القيد؟", "سؤال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string qry = "Delete from Suplliers where ID= " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQ1(qry, ht);
                    MessageBox.Show("تم محي القيد بنجاح");
                    GetData();
                }

            }
        }

   
    }
}
