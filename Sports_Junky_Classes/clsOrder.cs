using ClassLibrary;
using System;

public class clsOrder
{
    private int mOrderId;
    private DateTime mOrderDate;
    private string mOrderName;
    private int mOrderNumber;
    private int mOrderQuantity;
    private int mOrderTotal;

    public int OrderId { get => mOrderId; set => mOrderId = value; }
    public DateTime OrderDate { get => mOrderDate; set => mOrderDate = value; }
    public string OrderName { get => mOrderName; set => mOrderName = value; }
    public int OrderNumber { get => mOrderNumber; set => mOrderNumber = value; }
    public int OrderQuantity { get => mOrderQuantity; set => mOrderQuantity = value; }
    public int OrderTotal { get => mOrderTotal; set => mOrderTotal = value; }

    public bool Find(int Id) 
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@OrderId",Id);
        DB.Execute("sproc_tblOrder_FilterByOrderId");
        if (DB.Count == 1) 
        {
            mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID "]);
            mOrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
            mOrderName = Convert.ToString(DB.DataTable.Rows[0]["OrderName "]);
            mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
            mOrderQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["OrderQuantity"]);
            mOrderTotal = Convert.ToInt32(DB.DataTable.Rows[0]["OrderTotal"]);
            return true;
        }
        return false;
    }

    public string Valid(string orderNumber, string orderName,string quantity , string orderDate ,string orderTotal) 
    {
        string Error = "";
        try
        {
          
           
            Int32 orderTemp;
            Int32 quantityTemp;
            Int32 totalTemp;

            orderTemp=0;
            if (orderNumber.Length == 0)
            {
                Error += "Order Number Cannot be Empty";
            }
            else
            {
                if (int.TryParse(orderNumber, out orderTemp))
                {
                    if (orderTemp < 0)
                    {
                        Error += "\nOrder Number must be greater than 0 :";
                    }
                }
                else
                {
                    Error += "Order Number Must be an Integer:";
                }
            }



            if (quantity.Length == 0)
            {
                Error += "Order Quantity Cannot be Empty";
            }
            else
            {
                if (int.TryParse(quantity, out quantityTemp))
                {
                    if (quantityTemp < 0)
                    {
                        Error += "\nOrder Quantity must be greater than 0 :";
                    }
                }
                else
                {
                    Error += "Order Quantity Must be an Integer:";
                }
            }

            if (orderTotal.Length == 0)
            {
                Error += "Order Total Cannot be Empty";
            }
            else
            {
                if (int.TryParse(orderTotal, out totalTemp))
                {
                    if (totalTemp < 0)
                    {
                        Error += "\nOrder Total must be greater than 0 :";
                    }
                }
                else
                {
                    Error += "Order Total Must be an Integer:";
                }
            }


            DateTime DateTemp;
            DateTemp = Convert.ToDateTime(orderDate);
            if (DateTemp > DateTime.Now)
            {
                Error += "\nDate Cannot be in the future :";
            }
            if (DateTemp < DateTime.Now.AddYears(-100))
            {
                Error += "\nDate out of range :";
            }
        }
        catch(Exception ex)
        {
            Error += "Invalid Date Provided";
        }
       
        return Error;
    }
}