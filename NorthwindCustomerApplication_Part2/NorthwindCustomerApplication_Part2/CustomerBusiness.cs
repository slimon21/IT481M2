using System.Collections.Generic;

namespace NorthwindCustomerApp
{
    public class CustomerBusiness
    {
        private readonly CustomerDataAccess _dataAccess;

        public CustomerBusiness(string server, string database, string username, string password)
        {
            _dataAccess = new CustomerDataAccess(server, database, username, password);
        }

        public int GetCustomerCount() => _dataAccess.GetCustomerCount();
        public List<string> GetCustomerLastNames() => _dataAccess.GetCustomerLastNames();

        public int GetEmployeeCount() => _dataAccess.GetEmployeeCount();
        public List<string> GetEmployeeNames() => _dataAccess.GetEmployeeNames();

        public int GetOrderCount() => _dataAccess.GetOrderCount();
        public List<string> GetOrderSummaries() => _dataAccess.GetOrderSummaries();
    }
}
