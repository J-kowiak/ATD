using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerNo;
        private string mName;
        private string mEmail;
        private string mPassword;
        private DateTime mDateOfBirth;
        private string mAddress;
        private bool mArchived;

        public Int32 CustomerNo
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }

        }

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
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

        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public bool Archived
        {
            get
            {
                return mArchived;
            }
            set
            {
                mArchived = value;
            }
        }

        public bool Find(int CustomerNo)
        {
            clsDataConnection db = new clsDataConnection();

            db.AddParameter("@CustomerNo", CustomerNo);

            db.Execute("sproc_tblCustomer_FilterByCustomerNo");

            // If one record is found.
            if (db.Count == 1)
            {
                // Copy the data from the databse to the private data members.
                // All string values are trimmed to ensure that tests pass.
                this.CustomerNo = Convert.ToInt32(db.DataTable.Rows[0]["CustomerNo"]);
                this.Email = Convert.ToString(db.DataTable.Rows[0]["Email"]);
                this.DateOfBirth = Convert.ToDateTime(db.DataTable.Rows[0]["DateOfBirth"]);
                this.Address = Convert.ToString(db.DataTable.Rows[0]["Address"]);
                this.Name = Convert.ToString(db.DataTable.Rows[0]["Name"]);
                this.Password = Convert.ToString(db.DataTable.Rows[0]["Password"]);
                this.Archived = Convert.ToBoolean(db.DataTable.Rows[0]["Archived"]);

                return true;
            }
            // If no record is found.
            else
            {
                return false;
            }
        }
    }
}

