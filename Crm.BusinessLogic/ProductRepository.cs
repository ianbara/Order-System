using Crm.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLogic
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(1);

            if (productId == 2)
            {
                product.ProductName = "Gibson S.G.";
                product.ProductDescription = "Cherry Red";
                product.CurrentPrice = 255M;
            }

            return product;
        }

        public bool Save()
        {
            return true;
        }
    }
}
