using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

 
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later apparently
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        //Consturctor
        public clsCustomerCollection()
        {

            //object the stored procedure
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Archived", mThisCustomer.Archived);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Archived", mThisCustomer.Archived);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            //executre the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByName(string Name)
        {
            //filters the records based on a full or partial name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Name parameter to the database
            DB.AddParameter("@Name", Name);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.Archived = Convert.ToBoolean(DB.DataTable.Rows[Index]["Archived"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }
    }
}