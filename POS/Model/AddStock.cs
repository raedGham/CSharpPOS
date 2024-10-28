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
using Microsoft.Data.SqlClient;

namespace POS.Model
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int catID = 0;
        public int untID = 0;
        public int suppID = 0;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
                qry = "Insert into [Stock Items] values(@catid, @description, @qty , @unitid, @unitprice , @supplierid, @reorder,@expiry,@note, @barcode, @salesprice )";
            }
                        
            else
            {
                qry = "Update [Stock Items]  set  CategoryID=@catid , Description = @description , [Avail Qty] = @qty, [Unit Price] = @unitprice  where ID = @id ";
             }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@catid", Convert.ToInt32(cbCategory.SelectedValue));
            ht.Add("@description", txtDescription.Text);
            ht.Add("@qty", txtQty.Text);
            ht.Add("@unitid", Convert.ToInt32(cbUnit.SelectedValue));
            ht.Add("@unitprice", Convert.ToDecimal(txtUnitPrice.Text));
            ht.Add("@supplierid", Convert.ToInt32(cbSupplier.SelectedValue));
            ht.Add("@reorder", Convert.ToInt32(txtReorder.Text));
            ht.Add("@expiry", Convert.ToDateTime("01/01/2027") );
            ht.Add("@note", "");
            ht.Add("@salesprice", Convert.ToDecimal(txtSalesPrice.Text));
            ht.Add("@barcode", txtBarcode.Text);




            if (MainClass.SQ1(qry, ht) > 0)
            {
                MessageBox.Show("Save sucessfully..");
                id = 0;
                //  catID = 0;
                //txtItemName.Text = "";


                txtDescription.Focus();

            }
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            // for cb fill
            string qry = "select ID  'id', [Category Description] 'name' from [Stock Categories] ";
            MainClass.CBFill(qry, cbCategory);
            if (catID > 0) //For update
            {
                cbCategory.SelectedValue = catID;

            }

            string qry1 = "select ID  'id', [Description] 'name' from [Units] ";
            MainClass.CBFill(qry1, cbUnit);
            if (untID > 0) //For update
            {
                cbUnit.SelectedValue = untID;

            }

            string qry2 = "select ID  'id', [SupplierName] 'name' from [Suppliers] ";
            MainClass.CBFill(qry2, cbSupplier);
            if (suppID > 0) //For update
            {
                cbSupplier.SelectedValue = suppID;

            }


              if (id > 0)
              {
                  ForUpdateLoadData();
              } 
        }

        private void ForUpdateLoadData()
        {
            string qry = @"select * from [stock Items] where ID = " + id + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtDescription.Text = dt.Rows[0]["Description"].ToString();
                txtUnitPrice.Text = dt.Rows[0]["Unit Price"].ToString();
                txtQty.Text = dt.Rows[0]["Avail Qty"].ToString();
                txtReorder.Text = dt.Rows[0]["Reorder Level"].ToString();
                txtSalesPrice.Text = dt.Rows[0]["Sales Price"].ToString();
                txtBarcode.Text = dt.Rows[0]["Barcode"].ToString();



            }
        }
    }

}
