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



        [TestMethod]
        public void FindMethodOK()
        {
            clsReviews AnReviews = new clsReviews();

            Boolean Found = false;
            Int32 ReviewRating = 2;

            Found = AnReviews.Find(ReviewRating);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestReviewRatingFound()
        {
            clsReviews AnReviews = new clsReviews();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewRating = 2;
            Found = AnReviews.Find(ReviewRating);
            if (AnReviews.ReviewRating != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsReviews AnReviews = new clsReviews();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewRating = 2;
            Found = AnReviews.Find(ReviewRating);
            if (AnReviews.DateAdded != Convert.ToDateTime("19/02/2009")) ;
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReviewerNameFound()
        {
            clsReviews AnReviews = new clsReviews();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewRating = 2;
            Found = AnReviews.Find(ReviewRating);
            if(AnReviews.ReviewerName != "Joe Bloggs")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReviewTextFound()
        {
            clsReviews AnReviews = new clsReviews();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewRating = 2;
            Found = AnReviews.Find(ReviewRating);
            if(AnReviews.ReviewText != "Very Good")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestReviewedProductFound()
        {
            clsReviews AnReviews = new clsReviews();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewRating = 2;
            Found = AnReviews.Find(ReviewRating);
            if(AnReviews.ReviewedProduct != "Man Utd Shorts")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReviewApprovedFound()
        {
            clsReviews AnReviews = new clsReviews();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewRating = 2;
            Found = AnReviews.Find(ReviewRating);
            if(AnReviews.ReviewApproved != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }



}

