using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class testCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerNoActive()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            int TestData = 1;
            //assign the data to the property
            ACustomer.CustomerNo = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.CustomerNo, TestData);
        }

        [TestMethod]
        public void EmailActive()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "billyeparker@gmail.com";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void PasswordActive()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "password123";
            ACustomer.Password = TestData;
            Assert.AreEqual(ACustomer.Password, TestData);
        }

        [TestMethod]
        public void DateOfBirthActive()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateOfBirth = TestData;
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void AddressActive()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "15 Leicester Road";
            ACustomer.Address = TestData;
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void NameActive()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "Billy";
            ACustomer.Name = TestData;
            Assert.AreEqual(ACustomer.Name, TestData);
        }

        [TestMethod]
        public void ArchivedActive()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = false;
            ACustomer.Archived = TestData;
            Assert.AreEqual(ACustomer.Archived, TestData);
        }

    }
}
