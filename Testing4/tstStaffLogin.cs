using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStaffLogin
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create.
            clsStaffLogin staffLogin = new clsStaffLogin();

            // Test to see that it exists.
            Assert.IsNotNull(staffLogin);
        }

        [TestMethod]
        public void UsernameOK()
        {
            var staffLogin = new clsStaffLogin();

            string testData = "JohnDoe@gmail.com";

            staffLogin.Username = testData;

            Assert.AreEqual(staffLogin.Username, testData);
        }

        [TestMethod]
        public void PasswordOK()
        {
            var staffLogin = new clsStaffLogin();

            string testData = "test123";

            staffLogin.Password = testData;

            Assert.AreEqual(staffLogin.Password, testData);
        }

        [TestMethod]
        public void LoggedOK()
        {
            var staffLogin = new clsStaffLogin();

            Boolean testData = true;

            staffLogin.Logged = testData;

            Assert.AreEqual(staffLogin.Logged, testData);
        }

        [TestMethod]
        public void AdminOK()
        {
            var staffLogin = new clsStaffLogin();

            Boolean testData = true;

            staffLogin.Admin = testData;

            Assert.AreEqual(staffLogin.Admin, testData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            var staffLogin = new clsStaffLogin();

            Boolean found = false;

            string staffUsername = "johndoe@gmail.com";
            string staffPassword = "test123";

            found = staffLogin.Find(staffUsername, staffPassword);

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestStaffUsernameFound()
        {
            var staffLogin = new clsStaffLogin();

            Boolean found = false;

            Boolean OK = true;

            string staffUsername = "johndoe@gmail.com";
            string staffPassword = "test123";

            found = staffLogin.Find(staffUsername, staffPassword);

            if(staffLogin.Username != "johndoe@gmail.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPasswordFound()
        {
            var staffLogin = new clsStaffLogin();

            Boolean found = false;

            Boolean OK = true;

            string staffUsername = "johndoe@gmail.com";
            string staffPassword = "test123";

            found = staffLogin.Find(staffUsername, staffPassword);

            if (staffLogin.Password != "a41949ce331e10f588d406296f955ddbc3b54237b42e720a9e1d6b412d580741")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIsAdminFound()
        {
            var staffLogin = new clsStaffLogin();

            Boolean found = false;

            Boolean OK = true;

            string staffUsername = "johndoe@gmail.com";
            string staffPassword = "test123";

            found = staffLogin.Find(staffUsername, staffPassword);

            if (!staffLogin.Admin)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIsLoggedIn()
        {
            var staffLogin = new clsStaffLogin();

            Boolean found = false;

            Boolean OK = true;

            string staffUsername = "johndoe@gmail.com";
            string staffPassword = "test123";

            found = staffLogin.Find(staffUsername, staffPassword);

            if (!staffLogin.Logged)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
