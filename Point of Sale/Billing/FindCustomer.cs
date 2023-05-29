using PointOfSale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Point_of_Sale
{

    public partial class FindCustomer : Form
    {
        public FindCustomer()
        {
            InitializeComponent();
            DisplayCustomers();
        }
        CustomersCollections customers = new CustomersCollections();
        Billings billings = new Billings();

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
            Billings billings= new Billings();
            billings.Show();
        }
        private void DisplayCustomers()
        {
            List<Customers> list1 = new List<Customers>();

            list1 = customers.ReadCustomers();
            CustomersDGV.Rows.Clear();
            foreach (Customers s in list1)
            {
                AddRowToDataGrid(s);
            }
        }
        void AddRowToDataGrid(Customers s)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell();
            ID.Value = s.cusId;
            DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell();
            Name.Value = s.cusName;

            DataGridViewTextBoxCell PhoneNo = new DataGridViewTextBoxCell();
            PhoneNo.Value = s.cusPhone;

            DataGridViewTextBoxCell Email = new DataGridViewTextBoxCell();
            Email.Value = s.cusEmail;

            DataGridViewTextBoxCell Age = new DataGridViewTextBoxCell();
            Age.Value = s.cusAge;

            DataGridViewTextBoxCell Address = new DataGridViewTextBoxCell();
            Address.Value = s.cusAddress;

            row.Cells.Add(ID);
            row.Cells.Add(Name);
            row.Cells.Add(PhoneNo);
            row.Cells.Add(Email);
            row.Cells.Add(Age);
            row.Cells.Add(Address);
            CustomersDGV.Rows.Add(row);
        }
        int Key = 0;
        private void Reset()
        {
            Key = 0;
            searchTB.Text = "";
            DisplayCustomers();
        }

        private void CustomersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            billings.SelectedCustomer = CustomersDGV.SelectedRows[0].Cells[0].Value.ToString();
            billings.SelectedCustomerName = CustomersDGV.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Customers> list1 = new List<Customers>();
            string name = (searchTB.Text);
            list1 = customers.SearchCustomersByName(name);
            CustomersDGV.Rows.Clear();
            foreach (Customers p in list1)
            {
                AddRowToDataGrid(p);
            }
            if (list1.Count == 0)
            {
                MBox.Show("Not Available...");
                Reset();
            }
        }

        private void searchTB_Enter(object sender, EventArgs e)
        {
            if (searchTB.Text == "Customer Name")
            {
                searchTB.Text = "";
                searchTB.ForeColor = Color.Black;
            }
        }

        private void searchTB_Leave(object sender, EventArgs e)
        {
            if (searchTB.Text == "")
            {
                searchTB.Text = "Customer Name";
                searchTB.ForeColor = Color.Silver;
            }
        }

        private void ResetPB_Click(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            billings.GetCustomerAgain();
            this.Close();
            billings.Show();
        }

        private void searchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only alphabetic characters and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
