using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
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
                Response.Redirect("StaffLogin.aspx");
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        var staff = new clsStaff();

        int staffID = Convert.ToInt32(txtStaffID.Text);
        string staffUsername = txtStaffUsername.Text;
        string staffPassword = txtStaffPassword.Text;
        string staffName = txtStaffName.Text;
        string staffAddress = txtStaffAddress.Text;
        string staffDateOfCreation = txtDateOfCreation.Text;
        int staffAge = Convert.ToInt32(txtStaffAge.Text);
        bool staffAdmin = chkAdmin.Checked;

        // Check to see if the passed information is valid.
        string error = staff.Valid(staffDateOfCreation, staffAddress, staffName, staffPassword, staffUsername, staffAge);

        if(error == "")
        {
            staff.ID = staffID;
            staff.Username = staffUsername;
            staff.Password = staffPassword;
            staff.Name = staffName;
            staff.Address = staffAddress;
            staff.DateOfCreation = Convert.ToDateTime(staffDateOfCreation);
            staff.Age = staffAge;
            staff.Admin = staffAdmin;

            Session["staff"] = staff;

            // Navigate to Staff Viewer Page.
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            // Display the error message.
            lblError.Text = error;
        } 
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
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
            lblError.Text = "<b>ERROR - THIS RECORD DOES NOT EXIST!</b>";
        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        // Sets all login session information to null.
        Session["staffUsername"] = null;
        Session["staffPassword"] = null;
        Session["isAdmin"] = false;
        Session["isLoggedIn"] = false;

        Response.Redirect("StaffLogin.aspx");
    }
}