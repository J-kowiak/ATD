﻿using System;
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
        
    protected void ItemShipped_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the OrderID
        AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
        //store the ID in session object
        Session["AnOrder"] = AnOrder;
        //navigate to viewer page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}