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
        ClassLibrary.clsStockCollection stocks = new ClassLibrary.clsStockCollection();
        //set data source to list of stock in collection
        lstStock.DataSource = stocks.StockList;
        // set name of primary key
        lstStock.DataValueField = "ProductId";
        //set data field display
        lstStock.DataTextField = "Name";
        //bind data to list
        lstStock.DataBind();
    }





    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductId;
        //if record selected from list
        if (lstStock.SelectedIndex != -1)
        {
            //get primary key off record to edit
            ProductId = Convert.ToInt32(lstStock.SelectedValue);
            //store data in session obj
            Session["ProductId"] = ProductId;
            Response.Redirect("StockDataEntry.aspx");

        }
        else //if no record selected
        {
            lblError.Text = "Please select a to delete from list";
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["stock"] = -1;
        Response.Redirect("stock.aspx");
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click1(object sender, EventArgs e)
    {
        Session["ProductId"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 productId;
        //if record has been selected
        if (lstStock.SelectedIndex != -1)
        {
            //get primary key from record delete
            productId = Convert.ToInt32(lstStock.SelectedValue);
            //store the data
            Session["ProductId"] = productId;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select record to delete from list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection stocks = new clsStockCollection();
        stocks.FilterByCategory(tbCategory.Text);
        lstStock.DataSource = stocks.StockList;
        //set name of primary key
        lstStock.DataValueField = "ProductId";
        // set name of field to display
        lstStock.DataTextField = "Category";
        // bind data to list
        lstStock.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection stocks = new clsStockCollection();
        stocks.FilterByCategory("");
        //clear any existing filter
        tbCategory.Text = "";
        lstStock.DataSource = stocks.StockList;
        //set name of primary key
        lstStock.DataValueField = "ProductId";
        // set name of field to display
        lstStock.DataTextField = "Name";
        // bind data to list
        lstStock.DataBind();
    }

    protected void tbCategory_TextChanged(object sender, EventArgs e)
    {

    }
}