using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StaffLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
  
    }

    // Event handler for the Login button.
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // Create an instance of clsStaffLogin.
        var staffDetails = new clsStaffLogin();

        // Checks to see if the user data entered exists within the database.
        if (staffDetails.Find(txtStaffUsername.Text.ToLower(), txtStaffPassword.Text.ToLower()))
        {
            // Now set session.
            Session["staffUsername"] = staffDetails.Username;
            Session["staffPassword"] = staffDetails.Password;
            Session["isAdmin"] = staffDetails.Admin;
            Session["isLoggedIn"] = true;
            Session["staffID"] = staffDetails.ID;

            // Redirect to StaffList.
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            // Produce an user-friendly error.
            lblError.Text = "<b>WARNING - THE DETAILS YOU HAVE ENTERED ARE INCORRECT!</b>";
        }
    }
}