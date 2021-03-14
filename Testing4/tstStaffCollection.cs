using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class tstStaffCollection
    {
        // Fields.
        private clsStaffCollection allStaff;
        private List<clsStaff> staffList;
        private clsStaff staff;

        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of clsStaffCollection.
            this.allStaff = new clsStaffCollection();

            // Test to see that the class exists.
            Assert.IsNotNull(this.allStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            // Create an instance of the clsStaffCollection class.
            this.allStaff = new clsStaffCollection();

            // Create an instance of List<clsStaff>.
            this.staffList = new List<clsStaff>();

            // Create an item of test data.
            this.staff = new clsStaff
            {
                ID = 2,
                Admin = false,
                DateOfCreation = DateTime.Now.Date,
                Address = "112 Test Road",
                Name = "Jane Doe",
                Password = "test321",
                Username = "JaneDoe@gmail.com",
                Age = 30
            };

            // Add the test item to the staff list.
            this.staffList.Add(staff);

            // Set the allStaff's StaffList property to the newly created staff list.
            this.allStaff.StaffList = this.staffList;

            // Test to see allStaff's StaffList property is equal to the newly created staff list.
            Assert.AreEqual(this.allStaff.StaffList, this.staffList);
        }

        [TestMethod]
        public void ThisStaffMemberOK()
        {
            // Create an instance of the clsStaffCollection class.
            this.allStaff = new clsStaffCollection();

            // Create an item of test data.
            this.staff = new clsStaff
            {
                ID = 2,
                Admin = false,
                DateOfCreation = DateTime.Now.Date,
                Address = "112 Test Road",
                Name = "Jane Doe",
                Password = "test321",
                Username = "JaneDoe@gmail.com",
                Age = 30
            };

            // Set the current collection's staff member to the test data.
            this.allStaff.ThisStaffMember = this.staff;

            // Test to see if the current collection's staff member is equal to the test data.
            Assert.AreEqual(this.allStaff.ThisStaffMember, this.staff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // Create an instance of the clsStaffCollection class.
            this.allStaff = new clsStaffCollection();

            // Create an instance of List<clsStaff>.
            this.staffList = new List<clsStaff>();

            // Create an item of test data.
            this.staff = new clsStaff
            {
                ID = 2,
                Admin = false,
                DateOfCreation = DateTime.Now.Date,
                Address = "112 Test Road",
                Name = "Jane Doe",
                Password = "test321",
                Username = "JaneDoe@gmail.com",
                Age = 30
            };

            // Add the test item to the staff list.
            this.staffList.Add(this.staff);

            // Set the allStaff's StaffList property to the newly created staff list.
            this.allStaff.StaffList = this.staffList;

            // Test to see if both the created lists have the same count.
            Assert.AreEqual(this.allStaff.Count, this.staffList.Count);
        }
        
        [TestMethod]
        public void AddMethodOK()
        {
            // Create an instance of the clsStaffCollection class.
            this.allStaff = new clsStaffCollection();

            // Create an item of test data.
            this.staff = new clsStaff
            {
                Admin = false,
                DateOfCreation = DateTime.Now.Date,
                Address = "84 House Lane",
                Name = "Alex Smith",
                Username = "alexsmith@gmail.com",
                Password = clsStaffLogin.HashPassword("alexsmith@gmail.com", "as123"),
                Age = 24
            };

            // Set ThisStaffMember to the staff member.
            this.allStaff.ThisStaffMember = staff;

            // Variable to store the primary key, also add the record.
            Int32 primaryKey = this.allStaff.Add();

            // Set the primary key of the test data.
            this.staff.ID = primaryKey;

            // Find the record.
            this.allStaff.ThisStaffMember.Find(primaryKey);

            // Test to see ThisStaffMember matches the test data.
            Assert.AreEqual(this.allStaff.ThisStaffMember, this.staff);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create an instance of clsStaffCollection.
            this.allStaff = new clsStaffCollection();

            // Create the item of test data.
            this.staff = new clsStaff()
            {
                Admin = false,
                DateOfCreation = DateTime.Now.Date,
                Address = "5 House Lane",
                Name = "Kerri Fisher",
                Username = "kerrifisher@gmail.com",
                Password = clsStaffLogin.HashPassword("kerrifisher@gmail.com", "kf321"),
                Age = 22
            };

            // Set ThisStaffMember to the test data.
            this.allStaff.ThisStaffMember = this.staff;

            // Variable to store the primary key, also add the record.
            Int32 primaryKey = this.allStaff.Add();

            // Set the primary key of the test data.
            this.staff.ID = primaryKey;

            // Modify the test data.
            this.staff = new clsStaff()
            {
                ID = primaryKey,
                Admin = false,
                DateOfCreation = DateTime.Now.Date,
                Address = "84 House Lane",
                Name = "Kerri Smith",
                Username = "kerrismith@hotmail.co.uk",
                Password = clsStaffLogin.HashPassword("kerrismith@hotmail.co.uk", "ks321"),
                Age = 22
            };

            // Set the record based on the new test data.
            this.allStaff.ThisStaffMember = this.staff;

            // Update the record.
            this.allStaff.Update();

            // Find the record.
            this.allStaff.ThisStaffMember.Find(primaryKey);

            // Test to see ThisStaffMember matches the test data.
            Assert.AreEqual(this.allStaff.ThisStaffMember, this.staff);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of clsStaffCollection.
            this.allStaff = new clsStaffCollection();

            // Create the item of test data.
            this.staff = new clsStaff()
            {
                Admin = true,
                DateOfCreation = DateTime.Now.Date,
                Address = "NA",
                Name = "ADMIN",
                Username = "admin@gmail.com",
                Password = clsStaffLogin.HashPassword("admin@gmail.com", "a321"),
                Age = 22
            };

            // Set ThisStaffMember to the staff member.
            this.allStaff.ThisStaffMember = staff;

            // Variable to store the primary key, also add the record.
            Int32 primaryKey = this.allStaff.Add();

            // Find the record.
            this.allStaff.ThisStaffMember.ID = primaryKey;

            // Delete the record.
            this.allStaff.Delete();

            // Now find the record.
            Boolean found = this.allStaff.ThisStaffMember.Find(primaryKey);

            // Test to see that the record was not found.
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            // Create an instance of the class containing unfiltered results.
            this.allStaff = new clsStaffCollection();

            // Create an instance of the filtered data.
            var filteredStaff = new clsStaffCollection();

            // Apply a blank string (should return all records).
            filteredStaff.ReportByName("");

            // Test to see that the two values are the same.
            Assert.AreEqual(this.allStaff.Count, filteredStaff.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            // Create an instance of the filtered data.
            var filteredStaff = new clsStaffCollection();

            // Apply a name that does not exist.
            filteredStaff.ReportByName("Ad Min");

            // Test to see that there are no records.
            Assert.AreEqual(0, filteredStaff.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            // Create an instance of the filtered data.
            var filteredStaff = new clsStaffCollection();

            // Variable to store the outcome.
            Boolean ok = true;

            // Apply a name that does exist.
            filteredStaff.ReportByName("Doe");

            // Check that the correct number of records are found.
            if (filteredStaff.Count == 2)
            {
                // Check that the first record is ID 1 (John Doe).
                if (filteredStaff.StaffList[0].ID != 1)
                {
                    ok = false;
                }

                // Check that the second record is ID 2 (Jane Doe).
                if (filteredStaff.StaffList[1].ID != 2)
                {
                    ok = false;
                }
            }
            else
            {
                ok = false;
            }

            // Test to see that there are no records.
            Assert.IsTrue(ok);
        }
    }
}
