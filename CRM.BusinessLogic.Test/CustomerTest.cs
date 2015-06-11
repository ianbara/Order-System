using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crm.BusinessLogic;
using Crm.BusinessLogic.Models;

namespace CRM.BusinessLogic.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullName_Test_Valid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Ian";
            customer.LastName = "Bareham";

            string expectedResult = "Bareham, Ian";

            //Act
            string actualResult = customer.FullName;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FullName_FirstName_Empty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Bareham";

            string expectedResult = "Bareham";

            //Act
            string actualResult = customer.FullName;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FullName_LastName_Empty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Ian";

            string expectedResult = "Ian";

            //Act
            string actualResult = customer.FullName;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Ian";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Kelly";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Savannah";
            Customer.InstanceCount += 1;

            //Act

            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void Validate_Valid()
        {
            //Arrange 
            var customer = new Customer();
            customer.LastName = "Bareham";
            customer.Email = "ianbara@hotmail.com";

            var expected = true;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_Invalid_LastName()
        {
            //Arrange 
            var customer = new Customer();
            customer.Email = "ianbara@hotmail.com";

            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_Invalid_Email()
        {
            //Arrange 
            var customer = new Customer();
            customer.LastName = "Bareham";

            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
