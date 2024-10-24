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
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace POS.Model
{
    public partial class AddIngredient : Form
    {
        string filePath;
        Byte[] imageByteArray;
        public AddIngredient()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int cID = 0;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void ForUpdateLoadData()
        {
            string qry = @"select * from ingredients where ID = " + id + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtDescription.Text = dt.Rows[0]["Description"].ToString();


                Byte[] imageArray = (byte[])(dt.Rows[0]["InThumb"]);
                byte[] imageByteArray = imageArray;
                txtThumb.Image = Image.FromStream(new MemoryStream(imageByteArray));

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
                qry = "Insert into Ingredients values(@description, @img)";
            }
            else
            {
                qry = "Update ingredients  set Description = @description , InThumb = @img  where ID = @id ";
            }
            //For image 
            Image temp = new Bitmap(txtThumb.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@description", txtDescription.Text);
            ht.Add("@img", imageByteArray);


            if (MainClass.SQ1(qry, ht) > 0)
            {
                MessageBox.Show("Save sucessfully..");
                id = 0;
                cID = 0;
                txtDescription.Text = "";

                txtThumb.Image = POS.Properties.Resources.Bootstrap_Bootstrap_Bootstrap_x_diamond_fill_48;
                txtDescription.Focus();

            }
        }

        private void AddIngredient_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                ForUpdateLoadData();
            }
        }
    }
}
