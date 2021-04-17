using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 productId;
    protected void Page_Load(object sender, EventArgs e)
    {
        productId = Convert.ToInt32(Session["ProductId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection stockBook = new clsStockCollection();
        //find record to delete
        stockBook.ThisStock.Find(productId);
        //delete record
        stockBook.Delete();
        //redirect to main page
        Response.Redirect("StockList.aspx");

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}