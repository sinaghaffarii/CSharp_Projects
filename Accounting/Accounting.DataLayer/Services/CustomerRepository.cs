using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool DeleteCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customers GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }

        public bool InsertCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }
    }
}
