using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        //good teset data
        //create some test data to pass to the method
        string orderId = "123123";
        string ItemName = "Shirt";
        string Price = "23.12";
        string DateOrderMade = DateTime.Now.Date.ToString();
        string ItemShipped = "true";
        
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
            // creates instance of the class we want to create
            clsOrder anOrder = new clsOrder();

            Int32 TestData = 1;

            anOrder.OrderId = TestData;
            Assert.AreEqual(anOrder.OrderId, TestData);
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
            Int32 OrderId = 321321;
            //invoke the method
            found = anOrder.Find(OrderId);
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
            if (anOrder.OrderId != 321321)
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIdMinLessOne()
        {
            // Create an instance of clsStaff.
            clsOrder AnOrder = new clsOrder();
            //string variable to store error message
            String Error = "";
            //create variable to store the test data int
            int TestInt;
            //set the int
            TestInt = 0;
            string orderId = TestInt.ToString();

            // Variable which stores error messages if the test data is not valid.
            Error = AnOrder.Valid(orderId, this.ItemName, this.Price, this.DateOrderMade, this.ItemShipped);

            // Tests to see if the test data is valid.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdInvalidDataType()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set Date added to a non date value
            string orderId = "This is not an integer";
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ItemNameLessOne()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method 
            string ItemName = ""; //should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ItemNameMin()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method 
            string ItemName = "a"; //should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNamePlusOne()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method 
            string ItemName = "aa"; //should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxLessOne()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method 
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMax()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method 
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMid()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method 
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method 
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //should fail
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ItemNameExtremeMax()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method 
            string ItemName = ""; //should fail
            ItemName = ItemName.PadRight(500, 'a');//should fail
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            double TestDouble;
            TestDouble = 0.01;
            string Price = TestDouble.ToString(); //should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            double TestDouble;
            TestDouble = 10000.00;
            string Price = TestDouble.ToString(); //should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            double TestDouble;
            TestDouble = -0.01;
            string Price = TestDouble.ToString(); //should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            double TestDouble;
            TestDouble = 0.01;
            string Price = TestDouble.ToString(); //should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            double TestDouble;
            TestDouble = 9999.99;
            string Price = TestDouble.ToString(); //should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            double TestDouble;
            TestDouble = 10000.01;
            string Price = TestDouble.ToString(); //should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            double TestDouble;
            TestDouble = 5000.00;
            string Price = TestDouble.ToString(); //should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            double TestDouble;
            TestDouble = Double.MaxValue;
            string Price = TestDouble.ToString(); //should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMin()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            double TestDouble;
            TestDouble = Double.MinValue;
            string Price = TestDouble.ToString(); //should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidDataType()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set Date added to a non date value
            string Price = "This is not a Double";
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderMadeExtremeMin()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOrderMade = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderMadeMinLessOne()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOrderMade = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderMadeMin()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;           
            //convert the date variable to a string variable
            string DateOrderMade = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderMadeMinPlusOne()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOrderMade = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderMadeExtremeMax()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOrderMade = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderMadeInvalidData()
        {
            //create an instance of tyhe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set Date added to a non date value
            string DateOrderMade = "This is not a date";
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see that the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemShippedTrueTest()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create variable to store the Boolean
            Boolean TestBool;
            //set the Boolean to true
            TestBool = true;
            //convert the boolean variable to a string variable
            string ItemShipped = TestBool.ToString();
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemShippedFalseTest()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create variable to store the Boolean
            Boolean TestBool;
            //set the Boolean to true
            TestBool = false;
            //convert the boolean variable to a string variable
            string ItemShipped = TestBool.ToString();
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemShippedInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //convert the boolean variable to a string variable
            string ItemShipped = "This is not a Boolean";
            //invoke the method
            Error = AnOrder.Valid(orderId, ItemName, Price, DateOrderMade, ItemShipped);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        
    }
}
