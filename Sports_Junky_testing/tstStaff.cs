using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sports_Junky_testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);
        }
        public void TestMethod1()
        {
        }
    }
}
