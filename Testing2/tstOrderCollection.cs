﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);

        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderId = 1111;
            TestItem.ItemName = "Test Item";
            TestItem.ItemShipped = true;
            TestItem.Price = 22.22;
            TestItem.DateOrderMade = DateTime.Now.Date;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set properties of test Order
            TestOrder.OrderId = 1111;
            TestOrder.ItemName = "Test Item";
            TestOrder.ItemShipped = true;
            TestOrder.Price = 22.22;
            TestOrder.DateOrderMade = DateTime.Now.Date;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderId = 1111;
            TestItem.ItemName = "Test Item";
            TestItem.ItemShipped = true;
            TestItem.Price = 22.22;
            TestItem.DateOrderMade = DateTime.Now.Date;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderId = 123;
            TestItem.ItemName = "Test Item";
            TestItem.Price = 22.22;
            TestItem.DateOrderMade = DateTime.Now.Date;
            TestItem.ItemShipped = true;

            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            //add the record
            PrimaryKey = AllOrders.Add();

            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;

            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create the item of test data
            clsOrder TestItem = new clsOrder();

            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderId = 123;
            TestItem.ItemName = "Test Item";
            TestItem.Price = 22.22;
            TestItem.DateOrderMade = DateTime.Now.Date;
            TestItem.ItemShipped = true;

            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            //add the record
            PrimaryKey = AllOrders.Add();

            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;

            //modify the test data
            TestItem.OrderId = 124;
            TestItem.ItemName = "Test It3m";
            TestItem.Price = 22.33;
            TestItem.DateOrderMade = DateTime.Now.Date;
            TestItem.ItemShipped = false;

            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            //update the record
            AllOrders.Update();

            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisAddress matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderId = 1234;
            TestItem.ItemName = "Test Item3";
            TestItem.Price = 33.22;
            TestItem.DateOrderMade = DateTime.Now.Date;
            TestItem.ItemShipped = true;

            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            //add the record
            PrimaryKey = AllOrders.Add();

            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;

            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);

            //delete the record
            AllOrders.Delete();

            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByItemNameMethodOK()
        {
            //create an instance of the filtered data 
            Boolean OK = true;
            //create anm instance of the filtered data
            clsOrderCollection FilteredItems = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredItems.ReportByItemName("yyy yyy");
            //check that the correct number of records are found
            if(FilteredItems.Count == 2)
            {
                //check the first record is ID 322341
                if (FilteredItems.OrderList[0].OrderId != 322341)
                {
                    OK = false;
                }
                //check the first record is ID 322342
                if (FilteredItems.OrderList[1].OrderId != 322342)
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
        [TestMethod]
        public void ReportByItemNameNoneFound()
        {
            
            //create an instance of the filtered data
            clsOrderCollection FilteredItems = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredItems.ReportByItemName("xxx xxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredItems.Count);
        }
    }
}
