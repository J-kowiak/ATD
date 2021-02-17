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

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.CustomerNo = Convert.ToInt32(txtName.Text);
        //capture the customer no
        ACustomer.Name = txtName.Text;
        ACustomer.Email = txtEmail.Text;
        ACustomer.Password = txtPassword.Text;
        ACustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
        ACustomer.Address = txtAddress.Text;
        //store the customer in the session object
        Session["ACustomer"] = ACustomer;
        //navigate to viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}