using Point_of_Sale.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public partial class logins : Form
    {
        loginCollection loginObj= new loginCollection();

        public logins()
        {
            InitializeComponent();
        }

        private void Logins_Load(object sender, EventArgs e)
        {

        }
       

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            empLogin Obj = new empLogin();
            Obj.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string var_user = null, var_pass = null;

            List<loginModel> list1 = new List<loginModel>();

            list1 = loginObj.Readlogins();

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
                    MainMenu Obj = new MainMenu();
                    Obj.Show();
                    this.Hide();
                }
                break;
            }
            
            if (UnameTB.Text != var_user && PassTB.Text != var_pass)
            {
                MBox.Show("Worng Username or Password!");
            }
        }
    }
}
