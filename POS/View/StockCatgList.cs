using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.View
{
    public partial class StockCatgList : Form
    {
        public StockCatgList()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Model.AddStockCatg addStockCatg = new Model.AddStockCatg();
            addStockCatg.ShowDialog();
           // GetData();
        }
    }
}
