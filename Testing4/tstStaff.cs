using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create.
            clsStaff staff = new clsStaff();

            // Test to see that it exists.
            Assert.IsNotNull(staff);
        }

        [TestMethod]
        public void AdminOK()
        {
            clsStaff staff = new clsStaff();

            Boolean testData = true;

            staff.Admin = testData;

            Assert.AreEqual(staff.Admin, testData);
        }

        [TestMethod]
        public void DateOfCreationOK()
        {
            clsStaff staff = new clsStaff();

            DateTime testData = DateTime.Now.Date;

            staff.DateOfCreation = testData;

            Assert.AreEqual(staff.DateOfCreation, testData);
        }

        [TestMethod]
        public void AddressOK()
        {
            clsStaff staff = new clsStaff();

            string testData = "112 Test Street";

            staff.Address = testData;

            Assert.AreEqual(staff.Address, testData);
        }

        [TestMethod]
        public void IDOK()
        {
            clsStaff staff = new clsStaff();

            Int32 testData = 1;
       
            staff.ID = testData;

            Assert.AreEqual(staff.ID, testData);
        }

        [TestMethod]
        public void NameOK()
        {
            clsStaff staff = new clsStaff();

            string testData = "John Doe";

            staff.Name = testData;

            Assert.AreEqual(staff.Name, testData);
        }

        [TestMethod]
        public void PasswordOK()
        {
            clsStaff staff = new clsStaff();

            string testData = "test123";

            staff.Password = testData;

            Assert.AreEqual(staff.Password, testData);
        }

        [TestMethod]
        public void UsernameOK()
        {
            clsStaff staff = new clsStaff();

            string testData = "johndoe1@gmail.com";

            staff.Username = testData;

            Assert.AreEqual(staff.Username, testData);
        }
    }
}
