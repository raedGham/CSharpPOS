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
    public partial class StockList : Form
    {
        public StockList()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Model.AddStock addStock = new Model.AddStock();
            addStock.ShowDialog();
            // GetData();
        }

        private void StockList_Load(object sender, EventArgs e)
        {

        }
    }
}
