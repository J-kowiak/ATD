using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        private List<clsStaff> staffList;

        public clsStaffCollection()
        {
            this.staffList = new List<clsStaff>();

            Int32 index = 0;
            Int32 recordCount = 0;

            var db = new clsDataConnection();

            db.Execute("sproc_SelectAllTables");

            recordCount = db.Count;

            while (index < recordCount)
            {
                var staff = new clsStaff
                {
                    ID = Convert.ToInt32(db.DataTable.Rows[index]["staffID"]),
                    Admin = Convert.ToBoolean(db.DataTable.Rows[index]["admin"]),
                    DateOfCreation = Convert.ToDateTime(db.DataTable.Rows[index]["dateOfCreation"]),
                    Address = Convert.ToString(db.DataTable.Rows[index]["staffAddress"]),
                    Name = Convert.ToString(db.DataTable.Rows[index]["staffName"]),
                    Password = Convert.ToString(db.DataTable.Rows[index]["staffPassword"]),
                    Username = Convert.ToString(db.DataTable.Rows[index]["staffUsername"]),
                    Age = Convert.ToInt32(db.DataTable.Rows[index]["staffAge"])
                };

                this.staffList.Add(staff);

                index++;
            }
        }

        public List<clsStaff> StaffList
        {
            get
            {
                return this.staffList;
            }

            set
            {
                this.staffList = value;
            }
        }

        public int Count
        {
            get
            {
                return this.staffList.Count;
            }

            set
            {
                // NA.
            }
        }

        public clsStaff ThisStaffMember
        {
            get;

            set;
        }
    }
}