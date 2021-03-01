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
            if (db.Count == 1)
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

        public string Valid(string dateOfCreation, string staffAddress, string staffName, string staffPassword, string staffUsername, int staffAge)
        {
            string error = "";

            try
            {
                DateTime dateTemp = Convert.ToDateTime(dateOfCreation);

                if (dateTemp < DateTime.Now.Date)
                {
                    error += "The date cannot be in the past : ";
                }

                if (dateTemp > DateTime.Now.Date)
                {
                    error += "The date cannot be in the future : ";
                }
            }
            catch
            {
                error += "The date was not a valid date : ";
            }
            
            if (staffAddress.Length == 0)
            {
                error += "The staff address may not be blank : ";
            }

            if (staffAddress.Length > 50)
            {
                error += "The staff address must be less than 50 characters : ";
            }

            if (staffName.Length == 0)
            {
                error += "The staff name may not be blank : ";
            }

            if (staffName.Length > 50)
            {
                error += "The staff name must be less than 50 characters : ";
            }

            if (staffPassword.Length == 0)
            {
                error += "The staff password may not be blank : ";
            }

            if (staffPassword.Length > 64)
            {
                error += "The staff password must be less than 64 characters : ";
            }

            if (staffUsername.Length == 0)
            {
                error += "The staff username may not be blank : ";
            }

            if (staffUsername.Length > 50)
            {
                error += "The staff username must be less than 50 characters : ";
            }

            if (staffAge > 80)
            {
                error += "The staff age must be younger than 80 : ";
            }

            if (staffAge < 16)
            {
                error += "The staff age must be older than 16 : ";
            }

            if (staffAge.GetType() != typeof(int))
            {
                error += "The staff age must an integer : ";
            }

            return error;
        }
    }
}