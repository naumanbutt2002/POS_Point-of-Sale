//using Point_of_Sale.Employee;
using PointOfSale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Point_of_Sale
{
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
            DisplayCustomers();
        }
        CustomersCollections customers = new CustomersCollections();
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu Obj = new MainMenu();
            Obj.Show();
        }
        private void DisplayCustomers()
        {
            List<Customers> list1 = new List<Customers>();

            list1 = customers.ReadCustomers();
            CustomersDGV.Rows.Clear();
            foreach (Customers s in list1)
            {
                AddRowToDataGrid(s);
            }
        }
        void AddRowToDataGrid(Customers s)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell();
            ID.Value = s.cusId;
            DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell();
            Name.Value = s.cusName;

            DataGridViewTextBoxCell PhoneNo = new DataGridViewTextBoxCell();
            PhoneNo.Value = s.cusPhone;

            DataGridViewTextBoxCell Email = new DataGridViewTextBoxCell();
            Email.Value= s.cusEmail;

            DataGridViewTextBoxCell Age = new DataGridViewTextBoxCell();
            Age.Value = s.cusAge;

            DataGridViewTextBoxCell Address = new DataGridViewTextBoxCell();
            Address.Value = s.cusAddress;

            row.Cells.Add(ID);
            row.Cells.Add(Name);
            row.Cells.Add(PhoneNo);
            row.Cells.Add(Email);
            row.Cells.Add(Age);
            row.Cells.Add(Address);
            CustomersDGV.Rows.Add(row);
        }
        private void Reset()
        {
            CNameTb.Text = "";
            CPhoneTb.Text = "";
            CAddressTb.Text = "";
            CEmailTb.Text = "";
            CAgeTb.Text = "";
            Key = 0;
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MBox.Show("SELECT THE CUSTOMER ...");
            }
            else
            {
                customers.DeleteCustomer(Key);
                DisplayCustomers();
                Reset();
            }
        }
        private void editbtn_Click(object sender, EventArgs e)
        {
            // Get email address from the textbox
            string email = CEmailTb.Text;
            // Get phone number from the textbox
            string phoneNumber = CPhoneTb.Text;

            // Define regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Define regular expression pattern for phone number validation
            //string pattern2 = @"^\d{10}$";

            // Define regular expression pattern for Pakistani phone number validation
            string pattern2 = @"^(\+92|92|0)?(3\d{2}|4[89]\d|5\d{2}|6\d{2}|7\d{2}|8\d{2}|9\d{2})[ -]?\d{7}$";

            // Create Regex object to match pattern with email address
            Regex regex = new Regex(pattern);
            // Create Regex object to match pattern with phone number
            Regex regex2 = new Regex(pattern2);

            if (CNameTb.Text == "" || CPhoneTb.Text == "" || CEmailTb.Text == "" || CAgeTb.Text == "" || CAddressTb.Text == "")
            {
                MBox.Show("MISSING INFO...");
            }
            else if (!regex.IsMatch(email))
            {
                MessageBox.Show(this, "Please enter a valid email.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CEmailTb.Focus();
            }
            else if (!regex2.IsMatch(phoneNumber))
            {
                MessageBox.Show(this, "Please enter a valid phone number.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CPhoneTb.Focus();
            }
            else
            {
                customers.UpdateCustomer(Key, CNameTb.Text, CPhoneTb.Text, CEmailTb.Text, Convert.ToInt32(CAgeTb.Text), CAddressTb.Text);
                DisplayCustomers();
                Reset();
            }
        }
        int Key = 0;
        private void CustomersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNameTb.Text = CustomersDGV.SelectedRows[0].Cells[1].Value.ToString();
            CPhoneTb.Text = CustomersDGV.SelectedRows[0].Cells[2].Value.ToString();
            CEmailTb.Text = CustomersDGV.SelectedRows[0].Cells[3].Value.ToString();
            CAgeTb.Text = CustomersDGV.SelectedRows[0].Cells[4].Value.ToString();
            CAddressTb.Text = CustomersDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (CNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CustomersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void AddSupplier_Click(object sender, EventArgs e)
        {
            AddSuppliers obj = new AddSuppliers();
            obj.Show();
        }

        private void ViewSupplier_Click(object sender, EventArgs e)
        {
            ViewSuppliers obj = new ViewSuppliers();
            obj.Show();
            this.Hide();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer obj = new AddCustomer();
            obj.Show();
        }

        private void ViewCustomer2_Click(object sender, EventArgs e)
        {
            ViewCustomer obj = new ViewCustomer();
            obj.Show();
            this.Hide();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee obj = new AddEmployee();
            obj.Show();
        }

        private void ViewEmployee_Click(object sender, EventArgs e)
        {
            ViewEmployee obj = new ViewEmployee();
            obj.Show();
            this.Hide();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProducts obj = new AddProducts();
            obj.Show();

        }

        private void ViewProduct_Click(object sender, EventArgs e)
        {
            ViewProducts obj = new ViewProducts(); 
            obj.Show(); 
            this.Hide();
        }

        private void CNameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only alphabetic characters and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CPhoneTb_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void CAgeTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CEmailTb_Leave(object sender, EventArgs e)
        {
            //string email = CEmailTb.Text.Trim();

            //// Check if the email matches the email pattern
            //if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            //{
            //    MBox.Show("Please enter a valid email address.");
            //    CEmailTb.Focus();
            //}
        }

        private void searchTB_Enter(object sender, EventArgs e)
        {
            if (searchTB.Text == "Search Customer By Name")
            {
                searchTB.Text = "";
                searchTB.ForeColor = Color.Black;
            }
        }

        private void ResetPB_Click(object sender, EventArgs e)
        {
            Reset();
            DisplayCustomers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Customers> list1 = new List<Customers>();
            string name = (searchTB.Text);
            list1 = customers.SearchCustomersByName(name);
            CustomersDGV.Rows.Clear();
            foreach (Customers p in list1)
            {
                AddRowToDataGrid(p);
            }
            if (list1.Count == 0)
            {
                MBox.Show("Not Available...");
                Reset();
            }
        }
        private void searchTB_Leave(object sender, EventArgs e)
        {
            if (searchTB.Text == "")
            {
                searchTB.Text = "Search Customer By Name";
                searchTB.ForeColor = Color.Silver;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ViewBills viewBills = new ViewBills();
            viewBills.Show();
            this.Hide();
        }

        private void CEmailTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && char.IsDigit(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            // Allow only one + in the textbox
            if (e.KeyChar == '@' && ((System.Windows.Forms.TextBox)sender).Text.Contains("@"))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
