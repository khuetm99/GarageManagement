using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;

namespace GarageManagement_DAL
{
    public class DataProvider
    {
        private static DataProvider instance;

       internal static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }
        private string ConnectionString = @"Data Source=" + Dns.GetHostName() + ";Initial Catalog=GARAGEMANAGEMENT;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listParameter = query.Split(' ');
                        int i = 0;
                        foreach (string item in listParameter)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listParameter = query.Split(' ');
                        int i = 0;
                        foreach (string item in listParameter)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteNonQuery();
                    connection.Close(); 
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {                
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listParameter = query.Split(' ');
                        int i = 0;
                        foreach (string item in listParameter)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteScalar();               
                    connection.Close();
            }
            return data;
        }
    }
}
