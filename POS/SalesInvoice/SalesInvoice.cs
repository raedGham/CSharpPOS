using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.SalesInvoice
{
    public partial class SalesInvoice : Form
    {
        private byte[] imagearray;
        private int x = 0;
        public SalesInvoice()
        {
            InitializeComponent();
        }

        private void SalesInvoice_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProducts();

            // for cb fill
            string qry = "select ID  'id', [Person Name] 'name' from [Delivery Persons] ";
            MainClass.CBFill(qry, cbDelivery);
            //if (catID > 0) //For update
            //{
            //    cbCategory.SelectedValue = catID;

            //}

            // for cb fill
            string qry2 = "select ID  'id', ClientName 'name' from Clients ";
            MainClass.CBFill(qry2, cbClient);
            //if (catID > 0) //For update
            //{
            //    cbCategory.SelectedValue = catID;

            //}
        }
        private void AddCategory()
        {
            string qry = "select * from [Sitems Categories]";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Button b = new Button();
                    b.Margin = new Padding(3, 8, 3, 2);
                    b.ForeColor = Color.White;
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 1;
                    b.Font = new Font("Janna LT", 10);
                    b.Size = new Size(150, 50);
                    b.Text = row["Category Description"].ToString();

                    // Event for category click
                    b.Click += new EventHandler(_Click);

                    CategoryPanel.Controls.Add(b);
                }


            }
        }

        private void _Click(object sender, EventArgs e)
        {
            x = 1;
            Button b = (Button)sender;
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.Pcategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void LoadProducts()
        {

            string qry = "select * from [sales items] as I inner join [Sitems Categories] as C on C.ID = I.CategoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);



            foreach (DataRow item in dt.Rows)
            {

                byte[] imageData = item["InThumb"] as byte[];

                if (imageData != null)
                {
                    imagearray = (Byte[])item["InThumb"];
                    byte[] imagebytearray = imagearray;
                }


                AddItems("0", item["ID"].ToString(), item["Description"].ToString(), item["Category Description"].ToString(),
                         item["Sales Price"].ToString(), Image.FromStream(new MemoryStream(imagearray)));

            }

        }

        private void AddItems(string id, string ProductID, string name, string cat, string price, Image pimage)
        {
            dataGridView1.AllowUserToAddRows = false;
            var w = new ucProduct()
            {
                Pname = name,
                Pprice = price,
                Pcategory = cat,
                Pimage = pimage,
                id = Convert.ToInt32(ProductID)

            };
            w.Visible = false;
            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    // this will check if the product is already there then a one is added to its quantity
                    if (Convert.ToInt32(item.Cells["dgvItemID"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        GetTotal();
                        return;
                    }


                }
                // this line will add a new product , first 0 is for sn and second 0 is for id
                dataGridView1.Rows.Add(new Object[] { 0, 0, wdg.id, wdg.Pname, 1, wdg.Pprice, wdg.Pprice });
                GetTotal();
            };
        }

        private void InvoicePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblSelectedQty_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                tot += double.Parse(row.Cells["dgvAmount"].Value.ToString());
            }
            lblTotal.Text = tot.ToString("N0");

          
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;

            }
        }
    }
}
