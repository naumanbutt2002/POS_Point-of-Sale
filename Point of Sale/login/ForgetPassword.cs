using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale.login
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }
        loginCollection logins = new loginCollection();
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            List<loginModel> list1 = new List<loginModel>();

            if (UnameTB.Text == "" || HintTb.Text == "")
            {
                MBox.Show("MISSING INFO...");

            }
            
            else
            {
                list1=logins.FindPass(UnameTB.Text,HintTb.Text);
                foreach (loginModel s in list1)
                {
                    showPass.Text = s.Password;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empLogin obj=new empLogin();
            obj.Show();
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
