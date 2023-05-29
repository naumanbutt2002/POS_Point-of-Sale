using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale
{
    internal class Supplier
    {
        private int id;
        public int supId
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }
        private string name;
        public string supName
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
        public string supplierPhone
        {
            get { return ph; }
            set
            {
                if (value.Length<15)
                    ph = value;
            }
        }

        public string supplierCity { get; set; }

        public Supplier()
        {
            supId = 0;
            supName = "dummy";
            supplierCity = "dummy";
            supplierPhone = "dummy";
        }
        public Supplier(int id,string name, string city, string ph)
        {
            supId= id;
            supName=name;
            supplierCity=city;
            supplierPhone=ph;
        }
    }
}
