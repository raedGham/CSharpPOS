﻿using System;
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
    public partial class ItemList : Form
    {
        public ItemList()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Model.AddItem addItem = new Model.AddItem();
            addItem.ShowDialog();
            //GetData();
        }
    }
}
