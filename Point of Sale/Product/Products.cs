using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    internal class Products
    {
        private int id;
        public int ProductId
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }
        private string name;
        public string ProductName
        {
            get { return name; }
            set
            {
                if (value.Length > 50)
                    MessageBox.Show("Error! LastName must be less than 51 characters!");
                else
                    name = value;

            }
        }
        public string Categroy { get; set; }

        private decimal price;
        public decimal ProductPrice
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Error! price must be greater than 0!");
                }
                else
                {
                    price = value;
                }
            }
        }
        private int quantity;
        public int ProductQuantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Error! quantity must be greater than 0!");
                }
                else
                {
                    quantity = value;
                }
            }
        }
        private int supId;

        public int SupID
        {
            get { return supId; }
            set
            {
                if (value > 0)
                    supId = value;
            }
        }
        public Products()
        {
            ProductId = 0;
            ProductName = "dummy";
            Categroy = "dummy";
            ProductPrice = 0;
            SupID = 0;

        }
        public Products(int productId, string productName, string categroy, decimal productPrice, int productQuantity, int supID)
        {
            ProductId = productId;
            ProductName = productName;
            Categroy = categroy;
            ProductPrice = productPrice;
            SupID = supID;
        }
    }
}
