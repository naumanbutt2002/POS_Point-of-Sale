using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Point_of_Sale
{
    public partial class ViewSuppliers : Form
    {
        public ViewSuppliers()
        {
            InitializeComponent();
            DisplaySupp();
        }


        SupplierCollection supplier = new SupplierCollection();

        private void Button3_Click(object sender, EventArgs e)
        {
   


        }

        private void Label4_Click(object sender, EventArgs e)
        {
            AddProducts obj = new AddProducts();
            obj.Show();
            obj.TopMost = true;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu Obj = new MainMenu();
            Obj.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
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
        private void Reset()
        {
            SNameTb.Text = "";
            SPhoneTb.Text = "";
            SAddressTb.Text = "";
            Key = 0;
        
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MBox.Show("SELECT THE SUPPLIER ...");
            }
            else
            {
                supplier.DeleteSupplier(Key);
                DisplaySupp();
                Reset();
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            // Get phone number from the textbox
            string phoneNumber = SPhoneTb.Text;

            // Define regular expression pattern for Pakistani phone number validation
            string pattern = @"^(\+92|92|0)?(3\d{2}|4[89]\d|5\d{2}|6\d{2}|7\d{2}|8\d{2}|9\d{2})[ -]?\d{7}$";

            // Create Regex object to match pattern with phone number
            Regex regex = new Regex(pattern);

            if (SNameTb.Text == "" || SPhoneTb.Text == "" || SAddressTb.Text == "")
            {
                MBox.Show("MISSING INFO...");

            }
            else if (!regex.IsMatch(phoneNumber))
            {
                MessageBox.Show(this, "Please enter a valid phone number.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SPhoneTb.Focus();
            }
            else
            {
                supplier.UpdateSupplier(Key, SNameTb.Text, SAddressTb.Text, SPhoneTb.Text);
                DisplaySupp();
                Reset();
             
            }
        }
        int Key = 0;
        private void SuppliersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SNameTb.Text = SuppliersDGV.SelectedRows[0].Cells[1].Value.ToString();
            SPhoneTb.Text = SuppliersDGV.SelectedRows[0].Cells[2].Value.ToString();
            SAddressTb.Text = SuppliersDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (SNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SuppliersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            ViewProducts obj = new ViewProducts();
            obj.Show();
            this.Hide();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            AddSuppliers obj = new AddSuppliers();
            obj.Show();
            obj.TopMost = true;
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            ViewSuppliers obj = new ViewSuppliers();
            obj.Show();
            this.Hide();
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            AddCustomer obj = new AddCustomer();
            obj.Show();
            obj.TopMost = true;
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            ViewCustomer obj = new ViewCustomer();
            obj.Show();
            this.Hide();
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            AddEmployee obj = new AddEmployee();
            obj.Show();
            obj.TopMost = true;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {
            ViewEmployee obj = new ViewEmployee();
            obj.Show();
            this.Hide();
        }

        private void ViewSuppliers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void SNameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only alphabetic characters and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SPhoneTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only alphabetic characters and control keys
            // Check if the entered key is a digit or a control key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            // Allow only one + in the textbox
            if (e.KeyChar == '+' && ((TextBox)sender).Text.Contains("+"))
            {
                e.Handled = true;
            }
            // Allow only one - in the textbox
            if (e.KeyChar == '-' && ((TextBox)sender).Text.Contains("-"))
            {
                e.Handled = true;
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

        private void ResetPB_Click(object sender, EventArgs e)
        {
            Reset();
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
    }
}
