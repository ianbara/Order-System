using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLogic.Models
{
    public class Order
    {

        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

       
        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

    }
}
