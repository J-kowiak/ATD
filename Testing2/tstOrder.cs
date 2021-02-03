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
    }
}
