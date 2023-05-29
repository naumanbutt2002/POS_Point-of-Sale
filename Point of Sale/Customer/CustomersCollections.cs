using Point_of_Sale;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    internal class CustomersCollections : ICollection<Customers>
    {
        string ConnectionString = "Data Source=DESKTOP-0I4ML49\\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";
        List<Customers> list = new List<Customers>();
        List<Customers> searchList = new List<Customers>();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public List<Customers> ReadCustomers()
        {
            list.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From CustomerTable";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Customers cus = new Customers();
                    cus.cusId = sqlDataReader.GetInt32(0);
                    cus.cusName = sqlDataReader.GetString(1);
                    cus.cusPhone = sqlDataReader.GetString(2);
                    cus.cusEmail = sqlDataReader.GetString(3);
                    cus.cusAge = sqlDataReader.GetInt32(4);
                    cus.cusAddress = sqlDataReader.GetString(5);
                    list.Add(cus);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return list;
        }
        public List<Customers> SearchCustomers(int id)
        {
            searchList.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From CustomerTable WHERE CustId = " + id + "";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Customers cus = new Customers();
                    cus.cusId = sqlDataReader.GetInt32(0);
                    cus.cusName = sqlDataReader.GetString(1);
                    cus.cusPhone = sqlDataReader.GetString(2);
                    cus.cusEmail = sqlDataReader.GetString(3);
                    cus.cusAge = sqlDataReader.GetInt32(4);
                    cus.cusAddress = sqlDataReader.GetString(5);
                    searchList.Add(cus);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return searchList;
        }
        public List<Customers> SearchCustomersByName(string name)
        {
            searchList.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From CustomerTable where CustName='" + name + "'";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Customers cus = new Customers();
                    cus.cusId = sqlDataReader.GetInt32(0);
                    cus.cusName = sqlDataReader.GetString(1);
                    cus.cusPhone = sqlDataReader.GetString(2);
                    cus.cusEmail = sqlDataReader.GetString(3);
                    cus.cusAge = sqlDataReader.GetInt32(4);
                    cus.cusAddress = sqlDataReader.GetString(5);
                    searchList.Add(cus);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return searchList;
        }
        public void InsertCustomer(string name, string ph, string email, int age, string address)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();

                string insertQuery = "Insert into CustomerTable (CustName,CustPhone,CustEmail,CustAge,CustAddress) values('" + name + "','" + ph + "','" + email + "','" + age + "','" + address + "')";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();

                Customers cus = new Customers();
                cus.cusId = list.Count() + 1;
                cus.cusName = name;
                cus.cusPhone = ph;
                cus.cusEmail = email;
                cus.cusAge = age;
                cus.cusAddress = address;
                list.Add(cus);
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MBox.Show(e.Message);
            }
        }
        public void DeleteCustomer(int id)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string deleteQuery = "Delete From CustomerTable WHERE CustId = " + id + "";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                deleteCommand.ExecuteNonQuery();
                sqlConnection.Close();

                foreach (Customers s in list)
                {
                    if (s.cusId == Convert.ToInt32(id))
                    {
                        list.Remove(s);
                        break;
                    }
                }
                MBox.Show("Customer Deleted Scuessfully");
            }
            catch (Exception)
            {
                MBox.Show("This Customer can't be deleted becasue its in bill record.");
            }
        }
        public void UpdateCustomer(int id, string name, string ph, string email, int age, string address)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();

                string updateQuery = "UPDATE CustomerTable SET CustName = '" + name + "', CustPhone = '" + ph + "', CustEmail = '" + email + "', CustAge = '" + age + "', CustAddress = '" + address + "' WHERE CustID = " + id;
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                updateCommand.ExecuteNonQuery();
                sqlConnection.Close();
                foreach (Customers s in list)
                {
                    if (s.cusId == Convert.ToInt32(id))
                    {
                        s.cusName = name;
                        s.cusPhone = ph;
                        s.cusEmail = email;
                        s.cusAge = age;
                        s.cusAddress = address;
                        break;
                    }
                }
                MBox.Show("Customer Updated...");
            }
            catch (Exception e)
            {
                MBox.Show(e.Message);
            }
        }

        public void Add(Customers item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(Customers item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Customers[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Customers item)
        {
            list.Remove(item);
            return true;
        }

        public IEnumerator<Customers> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
