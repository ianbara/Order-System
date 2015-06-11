using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLogic.Models
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            bool isValid = true;

            if (OrderQuantity <=0) isValid = false;
            if (OrderItemId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;


            return isValid;
        }
    }
}
