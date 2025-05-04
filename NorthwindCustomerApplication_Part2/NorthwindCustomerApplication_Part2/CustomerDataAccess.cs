using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NorthwindCustomerApp
{
    public class CustomerDataAccess
    {
        private readonly string _connectionString;

        public CustomerDataAccess(string server, string database, string username, string password)
        {
            _connectionString = $"Server={server};Database={database};User Id={username};Password={password};";
        }

        public int GetCustomerCount()
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();
            var cmd = new SqlCommand("SELECT COUNT(*) FROM Customers", conn);
            return (int)cmd.ExecuteScalar();
        }

        public List<string> GetCustomerLastNames()
        {
            var lastNames = new List<string>();
            using var conn = new SqlConnection(_connectionString);
            conn.Open();
            var cmd = new SqlCommand("SELECT ContactName FROM Customers", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var name = reader["ContactName"].ToString();
                lastNames.Add(name?.Split(' ')[^1] ?? name);
            }
            return lastNames;
        }

        public int GetEmployeeCount()
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();
            var cmd = new SqlCommand("SELECT COUNT(*) FROM Employees", conn);
            return (int)cmd.ExecuteScalar();
        }

        public List<string> GetEmployeeNames()
        {
            var names = new List<string>();
            using var conn = new SqlConnection(_connectionString);
            conn.Open();
            var cmd = new SqlCommand("SELECT LastName FROM Employees", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                names.Add(reader["LastName"].ToString());
            }
            return names;
        }

        public int GetOrderCount()
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();
            var cmd = new SqlCommand("SELECT COUNT(*) FROM Orders", conn);
            return (int)cmd.ExecuteScalar();
        }

        public List<string> GetOrderSummaries()
        {
            var summaries = new List<string>();
            using var conn = new SqlConnection(_connectionString);
            conn.Open();
            var cmd = new SqlCommand("SELECT OrderID, OrderDate FROM Orders", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                summaries.Add($"Order #{reader["OrderID"]} on {reader["OrderDate"]:d}");
            }
            return summaries;
        }
    }
}
