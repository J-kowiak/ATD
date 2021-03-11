using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
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

        // If the user is not an admin.
        if (!(bool)Session["isAdmin"])
        {
            // Set database manipulation buttons to disabled.
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        // If not postback.
        if (!IsPostBack)
        {
            DisplayStaff();
        }
    }

    public void DisplayStaff()
    {
        // Create an instance of clsStaffCollection.
        var allStaff = new clsStaffCollection();

        lstStaffList.DataSource = allStaff.StaffList;

        lstStaffList.DataValueField = "ID";

        lstStaffList.DataTextField = "Name";

        lstStaffList.DataBind();
    }

    // Event handler for the Add button.
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Store -1 into the session object to indicate that this is a new record.
        Session["staffID"] = -1;

        // Redirect to the data entry page.
        Response.Redirect("StaffDataEntry.aspx");
    }

    // Event handler for the Edit button.
    protected void btnEdit_Click(object sender, EventArgs e)
    { 
        // If a record has been selected from the list.
        if (lstStaffList.SelectedIndex != -1)
        {
            // Ensures that a staff member can only edit their own data if they are not an admin.
            if (lstStaffList.SelectedIndex == (int)Session["staffID"] - 1 && !(bool)Session["isAdmin"])
            { 
                Int32 staffID = Convert.ToInt32(lstStaffList.SelectedValue);

                // Store the data in the session object.
                Session["staffID"] = staffID;

                // Redirect to the edit page.
                Response.Redirect("StaffDataEntry.aspx");
            }
            else if ((bool)Session["isAdmin"])
            {
                // Get the primary key valaue of the record to edit,
                // also create a variable to store the primary key value of the record to be edited.
                Int32 staffID = Convert.ToInt32(lstStaffList.SelectedValue);

                // Store the data in the session object.
                Session["staffID"] = staffID;

                // Redirect to the edit page.
                Response.Redirect("StaffDataEntry.aspx");
            }
        }
        // If no record has been selected.
        else
        {
            // Display an error.
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    // Event handler for the Delete button.
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // If a record has been selected from the list.
        if (lstStaffList.SelectedIndex != -1)
        {
            // Get the primary key valaue of the record to delete,
            // also create a variable to store the primary key value of the record to be deleted.
            Int32 staffID = Convert.ToInt32(lstStaffList.SelectedValue);

            // Store the data in the session object.
            Session["staffID"] = staffID;

            // Redirect to the edit page.
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        // If no record has been selected.
        else
        {
            // Display an error.
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    // Event handler for the View button.
    protected void btnView_Click(object sender, EventArgs e)
    {
        // If a record has been selected from the list.
        if (lstStaffList.SelectedIndex != -1)
        {
            // Get the primary key valaue of the record to delete,
            // also create a variable to store the primary key value of the record to be deleted.
            Int32 staffID = Convert.ToInt32(lstStaffList.SelectedValue);

            // Store the data in the session object.
            Session["staffID"] = staffID;

            // Redirect to the view page.
            Response.Redirect("StaffViewer.aspx");
        }
        // If no record has been selected.
        else
        {
            // Display an error.
            lblError.Text = "Please select a record to view from the list";
        }
    }

    // Event handler for the Apply button.
    protected void btnApply_Click(object sender, EventArgs e)
    {
        // Create an instance of clsStaffCollection.
        var staffList = new clsStaffCollection();

        staffList.ReportByName(txtFilter.Text);

        this.lstStaffList.DataSource = staffList.StaffList;

        // Set the name of the primary key.
        this.lstStaffList.DataValueField = "ID";

        // Set the name of the field to display.
        this.lstStaffList.DataTextField = "Name";

        // Bind the data to the list.
        this.lstStaffList.DataBind();
    }

    // Event handler for the Clear button.
    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Create an instance of the address collection.
        var staffList = new clsStaffCollection();

        staffList.ReportByName("");

        // Clear any existing filter to tidy up the interface.
        txtFilter.Text = "";

        this.lstStaffList.DataSource = staffList.StaffList;

        // Set the name of the primary key.
        this.lstStaffList.DataValueField = "ID";

        // Set the name of the field to display.
        this.lstStaffList.DataTextField = "Name";

        // Bind the data to the list.
        this.lstStaffList.DataBind();
    }

    // Event handler for the Logout button.
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        // Sets all login session information to null.
        Session["staffUsername"] = null;
        Session["staffPassword"] = null;
        Session["isAdmin"] = false;
        Session["isLoggedIn"] = false;
        Session["staffID"] = -1;

        // Redirect to StaffLogin.
        Response.Redirect("StaffLogin.aspx");
    }
}