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
            var staff = new clsStaff();

            Boolean testData = true;

            staff.Admin = testData;

            Assert.AreEqual(staff.Admin, testData);
        }

        [TestMethod]
        public void DateOfCreationOK()
        {
            var staff = new clsStaff();

            DateTime testData = DateTime.Now.Date;

            staff.DateOfCreation = testData;

            Assert.AreEqual(staff.DateOfCreation, testData);
        }

        [TestMethod]
        public void AddressOK()
        {
            var staff = new clsStaff();

            string testData = "112 Test Street";

            staff.Address = testData;

            Assert.AreEqual(staff.Address, testData);
        }

        [TestMethod]
        public void IDOK()
        {
            var staff = new clsStaff();

            Int32 testData = 1;
       
            staff.ID = testData;

            Assert.AreEqual(staff.ID, testData);
        }

        [TestMethod]
        public void NameOK()
        {
            var staff = new clsStaff();

            string testData = "John Doe";

            staff.Name = testData;

            Assert.AreEqual(staff.Name, testData);
        }

        [TestMethod]
        public void PasswordOK()
        {
            var staff = new clsStaff();

            string testData = "test123";

            staff.Password = testData;

            Assert.AreEqual(staff.Password, testData);
        }

        [TestMethod]
        public void UsernameOK()
        {
            var staff = new clsStaff();

            string testData = "johndoe1@gmail.com";

            staff.Username = testData;

            Assert.AreEqual(staff.Username, testData);
        }

        [TestMethod]
        public void AgeOK()
        {
            var staff = new clsStaff();

            int testData = 30;

            staff.Age = testData;

            Assert.AreEqual(staff.Age, testData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            var staff = new clsStaff();

            Boolean found = false;

            Int32 staffID = 2;

            found = staff.Find(staffID);

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            var staff = new clsStaff();

            Boolean found = false;

            Boolean OK = true;

            Int32 staffID = 2;

            found = staff.Find(staffID);

            if (staff.ID != 2)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAdminFound()
        {
            var staff = new clsStaff();

            Boolean found = false;

            Boolean OK = true;

            Int32 staffID = 2;

            found = staff.Find(staffID);

            if(staff.Admin)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfCreationFound()
        {
            var staff = new clsStaff();

            Boolean found = false;

            Boolean OK = true;

            Int32 staffID = 2;

            found = staff.Find(staffID);

            if(staff.DateOfCreation != Convert.ToDateTime("05/02/2021"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            var staff = new clsStaff();

            Boolean found = false;

            Boolean OK = true;

            Int32 staffID = 2;

            found = staff.Find(staffID);

            if (staff.Address != "123 Test Street")
            {
                OK = false;
            }

            Console.WriteLine(staff.Address);

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            var staff = new clsStaff();

            Boolean found = false;

            Boolean OK = true;

            Int32 staffID = 2;

            found = staff.Find(staffID);

            if (staff.Name != "Jane Doe")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPasswordFound()
        {
            var staff = new clsStaff();

            Boolean found = false;

            Boolean OK = true;

            Int32 staffID = 2;

            found = staff.Find(staffID);

            if (staff.Password != "test321")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffUsernameFound()
        {
            var staff = new clsStaff();

            Boolean found = false;

            Boolean OK = true;

            Int32 staffID = 2;

            found = staff.Find(staffID);

            if (staff.Username != "JaneDoe@gmail.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAgeFound()
        {
            var staff = new clsStaff();

            Boolean found = false;

            Boolean OK = true;

            Int32 staffID = 2;

            found = staff.Find(staffID);

            if (staff.Age != 30)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
