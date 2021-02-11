using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Creates a new instance of stock
        clsStock stock = new clsStock();
        // Captures the category 
        stock.Category = txtCategory.Text;
        // Stores category in session objecy
        Session["stock"] = stock;
        // Navigates to viewer page
        Response.Redirect("StockViewer");
    }
}