using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sports_Junky_Classes;


namespace Sports_Junky_testing
{
    [TestClass]
    public class tstReviews
    {
        string ReviewsId = "1";
        string ReviewerName = "Dave";
        string ReviewText = "Good Product";
        string ReviewRating = "4";
        string ReviewedProduct = "Spurs Shorts";
        string DateAdded = DateTime.Now.Date.ToString();
        string ReviewApproved = "true";
        



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

            String TestData = "Sophie";
            AnReviews.ReviewerName = TestData;

            Assert.AreEqual(AnReviews.ReviewerName, TestData);

        }

        [TestMethod]
        public void ReviewTextOK()
        {
            clsReviews AnReviews = new clsReviews();

            String TestData = "The product is bad";
            AnReviews.ReviewText = TestData;

            Assert.AreEqual(AnReviews.ReviewText, TestData);

        }

        [TestMethod]
        public void ReviewedProductOK()
        {
            clsReviews AnReviews = new clsReviews();

            String TestData = "Man Utd socks";
            AnReviews.ReviewedProduct = TestData;

            Assert.AreEqual(AnReviews.ReviewedProduct, TestData);

        }

        [TestMethod]
        public void ReviewRatingOK()
        {
            clsReviews AnReviews = new clsReviews();

            Int32 TestData = 2;
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
        public void ReviewsIdPropertyOK()
        {
            clsReviews AnReviews = new clsReviews();
            Int32 TestData = 1;
            AnReviews.ReviewsId = TestData;
            Assert.AreEqual(AnReviews.ReviewsId, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsReviews AnReviews = new clsReviews();

            Boolean Found = false;
            Int32 ReviewsId = 2;

            Found = AnReviews.Find(ReviewsId);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestReviewsIdFound()
        {
            clsReviews AnReviews = new clsReviews();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewsId = 2;
            Found = AnReviews.Find(ReviewsId);
            if (AnReviews.ReviewsId != 2)
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
            Int32 ReviewsId = 2;
            Found = AnReviews.Find(ReviewsId);
            if (AnReviews.DateAdded != Convert.ToDateTime("06/02/2020"));
            {
                OK = false;
            }
           // Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReviewerNameFound()
        {
            clsReviews AnReviews = new clsReviews();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewsId = 2;
             Found = AnReviews.Find(ReviewsId);
            //String ReviewerName = "Sophie";
            if (AnReviews.ReviewerName != "Sophie")
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
            Int32 ReviewsId = 2;
            Found = AnReviews.Find(ReviewsId);
            if (AnReviews.ReviewText != "The product is bad")
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
            Int32 ReviewsId = 2;
            Found = AnReviews.Find(ReviewsId);
            if (AnReviews.ReviewedProduct != "Man Utd socks")
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
            Int32 ReviewsId = 2;
            Found = AnReviews.Find(ReviewsId);
            if (AnReviews.ReviewApproved != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReviewRatingFound()
        {
            clsReviews AnReviews = new clsReviews();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewsId = 2;
            Found = AnReviews.Find(ReviewsId);
            if (AnReviews.ReviewsId != 2)
        {
        OK = false;
            }
    Assert.IsTrue(OK);
        }





        [TestMethod]
        public void ValidMethodOK()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            Error = AnReviews.Valid( ReviewedProduct, ReviewText, DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }


       /* [TestMethod]
        public void ReviewRatingMinLessOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewRating = "";
            Error = AnReviews.Valid(ReviewRating, ReviewApproved, ReviewedProduct, ReviewText,
                DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewRatingMin()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewRating = "a";
            Error = AnReviews.Valid(ReviewRating, ReviewApproved, ReviewedProduct, ReviewText,
               DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewRatingMinPlusOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewRating = "aa";
            Error = AnReviews.Valid(ReviewRating, ReviewApproved, ReviewedProduct, ReviewText,
               DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewRatingMaxLessOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewRating = "aaaaa";
            Error = AnReviews.Valid(ReviewRating, ReviewApproved, ReviewedProduct, ReviewText,
               DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewRatingMax()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewRating = "aaaaaa";
            Error = AnReviews.Valid(ReviewRating, ReviewApproved, ReviewedProduct, ReviewText,
               DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewRatingMid()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewRating = "aaa";
            Error = AnReviews.Valid(ReviewRating, ReviewApproved, ReviewedProduct, ReviewText,
               DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewRatingMaxPlusOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewRating = "aaaaaaa";
            Error = AnReviews.Valid(ReviewRating, ReviewApproved, ReviewedProduct, ReviewText,
               DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewRatingExtremeMax()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewRating = "";
            ReviewRating = ReviewRating.PadRight(500, 'a');
            Error = AnReviews.Valid(ReviewRating, ReviewApproved, ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }*/

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string DateAdded = "This is not a date!";
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewerNameMinLessOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewerName = "";
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewerNameMin()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewerName = "a";
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewerNameMinPlusOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewerName = "aa";
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewerNameMaxLessOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewerName = "";
            ReviewerName = ReviewerName.PadRight(49, 'a');
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewerNameMax()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewerName = "";
            ReviewerName = ReviewRating.PadRight(50, 'a');
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewerNameMaxPlusOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewerName = "";
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewerNameMid()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewerName = "";
            ReviewerName = ReviewerName.PadRight(25, 'a');
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewTextMinLessOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewText = "";
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewTextMin()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewText = "a";
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewTextMinPlusOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewText = "aa";
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewTextMaxLessOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewText = "";
            ReviewText = ReviewText.PadRight(49, 'a');
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewTextMax()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewText = "";
            ReviewText = ReviewText.PadRight(50, 'a');
            Error = AnReviews.Valid(ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewTextMaxPlusOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewText = "";
            ReviewText = ReviewText.PadRight(51, 'a');
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewTextMid()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewText = "";
            ReviewText = ReviewText.PadRight(25, 'a');
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewedProductLessOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewedProduct = "";
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewedProductMin()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewedProduct = "a";
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewedProductMinPlusOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewedProduct = "aa";
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewedProductMaxLessOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewedProduct = "";
            ReviewedProduct = ReviewedProduct.PadRight(49, 'a');
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewedProductMax()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewedProduct = "";
            ReviewedProduct = ReviewedProduct.PadRight(50, 'a');
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewedProductMaxPlusOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewedProduct = "";
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewedProductMid()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewedProduct = "";
            ReviewedProduct = ReviewedProduct.PadRight(25, 'a');
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

       /* [TestMethod]
        public void ReviewApprovedMinLessOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewApproved = "";
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewApprovedMin()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewApproved = "a";
            Error = AnReviews.Valid( ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewApprovedMinPlusOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewApproved = "aa";
            Error = AnReviews.Valid(ReviewRating, ReviewApproved, ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewApprovedMaxLessOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewApproved = "aaaaaaaa";
            Error = AnReviews.Valid(ReviewRating, ReviewApproved, ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewApprovedMax()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewApproved = "aaaaaaaaa";
            Error = AnReviews.Valid(ReviewRating, ReviewApproved, ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewApprovedMaxPlusOne()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewApproved = "aaaaaaaaaa";
            Error = AnReviews.Valid(ReviewRating, ReviewApproved, ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewApprovedMid()
        {
            clsReviews AnReviews = new clsReviews();
            String Error = "";
            string ReviewApproved = "aaaa";
            Error = AnReviews.Valid(ReviewRating, ReviewApproved, ReviewedProduct, ReviewText,
            DateAdded, ReviewerName);
            Assert.AreNotEqual(Error, "");
        }*/

    }

}

