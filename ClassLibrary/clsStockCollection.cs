using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();


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

        public clsStock ThisStock {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public clsStockCollection()
        {
            

            clsDataConnection Db = new clsDataConnection();

            Db.Execute("sproc_tblStock_SelectAll");

            PopulateArray(Db);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Name", mThisStock.Name);
            DB.AddParameter("@Category", mThisStock.Category);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@NextDelivery", mThisStock.NextDelivery);
            DB.AddParameter("@Sale_Ready", mThisStock.Sale_Ready);
            //exec query returning primary value
            return DB.Execute("sproc_tblStock_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", mThisStock.ProductId);
            DB.AddParameter("@Name", mThisStock.Name);
            DB.AddParameter("@Category", mThisStock.Category);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@NextDelivery", mThisStock.NextDelivery);
            DB.AddParameter("@Sale_Ready", mThisStock.Sale_Ready);
            //exec query returning primary value
             DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            //set parameter for stored procedure
            DB.AddParameter(@"ProductId", mThisStock.ProductId);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void FilterByCategory(string Category)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Category", Category);
            DB.Execute("sproc_tblStock_FilterByCategory");
            //populate array
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection Db)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            mStockList = new List<clsStock>();

            RecordCount = Db.Count;

            while (Index < RecordCount)
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