using Crm.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLogic
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            //temp retrieve dummy customer
            if (customerId == 1)
            {
                customer.FirstName = "Ian";
                customer.LastName = "Bareham";
            }
            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
      
    }
}
