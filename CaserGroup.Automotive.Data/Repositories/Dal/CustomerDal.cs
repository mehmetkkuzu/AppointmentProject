using CaserGroup.Automotive.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaserGroup.Automotive.Data.Models;
using System.Linq.Expressions;

namespace CaserGroup.Automotive.Data.Repositories.Dal
{
    public class CustomerDal : ICustomerDal
    {
        BaseRepository<Customer> operations = new BaseRepository<Customer>();

        public bool AddCustomer(Customer customer)
        {
            return operations.Add(customer);
        }

        public bool DeleteCustomer(int id)
        {
            return operations.Delete(GetCustomerById(id));
        }
        
        public Customer GetCustomerById(int id)
        {
            return operations.GetOne(id);
        }

        public List<Customer> GetCustomers()
        {
            return operations.GetAll().ToList();
        }

        public bool UpdateCustomer(Customer customer)
        {
            return operations.Update(customer);
        }
    }
}
