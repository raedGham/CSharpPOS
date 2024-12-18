﻿using System;
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
    public partial class AddClient : Form
    {
        public int id = 0;
        public AddClient()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                qry = "Insert into Clients values(@name, @address, @phone, @currentBalance)";
            }
            else
            {
                qry = "Update Clients set clientName = @name, Address=@address, Phone = @phone  where ID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@name", txtName.Text);
            ht.Add("@address", txtAddress.Text);
            ht.Add("@phone", txtPhone.Text);
            ht.Add("@currentBalance", 0);

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
