using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 productId;
    protected void Page_Load(object sender, EventArgs e)
    {
        productId = Convert.ToInt32(Session["ProductId"]);
        if(IsPostBack == false)
        {
            //if this is not a new record
            if(productId != -1)
            {
                DisplayStock();
            }
        }
    }

     void DisplayStock()
    {
        clsStockCollection allStock = new clsStockCollection();
        //find record to update
        allStock.ThisStock.Find(productId);
        //Display data for the record
        txtCategory.Text = allStock.ThisStock.Category.ToString();
        txtName.Text = allStock.ThisStock.Name.ToString();
        txtQuantity.Text = allStock.ThisStock.Quantity.ToString();
        txtNextDelivery.Text = allStock.ThisStock.Quantity.ToString();
        cbSaleReady.Checked = allStock.ThisStock.Sale_Ready;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        String Category = txtCategory.Text;
        String Name = txtName.Text;
        String NextDelivery = txtNextDelivery.Text;
        int Quantity = 0;
        try
        {
             Quantity = Convert.ToInt32(txtQuantity.Text);

        }
        catch
        {
             Quantity = -1;

        }
        String error = "";
        //Creates a new instance of stock
        clsStock stock = new clsStock();

        error = stock.Valid(Name, Category, Quantity, NextDelivery);
        if (error == "")
        {


            // Captures the attribute 
            stock.Category = Category;
            stock.Name = Name;
            stock.Quantity = Quantity;
            stock.ProductId = productId;
            stock.NextDelivery = Convert.ToDateTime(NextDelivery);
            stock.Sale_Ready = cbSaleReady.Checked;
            // Stores attributes in session objecy
            clsStockCollection StockList = new clsStockCollection();
            if (productId == -1)
            {
                StockList.ThisStock = stock;
                StockList.Add();
            }
            else
            {
                //find productId
                StockList.ThisStock.Find(productId);
                // set this stock property
                StockList.ThisStock = stock;
                StockList.Update();
            }
            // Navigates to list page
            Response.Redirect("StockList.aspx");
        }
        else
            lblError.Text = error;
    }

    protected void txtCategory_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock stock = new clsStock();
        Int32 productId;
        Boolean Found = false;
        // get primary key from user
        try
        {
            productId = Convert.ToInt32(txtProductId.Text);
        }
        catch
        {
            productId = -1;
        }
        // find record
        Found = stock.Find(productId);
        if (Found == true)
        {
            txtName.Text = stock.Name;
            txtCategory.Text = stock.Category;
            txtNextDelivery.Text = stock.NextDelivery.ToString();
            txtQuantity.Text = stock.Quantity.ToString();
            

        } else
        {
            lblError.Text = "Item cannot be found";
        }

    }

    protected void txtProductId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void cbSaleReady_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void txtName_TextChanged(object sender, EventArgs e)
    {

    }
}