using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    internal class OrderBills
    {
        private int Bno;
        public int billNo
        {
            get { return Bno; }
            set
            {
                if (value > 0)
                    Bno = value;
            }
        }
        public DateTime billDate { get; set; }

        private int id;
        public int CustId
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }
        private string cname;
        public string custName
        {
            get { return cname; }
            set
            {
                if (value.Length > 50)
                    Console.WriteLine("Error! Name must be less than 51 characters!");
                else
                    cname = value;

            }
        }
        //debit card , cash , jazzcash ,easypaisa
        //private string method;
        //public string paymentMethod
        //{
        //    get { return method; }
        //    set
        //    {
        //        //if (value== "jazzcash" || value == "easypaisa" || value == "cash" || value == "debit card")
        //        //{
        //        //    method = value;
        //        //}
        //        //else
        //        //    Console.WriteLine("Enter Payment Method In Correct Fromat");
        //        method = value;


        //    }
        //}

        private string pname;
        public string productName
        {
            get { return pname; }
            set
            {
                    pname = value;

            }
        }
        private int qty;
        public int ProductQty
        {
            get { return qty; }
            set
            {
                if (value > 0)
                    qty = value;
            }
        }

        private decimal amount;
        public decimal BillAmount
        {
            get { return amount; }
            set
            {
                if (value > 0)
                    amount = value;
            }
        }

        public OrderBills()
        {
            billNo = 0;
            billDate =DateTime.Now;
            CustId =0;
            custName = "dummy";
            //paymentMethod = "dummy";
            productName = "dummy";
            ProductQty = 0;
            BillAmount = 0;
        }
        public int SelectedCustomer { get; set; }

        public OrderBills(int bno, DateTime bdate,int cid,string cname, string pname,int qty,decimal amt)
        {
            billNo = bno;
            billDate = DateTime.Now;
            CustId = cid;
            custName = cname;
            //paymentMethod = pmethod;
            productName = pname;
            ProductQty = qty;
            BillAmount = amt;
        }
    }
}
