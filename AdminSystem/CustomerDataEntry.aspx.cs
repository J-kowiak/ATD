using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    //variable to store the primary key with page level scope
    Int32 CustomerNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {


            if (CustomerNo != -1)
            {
                //update the list box
                DisplayCustomers();
            }
        }
    }

    private void DisplayCustomers()
    {
        //create an instance of the customer collection
        var Customers = new clsCustomerCollection();
        //find the record to update
        Customers.ThisCustomer.Find(this.CustomerNo);
        //display the data for this record
        txtCustomerNo.Text = Customers.ThisCustomer.CustomerNo.ToString();
        txtName.Text = Customers.ThisCustomer.Name;
        txtEmail.Text = Customers.ThisCustomer.Email;
        txtDateOfBirth.Text = Customers.ThisCustomer.DateOfBirth.ToString();
        txtPassword.Text = Customers.ThisCustomer.Password;
        txtAddress.Text = Customers.ThisCustomer.Address;
        chkArchived.Checked = Customers.ThisCustomer.Archived;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string Password = txtPassword.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string Address = txtAddress.Text;
        String Error = "";
        Error = ACustomer.Valid(Email, DateOfBirth, Address, Name, Password);
        if (Error == "")
        {
            ACustomer.CustomerNo = CustomerNo;
            ACustomer.Name = txtName.Text;
            ACustomer.Email = txtEmail.Text;
            ACustomer.Password = txtPassword.Text;
            ACustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            ACustomer.Address = txtAddress.Text;
            ACustomer.Archived = chkArchived.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (CustomerNo == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerNo);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to CustomerList
        Response.Redirect("CustomerList.aspx");
    }
}