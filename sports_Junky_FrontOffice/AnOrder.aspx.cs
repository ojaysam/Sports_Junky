using Sports_Junky_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (!IsPostBack) 
        {
            if (OrderId > 0) 
            {
                DisplayOrder();
            }
        }
    }

    private void DisplayOrder()
    {
        clsOrderCollection orders = new clsOrderCollection();
        orders.ThisOrder.Find(OrderId);
        txtOrderNumber.Text = orders.ThisOrder.OrderNumber.ToString();
        txtOrderName.Text = orders.ThisOrder.OrderName;
        txtOrderQuantity.Text = orders.ThisOrder.OrderQuantity.ToString();
        txtOrderDate.Text = orders.ThisOrder.OrderDate.ToString();
        txtOrderTotal.Text = orders.ThisOrder.OrderTotal.ToString();
    }

    Int32 OrderId;
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderId;
        Boolean found = false;
        OrderId = Convert.ToInt32(txtOrderId.Text);
        found = AnOrder.Find(OrderId);
        if (found == true) 
        {
            txtOrderNumber.Text = AnOrder.OrderNumber.ToString();
            txtOrderName.Text = AnOrder.OrderName;
            txtOrderQuantity.Text = AnOrder.OrderQuantity.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtOrderTotal.Text = AnOrder.OrderTotal.ToString();
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string number = txtOrderNumber.Text;
        string name = txtOrderName.Text;
        string quantity = txtOrderQuantity.Text;
        string date = txtOrderDate.Text;
        string total = txtOrderTotal.Text;

        string Error = AnOrder.Valid(number, name, quantity, date, total);
        if (Error == "") {
            AnOrder.OrderNumber = Convert.ToInt32(number);
            AnOrder.OrderName = name;
            AnOrder.OrderQuantity = Convert.ToInt32(quantity);
            AnOrder.OrderDate = Convert.ToDateTime(date);
            AnOrder.OrderTotal = Convert.ToInt32(total);

            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderId <= 0) 
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderId);
                AnOrder.OrderId = OrderList.ThisOrder.OrderId;
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}