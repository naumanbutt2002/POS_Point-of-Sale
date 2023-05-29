using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    internal class Employees
    {
        private int id;
        public int empId
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }
        private string name;
        public string empName
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
        public string empPhone
        {
            get { return ph; }
            set
            {
                if (value.Length < 15)
                    ph = value;
            }
        }
        public string empDesignation { get; set; }

        private decimal salary;
        public decimal empSalary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error! Salary must be greater than 0!");
                }
                else
                {
                    salary = value;
                }
            }
        }
        public Employees()
        {
            empId = 0;
            empName = "dummy";
            empDesignation = "dummy";
            empPhone = "dummy";
            empSalary = 0;
        }
        public Employees(int id, string name, string designation, string ph, decimal salary)
        {
            empId = id;
            empName = name;
            empDesignation = designation;
            empPhone = ph;
            empSalary = salary;
        }

    }
}
