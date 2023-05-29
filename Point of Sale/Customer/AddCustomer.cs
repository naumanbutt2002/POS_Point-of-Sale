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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        CustomersCollections customers = new CustomersCollections();
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Reset()
        {
            CNameTb.Text = "";
            CPhoneTb.Text = "";
            CEmailTb.Text = "";
            CAgeTb.Text = "";
            CAddressTb.Text = "";
        }

        private void Savebtn_Click(object sender, EventArgs e)
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
                customers.InsertCustomer(CNameTb.Text, CPhoneTb.Text, CEmailTb.Text, Convert.ToInt32(CAgeTb.Text), CAddressTb.Text);
                MBox.Show("CUSTOMER SAVED");
                Reset();
            }
        }
        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void CNameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
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