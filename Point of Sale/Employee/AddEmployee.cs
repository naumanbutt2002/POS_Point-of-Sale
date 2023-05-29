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

namespace Point_of_Sale
{
    public partial class AddEmployee : Form
    {
        EmployeesCollection employees = new EmployeesCollection();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            ENameTb.Text = "";
            EmpPhoneTb.Text = "";
            EDesignationTb.Text = "";
            EmpSalaryTb.Text = "";
        }

        private void Savebtn_Click(object sender, EventArgs e)
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
                employees.InsertEmployee(ENameTb.Text, EDesignationTb.Text, EmpPhoneTb.Text, Convert.ToDecimal(EmpSalaryTb.Text));
                MBox.Show("Employee SAVED");
                Reset();
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
            if (e.KeyChar == '+' && ((System.Windows.Forms.TextBox)sender).Text.Contains("+"))
            {
                e.Handled = true;
            }
            // Allow only one - in the textbox
            if (e.KeyChar == '-' && ((System.Windows.Forms.TextBox)sender).Text.Contains("-"))
            {
                e.Handled = true;
            }
        }

        private void EmpSalaryTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, dot, and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one dot
            if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
