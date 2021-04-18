﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection

    {
        //private data member for list
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList
        {
            get
            { //return the private data}
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall do this later
            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }

            set
            {
                //set the private data
                mThisOrder = value;
            }
        }        

        //constructor for class
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisOrder
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();

            //return primary key of the new record
            DB.AddParameter("@ItemName", mThisOrder.ItemName);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@DateOrderMade", mThisOrder.DateOrderMade);
            DB.AddParameter("@ItemShipped", mThisOrder.ItemShipped);
            
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //adds a new record to the database based on the values of mThisOrder
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@ItemName", mThisOrder.ItemName);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@DateOrderMade", mThisOrder.DateOrderMade);
            DB.AddParameter("@ItemShipped", mThisOrder.ItemShipped);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");

        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByItemName(string ItemName)
        {
            //filters the records based on full or partial item name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the ItemName parameter to the database
            DB.AddParameter("@ItemName", ItemName);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByItemName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank Order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                AnOrder.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                AnOrder.DateOrderMade = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOrderMade"]);
                AnOrder.ItemShipped = Convert.ToBoolean(DB.DataTable.Rows[Index]["ItemShipped"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
    }
}