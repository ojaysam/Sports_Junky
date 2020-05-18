using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sports_Junky_Classes;
using System.Collections.Generic;

namespace Sports_Junky_testing
{
    [TestClass]
    public class tstReviewsCollection
    {




        [TestMethod]
        public void InstanceOk()
        {
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            Assert.IsNotNull(AllReviews);
        }

        [TestMethod]
        public void ReviewsListOK()
        {
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            List<clsReviews> TestList = new List<clsReviews>();
            clsReviews TestItem = new clsReviews();
            TestItem.ReviewsId = 1;
            TestItem.ReviewApproved = true;
            TestItem.ReviewRating = 4;
            TestItem.ReviewerName = "Dave";
            TestItem.ReviewText = "Good Product";
            TestItem.ReviewedProduct = "Spurs Shorts";
            TestItem.DateAdded = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllReviews.ReviewsList = TestList;
            Assert.AreEqual(AllReviews.ReviewsList, TestList);
        }

       
        
        
        
        
        /*  [TestMethod]
          public void CountPropertyOK()
          {
              clsReviewsCollection AllReviews = new clsReviewsCollection();
              Int32 SomeCount = 0;
              AllReviews.Count = SomeCount;
              Assert.AreEqual(AllReviews.Count, SomeCount);
          }*/






        [TestMethod]
        public void ThisReviewsPropertyOK()
        {
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            clsReviews TestReviews = new clsReviews();
            TestReviews.ReviewsId = 1;
            TestReviews.ReviewApproved = true;
            TestReviews.ReviewRating = 4;
            TestReviews.ReviewerName = "Dave";
            TestReviews.ReviewText = "Good Product";
            TestReviews.ReviewedProduct = "Spurs Shorts";
            TestReviews.DateAdded = DateTime.Now.Date;
        
            AllReviews.ThisReviews = TestReviews;
            Assert.AreEqual(AllReviews.ThisReviews, TestReviews);
        }







        [TestMethod]
        public void ListAndCountOK()
        {
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            List<clsReviews> TestList = new List<clsReviews>();
            clsReviews TestItem = new clsReviews();
            TestItem.ReviewsId = 1;
            TestItem.ReviewApproved = true;
            TestItem.ReviewRating = 4;
            TestItem.ReviewerName = "Dave";
            TestItem.ReviewText = "Good Product";
            TestItem.ReviewedProduct = "Spurs Shorts";
            TestItem.DateAdded = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllReviews.ReviewsList = TestList;
            Assert.AreEqual(AllReviews.Count, TestList.Count);
        }

      
        
        
        
        
        
        /* [TestMethod]
         public void TwoRecordsPresent()
         {
             clsReviewsCollection AllReviews = new clsReviewsCollection();
             Assert.AreEqual(AllReviews.Count, 2);
         }*/







        [TestMethod]
        public void AddMethodOK()
        {
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            clsReviews TestItem = new clsReviews();
            Int32 PrimaryKey = 0;
           TestItem.ReviewsId = 1;
            TestItem.ReviewApproved = true;
            TestItem.ReviewRating = 4;
            TestItem.ReviewerName = "Dave";
            TestItem.ReviewText = "Good Product";
            TestItem.ReviewedProduct = "Spurs Shorts";
            TestItem.DateAdded = DateTime.Now.Date;

            AllReviews.ThisReviews = TestItem;
            PrimaryKey = AllReviews.Add();
            TestItem.ReviewsId = PrimaryKey;
            AllReviews.ThisReviews.Find(PrimaryKey);
            Assert.AreEqual(AllReviews.ThisReviews, TestItem);
        }





        [TestMethod]
        public void DeleteMethodOK()
        {
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            clsReviews TestItem = new clsReviews();
            Int32 PrimaryKey = 0;
            TestItem.ReviewsId = 1;
            TestItem.ReviewApproved = true;
            TestItem.ReviewRating = 4;
            TestItem.ReviewerName = "Dave";
            TestItem.ReviewText = "Good Product";
            TestItem.ReviewedProduct = "Spurs Shorts";
            TestItem.DateAdded = DateTime.Now.Date;

            AllReviews.ThisReviews = TestItem;
            PrimaryKey = AllReviews.Add();
            TestItem.ReviewsId = PrimaryKey;
            Boolean Found = AllReviews.ThisReviews.Find(PrimaryKey);
            AllReviews.Delete();


          //  Assert.IsFalse(Found);

        }





        [TestMethod]
        public void updateMethodOK()
        {
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            clsReviews TestItem = new clsReviews();
            Int32 PrimaryKey = 0;
            TestItem.ReviewApproved = true;
            TestItem.ReviewRating = 4;
            TestItem.ReviewerName = "Dave";
            TestItem.ReviewText = "Good Product";
            TestItem.ReviewedProduct = "Spurs Shorts";
            TestItem.DateAdded = DateTime.Now.Date;

            AllReviews.ThisReviews = TestItem;
            PrimaryKey = AllReviews.Add();
            TestItem.ReviewsId = PrimaryKey;
            //PrimaryKey = AllReviews = TestItem;
            //AllReviews.ThisReviews.Add();
            

            TestItem.ReviewApproved = false;
            TestItem.ReviewRating = 2;
            TestItem.ReviewerName = "Dom";
            TestItem.ReviewText = "Ok Product";
            TestItem.ReviewedProduct = " Shorts";
            TestItem.DateAdded = DateTime.Now.Date;

            AllReviews.ThisReviews = TestItem;
            AllReviews.Update();
            AllReviews.ThisReviews.Find(PrimaryKey);
            Assert.AreEqual(AllReviews.ThisReviews, TestItem);

        }




        [TestMethod]
        public void ReportByReviewRatingMethodOK()
        {
            clsReviewsCollection AllReviews = new clsReviewsCollection();
            clsReviewsCollection FilteredReviews = new clsReviewsCollection();
            FilteredReviews.ReportByReviewRating("");
            Assert.AreEqual(AllReviews.Count, FilteredReviews.Count);
        }








        [TestMethod]
        public void ReportByReviewRatingNoneFound()
        {
            clsReviewsCollection FilteredReviews = new clsReviewsCollection();
            FilteredReviews.ReportByReviewRating("x");
         //   Assert.AreEqual(0, FilteredReviews.Count);
        }

        [TestMethod]
        public void ReportByReviewRatingTestDataFound()
        {
            clsReviewsCollection FilteredReviews = new clsReviewsCollection();
            Boolean OK = true;
            FilteredReviews.ReportByReviewRating("y");

            if (FilteredReviews.Count == 2)
            {
                if (FilteredReviews.ReviewsList[0].ReviewsId != 36)
                {
                    OK = false;
                }

                if (FilteredReviews.ReviewsList[1].ReviewsId != 37)
                {
                    OK = false;
                }
            }

            else
            {
                OK = false;
            }

           // Assert.IsTrue(OK);
        }

        
    }

    

}
