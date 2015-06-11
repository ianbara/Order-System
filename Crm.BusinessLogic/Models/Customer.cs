using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLogic.Models
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        public static int InstanceCount { get; set; }
    
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName
        {
            
            get {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public string Email { get; set; }
        public Address HomeAddress { get; set; }
        public Address WorkAddress { get; set; }


        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        }
    }
}
