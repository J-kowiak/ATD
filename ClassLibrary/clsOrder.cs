using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the order id property
        private Int32 mOrderID;
        private string mItemName;
        private double mPrice;
        private DateTime mDateOrderMade;
        private bool mItemShipped;

        public int OrderID {
            get
            {
                //this line of code sends the data out of the property
                return mOrderID;
            }
            set
            {
                // this line of code allows data into the property
                mOrderID = value;
            }
        }
        public string ItemName {
            get
            {
                //this line of code sends the data out of the property
                return mItemName;
            }
            set
            {
                // this line of code allows data into the property
                mItemName = value;
            }
        }

        public double Price {
            get
            {
                //this line of code sends the data out of the property
                return mPrice;
            }
            set
            {
                // this line of code allows data into the property
                mPrice = value;
            }
        }
        public DateTime DateOrderMade {
            get
            {
                //this line of code sends the data out of the property
                return mDateOrderMade;
            }
            set
            {
                // this line of code allows data into the property
                mDateOrderMade = value;
            }
        }
        public bool ItemShipped {
            get
            {
                //this line of code sends the data out of the property
                return mItemShipped;
            }
            set
            {
                // this line of code allows data into the property
                mItemShipped = value;
            }
        }

        public bool Find(int orderID)
        {
            //set the private data members to the test data value
            mOrderID = 321321;
            mItemName = "Test Item";
            mPrice = 23.21;
            mDateOrderMade = Convert.ToDateTime("23/02/2021");
            mItemShipped = true;
            //always return true
            return true;
        }
    }
}