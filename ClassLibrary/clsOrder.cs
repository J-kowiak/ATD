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

        public int OrderId {
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

        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the OrderId to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedures
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found (there should be either one or zero)
            if (DB.Count==1)
            {
                //set the private data members to the test data value
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mDateOrderMade = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOrderMade"]);
                mItemShipped = Convert.ToBoolean(DB.DataTable.Rows[0]["ItemShipped"]);

                //return that everything worked Ok
                return true;
            }

            //if no record is found
            else
            {
                return false;
            }
        }
    }
}