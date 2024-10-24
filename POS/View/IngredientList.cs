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
    public partial class IngredientList : Form
    {
        public IngredientList()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select ID, Description from ingredients where Description like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvDescription);


            MainClass.LoadData(qry, dataGridView1, lb);
            lblRecords.Text = (dataGridView1.Rows.Count - 1).ToString();
        }
        private void ClientsList_Load(object sender, EventArgs e)
        {
            GetData();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Model.AddIngredient addIngredient = new Model.AddIngredient();
            addIngredient.ShowDialog();
            GetData();
        }

        private void IngredientList_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                Model.AddIngredient frm = new Model.AddIngredient();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvID"].Value);
                frm.txtDescription.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvDescription"].Value);
               
                frm.ShowDialog();
                GetData();

            }

            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvID"].Value);
                DialogResult result = MessageBox.Show("هل تريد محي القيد؟", "سؤال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string qry = "Delete from ingredients where ID= " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQ1(qry, ht);
                    MessageBox.Show("تم محي القيد بنجاح");
                    GetData();
                }

            }
        }
    }
}
