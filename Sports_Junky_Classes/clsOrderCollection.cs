using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Junky_Classes
{
    public class clsOrderCollection
    {
        clsDataConnection dBConnection;
        //private data member for the current address
        clsOrder thisOrder = new clsOrder();
        private List<clsOrder> mOrderList;

        public clsOrderCollection()
        {
            dBConnection = new clsDataConnection();
            dBConnection.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(dBConnection);
        }
        public clsOrder ThisOrder
        {
            get
            {
                return thisOrder;
            }
            set
            {
                thisOrder = value;
            }
        }
        public Int32 Add()
        {
           
            Int32 PrimaryKey;
            //create a connection to the database
            clsDataConnection NewOrder = new clsDataConnection();

            NewOrder.AddParameter("@Number", ThisOrder.OrderNumber.ToString());

            NewOrder.AddParameter("@Name", ThisOrder.OrderName);
           
            NewOrder.AddParameter("@Quantity", ThisOrder.OrderQuantity);
            NewOrder.AddParameter("@Date", ThisOrder.OrderDate);
            NewOrder.AddParameter("@Total", ThisOrder.OrderTotal);

            //execute the query to add the record - it will return the primary key value of the new record
            PrimaryKey = NewOrder.Execute("sproc_tblOrder_Insert");
            //return the primary key value of the new record
            return PrimaryKey;
        }

        //function for the public Update method
        public void Update()
        {
         
            //create a connection to the database
            clsDataConnection NewOrder = new clsDataConnection();

            NewOrder.AddParameter("@OrderID", ThisOrder.OrderId);
            NewOrder.AddParameter("@Number", ThisOrder.OrderNumber.ToString());

            NewOrder.AddParameter("@Name", ThisOrder.OrderName);

            NewOrder.AddParameter("@Quantity", ThisOrder.OrderQuantity);
            NewOrder.AddParameter("@Date", ThisOrder.OrderDate);
            NewOrder.AddParameter("@Total", ThisOrder.OrderTotal);
            //execute the query
            NewOrder.Execute("sproc_tblOrder_Update");

        }
        public void Delete()
        ///it is a void function and returns no value
        {
            //initialise the DBConnection
            dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@OrderId", ThisOrder.OrderId);
            //execute the stored procedure to delete the address
            dBConnection.Execute("sproc_tblOrder_Delete");
        }
        public void FilterByName(string Name)
        ///it accepts a single parameter PostCode and returns no value
        {
            //initialise the DBConnection
            dBConnection = new clsDataConnection();
            
            dBConnection.AddParameter("@Name", Name);
               //execute the stored procedure to delete the address
            dBConnection.Execute("sproc_tblOrder_FilterByName");
            PopulateArray(dBConnection);
        }

        void PopulateArray(clsDataConnection DB) 
        {
       
            mOrderList = new List<clsOrder>();
            Int32 Index = 0;
            while (Index < dBConnection.Count)
            {
                clsOrder NewOrder = new clsOrder();
                NewOrder.OrderId = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["OrderID "]);

                NewOrder.OrderName = Convert.ToString(dBConnection.DataTable.Rows[Index]["OrderName "]);

                NewOrder.OrderNumber = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["OrderNumber"]);

                NewOrder.OrderQuantity = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["OrderQuantity"]);

                NewOrder.OrderTotal = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["OrderTotal"]);

                NewOrder.OrderDate = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["OrderDate"]);
                mOrderList.Add(NewOrder);
                Index++;

            }
        }

        public Int32 Count
        ///it returns the count of records currently in QueryResults
        {
            get
            {
                //return the count of records
                return dBConnection.Count;
            }
        }

        public List<clsOrder> OrdersList
        {
          
            get
            {
                //dBConnection = new clsDataConnection();
                //List<clsOrder> orderList = new List<clsOrder>();
                //Int32 Index = 0;
                //while (Index < dBConnection.Count)
                //{
                //    clsOrder NewOrder = new clsOrder();
                //    NewOrder.OrderId = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["OrderID"]);

                //    NewOrder.OrderName = Convert.ToString(dBConnection.DataTable.Rows[Index]["OrderName"]);

                //    NewOrder.OrderNumber = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["OrderNumber"]);

                //    NewOrder.OrderQuantity = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["OrderQuantity"]);

                //    NewOrder.OrderTotal = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["OrderTotal"]);

                //    NewOrder.OrderDate = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["OrderDate"]);

                //    Index++;

                //    orderList.Add(NewOrder);
                    return mOrderList;
                }
            set { mOrderList = value; }
               
            }
        }

    }

