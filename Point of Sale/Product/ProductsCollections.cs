using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PointOfSale
{
    internal class ProductsCollections : ICollection<Products>
    {
        string ConnectionString = "Data Source=DESKTOP-0I4ML49\\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";
        List<Products> list = new List<Products>();
        List<Products> searchList = new List<Products>();
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public List<Products> ReadProducts()
        {
            list.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From ProductTable";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Products plist = new Products();
                    plist.ProductId = sqlDataReader.GetInt32(0);
                    plist.ProductName = sqlDataReader.GetString(1);
                    plist.Categroy = sqlDataReader.GetString(2);
                    plist.ProductPrice = sqlDataReader.GetDecimal(3);
                    plist.ProductQuantity = sqlDataReader.GetInt32(4);
                    plist.SupID = sqlDataReader.GetInt32(5);
                    list.Add(plist);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;
        }

        public List<Products> SearchProducts(int id)
        {
            searchList.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From ProductTable WHERE PId = " + id + "";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Products plist = new Products();
                    plist.ProductId = sqlDataReader.GetInt32(0);
                    plist.ProductName = sqlDataReader.GetString(1);
                    plist.Categroy = sqlDataReader.GetString(2);
                    plist.ProductPrice = sqlDataReader.GetDecimal(3);
                    plist.ProductQuantity = sqlDataReader.GetInt32(4);
                    plist.SupID = sqlDataReader.GetInt32(5);
                    searchList.Add(plist);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return searchList;
        }
        public List<Products> DisplayProductswrtCat(String Category)
        {

            list.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From ProductTable where PCat='" + Category + "'";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Products plist = new Products();
                    plist.ProductId = sqlDataReader.GetInt32(0);
                    plist.ProductName = sqlDataReader.GetString(1);
                    plist.Categroy = sqlDataReader.GetString(2);
                    plist.ProductPrice = sqlDataReader.GetDecimal(3);
                    plist.ProductQuantity = sqlDataReader.GetInt32(4);
                    plist.SupID = sqlDataReader.GetInt32(5);
                    list.Add(plist);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;

        }
        
        public List<Products> SearchProducts(string nameprod)
        {
            searchList.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From ProductTable WHERE PName ='" + nameprod + "'";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Products plist = new Products();
                    plist.ProductId = sqlDataReader.GetInt32(0);
                    plist.ProductName = sqlDataReader.GetString(1);
                    plist.Categroy = sqlDataReader.GetString(2);
                    plist.ProductPrice = sqlDataReader.GetDecimal(3);
                    plist.ProductQuantity = sqlDataReader.GetInt32(4);
                    plist.SupID = sqlDataReader.GetInt32(5);
                    searchList.Add(plist);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return searchList;
        }

        public void InsertProduct(string name, string category, decimal price, int quantity, int PSup)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string insertQuery = "Insert into ProductTable (PName,PCat,PPrice,PQty,SupID) values('" + name + "','" + category + "','" + price + "','" + quantity + "','" + PSup + "')";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                Products product = new Products();
                product.ProductName = name;
                product.Categroy = category;
                product.ProductPrice = price;
                product.ProductQuantity = quantity;
                product.SupID = PSup;
                list.Add(product);
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void DeleteProduct(int id)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string deleteQuery = "Delete From ProductTable WHERE PId = " + id + "";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                deleteCommand.ExecuteNonQuery();
                foreach (Products p in list)
                {
                    if (p.ProductId == Convert.ToInt32(id))
                    {
                        list.Remove(p);
                        break;
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void UpdateProduct(int id, string name, string category, decimal price, int quantity, int PSup)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();

                string updateQuery = "UPDATE ProductTable SET PName = '" + name + "', PCat = '" + category + "', PPrice = '" + price + "', PQty = '" + quantity + "', SupId = '" + PSup + "' WHERE PId = " + id;
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                updateCommand.ExecuteNonQuery();
                foreach (Products p in list)
                {
                    if (p.ProductId == Convert.ToInt32(id))
                    {
                        p.ProductName = name;
                        p.Categroy = category;
                        p.ProductPrice = price;
                        p.ProductQuantity = quantity;
                        p.SupID = PSup;
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Add(Products item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(Products item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Products[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Products item)
        {
            list.Remove(item);
            return true;
        }

        public IEnumerator<Products> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
