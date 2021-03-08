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
        String Category = txtCategory.Text;
        String Name = txtName.Text;
        String NextDelivery = txtNextDelivery.Text;
        int Quantity = Convert.ToInt32(txtQuantity);
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
            stock.ProductId = Convert.ToInt32(txtProductId.Text);
            stock.NextDelivery = Convert.ToDateTime(NextDelivery);
            stock.Sale_Ready = Convert.ToBoolean(txtNextDelivery.Text);
            // Stores attributes in session objecy
            Session["stock"] = stock;
            // Navigates to viewer page
            Response.Redirect("StockViewer.aspx");
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
        productId = Convert.ToInt32(txtProductId.Text);
        // find record
        Found = stock.Find(productId);
        if (Found == true)
        {
            txtName.Text = stock.Name;
            txtCategory.Text = stock.Category;
            txtNextDelivery.Text = stock.NextDelivery.ToString();
            txtQuantity.Text = stock.Quantity.ToString();
            

        }

    }
}