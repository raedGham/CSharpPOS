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
using System.Xml.Linq;

namespace POS.Model
{
    public partial class AddUnit : Form
    {
        public AddUnit()
        {
            InitializeComponent();
        }
        public int id = 0;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
                qry = "Insert into units values(@description)";
            }
            else
            {
                qry = "Update units set Description = @description where ID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@description", txtDescription.Text);
          

            if (MainClass.SQ1(qry, ht) > 0)
            {
                MessageBox.Show("تم الحفظ");
                id = 0;
                txtDescription.Text = "";
                txtDescription.Focus();

            }
        }
    }
}
