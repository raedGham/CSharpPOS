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

namespace POS.Model
{
    public partial class AddItemCatg : Form
    {
        public int id = 0;
        public AddItemCatg()

        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
                qry = "Insert into [Sitems Categories] values(@category, @note)";
            }
            else
            {
                qry = "Update [Sitems Categories] set [Category Description] = @category, Note=@note where ID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@category", txtCategory.Text);
            ht.Add("@note", txtNote.Text);


            if (MainClass.SQ1(qry, ht) > 0)
            {
                MessageBox.Show("تم الحفظ");
                id = 0;
                txtCategory.Text = "";
                txtNote.Text = "";


            }
        }
    }
}
