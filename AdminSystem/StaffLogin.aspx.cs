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

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        var staffDetails = new clsStaffLogin();
        // Is the user an admin?

        if (staffDetails.Find(txtStaffUsername.Text, txtStaffPassword.Text))
        {
            // Now set session.
            Session["staffUsername"] = staffDetails.Username;
            Session["staffPassword"] = staffDetails.Password;
            Session["isAdmin"] = staffDetails.Admin;
            Session["isLoggedIn"] = true;

            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "<b>WARNING - THE DETAILS YOU HAVE ENTERED ARE INCORRECT!</b>";
        }
    }
}