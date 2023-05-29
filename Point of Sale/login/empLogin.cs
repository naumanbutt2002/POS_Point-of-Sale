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
    public partial class empLogin : Form
    {
        public empLogin()
        {
            InitializeComponent();
        }
        loginCollection logins = new loginCollection();
        private void signUp_Click(object sender, EventArgs e)
        {
            signUp label = new signUp();
            label.Show();
            this.Close();
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string var_user=null, var_pass = null ;
            List<loginModel> list1 = new List<loginModel>();

            list1 = logins.Readlogins();

            if (UnameTB.Text == "" || PassTB.Text == "")
            {
                MBox.Show("Enter Username and Password!");
            }
           
            foreach (loginModel s in list1)
            {
                var_user = s.UserName.ToString();
                var_pass = s.Password.ToString();
                
                if (UnameTB.Text == var_user && PassTB.Text == var_pass)
                {
                    Billings Obj = new Billings();
                    Obj.Show();
                    this.Close();
                    return ;
                }
                

            }
            if (UnameTB.Text != var_user && PassTB.Text != var_pass)
            {
                MBox.Show("Worng Username or Password!");
            }

        }

        private void ForgetPass_Click(object sender, EventArgs e)
        {
            ForgetPassword obj=new ForgetPassword();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logins logins = new logins();
            logins.Show();
            this.Close();
        }
    }
}
