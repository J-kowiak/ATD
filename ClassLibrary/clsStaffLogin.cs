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
        private string staffUsername;
        private string staffPassword;
        private bool isLoggedIn;
        private bool isAdmin;

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

        public bool Logged
        {
            get
            {
                return this.isLoggedIn;
            }

            set
            {
                this.isLoggedIn = value;
            }
        }

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

        public bool Find(string staffUsername, string staffPassword)
        {
            var db = new clsDataConnection();

            db.AddParameter("@staffUsername", staffUsername);
            db.AddParameter("@staffPassword", HashPassword(staffUsername, staffPassword));

            db.Execute("sproc_tblStaffLogin_CheckIfCorrectDetails");

            // If one record is found.
            if (db.Count == 1)
            {
                this.staffUsername = Convert.ToString(db.DataTable.Rows[0]["staffUsername"]).Trim();
                this.staffPassword = Convert.ToString(db.DataTable.Rows[0]["staffPassword"]).Trim();
                this.isAdmin = Convert.ToBoolean(db.DataTable.Rows[0]["admin"]);
                this.isLoggedIn = true;

                return true;
            }
            // If no record is found.
            else
            {
                return false;
            }
        }

        private string HashPassword(string staffUsername, string staffPassword)
        {
            // Staff Username acts as a salt.
            string password = staffUsername + staffPassword;

            using (SHA256 hash = SHA256.Create()) // Use SHA256 hashing algorithm.
            {
                // Hashes the password.
                byte[] passwordBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                string hashedPassword = "";

                for (int i = 0; i < passwordBytes.Length; i++)
                {
                    hashedPassword += passwordBytes[i].ToString("x2"); // Formats each byte.
                }

                return hashedPassword;
            }
        }
    }
}
