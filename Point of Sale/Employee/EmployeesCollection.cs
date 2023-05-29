using Point_of_Sale;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    internal class EmployeesCollection : ICollection<Employees>
    {
        string ConnectionString = "Data Source=DESKTOP-0I4ML49\\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";
        List<Employees> list = new List<Employees>();
        List<Employees> searchList = new List<Employees>();
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public List<Employees> ReadEmployees()
        {
            list.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From EmpTable";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Employees emp = new Employees();
                    emp.empId = sqlDataReader.GetInt32(0);
                    emp.empName = sqlDataReader.GetString(1);
                    emp.empDesignation = sqlDataReader.GetString(2);
                    emp.empPhone = sqlDataReader.GetString(3);
                    emp.empSalary = sqlDataReader.GetDecimal(4);

                    list.Add(emp);

                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return list;
        }
        public List<Employees> SearchEmployees(int id)
        {
            searchList.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From EmpTable WHERE EmpId = " + id + "";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Employees emp = new Employees();
                    emp.empId = sqlDataReader.GetInt32(0);
                    emp.empName = sqlDataReader.GetString(1);
                    emp.empDesignation = sqlDataReader.GetString(2);
                    emp.empPhone = sqlDataReader.GetString(3);
                    emp.empSalary = sqlDataReader.GetDecimal(4);
                    searchList.Add(emp);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return searchList;
        }
        public List<Employees> SearchEmployeesByName(string name)
        {
            searchList.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From EmpTable where EmpName='" + name + "'";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Employees emp = new Employees();
                    emp.empId = sqlDataReader.GetInt32(0);
                    emp.empName = sqlDataReader.GetString(1);
                    emp.empDesignation = sqlDataReader.GetString(2);
                    emp.empPhone = sqlDataReader.GetString(3);
                    emp.empSalary = sqlDataReader.GetDecimal(4);
                    searchList.Add(emp);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return searchList;
        }
        public void InsertEmployee(string name, string designation, string phone, decimal salary)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string insertQuery = "Insert into EmpTable (EmpName,EmpDesignation,EmpNo,EmpSalary) values('" + name + "','" + designation + "','" + phone + "','" + salary + "')";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                Employees emp = new Employees();
                emp.empId = list.Count + 1;
                emp.empName = name;
                emp.empDesignation = designation;
                emp.empPhone = phone;
                emp.empSalary = salary;
                list.Add(emp);
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void DeleteEmpoyee(int id)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string deleteQuery = "Delete From EmpTable WHERE EmpId = " + id + "";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                deleteCommand.ExecuteNonQuery();
                sqlConnection.Close();
                foreach (Employees s in list)
                {
                    if (s.empId == Convert.ToInt32(id))
                    {
                        list.Remove(s);
                        break;
                    }
                }
                
                MBox.Show("Employee Deleted...");
            }
            catch (Exception e)
            {
                MBox.Show(e.Message);
            }
        }
        public void UpdateEmployee(int id, string name, string designation, string phone, decimal salary)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string updateQuery = "UPDATE EmpTable SET EmpName = '" + name + "', EmpDesignation = '" + designation + "', EmpNo = '" + phone + "', EmpSalary = '" + salary + "' WHERE EmpID = " + id;
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                updateCommand.ExecuteNonQuery();
                sqlConnection.Close();
                foreach (Employees s in list)
                {
                    if (s.empId == Convert.ToInt32(id))
                    {
                        s.empName = name;
                        s.empDesignation = designation;
                        s.empPhone = phone;
                        s.empSalary = salary;
                    }
                }

                MBox.Show("Employee Updated...");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Add(Employees item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Employees item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Employees[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Employees item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Employees> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
