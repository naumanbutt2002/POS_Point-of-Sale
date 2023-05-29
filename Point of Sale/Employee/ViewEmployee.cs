//using Point_of_Sale.Customer;
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

namespace Point_of_Sale
{
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
            DisplayEmp();
        }
        EmployeesCollection employees = new EmployeesCollection();
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu Obj = new MainMenu();
            Obj.Show();
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }
        private void Reset()
        {
            ENameTb.Text = "";
            EmpPhoneTb.Text = "";
            EDesignationTb.Text = "";
            EmpSalaryTb.Text = "";
            Key = 0;
        }
        private void DisplayEmp()
        {
            List<Employees> list1 = new List<Employees>();
            list1 = employees.ReadEmployees();
            EmployeesDGV.Rows.Clear();
            foreach (Employees s in list1)
            {
                AddRowToDataGrid(s);
            }
        }
        void AddRowToDataGrid(Employees s)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell();
            ID.Value = s.empId;
            DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell();
            Name.Value = s.empName;
            DataGridViewTextBoxCell Designation = new DataGridViewTextBoxCell();
            Designation.Value = s.empDesignation;
            DataGridViewTextBoxCell PhoneNo = new DataGridViewTextBoxCell();
            PhoneNo.Value = s.empPhone;
            DataGridViewTextBoxCell Salary = new DataGridViewTextBoxCell();
            Salary.Value = s.empSalary;
            row.Cells.Add(ID);
            row.Cells.Add(Name);
            row.Cells.Add(Designation);
            row.Cells.Add(PhoneNo);
            row.Cells.Add(Salary);
            EmployeesDGV.Rows.Add(row);
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MBox.Show("SELECT THE SUPPLIER ...");

            }
            else
            {
                employees.DeleteEmpoyee(Key);
                DisplayEmp();
                Reset();
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            // Get phone number from the textbox
            string phoneNumber = EmpPhoneTb.Text;

            // Define regular expression pattern for Pakistani phone number validation
            string pattern = @"^(\+92|92|0)?(3\d{2}|4[89]\d|5\d{2}|6\d{2}|7\d{2}|8\d{2}|9\d{2})[ -]?\d{7}$";

            // Create Regex object to match pattern with phone number
            Regex regex = new Regex(pattern);
            if (ENameTb.Text == "" || EmpPhoneTb.Text == "" || EDesignationTb.Text == "" || EmpSalaryTb.Text == "")
            {
                MBox.Show("MISSING INFO...");
            }
            else if (!regex.IsMatch(phoneNumber))
            {
                MessageBox.Show(this, "Please enter a valid phone number.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmpPhoneTb.Focus();
            }
            else
            {
                employees.UpdateEmployee(Key, ENameTb.Text, EDesignationTb.Text, EmpPhoneTb.Text, Convert.ToDecimal(EmpSalaryTb.Text));
                DisplayEmp();
                Reset();
            }
        }
        int Key = 0;
        private void EmployeesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ENameTb.Text = EmployeesDGV.SelectedRows[0].Cells[1].Value.ToString();
            EDesignationTb.Text = EmployeesDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpPhoneTb.Text = EmployeesDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpSalaryTb.Text = EmployeesDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (ENameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeesDGV.SelectedRows[0].Cells[0].Value.ToString());
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
        private void ViewEmp_Click(object sender, EventArgs e)
        {
            ViewEmployee obj = new ViewEmployee();
            obj.Show();
            this.Hide();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProducts obj = new AddProducts();    
            obj.Show();
            this.Hide();    
        }

        private void ViewProduct_Click(object sender, EventArgs e)
        {
            ViewProducts obj= new ViewProducts();
            obj.Show();
            this.Hide();
        }

        private void EmpSalaryTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, dot, and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one dot
            if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void ENameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EDesignationTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EmpPhoneTb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Employees> list1 = new List<Employees>();
            string name = (searchTB.Text);
            list1 = employees.SearchEmployeesByName(name);
            EmployeesDGV.Rows.Clear();
            foreach (Employees p in list1)
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
            DisplayEmp();
        }

        private void searchTB_Enter(object sender, EventArgs e)
        {
            if (searchTB.Text == "Search Employee By Name")
            {
                searchTB.Text = "";
                searchTB.ForeColor = Color.Black;
            }
        }

        private void searchTB_Leave(object sender, EventArgs e)
        {
            if (searchTB.Text == "")
            {
                searchTB.Text = "Search Employee By Name";
                searchTB.ForeColor = Color.Silver;
            }
        }
    }
}
