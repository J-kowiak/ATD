using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // Fields.
    private Int32 staffID;

    // Event handler for the load event.
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

        // Get the number of the address to be deleted from the session object.
        this.staffID = Convert.ToInt32(Session["staffID"]);
    }

    // Event handler for the Yes button.
    protected void btnYes_Click(object sender, EventArgs e)
    {
        // Create a new instance of the staff collection.
        var staffList = new clsStaffCollection();

        // Find the record to delete.
        staffList.ThisStaffMember.Find(this.staffID);

        // Delete the record.
        staffList.Delete();

        // Redirect back to the main page.
        Response.Redirect("StaffList.aspx");
    }

    // Event handler for the No button.
    protected void btnNo_Click(object sender, EventArgs e)
    {
        // Redirect back to the main page.
        Response.Redirect("StaffList.aspx");
    }
}