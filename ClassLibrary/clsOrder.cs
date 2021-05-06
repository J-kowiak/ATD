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

        public string Valid(string orderId, string ItemName, string Price, string DateOrderMade, string ItemShipped)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the data values
            DateTime DateTemp;
            //creates a temporary variable to stor int
            int TempInt;
            //creates a temporary variable to store double floating point
            double TempDouble;
            //creates a temporary variable to store a boolean
            Boolean TempBool;
            

            //if the ItemName is blank
            if (ItemName.Length == 0)
            {
                //Record the Error
                Error = Error + "The Item name may not be blank";
            }

            if (ItemName.Length > 50)
            {
                //record the Error
                Error = Error + "The Item Name cannot be more than 50 characters.";
            }

            try
            {
                TempDouble = Convert.ToDouble(Price);
                if (TempDouble < 0.01)
                {
                    //record the Error
                    Error = Error + "The Price cannot be less than 0.01";
                }
                if (TempDouble > 10000)
                {
                    //record the Error
                    Error = Error + "The Price cannot be more than 10000";
                }
            }
            catch
            {
                //record the error
                Error = Error + "That is not a double";
            }

            try
            {
                TempBool = Convert.ToBoolean(ItemShipped);
                if (TempBool =! true || false)
                {
                    Error = Error + "That is not a Boolean";
                }
            }
            catch
            {
                Error = Error + "That is not a Boolean";
            }


            try
            {
                //copy the DateOrderMade value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateOrderMade);
               
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            try
            {
                TempInt = Convert.ToInt32(orderId);
                if (TempInt < 1)
                {
                    //record the Error
                    Error = Error + "The orderId cannot be blank";
                }
            }
            catch
            {
                //record the error
                Error = Error + "That is not an integer";
            }

            return Error;



        }
            //return any error messages    
            //return Error;
        
    }
}