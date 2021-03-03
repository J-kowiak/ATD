﻿using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mProductId;
        private Boolean mSale_Ready;
        private DateTime mNextDelivery;
        private Int32 mQuantity;
        private String mCategory;
        private String mName;

        public bool Sale_Ready {
            get
            {
                return mSale_Ready;
            }
            set
            {
                mSale_Ready = value;
            }
        }
        public DateTime NextDelivery {
            get
            {
                return mNextDelivery;
            }
            set
            {
                mNextDelivery = value;
            }
        }
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        public string Category
        {
            get
            {
                return mCategory;
            }
            set
            {
                mCategory = value;
            }
        }
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public int ProductId
        {
            get
            {
                //sends data out of the property
                return mProductId;
            }
            set
            {
                //allows data into property
                mProductId = value;
            }
                }

        public bool Find(int id)
        {

            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            // add parameter for product id to search
            DB.AddParameter("@ProductId", ProductId);
            // exec stored procedure
            DB.Execute("sproc_tblStock_FilterByProductId");
            // if found should be 1 or 0
            if (DB.Count == 1)
            {
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mCategory = Convert.ToString(DB.DataTable.Rows[0]["Category"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mNextDelivery = Convert.ToDateTime(DB.DataTable.Rows[0]["NextDelivery"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mSale_Ready = Convert.ToBoolean(DB.DataTable.Rows[0]["Sale_Ready"]);
                // returns everything that worked
                return true;
            }
            //if no record found
            else
            {
                // indicate a problem
                return false;
            }


        }
    }
}