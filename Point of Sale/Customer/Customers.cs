using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    internal class Customers
    {
        private int id;
        public int cusId
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }
        private string name;
        public string cusName
        {
            get { return name; }
            set
            {
                if (value.Length > 50)
                    Console.WriteLine("Error! LastName must be less than 51 characters!");
                else
                    name = value;
            }
        }

        private string ph;
        public string cusPhone
        {
            get { return ph; }
            set
            {
                if (value.Length < 15)
                    ph = value;
            }
        }

        public string cusEmail { get; set; }
        public int cusAge { get; set; }
        public string cusAddress { get; set; }  

        public Customers()
        {
            cusId = 0;
            cusName = "dummy";
            cusPhone = "dummy";
            cusEmail = "dummy";
            cusAge = 0;
            cusAddress = "dummy";
        }
        public Customers(int id, string name, string ph, string email, int age, string address)
        {
            cusId = id;
            cusName = name;
            cusPhone = ph;
            cusEmail = email;
            cusAge = age;
            cusAddress = address;
        }
    }
}

