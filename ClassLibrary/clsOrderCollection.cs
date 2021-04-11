using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection

    {
        //private data member for list
        List<clsOrder> mOrderList = new List<clsOrder>();

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

        public clsOrder ThisOrder { get; set; }

        //constructor for class
        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //objct for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
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