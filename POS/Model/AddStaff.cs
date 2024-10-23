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
    public partial class AddStaff : Form
    {
        public int id = 0;
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
                qry = "Insert into [Delivery Persons] values(@name, @address, @phone)";
            }
            else
            {
                qry = "Update [Delivery Persons] set [Person Name] = @name, Address=@address, Phone = @phone  where ID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@name", txtName.Text);
            ht.Add("@address", txtAddress.Text);
            ht.Add("@phone", txtPhone.Text);


            if (MainClass.SQ1(qry, ht) > 0)
            {
                MessageBox.Show("تم الحفظ");
                id = 0;
                txtName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtName.Focus();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
