using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sports_Junky_Classes;

namespace Sports_Junky_testing
{
    [TestClass]
    public class clsOrderTests
    {
        [TestMethod]
        public void FindMethodOK() 
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);

        }
     
        [TestMethod]
        public void InstanceOk() 
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime testData = DateTime.Now;
            AnOrder.OrderDate = testData;
            Assert.AreEqual(AnOrder.OrderDate , testData);
     
        }

        [TestMethod]
        public void OrderIdPropertyOk()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 testData = 1;
            AnOrder.OrderId = testData;
            Assert.AreEqual(AnOrder.OrderId , testData);
        }
        [TestMethod]
        public void OrderNumberPropertyOk()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 testData = 1;
            AnOrder.OrderNumber = testData;
            Assert.AreEqual(AnOrder.OrderNumber, testData);
        }
        [TestMethod]
        public void OrderNamePropertyOk()
        {
            clsOrder AnOrder = new clsOrder();
            string testData = "first order";
            AnOrder.OrderName = testData;
            Assert.AreEqual(AnOrder.OrderName, testData);
        }

        [TestMethod]
        public void OrderQuantityPropertyOk()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 testData = 1;
            AnOrder.OrderQuantity = testData;
            Assert.AreEqual(AnOrder.OrderQuantity, testData);
        }
        [TestMethod]
        public void OrderTotalPropertyOk()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 testData = 1;
            AnOrder.OrderTotal = testData;
            Assert.AreEqual(AnOrder.OrderTotal, testData);
        }

        ///////////////////////////////////
        [TestMethod]
        public void TestOrderFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.OrderId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestOrderDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.OrderDate != Convert.ToDateTime("16/09/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestOrderNumberFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 21;
            int testData = 1;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.OrderNumber != testData)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestOrderNameFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            string testData = "first order";
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.OrderName != testData)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestOrderQuantityFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int testData = 1;
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.OrderQuantity != testData)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestOrderTotalFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int testData = 1;
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.OrderTotal != testData)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK() 
        {
            clsOrder AnOrder = new clsOrder();
            string error = "";
            error = AnOrder.Valid("","","","","");
            Assert.AreEqual(error, "");
        }

        string Number = "1";
        string Name = "Order_1122";
        string Date = "05/16/2020";
        string Quantity = "5";
        string Total = "10";

        [TestMethod]
        public void OrderNumberIsInteger() 
        {
            clsOrder AnOrder = new clsOrder();
            Number = "abc";
            string error = "";
            error = AnOrder.Valid(Number, Name, Quantity,Date, Total);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void OrderQuantityIsInteger()
        {
            clsOrder AnOrder = new clsOrder();
            Quantity = "abc";
            string error = "";
            error = AnOrder.Valid(Number, Name, Quantity, Date, Total);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void OrderTotalIsInteger()
        {
            clsOrder AnOrder = new clsOrder();
            Total = "abcd";
            string error = "";
            error = AnOrder.Valid(Number, Name, Quantity, Date, Total);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void OrderDateIsValid()
        {
            clsOrder AnOrder = new clsOrder();
            Date = "abc";
            string error = "";
            error = AnOrder.Valid(Number, Name, Quantity, Date, Total);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void OrderNameNotEmpty()
        {
            clsOrder AnOrder = new clsOrder();
            Name = "";
            string error = "";
            error = AnOrder.Valid(Number, Name, Quantity, Date, Total);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            Date = "07/18/2020"; //future date
            string error = "";
            error = AnOrder.Valid(Number, Name, Quantity, Date, Total);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            Date = "07/18/1875"; //future date
            string error = "";
            error = AnOrder.Valid(Number, Name, Quantity, Date, Total);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void OrderNumberValid()
        {
            clsOrder AnOrder = new clsOrder();
            Number = "-1"; 
            string error = "";
            error = AnOrder.Valid(Number, Name, Quantity, Date, Total);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void OrderQuantityValid()
        {
            clsOrder AnOrder = new clsOrder();
            Quantity = "-1";
            string error = "";
            error = AnOrder.Valid(Number, Name, Quantity, Date, Total);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void OrderTotalValid()
        {
            clsOrder AnOrder = new clsOrder();
            Total = "-1";
            string error = "";
            error = AnOrder.Valid(Number, Name, Quantity, Date, Total);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void OrderTotalEmpty()
        {
            clsOrder AnOrder = new clsOrder();
            Total = "";
            string error = "";
            error = AnOrder.Valid(Number, Name, Quantity, Date, Total);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void OrderNumberEmpty()
        {
            clsOrder AnOrder = new clsOrder();
            Number = "";
            string error = "";
            error = AnOrder.Valid(Number, Name, Quantity, Date, Total);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void OrderQuantityEmpty()
        {
            clsOrder AnOrder = new clsOrder();
            Quantity = "";
            string error = "";
            error = AnOrder.Valid(Number, Name, Quantity, Date, Total);
            Assert.AreNotEqual(error, "");
        }


        /////////////////////////////////////////////////
        ///
        [TestMethod]
        public void OrderCollectionInstanceOK() 
        {
            clsOrderCollection orders = new clsOrderCollection(); //because database is in separate path
            Assert.IsNotNull(orders);
        }
        [TestMethod]
        public void OrderListOK() 
        {
            clsOrderCollection orders = new clsOrderCollection();
            List<clsOrder> testList = new List<clsOrder>();
            clsOrder testItem = new clsOrder();
            testItem.OrderId = 1;
            testItem.OrderNumber = 2;
            testItem.OrderName = "Name";
            testItem.OrderQuantity = 44;
            testItem.OrderDate = Convert.ToDateTime("05/18/2020");
            testItem.OrderTotal = 400;
            testList.Add(testItem);

            orders.OrdersList = testList;
            Assert.AreEqual(orders.OrdersList, testList);

        }
        [TestMethod]
        public void CountPropertyOK() 
        {
            clsOrderCollection orders = new clsOrderCollection();
            Int32 someCount = 0;
            Assert.AreEqual(orders.Count ,someCount);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection orders = new clsOrderCollection();
            clsOrder testItem = new clsOrder();
            testItem.OrderId = 1;
            testItem.OrderNumber = 2;
            testItem.OrderName = "Name";
            testItem.OrderQuantity = 44;
            testItem.OrderDate = Convert.ToDateTime("05/18/2020");
            testItem.OrderTotal = 400;

            orders.ThisOrder = testItem;
            Assert.AreEqual(orders.ThisOrder, testItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection orders = new clsOrderCollection();
            List<clsOrder> testList = new List<clsOrder>();
            clsOrder testItem = new clsOrder();
            testItem.OrderId = 1;
            testItem.OrderNumber = 2;
            testItem.OrderName = "Name";
            testItem.OrderQuantity = 44;
            testItem.OrderDate = Convert.ToDateTime("05/18/2020");
            testItem.OrderTotal = 400;

            orders.OrdersList = testList;
            Assert.AreEqual(orders.Count, testList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderCollection orders = new clsOrderCollection();
          
            Assert.AreEqual(orders.Count, 2);
        }


        /// <summary>
        /// ////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection orders = new clsOrderCollection();
            clsOrder testItem = new clsOrder();
            testItem.OrderId = 6;
            testItem.OrderNumber = 2;
            testItem.OrderName = "Name";
            testItem.OrderQuantity = 44;
            testItem.OrderDate = Convert.ToDateTime("05/18/2020");
            testItem.OrderTotal = 400;

            orders.ThisOrder = testItem;
           Int32 PrimaryKey = orders.Add();
            orders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(orders.ThisOrder , testItem);

        }
        [TestMethod]
        public void DeleteMethodOK() 
        {
            clsOrderCollection orders = new clsOrderCollection();
            orders.ThisOrder.Find(6);
            orders.Delete();
            Boolean found = orders.ThisOrder.Find(6);
            Assert.IsFalse(found);
        }
        [TestMethod]
        public void UpdateMethodOK() 
        {
            clsOrderCollection orders = new clsOrderCollection();
            clsOrder testItem = new clsOrder();
            testItem.OrderId = 6;
            testItem.OrderNumber = 2;
            testItem.OrderName = "Name";
            testItem.OrderQuantity = 44;
            testItem.OrderDate = Convert.ToDateTime("05/18/2020");
            testItem.OrderTotal = 400;

            orders.ThisOrder = testItem;
            Int32 PrimaryKey = orders.Add();

            testItem.OrderId = PrimaryKey;
            testItem.OrderNumber = 2;
            testItem.OrderName = "Different Name";
            testItem.OrderQuantity =55;
            testItem.OrderDate = Convert.ToDateTime("05/18/2020");
            testItem.OrderTotal = 300;

            orders.ThisOrder = testItem;
            orders.Update();
            orders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(orders.ThisOrder, testItem);
        }

        [TestMethod]
        public void SearchByNameOK() 
        {
            clsOrderCollection orders = new clsOrderCollection();
            orders.FilterByName("Name");
            Assert.AreEqual(2,orders.Count);
        }
    }
}
