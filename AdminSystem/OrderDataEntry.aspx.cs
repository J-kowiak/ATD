using System;
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
        AnOrder.OrderId = Convert.ToInt32(txtOrderID.Text);
        AnOrder.ItemName = txtItemName.Text;
        AnOrder.Price = Convert.ToDouble(txtPrice.Text);
        AnOrder.DateOrderMade = Convert.ToDateTime(txtDateOrderMade);
        
        //store the ID in session object
        Session["AnOrder"] = AnOrder;
        //navigate to viewer page
        Response.Redirect("OrderViewer.aspx");
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