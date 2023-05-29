using PointOfSale;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Point_of_Sale
{
    internal class loginCollection : ICollection<loginModel>
    {
        string ConnectionString = "Data Source=DESKTOP-0I4ML49\\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";
        List<loginModel> list = new List<loginModel>();
        List<loginModel> searchList = new List<loginModel>();
        public int Count => list.Count;

        public bool IsReadOnly => false;
        public List<loginModel> Readlogins()
        {
            list.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From login_tb";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                { 
                    loginModel login = new loginModel();
                    login.UserID= sqlDataReader.GetInt32(0);
                    login.UserName = sqlDataReader.GetString(1);
                    login.Password = sqlDataReader.GetString(2);
                    login.Designation = sqlDataReader.GetString(3);
                    login.hint = sqlDataReader.GetString(4);

                    list.Add(login);
                }
                sqlConnection.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;
        }
        public void Insert(string username, string pass, string designation, string hint)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                sqlConnection.Open();
                string selectQuery = "Insert into login_tb (username,pass,designation,hint) values('" + username + "','" + pass + "','" + designation + "','" + hint + "')";

                SqlCommand insertCommand = new SqlCommand(selectQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                loginModel login = new loginModel();
                login.UserID = list.Count() + 1;
                login.UserName = username;
                login.Password = pass;
                login.Designation = designation;
                login.hint = hint;

                list.Add(login);

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public List<loginModel> FindPass(string username, string hint)
        {
            list.Clear();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                string selectQuery = "Select * From login_tb where username ='" + username + "'"+ " AND hint ='"+hint+"'" ;
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader sqlDataReader = selectCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    loginModel login = new loginModel();
                    login.UserID = sqlDataReader.GetInt32(0);
                    login.UserName = sqlDataReader.GetString(1);
                    login.Password = sqlDataReader.GetString(2);
                    login.Designation = sqlDataReader.GetString(3);
                    login.hint = sqlDataReader.GetString(4);

                    list.Add(login);
                }
                sqlConnection.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;
        }
        public void Add(loginModel item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();       
        }

        public bool Contains(loginModel item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(loginModel[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<loginModel> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(loginModel item)
        {
            list.Remove(item);
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
