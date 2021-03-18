using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
      

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }

        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }

        }

        public clsStock ThisStock { get; set; }

        public clsStockCollection()
        {
            
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection Db = new clsDataConnection();

            Db.Execute("sproc_tblStock_SelectAll");

            RecordCount = Db.Count;

            while(Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                AnStock.Name = Convert.ToString(Db.DataTable.Rows[Index]["Name"]);
                AnStock.Category = Convert.ToString(Db.DataTable.Rows[Index]["Category"]);
                AnStock.Quantity = Convert.ToInt32(Db.DataTable.Rows[Index]["Quantity"]);
                AnStock.ProductId = Convert.ToInt32(Db.DataTable.Rows[Index]["ProductId"]);
                AnStock.NextDelivery = Convert.ToDateTime(Db.DataTable.Rows[Index]["NextDelivery"]);
                AnStock.Sale_Ready = Convert.ToBoolean(Db.DataTable.Rows[Index]["Sale_Ready"]);

                mStockList.Add(AnStock);
                Index++;
            }
        }
    }
}