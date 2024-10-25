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
    public partial class ItemList : Form
    {
        public ItemList()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select I.ID, Description,  C.[Category Description], [Sales Price]  from [Sales Items] as I inner join [Sitems Categories] as C on C.ID = I.CategoryID  where Description like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvItem);
            lb.Items.Add(dgvCategory);
            lb.Items.Add(dgvPrice);


            MainClass.LoadData(qry, dataGridView1, lb);
            lblRecords.Text = (dataGridView1.Rows.Count - 1).ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Model.AddItem addItem = new Model.AddItem();
            addItem.ShowDialog();
            GetData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                Model.AddItem frm = new Model.AddItem();
      //          frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvID"].Value);
      //          frm.txtCategory.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvCategory"].Value);
      //          frm.txtNote.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvNote"].Value);
                frm.ShowDialog();
                GetData();

            }

            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvID"].Value);
                DialogResult result = MessageBox.Show("هل تريد محي القيد؟", "سؤال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string qry = "Delete from [Sales Items] where ID= " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQ1(qry, ht);
                    MessageBox.Show("تم محي القيد بنجاح");
                    GetData();
                }

            }
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
