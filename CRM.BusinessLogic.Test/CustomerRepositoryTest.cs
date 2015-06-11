using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crm.BusinessLogic;
using Crm.BusinessLogic.Models;

namespace CRM.BusinessLogic.Test
{
    /// <summary>
    /// Summary description for CustomerRepositoryTest
    /// </summary>
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void Retrieve_Existing()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Ian",
                LastName = "Bareham",
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
