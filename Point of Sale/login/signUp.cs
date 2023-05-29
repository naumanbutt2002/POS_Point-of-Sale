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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Point_of_Sale.login
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }
        loginCollection login = new loginCollection();
        public static bool ValidatePassword(string password)
        {

            //Contains at least one lowercase letter
            //Contains at least one uppercase letter
            //Contains at least one digit
            //Contains at least one special character(not alphanumeric)
            //Is at least 8 characters long

            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
            return regex.IsMatch(password);
        }
        public static bool ValidateUsername(string username)
        {
            //Contains only alphanumeric characters, hyphens, and underscores
            //Is between 3 and 16 characters long
            var regex = new Regex(@"^[a-zA-Z0-9_-]{3,16}$");
            return regex.IsMatch(username);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool isValid1 = ValidateUsername(UnameTB.Text);
            bool isValid2 = ValidatePassword(PassTB.Text);

            if (UnameTB.Text == "" || PassTB.Text == "" || confirmPassTb.Text == "" || DesigantionTb.Text == "" || HintTb.Text == "")
            {
                MBox.Show("MISSING INFO...");

            }
            
            else if (PassTB.Text != confirmPassTb.Text)
            {
                MBox.Show("PASSWORD NOT MATCHED...");
            }
            else
            {
                if (isValid1 && isValid2)
                {
                    login.Insert(UnameTB.Text, PassTB.Text, DesigantionTb.Text, HintTb.Text);
                    MBox.Show("SIGN UP SUCESSFULLY...");
                    this.Close();
                    empLogin empLogin = new empLogin();
                    empLogin.Show();
                }
                else if(!isValid1)
                {
                    MBox.Show("Username must between 3 and 16 characters long, only alphanumeric characters, hyphens and underscores are allowed!");
                }
                else
                {
                    MBox.Show("Password must be 8 characters long, one lowercase, uppercase, digit and special case!");
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
         }

        private void DesigantionTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            empLogin empLogin = new empLogin();
            empLogin.Show();
            this.Close();
        }
    }
}
