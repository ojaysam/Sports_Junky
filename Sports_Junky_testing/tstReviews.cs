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

        
            [TestMethod]
            public void ReviewerNameOK()
            {
            clsReviews AnReviews = new clsReviews();

            String TestData = "John B";
            AnReviews.ReviewerName= TestData;

            Assert.AreEqual(AnReviews.ReviewerName, TestData);
       
            }

        [TestMethod]
        public void ReviewTextOK()
        {
            clsReviews AnReviews = new clsReviews();

            String TestData = "Product is good";
            AnReviews.ReviewText = TestData;

            Assert.AreEqual(AnReviews.ReviewText, TestData);

        }

        [TestMethod]
        public void ReviewedProductOK()
        {
            clsReviews AnReviews = new clsReviews();

            String TestData = "Spurs' Shorts";
            AnReviews.ReviewedProduct = TestData;

            Assert.AreEqual(AnReviews.ReviewedProduct, TestData);

        }

        [TestMethod]
        public void ReviewRatingOK()
        {
            clsReviews AnReviews = new clsReviews();

            Int32 TestData = 4;
            AnReviews.ReviewRating = TestData;

            Assert.AreEqual(AnReviews.ReviewRating, TestData);

        }

        [TestMethod]
        public void DateAddedOK()
        {
            clsReviews AnReviews = new clsReviews();

            DateTime TestData = DateTime.Now.Date;
            AnReviews.DateAdded = TestData;

            Assert.AreEqual(AnReviews.DateAdded, TestData);

        }

        [TestMethod]
        public void ReviewApprovedOK()
        {
            clsReviews AnReviews = new clsReviews();

            Boolean TestData = true;
            AnReviews.ReviewApproved = TestData;

            Assert.AreEqual(AnReviews.ReviewApproved, TestData);

        }






    }



}

