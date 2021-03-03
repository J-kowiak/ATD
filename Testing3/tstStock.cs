using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        clsStock stock = new clsStock();
        
        [TestMethod]
        public void InstanceOK()
        {
            //Creates an instance
            
            Assert.IsNotNull(stock);
        }
        [TestMethod]
        public void Sale_ReadyPropertyOK()
        {
            // creates some data
            Boolean data = true;
            // Assigns the data to the property 
            stock.Sale_Ready = data;
            // Tests to see if the data is the same
            Assert.AreEqual(stock.Sale_Ready, data);
        }
        [TestMethod]
        public void NextDeliveryPropertyOK()
        {
            // creates some data
            DateTime data = DateTime.Now.Date;
            // Assigns the data to the property 
            stock.NextDelivery = data;
            // Tests to see if the value is the same
            Assert.AreEqual(stock.NextDelivery, data);
        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            // creates some data
            int data = 1;
            // Assigns the data to the property 
            stock.Quantity = data;
            // Tests to see if the value is the same
            Assert.AreEqual(stock.Quantity, data);
        }
        [TestMethod]
        public void CategoryPropertyOK()
        {
            // creates some data
            String data = "Jumper";
            // Assigns the data to the property 
            stock.Category = data;
            // Tests to see if the value is the same
            Assert.AreEqual(stock.Category, data);
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            // creates some data
            String data = "Navy Cotton Jumper";
            // Assigns the data to the property 
            stock.Name = data;
            // Tests to see if the value is the same
            Assert.AreEqual(stock.Name, data);
        }
        [TestMethod]
        public void ProductIdPropertyOK()
        {
            // creates some data
            int data = 1;
            // Assigns the data to the property 
            stock.ProductId = data;
            // Tests to see if the value is the same
            Assert.AreEqual(stock.ProductId, data);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            // creates some data
            Boolean found = true;
            // creates another variable
            Int32 id = 1;
            // Invokes a method
            found = stock.Find(id);
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestProductIdFound()
        {
            // Stores the result of the search
            Boolean found = false;
            // record if data is ok 
            Boolean OK = true;
            // creates another variable
            Int32 id = 1;
            // Invokes a method
            found = stock.Find(id);
            //checks productId
            if (stock.ProductId != 1)
            {
                OK = false;
            }
            // tests to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            // Stores the result of the search
            Boolean found = false;
            // record if data is ok 
            Boolean OK = true;
            // creates another variable
            Int32 id = 1;
            // Invokes a method
            found = stock.Find(id);
            //checks productId
            if (stock.Name != "Navy Cotton Jumper")
            {
                OK = false;
            }
            // tests to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCategoryFound()
        {
            // Stores the result of the search
            Boolean found = false;
            // record if data is ok 
            Boolean OK = true;
            // creates another variable
            Int32 id = 1;
            // Invokes a method
            found = stock.Find(id);
            //checks productId
            if (stock.Category != "Jumper")
            {
                OK = false;
            }
            // tests to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            // Stores the result of the search
            Boolean found = false;
            // record if data is ok 
            Boolean OK = true;
            // creates another variable
            Int32 id = 1;
            // Invokes a method
            found = stock.Find(id);
            //checks productId
            if (stock.Quantity != 50)
            {
                OK = false;
            }
            // tests to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNextDeliveryFound()
        {
            // Stores the result of the search
            Boolean found = false;
            // record if data is ok 
            Boolean OK = true;
            // creates another variable
            Int32 id = 1;
            // Invokes a method
            found = stock.Find(id);
            //checks productId
            if (stock.NextDelivery != Convert.ToDateTime("16/09/2020"))
            {
                OK = false;
            }
            // tests to see if result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSale_ReadyFound()
        {
            // Stores the result of the search
            Boolean found = false;
            // record if data is ok 
            Boolean OK = true;
            // creates another variable
            Int32 id = 1;
            // Invokes a method
            found = stock.Find(id);
            //checks productId
            if (stock.Sale_Ready != true)
            {
                OK = false;
            }
            // tests to see if result is ok
            Assert.IsTrue(OK);
        }
    }
}
