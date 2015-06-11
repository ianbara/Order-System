using Crm.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLogic
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            var order = new Order(1);

            //Temp data for test
            if (orderId == 10)
            {
                var utcDateTime = new DateTime(2012, 02, 29, 12, 43, 0, DateTimeKind.Utc);
                var dto = new DateTimeOffset(utcDateTime).ToOffset(TimeSpan.FromHours(2));
                order.OrderDate = dto;
            }
            return order;
        }

        public bool Save()
        {
            return true;
        }

    }
}
