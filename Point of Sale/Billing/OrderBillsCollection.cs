using Point_of_Sale;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PointOfSale
{
    internal class OrderBillsCollection: ICollection<OrderBills>
    {
        string ConnectionString = "Data Source=DESKTOP-0I4ML49\\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";
        List<OrderBills> list = new List<OrderBills>();
        List<OrderBills> searchList = new List<OrderBills>();
        

        public int Count => list.Count;

        public bool IsReadOnly => false;

        public List<OrderBills> ReadOrderBills()
        {
            list.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From BillTable";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    OrderBills b = new OrderBills();
                    b.billNo = sqlDataReader.GetInt32(0);
                    b.billDate = sqlDataReader.GetDateTime(1);
                    b.CustId= sqlDataReader.GetInt32(2);
                    b.custName= sqlDataReader.GetString(3);
                    //b.paymentMethod= sqlDataReader.GetString(4);
                    b.productName= sqlDataReader.GetString(4);
                    b.ProductQty=sqlDataReader.GetInt32(5);
                    b.BillAmount=sqlDataReader.GetDecimal(6);
                    list.Add(b);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return list;

        }

        public List<OrderBills> SearchBills(int id)
        {
            searchList.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From BillTable WHERE BNum = " + id.ToString() + "";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    OrderBills b = new OrderBills();
                    b.billNo = sqlDataReader.GetInt32(0);
                    b.billDate = sqlDataReader.GetDateTime(1);
                    b.CustId = sqlDataReader.GetInt32(2);
                    b.custName = sqlDataReader.GetString(3);
                    //b.paymentMethod = sqlDataReader.GetString(4);
                    b.productName = sqlDataReader.GetString(4);
                    b.ProductQty = sqlDataReader.GetInt32(5);
                    b.BillAmount = sqlDataReader.GetDecimal(6);
                    searchList.Add(b);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return searchList;
        }
        public void DeleteBills(int id)
        {
            searchList.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string deleteQuery = "Delete From BillTable WHERE BNum = " + id + "";
                SqlCommand selectCommand = new SqlCommand(deleteQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                sqlConnection.Close();
                foreach (OrderBills s in list)
                {
                    if (s.billNo == Convert.ToInt32(id))
                    {
                        list.Remove(s);
                        break;
                    }
                }
                MBox.Show("Bill Deleted...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<OrderBills> SearchBillsByName(string name)
        {
            searchList.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From BillTable where CustName='" + name + "'";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    OrderBills b = new OrderBills();
                    b.billNo = sqlDataReader.GetInt32(0);
                    b.billDate = sqlDataReader.GetDateTime(1);
                    b.CustId = sqlDataReader.GetInt32(2);
                    b.custName = sqlDataReader.GetString(3);
                    //b.paymentMethod = sqlDataReader.GetString(4);
                    b.productName = sqlDataReader.GetString(4);
                    b.ProductQty = sqlDataReader.GetInt32(5);
                    b.BillAmount = sqlDataReader.GetDecimal(6);
                    searchList.Add(b);
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return searchList;
        }

        string PNAME;
        int PStock, NEWQTY, PID;
        decimal PAmount;
        public void updateqty(int Pid,string Pname,int newQty)
        {
            PNAME= Pname;
            NEWQTY=newQty;
            PID = Pid;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * from ProductTable WHERE PId=@idparam";
                SqlCommand cmd = new SqlCommand(selectQuery, sqlConnection);
                cmd.Parameters.AddWithValue("@idparam", Pid);
                
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    PAmount = sqlDataReader.GetDecimal(3);
                    PStock = sqlDataReader.GetInt32(4);
                }
                
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            PStock = PStock - newQty;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("update ProductTable set PQty=@PQ where PId=@PKey", sqlConnection);

                cmd.Parameters.AddWithValue("@PQ", PStock);
                cmd.Parameters.AddWithValue("@PKey", Pid);

                cmd.ExecuteNonQuery();


                sqlConnection.Close();
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<OrderBills> InsertOrderBills(int cid, string custname)
        {
            List<OrderBills> currentlist= new List<OrderBills>();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("insert into BillTable(BDate,CustId,CustName,ProductName,ProductQty,Amount)values(@BD,@CI,@CN,@PN,@PQ,@AM)", sqlConnection);
                DateTime bdate = DateTime.Now;

                cmd.Parameters.AddWithValue("@BD", bdate);
                cmd.Parameters.AddWithValue("@CI", cid);
                cmd.Parameters.AddWithValue("@CN", custname);
                cmd.Parameters.AddWithValue("@PN", PNAME);
                cmd.Parameters.AddWithValue("@PQ", NEWQTY);
                decimal payAmount;
                payAmount = NEWQTY*PAmount;
                cmd.Parameters.AddWithValue("@AM",payAmount);

                cmd.ExecuteNonQuery();


                sqlConnection.Close();

                OrderBills b = new OrderBills();
 
                b.billNo = list.Count() + 1;
                b.billDate = bdate;
                b.CustId =cid;
                b.custName = custname;
                b.productName = PNAME;
                b.ProductQty = NEWQTY;
                b.BillAmount =payAmount;

                list.Add(b);
                currentlist.Add(b);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return currentlist;
        }
        public void DeleteOrderBills(int id)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string deleteQuery = "Delete From BillTable WHERE BNum = " + id + "";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                deleteCommand.ExecuteNonQuery();
                sqlConnection.Close();

                foreach (OrderBills s in list)
                {
                    if (s.billNo == Convert.ToInt32(id))
                    {
                        list.Remove(s);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void UpdateOrderBills(int id, DateTime date, int billCust, string name, string payMethod, string ProductName, int ProductQty, decimal payAmount)
        {
            //DateTime date = DateTime.Now;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                
                string updateQuery = "UPDATE BillTable SET BDate  = '" + date + "', CustId = '" + billCust + "', CustName = '" + name + "' ProductName = '" + ProductName + "', ProductQty = '" + ProductQty + "', Amount = '" + payAmount + "' WHERE BNum = " + id;
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                updateCommand.ExecuteNonQuery();
                sqlConnection.Close();

                foreach (OrderBills b in list)
                {
                    if (b.billNo == Convert.ToInt32(id))
                    {
                        b.billDate = date;
                        b.CustId = billCust;
                        b.custName = name;
                        //b.paymentMethod = payMethod;
                        b.productName = ProductName;
                        b.ProductQty = ProductQty;
                        b.BillAmount = payAmount;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Add(OrderBills item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(OrderBills item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(OrderBills[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(OrderBills item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<OrderBills> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
