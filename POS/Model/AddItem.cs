using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Model
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int cID = 0;

        string filePath;
        Byte[] imageByteArray;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
                qry = "Insert into [Sales Items] values(@catid @description, @price , @img)";
            }
            else
            {
                qry = "Update [Sales Items]  set Description = @description , InThumb = @img, Price = @price , CategoryID=@catid  where ID = @id ";
            }
            //For image 
            Image temp = new Bitmap(txtThumb.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@catid", Convert.ToInt32(cbCategory.SelectedValue));
            ht.Add("@description", txtItemName.Text);
            ht.Add("@price", Convert.ToDecimal(txtPrice.Text));
            ht.Add("@img", imageByteArray);


            if (MainClass.SQ1(qry, ht) > 0)
            {
                MessageBox.Show("Save sucessfully..");
                id = 0;
                cID = 0;
                txtItemName.Text = "";

                txtThumb.Image = POS.Properties.Resources.Bootstrap_Bootstrap_Bootstrap_x_diamond_fill_48;
                txtItemName.Focus();

            }
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            // for cb fill
            string qry = "select ID  'id', [Category Description] 'name' from [Sitems Categories] ";
            MainClass.CBFill(qry, cbCategory);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " Images (.jpg , .png) | *.jpg ; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                txtThumb.Image = new Bitmap(filePath);
            }
        }
    }
}
