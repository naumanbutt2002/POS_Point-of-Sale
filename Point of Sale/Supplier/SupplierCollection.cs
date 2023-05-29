using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
namespace Point_of_Sale
{
    internal class SupplierCollection: ICollection<Supplier>
    {
        string ConnectionString = "Data Source=DESKTOP-0I4ML49\\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";
        List<Supplier> list = new List<Supplier>();
        List<Supplier> searchList = new List<Supplier>();

        public int Count => list.Count;
        

        public bool IsReadOnly => false;

        public List<Supplier> ReadSupplier()
        {
            list.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From SupplierTb";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    
                    Supplier sup = new Supplier();
                    sup.supId = sqlDataReader.GetInt32(0);
                    sup.supName = sqlDataReader.GetString(1);
                    sup.supplierCity = sqlDataReader.GetString(2);
                    sup.supplierPhone = sqlDataReader.GetString(3);
                    list.Add(sup);
                    
                   
                }
                sqlConnection.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;


        }
        public List<Supplier> SearchSuppliers(int id)
        {
            searchList.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From SupplierTb WHERE Supplier_ID = " + id.ToString() + "";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Supplier sup = new Supplier();
                    sup.supId = sqlDataReader.GetInt32(0);
                    sup.supName = sqlDataReader.GetString(1);
                    sup.supplierCity = sqlDataReader.GetString(2);
                    sup.supplierPhone = sqlDataReader.GetString(3);
                    searchList.Add(sup);
                }
                sqlConnection.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return searchList;
        }
        public List<Supplier> SearchSuppliersByName(string name)
        {
            searchList.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                //string selectQuery = "Select * From SupplierTb WHERE Supplier_ID = " + id.ToString() + "";
                string selectQuery = "Select * From SupplierTb where Supplier_name='" + name + "'";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Supplier sup = new Supplier();
                    sup.supId = sqlDataReader.GetInt32(0);
                    sup.supName = sqlDataReader.GetString(1);
                    sup.supplierCity = sqlDataReader.GetString(2);
                    sup.supplierPhone = sqlDataReader.GetString(3);
                    searchList.Add(sup);
                }
                sqlConnection.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return searchList;
        }

        public void InsertSupplier(string name,string city,string phone)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                sqlConnection.Open();
                
                string insertQuery = "Insert into SupplierTb (Supplier_name,Supplier_City,Supplier_phone) values('" + name + "','" + city + "','" + phone + "')";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();

                Supplier sup = new Supplier();
                sup.supId =list.Count()+1;
                sup.supName = name;
                sup.supplierCity = city;
                sup.supplierPhone = phone;
                list.Add(sup);

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void DeleteSupplier(int id)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                
                string deleteQuery = "Delete From SupplierTb WHERE Supplier_ID = " + id + "";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                deleteCommand.ExecuteNonQuery();
                
                sqlConnection.Close();

                

                foreach(Supplier s in list)
                { 
                    if (s.supId == Convert.ToInt32(id))
                    {
                        list.Remove(s);
                        break;
                    }
                }
                MBox.Show("Supplier Deleted...");

            }
            catch (Exception e)
            {
                // MessageBox.Show(e.Message);
                MBox.Show("This Supplier can't be deleted becasue its stock is available.");


            }
        }
        public void UpdateSupplier(int id,string name,string city,string phone)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string updateQuery = "UPDATE SupplierTb SET Supplier_name = '"+name+"', Supplier_City = '"+city+"', Supplier_phone = '"+phone+"' WHERE Supplier_ID = " + id;
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                updateCommand.ExecuteNonQuery();
                sqlConnection.Close();

                foreach (Supplier s in list)
                {
                    if (s.supId == Convert.ToInt32(id))
                    {
                        s.supName = name;
                        s.supplierCity = city;
                        s.supplierPhone = phone;
                        break;
                    }
                }
                MBox.Show("Supplier Updated...");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            
        }

        public void Add(Supplier item)
        {
            list.Add(item); 
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(Supplier item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Supplier[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Supplier item)
        {
            //DeleteSupplier();
            list.Remove(item);
            return true;

        }

        public IEnumerator<Supplier> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
