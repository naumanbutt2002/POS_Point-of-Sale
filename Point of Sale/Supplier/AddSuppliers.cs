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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Point_of_Sale
{
    public partial class AddSuppliers : Form
    {
        SupplierCollection supplier = new SupplierCollection();

        public AddSuppliers()
        {
            InitializeComponent();
            this.ControlBox = false;
        }



        private void Button1_MouseHover(object sender, EventArgs e)
        {
            Savebtn.BackColor = Color.YellowGreen;
        }


        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Savebtn.BackColor = Color.Transparent;
        }

        
        private void PictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset()
        {
            SNameTb.Text = "";
            SPhoneTb.Text = "";
            SAddressTb.Text = "";
             }

        private void Savebtn_Click(object sender, EventArgs e)
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
                supplier.InsertSupplier(SNameTb.Text, SAddressTb.Text, SPhoneTb.Text);
                MBox.Show("Supplier Saved...");
                Reset();
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void SNameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only alphabetic characters and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SAddressTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void SPhoneTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key
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
    }
}
