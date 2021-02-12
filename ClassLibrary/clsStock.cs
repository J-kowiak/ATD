using System;

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
            // hard coded for test
            mSale_Ready = true;
            mQuantity = 5;
            mName = "fred";
            mCategory = "Jumper";
            mNextDelivery = Convert.ToDateTime("16/09/2020");
            mProductId = 21;

            return true;
            //throw new NotImplementedException();
        }
    }
}