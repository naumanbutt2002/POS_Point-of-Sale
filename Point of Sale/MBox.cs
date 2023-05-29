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
    public partial class MBox : Form
    {
        public MBox()
        {
            InitializeComponent();
            MessageLabel.Text = Message;
        } 

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static string Message;
        public static void Show(string msg)
        {
            Message = msg;
            MBox Obj = new MBox();
            Obj.Show();
        }
        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void GunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageLbl_Click(object sender, EventArgs e)
        {

        }

        private void MBox_Load(object sender, EventArgs e)
        {

        }

        private void MessageLabel_TextChanged(object sender, EventArgs e)
        {
            MessageLabel.TextAlign = HorizontalAlignment.Center;
        }
    }
}
