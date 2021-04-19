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
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer.Find((int)Session["SelectedCustomerID"]);
        //display the customer number for this entry
        Response.Write("CustomerNo: " + ACustomer.CustomerNo + "<br>");
        Response.Write("Email: " + ACustomer.Email + "<br>");
        Response.Write("Name: " + ACustomer.Name + "<br>");
        Response.Write("Password: " + ACustomer.Password + "<br>");
        Response.Write("Date of Birth: " + ACustomer.DateOfBirth + "<br>");
        Response.Write("Address: " + ACustomer.Address + "<br>");
        Response.Write("Archived: " + ACustomer.Archived);
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        //redirect to Customer List
        Response.Redirect("CustomerList.aspx");
    }
}