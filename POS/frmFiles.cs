using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.View;

namespace POS
{
    public partial class frmFiles : Form
    {
        public frmFiles()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Model.AddClient addClient = new Model.AddClient();
            addClient.ShowDialog();
        }

        private void btnListClient_Click(object sender, EventArgs e)
        {

            View.ClientsList frm = new View.ClientsList();
            frm.Show();
        }

        private void frmFiles_Load(object sender, EventArgs e)
        {

        }

        private void btnListDelivery_Click(object sender, EventArgs e)
        {
            View.staffList frm = new View.staffList();
            frm.Show();
        }

        private void btnListSupplier_Click(object sender, EventArgs e)
        {
            View.SupplierList frm = new View.SupplierList();
            frm.Show();
        }

        private void btnListStock_Click(object sender, EventArgs e)
        {
            View.StockList frm = new View.StockList();
            frm.Show();
        }

        private void btnListCategory_Click(object sender, EventArgs e)
        {
            View.StockCatgList frm = new View.StockCatgList();
            frm.Show();
        }

        private void btnListUnit_Click(object sender, EventArgs e)
        {
            View.UnitList frm = new View.UnitList();
            frm.Show();
        }

        private void btnListIngredient_Click(object sender, EventArgs e)
        {
            View.IngredientList frm = new View.IngredientList();
            frm.Show();
        }

        private void btnListItemCatg_Click(object sender, EventArgs e)
        {
            View.ItemCatgList frm = new View.ItemCatgList();
            frm.Show();
        }

        private void btnListItem_Click(object sender, EventArgs e)
        {
            View.ItemList frm = new View.ItemList();
            frm.Show();
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            Model.AddIngredient addIngredient = new Model.AddIngredient();
            addIngredient.ShowDialog();
        }

        private void btnAddItemCatg_Click(object sender, EventArgs e)
        {
            Model.AddItemCatg addItemCatg = new Model.AddItemCatg();
            addItemCatg.ShowDialog();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Model.AddItem addItem = new Model.AddItem();
            addItem.ShowDialog();
        }

        private void btnAddDelivery_Click(object sender, EventArgs e)
        {
            Model.AddStaff addStaff = new Model.AddStaff();
            addStaff.ShowDialog();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Model.AddStockCatg addStockCatg = new Model.AddStockCatg();
            addStockCatg.ShowDialog();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            Model.AddStock addStock = new Model.AddStock();
            addStock.ShowDialog();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Model.AddSupplier addSupplier = new Model.AddSupplier();
            addSupplier.ShowDialog();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            Model.AddUnit addUnit = new Model.AddUnit();
            addUnit.ShowDialog();
        }
    }
}
