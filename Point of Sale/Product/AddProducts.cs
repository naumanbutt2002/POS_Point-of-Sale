using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//SQL
using System.Data.SqlClient;
using System.Collections;
using PointOfSale;

namespace Point_of_Sale
{
    public partial class AddProducts : Form
    {
        SupplierCollection supplier = new SupplierCollection();
        ProductsCollections product = new ProductsCollections();
        public AddProducts()
        {
            InitializeComponent();
            GetSuppliersIds();
            DisplaySupp();
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();    
        }
        private void Reset()
        {
            supIdCb.SelectedIndex=-1;
            PnameTb.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";
            PCatCb.SelectedIndex = -1;
            supNameTb.Text = "";
        }
        private void GetSuppliersIds()
        {
            List<Supplier> list1 = new List<Supplier>();
            List<int> list2 = new List<int>();

            list1 = supplier.ReadSupplier();

            foreach (Supplier s in list1)
            {
                list2.Add(s.supId);
            }

            supIdCb.DataSource = list2;
        }
        private void GetSupplierName()
        {
            List<Supplier> list1 = new List<Supplier>();

            list1 = supplier.ReadSupplier();
            foreach (Supplier s in list1)
            {
                string supidc = supIdCb.SelectedValue.ToString();
                if (s.supId == Convert.ToInt32(supidc))
                {
                    supNameTb.Text = s.supName;
                    break;
                }
            }

        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(supIdCb.SelectedIndex == -1 || PnameTb.Text=="" || PCatCb.SelectedIndex==-1 || PriceTb.Text=="" || QtyTb.Text=="")
            {
                MBox.Show("MISSING INFO...");

            }
            else
            {
                product.InsertProduct(PnameTb.Text, Convert.ToString(PCatCb.SelectedItem), Convert.ToDecimal(PriceTb.Text), Convert.ToInt32(QtyTb.Text), Convert.ToInt32(supIdCb.SelectedValue));
                MBox.Show("Product Saved...");
                Reset();
                this.Close();
                MainMenu obj = new MainMenu();
                obj.Show();
            }
                    
        }

        private void supIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSupplierName();
        }
        private void DisplaySupp()
        {
            List<Supplier> list1 = new List<Supplier>();

            list1 = supplier.ReadSupplier();
            SuppliersDGV.Rows.Clear();
            foreach (Supplier s in list1)
            {
                AddRowToDataGrid(s);

            }
        }
        void AddRowToDataGrid(Supplier s)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell();
            ID.Value = s.supId;
            DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell();
            Name.Value = s.supName;
            DataGridViewTextBoxCell PhoneNo = new DataGridViewTextBoxCell();
            PhoneNo.Value = s.supplierPhone;
            DataGridViewTextBoxCell Address = new DataGridViewTextBoxCell();
            Address.Value = s.supplierCity;
            row.Cells.Add(ID);
            row.Cells.Add(Name);
            row.Cells.Add(PhoneNo);
            row.Cells.Add(Address);
            SuppliersDGV.Rows.Add(row);

        }
        int Key = 0;
        private void SuppliersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            supIdCb.Text = SuppliersDGV.SelectedRows[0].Cells[0].Value.ToString();
            supNameTb.Text = SuppliersDGV.SelectedRows[0].Cells[1].Value.ToString();

            if (supNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SuppliersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Supplier> list1 = new List<Supplier>();
            string name = (searchTB.Text);
            list1 = supplier.SearchSuppliersByName(name);
            SuppliersDGV.Rows.Clear();
            foreach (Supplier p in list1)
            {
                AddRowToDataGrid(p);
            }
            if (list1.Count == 0)
            {
                MBox.Show("Not Available...");
            }
            Reset();
        }
        private void reset()
        {
            Key = 0;
        }

        private void ResetPB_Click(object sender, EventArgs e)
        {
            reset();
            DisplaySupp();
        }

        private void searchTB_Enter(object sender, EventArgs e)
        {
            if (searchTB.Text == "Search Supplier By Name")
            {
                searchTB.Text = "";
                searchTB.ForeColor = Color.Black;
            }
        }

        private void searchTB_Leave(object sender, EventArgs e)
        {
            if (searchTB.Text == "")
            {
                searchTB.Text = "Search Supplier By Name";
                searchTB.ForeColor = Color.Silver;
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
            // Allow only alphabetic characters and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void supIdCb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void searchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only alphabetic characters and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show(this);
            this.Hide();
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
