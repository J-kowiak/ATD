using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // Fields.
        private List<clsStaff> staffList;
        private clsStaff thisStaffMember;

        private clsDataConnection db;

        // Constructor.
        public clsStaffCollection()
        {
            this.staffList = new List<clsStaff>();
            this.thisStaffMember = new clsStaff();

            // Connect to the database.
            this.db = new clsDataConnection();

            // Execute the stored procedure.
            this.db.Execute("sproc_SelectAllTables");

            // Populate the array list with the data table.
            PopulateArray(this.db);
        }

        // Methods.
        // Adds a new record to the database based on the values of thisStaffMember.
        public int Add()
        {
            // Connect to the database.
            this.db = new clsDataConnection();

            // Set the parameters for the stored procedure (sproc_Staff_Insert).
            this.db.AddParameter("@staffUsername", this.thisStaffMember.Username);
            this.db.AddParameter("@staffPassword", this.thisStaffMember.Password);
            this.db.AddParameter("@staffName", this.thisStaffMember.Name);
            this.db.AddParameter("@staffAddress", this.thisStaffMember.Address);
            this.db.AddParameter("@dateOfCreation", this.thisStaffMember.DateOfCreation);
            this.db.AddParameter("@staffAge", this.thisStaffMember.Age);
            this.db.AddParameter("@admin", this.thisStaffMember.Admin);

            // Execute the query returning the primary key value.
            return this.db.Execute("sproc_Staff_Insert");
        }

        // Updates an existing record based on the values of thisStaffMember.
        public void Update()
        {
            // Connect to the database.
            this.db = new clsDataConnection();

            // Set the parameters for the stored procedure (sproc_Staff_Update).
            this.db.AddParameter("@staffID", this.thisStaffMember.ID);
            this.db.AddParameter("@staffUsername", this.thisStaffMember.Username);
            this.db.AddParameter("@staffPassword", this.thisStaffMember.Password);
            this.db.AddParameter("@staffName", this.thisStaffMember.Name);
            this.db.AddParameter("@staffAddress", this.thisStaffMember.Address);
            this.db.AddParameter("@dateOfCreation", this.thisStaffMember.DateOfCreation);
            this.db.AddParameter("@staffAge", this.thisStaffMember.Age);
            this.db.AddParameter("@admin", this.thisStaffMember.Admin);

            // Execute the query returning the primary key value.
            this.db.Execute("sproc_Staff_Update");
        }

        // Deletes the record pointed to by thisStaffMember.
        public void Delete()
        {
            // Connect to the database.
            this.db = new clsDataConnection();

            // Set the parameter for the stored procedure (sproc_Staff_Delete).
            this.db.AddParameter("@staffID", this.thisStaffMember.ID);

            // Execute the stored procedure.
            this.db.Execute("sproc_Staff_Delete");
        }

        // Filters the records based on a full or partial name.
        public void ReportByName(string staffName)
        {
            // Connect to the database.
            this.db = new clsDataConnection();

            // Set the parameter for the stored procedure (sproc_tblStaff_FilterByName).
            this.db.AddParameter("@staffName", staffName);

            // Execute the stored procedure.
            this.db.Execute("sproc_tblStaff_FilterByName");

            // Populate the array list with the data table.
            PopulateArray(this.db);
        }

        // Populates the array list based on the data table in the paramater db.
        private void PopulateArray(clsDataConnection db)
        {
            // Variable for the index.
            Int32 index = 0;

            // Variable to store the record count.
            Int32 recordCount = db.Count;

            // Clear the private array list.
            this.staffList = new List<clsStaff>();

            // While there are records to process.
            while (index < recordCount)
            {
                // Create a blank address.
                var staff = new clsStaff()
                {
                    // Read in the fields from the current record.
                    ID = Convert.ToInt32(db.DataTable.Rows[index]["staffID"]),
                    Admin = Convert.ToBoolean(db.DataTable.Rows[index]["admin"]),
                    DateOfCreation = Convert.ToDateTime(db.DataTable.Rows[index]["dateOfCreation"]),
                    Address = Convert.ToString(db.DataTable.Rows[index]["staffAddress"]),
                    Name = Convert.ToString(db.DataTable.Rows[index]["staffName"]),
                    Password = Convert.ToString(db.DataTable.Rows[index]["staffPassword"]),
                    Username = Convert.ToString(db.DataTable.Rows[index]["staffUsername"]),
                    Age = Convert.ToInt32(db.DataTable.Rows[index]["staffAge"])
                };

                // Add the record to the private data member.
                this.staffList.Add(staff);

                // Point to the next record.
                index++;
            }
        }

        // Getter and Setter for staff member collection.
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

        // Getter for staff member collection's size.
        public int Count
        {
            get
            {
                return this.staffList.Count;
            }

            set
            {
                
            }
        }

        // Getter and Setter for current instance of clsStaff.
        public clsStaff ThisStaffMember
        {
            get
            {
                return this.thisStaffMember;
            }

            set
            {
                this.thisStaffMember = value;
            }
        }
    }
}