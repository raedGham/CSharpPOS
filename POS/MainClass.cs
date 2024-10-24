using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
   class MainClass
    {
   
            static string OfficeServer = "DESKTOP-UHLS283\\SQLEXPRESS";
            static string LaptopServer = "SPECTRE";
            public static readonly string con_string = "Persist Security Info=False;TrustServerCertificate=True;Trusted_Connection=True;database=fastPOS;server=" + LaptopServer;
            public static SqlConnection con = new SqlConnection(con_string);



            public static bool IsValiduser(string user, string pass)
            {
                bool isValid = false;
                string qry = @"Select * from users where UserName = '" + user + "' and Password ='" + pass + "'  ";
                SqlCommand cmd = new SqlCommand(qry, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    isValid = true;
                    USER = dt.Rows[0]["UserName"].ToString();
                }

                return isValid;
            }
            public static string user;
            public static string USER
            {
                get { return user; }
                private set { user = value; }

            }

            //Method for CRUD operation

            public static int SQ1(string qry, Hashtable ht)
            {
                int res = 0;
                try
                {
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.CommandType = CommandType.Text;
                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    }
                    if (con.State == ConnectionState.Closed) { con.Open(); }
                    res = cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open) { con.Close(); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
                return res;
            }
            // for Loading data fromdatabase

            public static void LoadData(string qry, DataGridView gv, ListBox lb)
            {
                // serial no in grid view

                gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);

                try
                {
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i < lb.Items.Count; i++)
                    {
                        string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                        gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();

                    }

                    gv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }

            private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)

            {
                DataGridView gv = (DataGridView)sender;
                int count = 0;

                foreach (DataGridViewRow row in gv.Rows)
                {
                    count++;
                    row.Cells[0].Value = count;

                }

            }

            public static void CBFill(string qry, ComboBox cb)
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = "Name";
                cb.ValueMember = "id";
                cb.DataSource = dt;
                cb.SelectedIndex = -1;

            }
        }

    }
