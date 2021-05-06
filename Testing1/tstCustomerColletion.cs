using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerColletion
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to be assigned
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerNo = 1;
            TestItem.Email = "someemail@email.com";
            TestItem.Name = "somename";
            TestItem.Password = "somepass";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestItem.Address = "123 Leicester Street";
            TestItem.Archived = false;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void CountCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the customer
            Int32 SomeCount = 0;
            //assign the data to the customer
            AllCustomer.Count = SomeCount;
            //test to see that the two values are the same
        }

        [TestMethod]
        public void ThisCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the customer
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerNo = 1;
            TestCustomer.Email = "someemail@email.com";
            TestCustomer.Name = "somename";
            TestCustomer.Password = "somepass";
            TestCustomer.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestCustomer.Address = "123 Leicester Street";
            TestCustomer.Archived = false;
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the customer
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerNo = 1;
            TestItem.Email = "someemail@email.com";
            TestItem.Name = "somename";
            TestItem.Password = "somepass";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestItem.Address = "123 Leicester Street";
            TestItem.Archived = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the customer
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerNo = 1;
            TestItem.Email = "someemail@email.com";
            TestItem.Name = "somename";
            TestItem.Password = "somepass";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestItem.Address = "123 Leicester Street";
            TestItem.Archived = false;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerNo = 1;
            TestItem.Email = "someemail@email.com";
            TestItem.Name = "somename";
            TestItem.Password = "somepass";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestItem.Address = "123 Leicester Street";
            TestItem.Archived = false;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //modify the test data
            TestItem.CustomerNo = 2;
            TestItem.Email = "someemailmod@email.com";
            TestItem.Name = "somenamemod";
            TestItem.Password = "somepass";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Address = "1234 Leicester Street";
            TestItem.Archived = true;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerNo = 1;
            TestItem.Email = "someemail@email.com";
            TestItem.Name = "somename";
            TestItem.Password = "somepass";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestItem.Address = "123 Leicester Street";
            TestItem.Archived = false;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string
            FilteredCustomers.ReportByName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a name that doesnt exist
            FilteredCustomers.ReportByName("vbgyufdb");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that doesn't exist
            FilteredCustomers.ReportByName("test");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first ID is 12 (TO BE DECIDED)
                if (FilteredCustomers.CustomerList[0].CustomerNo != 5)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[1].CustomerNo != 6)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
