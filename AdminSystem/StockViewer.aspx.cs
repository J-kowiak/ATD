﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // creates an instance
        clsStock stock = new clsStock();
        // get data from session object
        stock = (clsStock)Session["stock"];
        // displays category on page
        Response.Write(stock.Category);
        Response.Write(stock.Name);
        Response.Write(stock.NextDelivery);
        Response.Write(stock.ProductId);
        Response.Write(stock.Sale_Ready);
        Response.Write(stock.Quantity);
    }
}