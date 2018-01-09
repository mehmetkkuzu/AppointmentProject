using CaserGroup.Automotive.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaserGroup.Automotive.Data.Interface
{
    public interface ICustomerDal 
    {
        bool AddCustomer(Customer customer);

        bool UpdateCustomer(Customer customer);

        bool DeleteCustomer(int id);

        Customer GetCustomerById(int id);

        List<Customer> GetCustomers();

    }
}
