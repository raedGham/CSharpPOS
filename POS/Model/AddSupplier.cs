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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
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
                qry = "Insert into Suppliers values(@name, @address, @phone, @supply,@currentBalance)";
            }
            else
            {
                qry = "Update Suppliers set SupplierName = @name, Address=@address, Phone = @phone, SupplyType = @supply  where ID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@name", txtName.Text);
            ht.Add("@address", txtAddress.Text);
            ht.Add("@phone", txtPhone.Text);
            ht.Add("@supply", txtSupply.Text);
            ht.Add("@currentBalance", 0);


            if (MainClass.SQ1(qry, ht) > 0)
            {
                MessageBox.Show("تم الحفظ");
                id = 0;
                txtName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtSupply.Text = "";
                txtName.Focus();

            }
        }
    }
}
