using PointOfSale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public partial class ViewBills : Form
    {
        OrderBillsCollection orderBills = new OrderBillsCollection();

        public ViewBills()
        {
            InitializeComponent();
            DisplayBills();
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu Obj = new MainMenu();
            Obj.Show();
        }
        private void DisplayBills()
        {
            List<OrderBills> list1 = new List<OrderBills>();

            list1 = orderBills.ReadOrderBills();

            SellsDGV.Rows.Clear();
            foreach (OrderBills p in list1)
            {
                AddRowToDataGrid(p);

            }
        }
        void AddRowToDataGrid(OrderBills s)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell BNO = new DataGridViewTextBoxCell();
            BNO.Value = s.billNo;
            DataGridViewTextBoxCell BDate = new DataGridViewTextBoxCell();
            BDate.Value = s.billDate;

            DataGridViewTextBoxCell CustID = new DataGridViewTextBoxCell();
            CustID.Value = s.CustId;
            DataGridViewTextBoxCell CustName = new DataGridViewTextBoxCell();
            CustName.Value = s.custName;
            DataGridViewTextBoxCell PName = new DataGridViewTextBoxCell();
            PName.Value = s.productName;
            DataGridViewTextBoxCell PQty = new DataGridViewTextBoxCell();
            PQty.Value = s.ProductQty;
            DataGridViewTextBoxCell Amount = new DataGridViewTextBoxCell();
            Amount.Value = s.BillAmount;
            row.Cells.Add(BNO);
            row.Cells.Add(BDate);
            row.Cells.Add(CustID);
            row.Cells.Add(CustName);
            row.Cells.Add(PName);
            row.Cells.Add(PQty);
            row.Cells.Add(Amount);
            SellsDGV.Rows.Add(row);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<OrderBills> list1 = new List<OrderBills>();
            string name = (searchTB.Text);
            list1 = orderBills.SearchBillsByName(name);
            SellsDGV.Rows.Clear();
            foreach (OrderBills p in list1)
            {
                AddRowToDataGrid(p);
            }
            if (list1.Count == 0)
            {
                MBox.Show("Not Available...");
            }
            Reset();
        }
        private void Reset()
        {
            key = 0;

        }
        private void ResetPB_Click(object sender, EventArgs e)
        {
            Reset();
            DisplayBills();
        }
        int key = 0;
        private void SellsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            key = Convert.ToInt32(SellsDGV.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            Reset();
            DisplayBills();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MBox.Show("SELECT THE BILL ...");
            }
            else
            {
                orderBills.DeleteBills(key);
                DisplayBills();
                Reset();
            }
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
