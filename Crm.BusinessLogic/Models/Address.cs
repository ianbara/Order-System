using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLogic.Models
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }
        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string HouseNameBuildingNo { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }

    }
}
