using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private int staffID;
        private Boolean admin;
        private DateTime dateOfCreation;
        private string staffAddress;
        private string staffName;
        private string staffPassword;
        private string staffUsername;
        private int staffAge;

        public int ID
        {
            get
            {
                return this.staffID;
            }
            set
            {
                this.staffID = value;
            }
        }

        public bool Admin
        {
            get
            {
                return this.admin;
            }
            set
            {
                this.admin = value;
            }
        }

        public DateTime DateOfCreation
        {
            get
            {
                return this.dateOfCreation;
            }
            set
            {
                this.dateOfCreation = value;
            }
        }

        public string Address
        {
            get
            {
                return this.staffAddress;
            }
            set
            {
                this.staffAddress = value;
            }
        }

        public string Name
        {
            get
            {
                return this.staffName;
            }
            set
            {
                this.staffName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.staffPassword;
            }
            set
            {
                this.staffPassword = value;
            }
        }

        public string Username
        {
            get
            {
                return this.staffUsername;
            }
            set
            {
                this.staffUsername = value;
            }
        }

        public int Age
        {
            get
            {
                return this.staffAge;
            }
            set
            {
                this.staffAge = value;
            }
        }

        public bool Find(int staffID)
        {
            var db = new clsDataConnection();

            db.AddParameter("@staffID", staffID);

            db.Execute("sproc_tblStaff_FilterByStaffID");

            // If one record is found.
            if(db.Count == 1)
            {
                // Copy the data from the databse to the private data members.
                // All string values are trimmed to ensure that tests pass.
                this.staffID = Convert.ToInt32(db.DataTable.Rows[0]["staffID"]);
                this.admin = Convert.ToBoolean(db.DataTable.Rows[0]["admin"]);
                this.dateOfCreation = Convert.ToDateTime(db.DataTable.Rows[0]["dateOfCreation"]);
                this.staffAddress = Convert.ToString(db.DataTable.Rows[0]["staffAddress"]).Trim();
                this.staffName = Convert.ToString(db.DataTable.Rows[0]["staffName"]).Trim();
                this.staffPassword = Convert.ToString(db.DataTable.Rows[0]["staffPassword"]).Trim();
                this.staffUsername = Convert.ToString(db.DataTable.Rows[0]["staffUsername"]).Trim();
                this.staffAge = Convert.ToInt32(db.DataTable.Rows[0]["staffAge"]);

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