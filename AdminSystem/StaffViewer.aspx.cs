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
        if (Session["isLoggedIn"] == null)
        {
            Response.Redirect("StaffLogin.aspx");
        }
        else
        {
            if (!(bool)Session["isLoggedIn"] || Session["isLoggedIn"] == null)
            {
                Response.Redirect("StaffLogin.aspx");
            }
        }

        clsStaff staff = new clsStaff();

        staff = (clsStaff)Session["staff"];

        Response.Write("Staff ID: " + staff.ID + "<br>");
        Response.Write("Staff Username: " + staff.Username + "<br>");
        Response.Write("Staff Password: " + staff.Password + "<br>");
        Response.Write("Staff Name: " + staff.Name + "<br>");
        Response.Write("Staff Address: " + staff.Address + "<br>");
        Response.Write("Date of Creation: " + staff.DateOfCreation + "<br>");
        Response.Write("Staff Age: " + staff.Age + "<br>");
        Response.Write("Is Admin: " + staff.Admin);
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffDataEntry.aspx");
    }
}