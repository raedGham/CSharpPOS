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
    public partial class ItemCatgList : Form
    {
        public ItemCatgList()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Model.AddItemCatg addItemCatg = new Model.AddItemCatg();
            addItemCatg.ShowDialog();
           // GetData();
        }
    }
}
