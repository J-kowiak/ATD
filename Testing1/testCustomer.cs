using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class testCustomer
    {

        //good test data
        String Email = "someemail@email.com";
        String DateOfBirth = DateTime.Now.Date.AddYears(-18).ToString();
        String Address = "12 Leicester Street";
        String Name = "Koyomi";
        String Password = "SomePass123";


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
            String TestData = "testemail@email.com";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void PasswordActive()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "somepass123";
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
            String TestData = "59 Leicester Road";
            ACustomer.Address = TestData;
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void NameActive()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "test";
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
            Int32 CustomerNo = 5;
            Found = ACustomer.Find(CustomerNo);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 5;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.CustomerNo != 5)
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
            Int32 CustomerNo = 5;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.Name != "Test")
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
            Int32 CustomerNo = 5;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.Email != "testemail@email.com")
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
            Int32 CustomerNo = 5;
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
            Int32 CustomerNo = 5;
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
            Int32 CustomerNo = 5;
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
            Int32 CustomerNo = 5;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.Archived != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Name = "";
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(500, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(500, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "";
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(500, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(500, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(13).AddDays(-1);
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-13);
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-13).AddDays(-1);
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-200).AddDays(1);
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-200);
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-200).AddDays(-1);
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            Console.WriteLine(TestDate);
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1000);
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string DateOfBirth = "this is not a date!";
            Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
            Assert.AreNotEqual(Error, "");
        }


    }
}

