using System.Collections.Generic;
using IN451_Unit2_Justin_Meyer.Data;

namespace IN451_Unit2_Justin_Meyer.Business
{
    public class CustomerService
    {
        private readonly NorthwindRepository _repo;

        public CustomerService(string connectionString)
        {
            _repo = new NorthwindRepository(connectionString);
        }

        public int GetCustomerCount() => _repo.GetCustomerCount();

        public List<string> GetCustomerNames() => _repo.GetCustomerNames();

        public List<string> GetCustomerLastNames() => _repo.GetCustomerLastNames();
    }
}
