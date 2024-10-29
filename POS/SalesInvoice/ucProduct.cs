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
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;

        public int id { get; set; }
        public string Pname
        {
            get { return lblPName.Text; }
            set { lblPName.Text = value; }
        }

        public Image Pimage
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }
        public string Pprice { get; set; }

        public string Pcategory { get; set; }

        private void txtImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
     
    }
}
