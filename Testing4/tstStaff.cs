using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        private string dateOfCreation = DateTime.Now.Date.ToString();
        private string staffAddress = "112 Test Street"; 
        private string staffName = "John Doe"; 
        private string staffPassword = "test123"; 
        private string staffUsername = "JohnDoe@gmail.com"; 
        private int staffAge = 32;

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

            if (staff.Admin)
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

            if (staff.DateOfCreation != Convert.ToDateTime("05/02/2021"))
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

            if (staff.Password != "52cdd6dc7f26c0aafb3005e4d2106852cb7ba56fc4bd493dcd7116ae11a7c5f1")
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

            if (staff.Username != "janedoe@gmail.com")
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

        [TestMethod]
        public void ValidMethodOK()
        {
            var staff = new clsStaff();

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DateOfCreationExtremeMin()
        {
            var staff = new clsStaff();

            DateTime testDate = DateTime.Now.Date.AddYears(-100);

            string dateOfCreation = testDate.ToString();

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateOfCreationMinLessOne()
        {
            var staff = new clsStaff();

            DateTime testDate = DateTime.Now.Date.AddDays(-1);

            string dateOfCreation = testDate.ToString();

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateOfCreationMin()
        {
            var staff = new clsStaff();

            DateTime testDate = DateTime.Now.Date;

            string dateOfCreation = testDate.ToString();

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DateOfCreationMinPlusOne()
        {
            var staff = new clsStaff();

            DateTime testDate = DateTime.Now.Date.AddDays(1);

            string dateOfCreation = testDate.ToString();

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateOfCreationExtremeMax()
        {
            var staff = new clsStaff();

            DateTime testDate = DateTime.Now.Date.AddYears(100);

            string dateOfCreation = testDate.ToString();

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateOfCreationInvalidDate()
        {
            var staff = new clsStaff();

            string dateOfCreation = "This is not a date!";

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            var staff = new clsStaff();

            string staffAddress = "";

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMin()
        {
            var staff = new clsStaff();

            string staffAddress = "n";

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            var staff = new clsStaff();

            string staffAddress = "ng";

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMaxLessOne()
        {
            var staff = new clsStaff();

            string staffAddress = "".PadRight(49, 'n');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMax()
        {
            var staff = new clsStaff();

            string staffAddress = "".PadRight(50, 'n');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            var staff = new clsStaff();

            string staffAddress = "".PadRight(51, 'n');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMid()
        {
            var staff = new clsStaff();

            string staffAddress = "".PadRight(25, 'n');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            var staff = new clsStaff();

            string staffAddress = "".PadRight(500, 'n');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            var staff = new clsStaff();

            string staffName = "";

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            var staff = new clsStaff();

            string staffName = "J";

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            var staff = new clsStaff();

            string staffName = "Jo";

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            var staff = new clsStaff();

            string staffName = "".PadRight(49, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            var staff = new clsStaff();

            string staffName = "".PadRight(50, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            var staff = new clsStaff();

            string staffName = "".PadRight(51, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            var staff = new clsStaff();

            string staffName = "".PadRight(25, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            var staff = new clsStaff();

            string staffName = "".PadRight(500, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMinLessOne()
        {
            var staff = new clsStaff();

            string staffPassword = "";

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMin()
        {
            var staff = new clsStaff();

            string staffPassword = "J";

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMinPlusOne()
        {
            var staff = new clsStaff();

            string staffPassword = "Jo";

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxLessOne()
        {
            var staff = new clsStaff();

            string staffPassword = "".PadRight(63, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMax()
        {
            var staff = new clsStaff();

            string staffPassword = "".PadRight(64, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxPlusOne()
        {
            var staff = new clsStaff();

            string staffPassword = "".PadRight(65, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordMid()
        {
            var staff = new clsStaff();

            string staffPassword = "".PadRight(23, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffPasswordExtremeMax()
        {
            var staff = new clsStaff();

            string staffPassword = "".PadRight(500, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMinLessOne()
        {
            var staff = new clsStaff();

            string staffUsername = "";

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMin()
        {
            var staff = new clsStaff();

            string staffUsername = "J";

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMinPlusOne()
        {
            var staff = new clsStaff();

            string staffUsername = "Jo";

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMaxLessOne()
        {
            var staff = new clsStaff();

            string staffUsername = "".PadRight(49, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMax()
        {
            var staff = new clsStaff();

            string staffUsername = "".PadRight(50, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMaxPlusOne()
        {
            var staff = new clsStaff();

            string staffUsername = "".PadRight(51, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameMid()
        {
            var staff = new clsStaff();

            string staffUsername = "".PadRight(25, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffUsernameExtremeMax()
        {
            var staff = new clsStaff();

            string staffUsername = "".PadRight(500, 'J');

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeExtremeMin()
        {
            var staff = new clsStaff();

            int staffAge = -800;

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMinLessOne()
        {
            var staff = new clsStaff();

            int staffAge = 15;

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMin()
        {
            var staff = new clsStaff();

            int staffAge = 16;

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMinPlusOne()
        {
            var staff = new clsStaff();

            int staffAge = 17;

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMaxLessOne()
        {
            var staff = new clsStaff();

            int staffAge = 79;

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMax()
        {
            var staff = new clsStaff();

            int staffAge = 80;

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMaxPlusOne()
        {
            var staff = new clsStaff();

            int staffAge = 81;

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeMid()
        {
            var staff = new clsStaff();

            int staffAge = 40;

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAgeExtremeMax()
        {
            var staff = new clsStaff();

            int staffAge = 800;

            string error = staff.Valid(dateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

            Assert.AreNotEqual(error, "");
        }
    }
}
