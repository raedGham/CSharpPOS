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
    public partial class staffList : Form
    {
        public staffList()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select ID, [Person Name], Address, Phone from [Delivery Persons] where [Person Name] like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvAddress);
            lb.Items.Add(dgvPhone);

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
            Model.AddStaff addStaff = new Model.AddStaff();
            addStaff.ShowDialog();
            GetData();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                Model.AddStaff frm = new Model.AddStaff();
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
                    string qry = "Delete from [Delivery Persons] where ID= " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQ1(qry, ht);
                    MessageBox.Show("تم محي القيد بنجاح");
                    GetData();
                }

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void staffList_Load(object sender, EventArgs e)
        {
            GetData();
        }

        
    }
}
