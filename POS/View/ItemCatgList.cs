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
    public partial class ItemCatgList : Form
    {
        public ItemCatgList()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select ID, [Category Description], Note from [Sitems Categories] where [Category Description] like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvCategory);
            lb.Items.Add(dgvNote);


            MainClass.LoadData(qry, dataGridView1, lb);
            lblRecords.Text = (dataGridView1.Rows.Count - 1).ToString();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Model.AddItemCatg addItemCatg = new Model.AddItemCatg();
            addItemCatg.ShowDialog();
            GetData();
        }

        private void ItemCatgList_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                Model.AddItemCatg frm = new Model.AddItemCatg();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvID"].Value);
                frm.txtCategory.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvCategory"].Value);
                frm.txtNote.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvNote"].Value);
                frm.ShowDialog();
                GetData();

            }

            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvID"].Value);
                DialogResult result = MessageBox.Show("هل تريد محي القيد؟", "سؤال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string qry = "Delete from [Sitems Categories] where ID= " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQ1(qry, ht);
                    MessageBox.Show("تم محي القيد بنجاح");
                    GetData();
                }

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
