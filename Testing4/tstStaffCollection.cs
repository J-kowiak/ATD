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
        [TestMethod]
        public void InstanceOK()
        {
            var allStaff = new clsStaffCollection();

            Assert.IsNotNull(allStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            var allStaff = new clsStaffCollection();

            List<clsStaff> staffList = new List<clsStaff>();

            var staff = new clsStaff
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

            staffList.Add(staff);

            allStaff.StaffList = staffList;

            Assert.AreEqual(allStaff.StaffList, staffList);
        }

        [TestMethod]
        public void ThisStaffMemberOK()
        {
            var allStaff = new clsStaffCollection();

            var staff = new clsStaff
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

            allStaff.ThisStaffMember = staff;

            Assert.AreEqual(allStaff.ThisStaffMember, staff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            var allStaff = new clsStaffCollection();

            List<clsStaff> staffList = new List<clsStaff>();

            var staff = new clsStaff
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

            staffList.Add(staff);

            allStaff.StaffList = staffList;

            Assert.AreEqual(allStaff.Count, staffList.Count);
        }
    }
}
