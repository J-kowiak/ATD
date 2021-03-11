using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ClassLibrary
{
    public class clsStaffLogin
    {
        // Fields.
        private int staffID;
        private string staffUsername;
        private string staffPassword;
        private bool isAdmin;

        private clsDataConnection db;

        // Constructor.
        public clsStaffLogin()
        {
            this.db = new clsDataConnection();
        }

        // Methods.

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

        // Getter and Setter for staff username.
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

        // Getter and Setter for staff password.
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

        // Getter and Setter for staff's admin privilege.
        public bool Admin
        {
            get
            {
                return this.isAdmin;
            }

            set
            {
                this.isAdmin = value;
            }
        }

        /*
         * Finds the staff memeber whose information is passed to the 
         * method's parameters.
         * 
         * If the parameters match with a record in the database, true is
         * returned, false otherwise.
         */
        public bool Find(string staffUsername, string staffPassword)
        {
            //this.db = new clsDataConnection();

            this.db.AddParameter("@staffUsername", staffUsername);
            this.db.AddParameter("@staffPassword", HashPassword(staffUsername, staffPassword));

            this.db.Execute("sproc_tblStaffLogin_CheckIfCorrectDetails");

            // If one record is found.
            if (this.db.Count == 1)
            {
                this.staffID = Convert.ToInt32(this.db.DataTable.Rows[0]["staffID"]);
                this.staffUsername = Convert.ToString(this.db.DataTable.Rows[0]["staffUsername"]).Trim();
                this.staffPassword = Convert.ToString(this.db.DataTable.Rows[0]["staffPassword"]).Trim();
                this.isAdmin = Convert.ToBoolean(this.db.DataTable.Rows[0]["admin"]);

                return true;
            }
            // If no record is found.
            else
            {
                return false;
            }
        }

        // Hashes the staff member's password using SHA256.
        public static string HashPassword(string staffUsername, string staffPassword)
        {
            // Staff username acts as a salt.
            string password = staffUsername + staffPassword;

            using (SHA256 hash = SHA256.Create()) // Use SHA256 hashing algorithm.
            {
                // Hashes the password.
                byte[] passwordBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                string hashedPassword = "";

                for (int i = 0; i < passwordBytes.Length; i++)
                {
                    hashedPassword += passwordBytes[i].ToString("x2"); // Formats each byte to hexadecimal.
                }

                return hashedPassword;
            }
        }
    }
}
