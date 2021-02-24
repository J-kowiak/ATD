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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //variable to store the results of validation
            Boolean Found = false;
            Int32 CustomerNo = 20;
            Found = ACustomer.Find(CustomerNo);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.CustomerNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.Name != "Billy")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.Email != "billyparker@email.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.Password != "somepass1")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.DateOfBirth != Convert.ToDateTime("19/05/2001"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.Address != "59 Leicester Road")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestArchivedFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.Archived != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

