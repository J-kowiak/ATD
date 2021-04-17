using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderIDint;
    protected void Page_Load(object sender, EventArgs e)
    {

        //get the number of the order to be processed
        OrderIDint = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderIDint != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
       
    }

    void DisplayOrder()
    {
        //create an instance of the order list
        clsOrderCollection OrderList = new clsOrderCollection();
        //find the record to update
        OrderList.ThisOrder.Find(OrderIDint);
        
        //display the data for this record
        txtOrderID.Text = OrderList.ThisOrder.OrderId.ToString();
        txtItemName.Text = OrderList.ThisOrder.ItemName.ToString();
        txtPrice.Text = OrderList.ThisOrder.Price.ToString();
        txtDateOrderMade.Text = OrderList.ThisOrder.DateOrderMade.ToString();
        chkItemShipped.Checked = OrderList.ThisOrder.ItemShipped;

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
        string OrderID = txtOrderID.Text;
        //capture the ItemName
        string ItemName = txtItemName.Text;
        //capture the Price
        string Price = txtPrice.Text;
        //capture the Date the order was made
        string DateOrderMade = txtDateOrderMade.Text;
        //captures whether the Item has shipped
        string ItemShipped = chkItemShipped.Checked.ToString();
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(OrderID, ItemName, Price, DateOrderMade, ItemShipped);
        if (Error == "")
        {
            //capture the OrderID
            AnOrder.OrderId = Convert.ToInt32(txtOrderID.Text);
            //capture the ItemName
            AnOrder.ItemName = txtItemName.Text;
            //capture the Price
            AnOrder.Price = Convert.ToDouble(txtPrice.Text);
            //capture the Date the order was made
            AnOrder.DateOrderMade = Convert.ToDateTime(txtDateOrderMade);
            //captures Item Shipped
            AnOrder.ItemShipped = chkItemShipped.Checked;

            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();
            //if this is a new record i.e. OrderId = -1 then add the data
            if (OrderIDint == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();

            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderIDint);
                //set ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
        
        
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderId = 0;
        //variable to store the result of the find operation
        Boolean Found=false;
        //get Primary key entered by the user
        AnOrder.OrderId = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        // if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderID.Text = AnOrder.OrderId.ToString();
            txtItemName.Text = AnOrder.ItemName;
            txtPrice.Text = AnOrder.Price.ToString();
            txtDateOrderMade.Text = AnOrder.DateOrderMade.ToString();
            
        }

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    
}