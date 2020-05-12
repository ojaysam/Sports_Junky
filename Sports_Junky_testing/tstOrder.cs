using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sports_Junky_testing
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
    }
}
