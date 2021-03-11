using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private Int32 staffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Checks to see if 'isLoggedIn' has been set.
        if (Session["isLoggedIn"] == null)
        {
            // Redirect the user back to StaffLogin page.
            Response.Redirect("StaffLogin.aspx");
        }
        else
        {
            // If the user is not logged in.
            if (!(bool)Session["isLoggedIn"])
            {
                // Redirect to StaffLogin.
                Response.Redirect("StaffLogin.aspx");
            }
        }

        // Get the value of the ID to be processed.
        this.staffID = Convert.ToInt32(Session["staffID"]);

        // If not postback.
        if (!IsPostBack)
        {
            // If this is not a new record.
            if (this.staffID != -1)
            {
                // Display the current data for the record.
                DisplayAddress();
            }
            else
            {
                // Auto-assign not editable values.
                txtStaffID.Text = 0.ToString();
                txtDateOfCreation.Text = DateTime.Now.ToString();
            }
        }
    }

    private void DisplayAddress()
    {
        // Create an instance of clsStaffCollection.
        var staffList = new clsStaffCollection();

        // Find the record to update.
        staffList.ThisStaffMember.Find(this.staffID);

        // Display the data for this record.
        txtStaffID.Text = staffList.ThisStaffMember.ID.ToString();
        txtStaffUsername.Text = staffList.ThisStaffMember.Username;
        txtStaffPassword.Text = staffList.ThisStaffMember.Password;
        txtStaffName.Text = staffList.ThisStaffMember.Name;
        txtStaffAddress.Text = staffList.ThisStaffMember.Address;
        txtDateOfCreation.Text = staffList.ThisStaffMember.DateOfCreation.ToString();
        txtStaffAge.Text = staffList.ThisStaffMember.Age.ToString();
        chkAdmin.Checked = staffList.ThisStaffMember.Admin;
    }

    // Event handler for the OK buttton.
    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create an instance of clsStaff.
        var staff = new clsStaff();

        int staffID;
        int staffAge;
        
        // Ensure that data entered matches required data type.
        try
        {
            staffID = Convert.ToInt32(txtStaffID.Text);
            staffAge = Convert.ToInt32(txtStaffAge.Text);
        }
        catch (System.FormatException)
        {
            staffAge = -1;
            staffAge = -1;
        }

        string staffUsername = txtStaffUsername.Text;
        string staffPassword = txtStaffPassword.Text;
        string staffName = txtStaffName.Text;
        string staffAddress = txtStaffAddress.Text;
        string staffDateOfCreation = DateTime.Now.ToString();
        bool staffAdmin = chkAdmin.Checked;

        // Check to see if the passed information is valid.
        string error = staff.Valid(staffAddress, staffName, staffPassword, staffUsername, staffAge);

        // If all the data is valid.
        if (error == "")
        {
            // Set the properties of staff instance.
            staff.ID = this.staffID;
            staff.Username = staffUsername;
            staff.Password = clsStaffLogin.HashPassword(staffUsername, staffPassword);
            staff.Name = staffName;
            staff.Address = staffAddress;
            staff.DateOfCreation = Convert.ToDateTime(staffDateOfCreation);
            staff.Age = staffAge;
            staff.Admin = staffAdmin;

            // Create a new instance of clsStaffCollection.
            var staffList = new clsStaffCollection();

            // If this is a new record i.e. staffID = -1 then add the data.
            if (this.staffID == -1)
            {
                // Set the ThisStaffMember property.
                staffList.ThisStaffMember = staff;

                // Add the new record.
                staffList.Add();
            }
            // Otherwise, it must be an update.
            else
            {
                // Find the record to update.
                staffList.ThisStaffMember.Find(this.staffID);

                // Set the ThisStaffMember property.
                staffList.ThisStaffMember = staff;

                // Update the record.
                staffList.Update();
            }
            // Navigate back to StaffList Page.
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            // Display the error message.
            lblError.Text = error;
        } 
    }

    // Event handler for the Find button.
    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of clsStaff.
        var staff = new clsStaff();

        Int32 staffID;

        Boolean found = false;

        // Prevents crash if user enters a value other than an integer.
        try
        {
            staffID = Convert.ToInt32(txtStaffID.Text);
        }
        catch(System.FormatException)
        {
            staffID = -1; // Set a default value that would not exist.
        }
        
        found = staff.Find(staffID);

        // If the staff ID exists...
        if (found)
        {
            // If the user has admin privileges.
            if ((bool) Session["isAdmin"])
            {
                // Admin view - all data is available.
                txtStaffUsername.Text = staff.Username;
                txtStaffPassword.Text = staff.Password;
                txtStaffName.Text = staff.Name;
                txtStaffAddress.Text = staff.Address;
                txtDateOfCreation.Text = Convert.ToString(staff.DateOfCreation);
                txtStaffAge.Text = Convert.ToString(staff.Age);
                chkAdmin.Checked = staff.Admin;
            }
            else
            {
                // Staff member without admin privileges - some data is redacted. 
                txtStaffUsername.Text = staff.Username;
                txtStaffPassword.Text = "REDACTED";
                txtStaffName.Text = staff.Name;
                txtStaffAddress.Text = staff.Address;
                txtDateOfCreation.Text = Convert.ToString(staff.DateOfCreation);
                txtStaffAge.Text = Convert.ToString(staff.Age);
                chkAdmin.Checked = staff.Admin;
            }  
        }
        else
        {
            // Return an user-friendly error message.
            lblError.Text = "<b>ERROR - THIS RECORD DOES NOT EXIST!</b>";
        }
    }

    // Event handler for Cancel button.
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // Redirect back to StaffList.
        Response.Redirect("StaffList.aspx");
    }

    // Event handler for Logout button.
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        // Sets all login session information to null.
        Session["staffUsername"] = null;
        Session["staffPassword"] = null;
        Session["isAdmin"] = false;
        Session["isLoggedIn"] = false;
        Session["staffID"] = -1;

        // Redirect back to StaffLogin.
        Response.Redirect("StaffLogin.aspx");
    } 
}