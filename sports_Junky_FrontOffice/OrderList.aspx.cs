using Sports_Junky_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            
            DisplayOrders();
        }
    }
    
    void DisplayOrders() 
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrders.DataSource = Orders.OrdersList;
        lstOrders.DataValueField = "OrderId";
        lstOrders.DataTextField = "OrderName";
        lstOrders.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrders.SelectedIndex != -1) 
        {
            OrderId = Convert.ToInt32(lstOrders.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("DeleteOrder.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrders.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrders.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("AnOrder.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to Edit";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection orders = new clsOrderCollection();
        orders.FilterByName(txtSearchByName.Text);
        lstOrders.DataSource = orders.OrdersList;
        lstOrders.DataValueField = "OrderId";
        lstOrders.DataTextField = "OrderName";
        lstOrders.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        lstOrders.Items.Clear();
    }
}