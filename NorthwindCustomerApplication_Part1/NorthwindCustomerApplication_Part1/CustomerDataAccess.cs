using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace NorthwindCustomerApp
{
    public class CustomerDataAccess
    {
        private readonly string _connectionString;

        public CustomerDataAccess()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["NorthwindDB"].ConnectionString;
        }

        public int GetCustomerCount()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Customers", conn);
                return (int)cmd.ExecuteScalar();
            }
        }

        public List<string> GetCustomerLastNames()
        {
            List<string> lastNames = new List<string>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ContactName FROM Customers", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lastNames.Add(reader["ContactName"].ToString().Split(' ')[^1]);
                }
            }
            return lastNames;
        }
    }
}
