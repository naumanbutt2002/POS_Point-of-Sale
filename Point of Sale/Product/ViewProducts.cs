using PointOfSale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Point_of_Sale
{
    public partial class ViewProducts : Form
    {
        ProductsCollections products = new ProductsCollections();
        public ViewProducts()
        {
            InitializeComponent();
            DisplayProducts();
        }
        private void PLabel_Click(object sender, EventArgs e)
        {
            AddProducts obj = new AddProducts();
            obj.Show();
            obj.TopMost = true;
        }
        private void SupplierLabel_Click(object sender, EventArgs e)
        {
            AddSuppliers obj = new AddSuppliers();
            obj.Show();
            obj.TopMost = true;
        }
        private void CustomerLabel_Click(object sender, EventArgs e)
        {
            AddCustomer obj = new AddCustomer();
            obj.Show();
            obj.TopMost = true;
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }
        private void DisplayProducts()
        {
            List<Products> list1 = new List<Products>();
            list1 = products.ReadProducts();
            ProductsDGV.Rows.Clear();
            foreach (Products p in list1)
            {
                AddRowToDataGrid(p);
            }
        }
        void AddRowToDataGrid(Products s)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell PID = new DataGridViewTextBoxCell();
            PID.Value = s.ProductId;
            DataGridViewTextBoxCell SupID = new DataGridViewTextBoxCell();
            SupID.Value = s.SupID;
            DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell();
            Name.Value = s.ProductName;
            DataGridViewTextBoxCell Cat = new DataGridViewTextBoxCell();
            Cat.Value = s.Categroy;
            DataGridViewTextBoxCell Qty = new DataGridViewTextBoxCell();
            Qty.Value = s.ProductQuantity;
            DataGridViewTextBoxCell Price = new DataGridViewTextBoxCell();
            Price.Value = s.ProductPrice;
            row.Cells.Add(PID);
            row.Cells.Add(SupID);
            row.Cells.Add(Name);
            row.Cells.Add(Cat);
            row.Cells.Add(Qty);
            row.Cells.Add(Price);
            ProductsDGV.Rows.Add(row);
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Key==0)
            {
                MBox.Show("SELECT THE PRODUCT ...");
            }
            else
            {
                products.DeleteProduct(Key);
                MBox.Show("Product Deleted...");
                DisplayProducts();
                Reset();
            }
        }
        int Key = 0;
        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            supIdTb.Text = ProductsDGV.SelectedRows[0].Cells[1].Value.ToString();
            PnameTb.Text = ProductsDGV.SelectedRows[0].Cells[2].Value.ToString();
            PCatCb.SelectedItem = ProductsDGV.SelectedRows[0].Cells[3].Value.ToString();
            QtyTb.Text = ProductsDGV.SelectedRows[0].Cells[4].Value.ToString();
            PriceTb.Text = ProductsDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (PnameTb.Text=="")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            searchTB.Text = "  Search Product By ID";
            searchTB.ForeColor= Color.Silver;
            supIdTb.Text = "";
            PnameTb.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";
            PCatCb.SelectedIndex = -1;
            Key = 0;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (supIdTb.Text == "" || PnameTb.Text == "" || PCatCb.SelectedIndex == -1 || PriceTb.Text == "" || QtyTb.Text == "")
            {
                MBox.Show("MISSING INFO...");
            }
            else
            {
                products.UpdateProduct(Key, PnameTb.Text, PCatCb.SelectedItem.ToString(), Convert.ToDecimal(PriceTb.Text), Convert.ToInt32(QtyTb.Text),Convert.ToInt32(supIdTb.Text));
                MBox.Show("Product Updated...");
                DisplayProducts();
                Reset();
            }
        }
        private void ViewProductLabel_Click(object sender, EventArgs e)
        {
            ViewProducts obj = new ViewProducts();
            obj.Show();
            this.Hide();
        }

        private void ViewSupplierLabel_Click(object sender, EventArgs e)
        {
            ViewSuppliers obj = new ViewSuppliers();
            obj.Show();
            this.Hide();
        }

        private void ViewCustomerLabel_Click(object sender, EventArgs e)
        {
            ViewCustomer obj = new ViewCustomer();
            obj.Show();
            this.Hide();
        }

        private void EmployeeLabel_Click(object sender, EventArgs e)
        {
            AddEmployee obj = new AddEmployee();
            obj.Show();
            obj.TopMost = true;
        }

        private void ViewEmpLabel_Click(object sender, EventArgs e)
        {
            ViewEmployee obj = new ViewEmployee();
            obj.Show();
            this.Hide();
        }
        private void ViewProducts_Load(object sender, EventArgs e)
        {

        }
        private void CatategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Products> list2 = new List<Products>();
            list2 = products.DisplayProductswrtCat(CatategoryBox.SelectedItem.ToString());
            ProductsDGV.Rows.Clear();
            foreach (Products p in list2)
            {
                AddRowToDataGrid(p);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Products> list1 = new List<Products>();
            int id = Convert.ToInt32(searchTB.Text);
            list1 = products.SearchProducts(id);
            ProductsDGV.Rows.Clear();
            foreach (Products p in list1)
            {
                AddRowToDataGrid(p);
            }
            if(list1.Count==0)
            {
                MBox.Show("Not Available...");
            }
            Reset();
        }
        private void ClosePB_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu Obj = new MainMenu();
            Obj.Show();
        }

        private void searchTB_Enter(object sender, EventArgs e)
        {
            if (searchTB.Text == "  Search Product By ID")
            {
                searchTB.Text = "";
                searchTB.ForeColor = Color.Black;
            }
        }
        private void searchTB_Leave(object sender, EventArgs e)
        {
            if (searchTB.Text == "")
            {
                searchTB.Text = "  Search Product By ID";
                searchTB.ForeColor = Color.Silver;
            }
        }
        private void ResetPB_Click(object sender, EventArgs e)
        {
            DisplayProducts();
            Reset();
        }

        private void Label20_Click(object sender, EventArgs e)
        {
            ViewBills billings = new ViewBills();
            billings.Show();
            this.Hide();
        }

        private void supIdTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PriceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void QtyTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PnameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void searchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only alphabetic characters and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void PCatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PCatCb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only alphabetic characters and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
