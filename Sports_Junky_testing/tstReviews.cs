using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sports_Junky_Classes;

namespace Sports_Junky_testing
{
    [TestClass]
    public class tstReviews
    {
        [TestMethod]
        public void InstanceOK()
             {
            clsReviews AnReviews = new clsReviews();

            Assert.IsNotNull(AnReviews);
        }
    }
}
