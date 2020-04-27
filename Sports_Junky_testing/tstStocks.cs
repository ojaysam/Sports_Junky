using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sports_Junky_testing
{
    [TestClass]
    public class tstStocks
    {
        [TestMethod]
        
        public void InstnceOK()
        {
            clsStocks astocks = new clsStocks();
            // test to see if it exists
            Assert.IsNotNull (astocks);
        }
        [TestMethod]
        public void StocksNoExits()
        {
            clsStocks astocks = new clsStocks();
            
        }




    }
}