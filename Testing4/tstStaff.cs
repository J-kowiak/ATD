using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        // Fields.
        private clsStaff staff;

        // Test Data.
        private readonly int staffID = 1;
        private readonly string staffUsername = "johndoe@gmail.com";
        private readonly string staffPassword = "test123";
        private readonly string staffName = "John Doe";
        private readonly string staffAddress = "123 Test Street";
        private readonly DateTime dateOfCreation = Convert.ToDateTime("09/03/2021");
        private readonly int staffAge = 32;
        private readonly bool staffAdmin = true;
        
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Test to see that the class exists.
            Assert.IsNotNull(this.staff);
        }

        [TestMethod]
        public void AdminOK()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Set staff's Admin property to the test data.
            this.staff.Admin = this.staffAdmin;

            // Test to see if staff's Admin property is equal to the test data.
            Assert.AreEqual(this.staff.Admin, this.staffAdmin);
        }

        [TestMethod]
        public void DateOfCreationOK()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Set staff's DateOfCreation property to the test data.
            this.staff.DateOfCreation = this.dateOfCreation;

            // Test to see if staff's DateOfCreation property is equal to the test data.
            Assert.AreEqual(this.staff.DateOfCreation, this.dateOfCreation);
        }

        [TestMethod]
        public void AddressOK()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Set staff's Address property to the test data.
            this.staff.Address = this.staffAddress;

            // Test to see if staff's Address property is equal to the test data.
            Assert.AreEqual(this.staff.Address, this.staffAddress);
        }

        [TestMethod]
        public void IDOK()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Set staff's ID property to the test data.
            this.staff.ID = this.staffID;

            // Test to see if staff's ID property is equal to the test data.
            Assert.AreEqual(this.staff.ID, this.staffID);
        }

        [TestMethod]
        public void NameOK()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Set staff's Name property to the test data.
            this.staff.Name = this.staffName;

            // Test to see if staff's Name property is equal to the test data.
            Assert.AreEqual(this.staff.Name, this.staffName);
        }

        [TestMethod]
        public void PasswordOK()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Set staff's Password property to the test data.
            this.staff.Password = this.staffPassword;

            // Test to see if staff's Password property is equal to the test data.
            Assert.AreEqual(this.staff.Password, this.staffPassword);
        }

        [TestMethod]
        public void UsernameOK()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Set staff's Username property to the test data.
            this.staff.Username = this.staffUsername;

            // Test to see if staff's Username property is equal to the test data.
            Assert.AreEqual(this.staff.Username, this.staffUsername);
        }

        [TestMethod]
        public void AgeOK()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Set staff's Age property to the test data.
            this.staff.Age = this.staffAge;

            // Test to see if staff's Age property is equal to the test data.
            Assert.AreEqual(this.staff.Age, this.staffAge);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Variable which stores whether or not the staff member exists in the database.
            Boolean found = this.staff.Find(this.staffID);

            // Test to see if the staff member exists within the database.
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Variable which stores whether or not the staff member's ID exists in the database.
            Boolean found = this.staff.Find(this.staffID);

            Boolean OK = true;

            // Checks to see if staff's ID property is equal to staffID.
            if (this.staff.ID != this.staffID)
            {
                OK = false;
            }

            // Test to see if the staff member's ID exists within the database.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAdminFound()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Variable which stores whether or not the staff member's ID exists in the database. 
            Boolean found = this.staff.Find(this.staffID);

            Boolean OK = true;

            // Checks to see if staff's Admin property is equal to true or false.
            if (!this.staff.Admin)
            {
                OK = false;
            }

            // Test to see if the staff member's admin privilege is true or false within the database.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfCreationFound()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Variable which stores whether or not the staff member's ID exists in the database. 
            Boolean found = this.staff.Find(this.staffID);

            Boolean OK = true;

            // Checks to see if the staff's DateOfCreation property is equal to dateOfCreation.
            if (this.staff.DateOfCreation != this.dateOfCreation)
            {
                OK = false;
            }

            // Tests to see if the staff member's DateOfCreation exists within the database.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Variable which stores whether or not the staff member's ID exists in the database. 
            Boolean found = this.staff.Find(this.staffID);

            Boolean OK = true;

            // Checks to see if the staff's Address property is equal to staffAddress.
            if (this.staff.Address != this.staffAddress)
            {
                OK = false;
            }

            // Tests to see if the staff member's Address exists within the database.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            Boolean found = false;

            Boolean OK = true;

            Int32 staffID = this.staffID;

            // Variable which stores whether or not the staff member's ID exists in the database. 
            found = this.staff.Find(staffID);

            // Checks to see if the staff's Address property is equal to staffName.
            if (this.staff.Name != this.staffName)
            {
                OK = false;
            }

            // Tests to see if the staff member's Name exists within the database.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPasswordFound()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Variable which stores whether or not the staff member's ID exists in the database. 
            Boolean found = this.staff.Find(this.staffID);

            Boolean OK = true;

            // Checks to see if the staff's Password property is equal to staffPassword.
            if (this.staff.Password != clsStaffLogin.HashPassword(this.staffUsername, this.staffPassword))
            {
                OK = false;
            }

            // Tests to see if the staff member's Password exists within the database.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffUsernameFound()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Variable which stores whether or not the staff member's ID exists in the database. 
            Boolean found = this.staff.Find(this.staffID);

            Boolean OK = true;

            // Checks to see if the staff's Username property is equal to staffUsername.
            if (this.staff.Username != this.staffUsername)
            {
                OK = false;
            }

            // Tests to see if the staff member's Username exists within the database.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAgeFound()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Variable which stores whether or not the staff member's ID exists in the database. 
            Boolean found = this.staff.Find(this.staffID);

            Boolean OK = true;

            // Checks to see if the staff's Age property is equal to staffAge.
            if (this.staff.Age != this.staffAge)
            {
                OK = false;
            }

            // Tests to see if the staff member's Age exists within the database.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffAddress = "";

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(staffAddress, this.staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMin()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffAddress = "n";

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(staffAddress, this.staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffAddress = "ng";

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(staffAddress, this.staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMaxLessOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffAddress = "".PadRight(49, 'n');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(staffAddress, this.staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMax()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffAddress = "".PadRight(50, 'n');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(staffAddress, this.staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffAddress = "".PadRight(51, 'n');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(staffAddress, this.staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMid()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffAddress = "".PadRight(25, 'n');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(staffAddress, this.staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffAddress = "".PadRight(500, 'n');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(staffAddress, this.staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffName = "";

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffName = "J";

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffName = "Jo";

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffName = "".PadRight(49, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffName = "".PadRight(50, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffName = "".PadRight(51, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffName = "".PadRight(25, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffName = "".PadRight(500, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, staffName, this.staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMinLessOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffPassword = "";

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMin()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffPassword = "J";

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMinPlusOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffPassword = "Jo";

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxLessOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffPassword = "".PadRight(63, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMax()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffPassword = "".PadRight(64, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxPlusOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffPassword = "".PadRight(65, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMid()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffPassword = "".PadRight(23, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordExtremeMax()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffPassword = "".PadRight(500, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, staffPassword, this.staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMinLessOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffUsername = "";

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMin()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffUsername = "J";

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMinPlusOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffUsername = "Jo";

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMaxLessOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffUsername = "".PadRight(49, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMax()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffUsername = "".PadRight(50, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMaxPlusOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffUsername = "".PadRight(51, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMid()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffUsername = "".PadRight(25, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameExtremeMax()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            string staffUsername = "".PadRight(500, 'J');

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, staffUsername, this.staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeExtremeMin()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            int staffAge = -800;

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, this.staffUsername, staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMinLessOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            int staffAge = 15;

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, this.staffUsername, staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMin()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            int staffAge = 16;

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, this.staffUsername, staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMinPlusOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            int staffAge = 17;

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, this.staffUsername, staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMaxLessOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            int staffAge = 79;

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, this.staffUsername, staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMax()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            int staffAge = 80;

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, this.staffUsername, staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMaxPlusOne()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            int staffAge = 81;

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, this.staffUsername, staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMid()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            int staffAge = 40;

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, this.staffUsername, staffAge);

            // Tests to see if the test data is valid.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeExtremeMax()
        {
            // Create an instance of clsStaff.
            this.staff = new clsStaff();

            int staffAge = 800;

            // Variable which stores error messages if the test data is not valid.
            string error = this.staff.Valid(this.staffAddress, this.staffName, this.staffPassword, this.staffUsername, staffAge);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(error, "");
        }
    }
}
