using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Checks to see if the key "isLoggedIn" exists within the Session array.
        if (Session["isLoggedIn"] == null)
        {
            // Redirect to StaffLogin.
            Response.Redirect("StaffLogin.aspx");
        }
        else
        {
            // Checks to see if the user is logged in.
            if (!(bool)Session["isLoggedIn"] || Session["isLoggedIn"] == null)
            {
                // Redirect to StaffLogin.
                Response.Redirect("StaffLogin.aspx");
            }
        }

        // Create an instance of clsStaff.
        var staff = new clsStaff();

        /* 
         * Check to see if the selected staff member's ID is within the database, 
         * if so, populate clsStaff's properties.
         */ 
        staff.Find((int)Session["selectedStaffID"]);

        // Checks to see if the staff member has admin privileges or the if the selected user is the actual user itself.
        if ((bool)Session["isAdmin"] || (int) Session["selectedStaffID"] == (int) Session["staffID"])
        {
            // Admin view - all data is available.
            Response.Write("Staff ID: " + staff.ID + "<br>");
            Response.Write("Staff Username: " + staff.Username + "<br>");
            Response.Write("Staff Password: " + staff.Password + "<br>");
            Response.Write("Staff Name: " + staff.Name + "<br>");
            Response.Write("Staff Address: " + staff.Address + "<br>");
            Response.Write("Date of Creation: " + staff.DateOfCreation + "<br>");
            Response.Write("Staff Age: " + staff.Age + "<br>");
            Response.Write("Is Admin: " + staff.Admin);
        }
        else
        {
            // Staff member without admin privileges - some data is redacted. 
            Response.Write("Staff ID: " + staff.ID + "<br>");
            Response.Write("Staff Username: " + staff.Username + "<br>");
            Response.Write("Staff Password: REDACTED" + "<br>");
            Response.Write("Staff Name: " + staff.Name + "<br>");
            Response.Write("Staff Address: REDACTED" + "<br>");
            Response.Write("Date of Creation: " + staff.DateOfCreation + "<br>");
            Response.Write("Staff Age: " + staff.Age + "<br>");
            Response.Write("Is Admin: " + staff.Admin);
        }
    }

    // Event handler for the Back button.
    protected void btnBack_Click(object sender, EventArgs e)
    {
        // Redirect to StaffList.
        Response.Redirect("StaffList.aspx");
    }
}