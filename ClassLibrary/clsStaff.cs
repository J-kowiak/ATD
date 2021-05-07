using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        // Fields.
        private int staffID;
        private Boolean admin;
        private DateTime dateOfCreation;
        private string staffAddress;
        private string staffName;
        private string staffPassword;
        private string staffUsername;
        private int staffAge;

        private clsDataConnection db;

        // Constructor.
        public clsStaff()
        {
            this.db = new clsDataConnection();
        }

        // Methods.
        /*
         * Finds the staff memeber whose information is passed to the 
         * method's parameters.
         * 
         * If the parameters match with a record in the database, true is
         * returned, false otherwise.
         */
        public bool Find(int staffID)
        {
            // Connect to the database.
            this.db = new clsDataConnection();

            // Set the parameter for the stored procedure (sproc_tblStaff_FilterByStaffID).
            this.db.AddParameter("@staffID", staffID);

            // Execute the stored procedure.
            this.db.Execute("sproc_tblStaff_FilterByStaffID");

            // If one record is found.
            if (this.db.Count == 1)
            {
                // Copy the data from the databse to the private data members.
                // All string values are trimmed to ensure that tests pass.
                this.staffID = Convert.ToInt32(db.DataTable.Rows[0]["staffID"]);
                this.admin = Convert.ToBoolean(db.DataTable.Rows[0]["admin"]);
                this.dateOfCreation = Convert.ToDateTime(db.DataTable.Rows[0]["dateOfCreation"]);
                this.staffAddress = Convert.ToString(db.DataTable.Rows[0]["staffAddress"]);
                this.staffName = Convert.ToString(db.DataTable.Rows[0]["staffName"]);
                this.staffPassword = Convert.ToString(db.DataTable.Rows[0]["staffPassword"]);
                this.staffUsername = Convert.ToString(db.DataTable.Rows[0]["staffUsername"]);
                this.staffAge = Convert.ToInt32(db.DataTable.Rows[0]["staffAge"]);

                return true;
            }
            // If no record is found.
            else
            {
                return false;
            }
        }

        // Validates the information that the user has entered.
        public string Valid(string staffAddress, string staffName, string staffPassword, string staffUsername, string staffAge)
        {
            // Variable to store the error message.
            string error = "";

            if (staffAddress.Length == 0)
            {
                error += "The staff address may not be blank : ";
            }

            if (staffAddress.Length > 50)
            {
                error += "The staff address must be less than or equal to 50 characters : ";
            }

            if (staffName.Length == 0)
            {
                error += "The staff name may not be blank : ";
            }

            if (staffName.Length > 50)
            {
                error += "The staff name must be less than or equal to 50 characters : ";
            }

            if (staffPassword.Length == 0)
            {
                error += "The staff password may not be blank : ";
            }

            if (staffPassword.Length > 64)
            {
                error += "The staff password must be less than or equal to 64 characters : ";
            }

            if (staffUsername.Length == 0)
            {
                error += "The staff username may not be blank : ";
            }

            if (staffUsername.Length > 50)
            {
                error += "The staff username must be less than or equal to 50 characters : ";
            }

            try
            {
                int age = Convert.ToInt32(staffAge);

                if (age > 80)
                {
                    error += "The staff age must be younger than 81 : ";
                }

                if (age < 16)
                {
                    error += "The staff age must be older than 15 : ";
                }
            }
            catch (System.FormatException)
            {
                error += "The staff age must be an integer : ";
            }

            return error;
        }

        // Getter and Setter for staff ID.
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

        // Getter and Setter for staff's admin privilege.
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

        // Getter and Setter for staff member's date of account creation.
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

        // Getter and Setter for staff member's address.
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

        // Getter and Setter for staff member's name.
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

        // Getter and Setter for staff member's password.
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

        // Getter and Setter for staff member's username.
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

        // Getter and Setter for staff member's age.
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
    }
}