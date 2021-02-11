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
        if (!(bool)Session["isLoggedIn"] || Session["isLoggedIn"] == null)
        {   
            Response.Redirect("StaffLogin.aspx");
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        var staff = new clsStaff
        {
            ID = Convert.ToInt32(txtStaffID.Text),
            Username = txtStaffUsername.Text,
            Password = txtStaffPassword.Text,
            Name = txtStaffName.Text,
            Address = txtStaffAddress.Text,
            DateOfCreation = Convert.ToDateTime(txtDateOfCreation.Text),
            Age = Convert.ToInt32(txtStaffAge.Text),
            Admin = chkAdmin.Checked
        };

        Session["staff"] = staff;

        // Navigate to Staff Viewer Page.
        Response.Redirect("StaffViewer.aspx");
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
        Session["staffUsername"] = null;
        Session["staffPassword"] = null;
        Session["isAdmin"] = false;
        Session["isLoggedIn"] = false;

        Response.Redirect("StaffLogin.aspx");
    }
}