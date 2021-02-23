using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            // creates instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            Assert.IsNotNull(anOrder);

        }

        [TestMethod]
        public void OrderIdOK()
        {
            clsOrder anOrder = new clsOrder();

            Int32 TestData = 1;

            anOrder.OrderID = TestData;
            Assert.AreEqual(anOrder.OrderID, TestData);
        }

        [TestMethod]
        public void ItemNameOK()
        {
            clsOrder anOrder = new clsOrder();

            string TestData = "21b";

            anOrder.ItemName = TestData;
            Assert.AreEqual(anOrder.ItemName, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsOrder anOrder = new clsOrder();

            Double TestData = 1.23;

            anOrder.Price = TestData;
            Assert.AreEqual(anOrder.Price, TestData);
        }

        [TestMethod]
        public void DateOrderMadeOK()
        {
            clsOrder anOrder = new clsOrder();

            DateTime TestData = DateTime.Now.Date;

            anOrder.DateOrderMade = TestData;
            Assert.AreEqual(anOrder.DateOrderMade, TestData);
        }
        [TestMethod]
        public void ItemShippedOK()
        {
            clsOrder anOrder = new clsOrder();

            Boolean TestData = true;

            anOrder.ItemShipped = TestData;

            Assert.AreEqual(anOrder.ItemShipped, TestData);


        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class that we want to create
            clsOrder anOrder = new clsOrder();
            //Boolean variable to store the result of the validation
            Boolean found = false;
            //create some test data to use with teh method 
            Int32 OrderID = 321321;
            //invoke the method
            found = anOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(found);



        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class that we want to create
            clsOrder anOrder = new clsOrder();
            //Boolean variable to store the result of the validation
            Boolean found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with teh method 
            Int32 OrderID = 321321;
            //invoke the method
            found = anOrder.Find(OrderID);
            //check the order id
            if (anOrder.OrderID != 321321)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestItemNameOK()
        {
            //create an instance of the class that we want to create
            clsOrder anOrder = new clsOrder();
            //Boolean variable to store the result of the validation
            Boolean found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with teh method 
            Int32 OrderID = 321321;
            //invoke the method
            found = anOrder.Find(OrderID);
            //check the order id
            if (anOrder.ItemName != "Test Item")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceOK()
        {
            //create an instance of the class that we want to create
            clsOrder anOrder = new clsOrder();
            //Boolean variable to store the result of the validation
            Boolean found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with teh method 
            Int32 OrderID = 321321;
            //invoke the method
            found = anOrder.Find(OrderID);
            //check the order id
            if (anOrder.Price != 23.21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOrderMadeOK()
        {
            //create an instance of the class that we want to create
            clsOrder anOrder = new clsOrder();
            //Boolean variable to store the result of the validation
            Boolean found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with teh method 
            Int32 OrderID = 321321;
            //invoke the method
            found = anOrder.Find(OrderID);
            //check the order id
            if (anOrder.DateOrderMade != Convert.ToDateTime("23/02/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemShipped()
        {
            //create an instance of the class that we want to create
            clsOrder anOrder = new clsOrder();
            //Boolean variable to store the result of the validation
            Boolean found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with teh method 
            Int32 OrderID = 321321;
            //invoke the method
            found = anOrder.Find(OrderID);
            //check the order id
            if (anOrder.ItemShipped != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
