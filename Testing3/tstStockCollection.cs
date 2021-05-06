﻿using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        clsStockCollection allStock = new clsStockCollection();
        clsStock ItemTest = new clsStock();


        [TestMethod]
        public void InstanceOk()
        {
            Assert.IsNotNull(allStock);
        }
        [TestMethod]
        public void StockListOk()
        {
            List<clsStock> TestList = new List<clsStock>();

            ItemTest.Name = "Pink Hat";
            ItemTest.Category = "HeadWear";
            ItemTest.Quantity = 70;
            ItemTest.Sale_Ready = true;
            ItemTest.NextDelivery = DateTime.Now.Date;
            ItemTest.ProductId = 1;

            TestList.Add(ItemTest);
            // Assign data to propety
            allStock.StockList = TestList;
            Assert.AreEqual(allStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOk()
        {
            clsStock TestStock = new clsStock();
            TestStock.Name = "Pink Hat";
            TestStock.Category = "HeadWear";
            TestStock.Quantity = 70;
            TestStock.Sale_Ready = true;
            TestStock.NextDelivery = DateTime.Now.Date;
            TestStock.ProductId = 1;

            allStock.ThisStock = TestStock;
            Assert.AreEqual(allStock.ThisStock, TestStock);

        }



        [TestMethod]
        public void AddMethodOk()
        {
            Int32 PrimaryKey = 0;

            ItemTest.Name = "Pink Hat";
            ItemTest.Category = "HeadWear";
            ItemTest.Quantity = 70;
            ItemTest.Sale_Ready = true;
            ItemTest.NextDelivery = DateTime.Now.Date;

            // sets to test data
            allStock.ThisStock = ItemTest;
            //add record
            PrimaryKey = allStock.Add();
            //set primary key to test data
            ItemTest.ProductId = PrimaryKey;
            //find record
            allStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(allStock.ThisStock, ItemTest);

        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            Int32 PrimaryKey = 0;
            //set its propeties
            ItemTest.Name = "Pink Hat";
            ItemTest.Category = "HeadWear";
            ItemTest.Quantity = 70;
            ItemTest.Sale_Ready = true;
            ItemTest.NextDelivery = DateTime.Now.Date;

            // sets to test data
            allStock.ThisStock = ItemTest;
            PrimaryKey = allStock.Add();
            ItemTest.ProductId = PrimaryKey;

            //modifiying data

            ItemTest.Name = "Blue Gloves";
            ItemTest.Category = "HandWear";
            ItemTest.Quantity = 25;
            ItemTest.Sale_Ready = false;
            ItemTest.NextDelivery = DateTime.Now.Date;
            ItemTest.ProductId = PrimaryKey;

            allStock.ThisStock = ItemTest;
            allStock.Update();
            allStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(allStock.ThisStock, ItemTest);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            Int32 primaryKey = 0;
            ItemTest.Sale_Ready = true;
            ItemTest.ProductId = 0;
            ItemTest.Quantity = 100;
            ItemTest.Name = "Black mask";
            ItemTest.Category = "FaceWear";
            ItemTest.NextDelivery = DateTime.Now;

            allStock.ThisStock = ItemTest;
            primaryKey = allStock.Add();
            ItemTest.ProductId = primaryKey;
            allStock.ThisStock.Find(primaryKey);
            allStock.Delete();
            Boolean Found = allStock.ThisStock.Find(primaryKey);
            Assert.IsFalse(Found);
            
        }
        [TestMethod]
        public void FilterByCategoryOk()
        {
            //creates an instance of filtered data
            clsStockCollection filteredStock = new clsStockCollection();
            filteredStock.FilterByCategory("");
            Assert.AreEqual(allStock.Count, filteredStock.Count);
        }
        [TestMethod]
        public void FilterByCategoryNoneFoundOk()
        {
            //creates an instance of filtered data
            clsStockCollection filteredStock = new clsStockCollection();
            filteredStock.FilterByCategory("XXX XX");
            Assert.AreEqual(0,filteredStock.Count);
        }

        [TestMethod]
        public void FilterByCategoryFoundOk()
        {
            //creates an instance of filtered data
            clsStockCollection filteredStock = new clsStockCollection();
            Boolean OK = true;
            filteredStock.FilterByCategory("xx");
            //checks if correct number of records found
            if(filteredStock.Count == 2)
            {
                if(filteredStock.StockList[0].ProductId != 3)
                {
                    OK = false;
                }
                if (filteredStock.StockList[1].ProductId != 6)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
