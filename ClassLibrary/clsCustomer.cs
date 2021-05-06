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

        public string Valid()
        {
            throw new NotImplementedException();
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

        public string Valid(string email, string dateOfBirth, string address, string name, string password)
        {
            String Error = "";
            DateTime DateTemp;
            if (name.Length == 0)
            {
                Error = Error + "Name may not be blank : ";
            }
            if (name.Length > 50)
            {
                Error = Error + "Name must be 50 characters or less: ";
            }
            if (email.Length == 0)
            {
                Error = Error + "Email may not be blank : ";
            }
            if (email.Length > 50)
            {
                Error = Error + "Email must be 50 characters or less: ";
            }
            if (password.Length == 0)
            {
                Error = Error + "Password may not be blank : ";
            }
            if (password.Length > 50)
            {
                Error = Error + "Password must be 50 characters or less: ";
            }
            if (address.Length == 0)
            {
                Error = Error + "Address may not be blank : ";
            }
            if (address.Length > 50)
            {
                Error = Error + "Address must be 50 characters or less: ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp > DateTime.Now.Date.AddYears(-13))
                {
                    Error = Error + "Date of Birth must be 13 years or older : ";
                }
                if (DateTemp < DateTime.Now.Date.AddYears(-200))
                {
                    Error = Error + "Date of Birth must 200 years or younger : ";
                }


            }
            catch
            {
                Error = Error + "the date was not a valid date : ";
            }
            //return any error messages
            return Error;
        }
    }
}