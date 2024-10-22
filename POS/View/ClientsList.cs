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
    public partial class ClientsList : Form
    {
        public ClientsList()
        {
            InitializeComponent();
        }



      public void GetData()
        {
            string qry = "Select ID, ClientName, Address, phone from clients where ClientName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvAddress);
            lb.Items.Add(dgvPhone);


            MainClass.LoadData(qry, dataGridView1, lb);
        }
        private void ClientsList_Load(object sender, EventArgs e)
        {
            GetData();
        }

    
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
