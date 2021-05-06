using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 CustomerNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer list
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        //find the record to delete
        CustomerList.ThisCustomer.Find(CustomerNo);
        //delete the record
        CustomerList.Delete();
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}