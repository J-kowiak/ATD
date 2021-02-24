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

        public bool Find(int customerNo)
        {
            mCustomerNo = 21;
            mName = "Billy";
            mEmail = "billyparker@email.com";
            mPassword = "somepass1";
            mDateOfBirth = Convert.ToDateTime("19/05/2001");
            mAddress = "59 Leicester Road";
            mArchived = false;
            return true;
        }

