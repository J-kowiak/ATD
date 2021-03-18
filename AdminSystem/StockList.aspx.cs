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
        //if this is the first time page is displayed
        if (IsPostBack == false)
        {
            DisplayStock();
        }
    }
    void DisplayStock()
    {
        clsStockCollection Stocks = new clsStockCollection();
        //set data source to list of stock in collection
        lstStock.DataSource = Stocks.StockList;
        // set name of primary key
        lstStock.DataValueField = "ProductId";
        //set data field display
        lstStock.DataTextField = "Name";
        //bind data to list
        lstStock.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}