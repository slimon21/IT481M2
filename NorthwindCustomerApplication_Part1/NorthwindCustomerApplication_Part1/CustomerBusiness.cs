using System.Collections.Generic;
using System.Data.SqlClient;

namespace NorthwindCustomerApp
{
    public class CustomerBusiness
    {
        private CustomerDataAccess _dataAccess;

        public CustomerBusiness()
        {
            _dataAccess = new CustomerDataAccess();
        }

        public int GetCustomerCount()
        {
            return _dataAccess.GetCustomerCount();
        }

        public List<string> GetCustomerLastNames()
        {
            return _dataAccess.GetCustomerLastNames();
        }
    }
}
