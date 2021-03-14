using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStaffLogin
    {
        // Fields.
        private clsStaffLogin staffLogin;

        // Test Data.
        private readonly string staffUsername = "johndoe@gmail.com";
        private readonly string staffPassword = "test123";
        private readonly bool staffAdmin = true;

        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of clsStaffLogin.
            this.staffLogin = new clsStaffLogin();

            // Test to see that the class exists.
            Assert.IsNotNull(this.staffLogin);
        }

        [TestMethod]
        public void UsernameOK()
        {
            // Create an instance of clsStaffLogin.
            this.staffLogin = new clsStaffLogin();

            // Set staffLogin's Username property to the test data.
            this.staffLogin.Username = this.staffUsername;

            // Test to see if staffLogin's Username property is equal to the test data.
            Assert.AreEqual(this.staffLogin.Username, this.staffUsername);
        }

        [TestMethod]
        public void PasswordOK()
        {
            // Create an instance of clsStaffLogin.
            this.staffLogin = new clsStaffLogin();

            // Set staffLogin's Password property to the test data.
            this.staffLogin.Password = this.staffPassword;

            // Test to see if staffLogin's Password property is equal to the test data.
            Assert.AreEqual(this.staffLogin.Password, this.staffPassword);
        }

        [TestMethod]
        public void AdminOK()
        {
            // Create an instance of clsStaffLogin.
            this.staffLogin = new clsStaffLogin();

            // Set staffLogin's Admin property to the test data.
            this.staffLogin.Admin = this.staffAdmin;

            // Test to see if staffLogin's Admin property is equal to the test data.
            Assert.AreEqual(this.staffLogin.Admin, this.staffAdmin);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of clsStaffLogin.
            this.staffLogin = new clsStaffLogin();

            // Variable which stores whether or not the staff member exists in the database.
            Boolean found = this.staffLogin.Find(this.staffUsername, this.staffPassword);

            // Test to see if the staff member exists within the database.
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestStaffUsernameFound()
        {
            // Create an instance of clsStaffLogin.
            this.staffLogin = new clsStaffLogin();

            // Variable which stores whether or not the staff member's username exists in the database.
            Boolean found = this.staffLogin.Find(this.staffUsername, this.staffPassword);

            Boolean ok = true;

            // Checks to see if staffLogin's Username property is equal to staffUsername.
            if (this.staffLogin.Username != this.staffUsername)
            {
                ok = false;
            }

            // Test to see if the staff member's username exists within the database.
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestStaffPasswordFound()
        {
            // Create an instance of clsStaffLogin.
            this.staffLogin = new clsStaffLogin();

            // Variable which stores whether or not the staff member's password exists in the database.
            Boolean found = this.staffLogin.Find(this.staffUsername, this.staffPassword);

            Boolean ok = true;

            // Checks to see if staffLogin's Password property is equal to staffUsername.
            if (this.staffLogin.Password != clsStaffLogin.HashPassword(this.staffUsername, this.staffPassword))
            {
                ok = false;
            }

            // Test to see if the staff member's password exists within the database.
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestStaffIsAdminFound()
        {
            // Create an instance of clsStaffLogin.
            this.staffLogin = new clsStaffLogin();

            // Variable which stores whether or not the staff member is an admin.
            Boolean found = this.staffLogin.Find(this.staffUsername, this.staffPassword);

            Boolean ok = true;

            // Checks to see if staffLogin's Admin property is true or false.
            if (!this.staffLogin.Admin)
            {
                ok = false;
            }

            // Test to see if the staff member's admin privilege is true or false within the database.
            Assert.IsTrue(ok);
        }
    }
}
