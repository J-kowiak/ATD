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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff staff = new clsStaff();

        staff.ID = Convert.ToInt32(txtStaffID.Text);
        staff.Username = txtStaffUsername.Text;
        staff.Password = txtStaffPassword.Text;
        staff.Name = txtStaffName.Text;
        staff.Address = txtStaffAddress.Text;
        staff.DateOfCreation = Convert.ToDateTime(txtDateOfCreation.Text);
        staff.Admin = chkAdmin.Checked;

        Session["staff"] = staff;

        // Navigate to Staff Viewer Page.
        Response.Redirect("StaffViewer.aspx");
    }
}