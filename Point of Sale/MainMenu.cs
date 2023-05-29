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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {
            ViewProducts obj = new ViewProducts();
            obj.Show();
            this.Hide();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {
            AddCustomer obj = new AddCustomer();
            obj.Show();
            obj.TopMost = true;
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            ViewSuppliers obj = new ViewSuppliers();
            obj.Show();
            this.Hide();
        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label48_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            AddProducts obj = new AddProducts();
            obj.Show();
            this.Hide();
            ///obj.TopMost = true;
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            AddSuppliers obj = new AddSuppliers();
            obj.Show();
            obj.TopMost = true;
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            ViewCustomer obj = new ViewCustomer();
            obj.Show();
            this.Hide();
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            AddEmployee obj = new AddEmployee();
            obj.Show();
            obj.TopMost = true;
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            ViewEmployee obj = new ViewEmployee();
            obj.Show();
            this.Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Label19_Click(object sender, EventArgs e)
        {
            logins obj = new logins();
            obj.Show();
            this.Close();
        }

        private void Label20_Click(object sender, EventArgs e)
        {
            ViewBills Obj = new ViewBills();
            Obj.Show();
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }
    }
}
