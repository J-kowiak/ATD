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
        if (!IsPostBack)
        {
            DisplayStaff();
        }
    }

    public void DisplayStaff()
    {
        var allStaff = new clsStaffCollection();

        lstStaffList.DataSource = allStaff.StaffList;

        lstStaffList.DataValueField = "ID";

        lstStaffList.DataTextField = "Name";

        lstStaffList.DataBind();
    }
}