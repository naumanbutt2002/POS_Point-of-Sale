using Point_of_Sale.login;
using PointOfSale;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public partial class Billings : Form
    {
        ProductsCollections products = new ProductsCollections();

        CustomersCollections customers = new CustomersCollections();
        OrderBillsCollection orderBills = new OrderBillsCollection();
        public String SelectedCustomer { get; set; }
        public String SelectedCustomerName { get; set; }

        public Billings()
        {
            //this.Controls.Clear();
            InitializeComponent();
            DisplayProducts();
            //GetCustomer();
        }

        //private void CNameTb_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void Billings_Load(object sender, EventArgs e)
        //{

        //}

        //private void Label12_Click(object sender, EventArgs e)
        //{

        //}

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Close();
            empLogin empLogin = new empLogin();
            empLogin.Show();
        }
        private void DisplayProducts()
        {
            List<Products> list1 = new List<Products>();

            list1 = products.ReadProducts();
            ProductsDGV.Rows.Clear();
            foreach (Products p in list1)
            {
                AddRowToDataGrid(p);

            }
        }
        void AddRowToDataGrid(Products s)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell PID = new DataGridViewTextBoxCell();
            PID.Value = s.ProductId;
            DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell();
            Name.Value = s.ProductName;

            DataGridViewTextBoxCell Cat = new DataGridViewTextBoxCell();
            Cat.Value = s.Categroy;
            DataGridViewTextBoxCell Qty = new DataGridViewTextBoxCell();
            Qty.Value = s.ProductQuantity;
            DataGridViewTextBoxCell Price = new DataGridViewTextBoxCell();
            Price.Value = s.ProductPrice;

            row.Cells.Add(PID);
            row.Cells.Add(Name);
            row.Cells.Add(Cat);
            row.Cells.Add(Qty);
            row.Cells.Add(Price);


            ProductsDGV.Rows.Add(row);

        }
        //private void GetCustName()
        //{
        //    List<Customers> list1 = new List<Customers>();

        //    list1 = customers.ReadCustomers();
        //    foreach (Customers s in list1)
        //    {
        //        string cusidc = CustIdCb.SelectedValue.ToString();
        //        if (s.cusId == Convert.ToInt32(cusidc))
        //        {
        //            CustNameTb.Text = s.cusName;
        //            break;
        //        }
        //    }
        //}
        private void SearchProducts()
        {
           
            List<Products> list1 = new List<Products>();
            string searchname = Convert.ToString(searchTB.Text);
            list1 = products.SearchProducts(searchname);
            ProductsDGV.Rows.Clear();
            foreach (Products p in list1)
            {
                AddRowToDataGrid(p);

            }

            if (list1.Count == 0)
            {
                MBox.Show("Not Available...");
            }
            Reset();
        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            SearchProducts();
            searchTB.Text = "";
        }

        private void search_refresh_Click(object sender, EventArgs e)
        {
            DisplayProducts();
            searchTB.Text = "";
        }
        //private void GetCustomer()
        //{

        //        List<Customers> list1 = new List<Customers>();
        //        List<int> list2 = new List<int>();
        //        list1 = customers.ReadCustomers();
        //        foreach (Customers s in list1)
        //        {
        //            list2.Add(s.cusId);
        //        }
        //        CustIdCb.DataSource = list2;
        //}
        public void GetCustomerAgain()
        {

            //if (SelectedCustomer != 0)
            //{
                CustIdCb.Text = SelectedCustomer.ToString();
                CustNameTb.Text = SelectedCustomerName.ToString();

            //}
            //else
            //{
            //    List<Customers> list1 = new List<Customers>();
            //    List<int> list2 = new List<int>();
            //    list1 = customers.ReadCustomers();
            //    foreach (Customers s in list1)
            //    {
            //        list2.Add(s.cusId);
            //    }
            //    CustIdCb.DataSource = list2;
            //}
        }
        private void Reset()
        {
            Pname = "";
            QtyTb.Text = "";
            CustIdCb.Text = "";

            CustNameTb.Text = "";
            CustIdCb.SelectedItem= null;

            Key = 0;
        }
      
        int Key = 0, n = 1;
        decimal total = 0;
        string Pname;
        int Pprice, PStock;
        decimal Subtotal;

        private void AddProductsbtn_Click(object sender, EventArgs e)
        {
            if(Key==0)
            {
                MBox.Show("Select a Product!");
            }
            else if (QtyTb.Text == "")
            {
                MBox.Show("Enter The Quantity!");
            }
            else if (Convert.ToInt32(QtyTb.Text)>PStock)
            {
                MBox.Show("No Enough Stock!");
            }
            else
            {
                orderBills.updateqty(Key, Pname, Convert.ToInt32(QtyTb.Text));

                List<OrderBills> list1 = new List<OrderBills>();
                list1 = orderBills.InsertOrderBills(Convert.ToInt32(CustIdCb.Text), CustNameTb.Text);

                foreach (OrderBills s in list1)
                {

                    Subtotal=s.BillAmount;   

                }
                total = total + Subtotal;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n;
                newRow.Cells[1].Value = Pname;
                newRow.Cells[2].Value = QtyTb.Text;
                newRow.Cells[3].Value = Pprice;
                newRow.Cells[4].Value = Subtotal;
                BillDGV.Rows.Add(newRow);
                n++;
                SubTotalTb.Text = "" + total;
                DisplayProducts();
                //Reset();
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        //private void CustIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    GetCustName(); 
        //}

        private void VARTb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void VARTb_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void VARTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (VARTb.Text == "")
            {

            }
            else if (SubTotalTb.Text == "")
            {
                MBox.Show("Add Products to Cart!");
                VARTb.Text = "";
            }
            else
            {
                try
                {
                    double VAT = (Convert.ToDouble(VARTb.Text) / 100) * Convert.ToInt32(SubTotalTb.Text);
                    TotTaxTb.Text = "" + VAT;
                    GrdTotalTb.Text = "" + (Convert.ToInt32(SubTotalTb.Text) + Convert.ToDouble(TotTaxTb.Text));
                }
                catch (Exception Ex)
                {
                    MBox.Show(Ex.Message);
                }
            }

        }

        private void DiscTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (DiscTb.Text == "")
            {

            }
            else if (SubTotalTb.Text == "")
            {
                MBox.Show("Add Products to Cart!");
                DiscTb.Text = "";
            }
            else
            {
                try
                {
                    double Disc = (Convert.ToDouble(DiscTb.Text) / 100) * Convert.ToInt32(SubTotalTb.Text);
                    DiscTotTb.Text = "" + Disc;
                    GrdTotalTb.Text = "" + (Convert.ToInt32(SubTotalTb.Text) + Convert.ToDouble(TotTaxTb.Text) - Convert.ToDouble(DiscTotTb.Text));
                }
                catch (Exception Ex)
                {
                    MBox.Show(Ex.Message);
                }
            }
        }
        
        int flag=0;
        private void PrintBill_Click(object sender, EventArgs e)
        {
            flag++;
            if (flag == 1)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            flag--;
        }
        

        private void PrintPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void ViewBills_Click(object sender, EventArgs e)
        {
            ViewBills_Billing Obj = new ViewBills_Billing();
            Obj.Show();
        }
        int prodid, prodqty, prodprice, tottal, pos = 60;

        private void VARTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, dot, and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one dot in the textbox
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void TotTaxTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, dot, and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one dot in the textbox
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void DiscTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, dot, and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one dot in the textbox
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void DiscTotTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, dot, and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one dot in the textbox
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void searchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CustIdCb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SubTotalTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, dot, and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one dot in the textbox
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void GrdTotalTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, dot, and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one dot in the textbox
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void findCustomer_Click(object sender, EventArgs e)
        {
            FindCustomer findCustomer = new FindCustomer();
            findCustomer.Show();
            findCustomer.TopMost = true;
            Billings bill = new Billings();
            bill.Close();
        }

        private void Billings_Load(object sender, EventArgs e)
        {
            //CustIdCb.Text = SelectedCustomer.ToString();
            //CustIdCb.SelectedValue = SelectedCustomer;
            //GetCustomer();

        }

        private void QtyTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            DiscTb.Text = "";
            VARTb.Text = "";
            GrdTotalTb.Text = "";
            SubTotalTb.Text = "";
            Reset();
            BillDGV.Rows.Clear();
        }


        string prodname;
        
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Point of Sale", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(26, 40));

            
            foreach (DataGridViewRow row in BillDGV.Rows)
            {   
                    if(Convert.ToInt32(row.Cells["Column1"].Value) == 0)
                    {
                         pos = pos + 20;
                }
                else
                {
                    prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                    prodname = "" + row.Cells["Column2"].Value;
                    prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                    prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                    tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                    e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(26, pos));
                    e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(45, pos));
                    e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(170, pos));
                    e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(120, pos));
                    e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(235, pos));
                    pos = pos + 20;
                }
                
            }

            e.Graphics.DrawString("Grand Total: Rs"+GrdTotalTb.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(50,pos+50));

            BillDGV.Rows.Clear();
            BillDGV.Refresh();

            pos = 100;
            GrdTotalTb.Text = "";
            n = 0;

        }


        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pname = ProductsDGV.SelectedRows[0].Cells[1].Value.ToString();
            //PCatCb.SelectedItem = ProductsDGV.SelectedRows[0].Cells[2].Value.ToString();
            PStock = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[3].Value.ToString());
            Pprice = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[4].Value.ToString());


            if (Pname== "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
