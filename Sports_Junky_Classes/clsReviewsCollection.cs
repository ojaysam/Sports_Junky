 using System;
using System.Collections.Generic;

namespace Sports_Junky_Classes
{
    public class clsReviewsCollection
    {

        List<clsReviews> mReviewsList = new List<clsReviews>();
        clsReviews mThisReviews = new clsReviews();

        public clsReviewsCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblReviews_SelectAll");
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mReviewsList = new List<clsReviews>();

            while (Index < RecordCount)
            {
                clsReviews AnReviews = new clsReviews();
                AnReviews.ReviewsId = Convert.ToInt32(DB.DataTable.Rows[Index]["ReviewsId"]);
                AnReviews.ReviewRating = Convert.ToInt32(DB.DataTable.Rows[Index]["ReviewRating"]);
                AnReviews.ReviewerName = Convert.ToString(DB.DataTable.Rows[Index]["ReviewerName"]);
                AnReviews.ReviewText = Convert.ToString(DB.DataTable.Rows[Index]["ReviewText"]);
                AnReviews.ReviewedProduct = Convert.ToString(DB.DataTable.Rows[Index]["ReviewedProduct"]);
                AnReviews.ReviewApproved = Convert.ToBoolean(DB.DataTable.Rows[Index]["ReviewApproved"]);
                AnReviews.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);

                mReviewsList.Add(AnReviews);
                Index++;
            }
        }




        public List<clsReviews> ReviewsList
        {
            get
            {
                return mReviewsList;

            }
            set
            {
                mReviewsList = value;
            }

        }

        public int Count
        {
            get
            {
                return mReviewsList.Count;
            }
            set
            {

            }
        }



        public clsReviews ThisReviews
        {
            get
            {
                return mThisReviews;
            }
            set
            {
                mThisReviews = value;
            }
        }





        /* public clsReviewsCollection()
         {

             clsDataConnection DB = new clsDataConnection();
             DB.Execute("sproc_tblReviews_SelectAll");
             PopulateArray(DB);

             Int32 Index = 0;
             Int32 RecordCount = 0;
            // clsDataConnection DB = new clsDataConnection();
             DB.Execute("sproc_tblReviews_SelectAll");
             PopulateArray(DB);
             RecordCount = DB.Count;
             while (Index < RecordCount)
             {
                 clsReviews AnReviews = new clsReviews();
                 AnReviews.ReviewsId = Convert.ToInt32(DB.DataTable.Rows[Index]["ReviewsId"]);
                 AnReviews.ReviewRating = Convert.ToInt32(DB.DataTable.Rows[Index]["ReviewRating"]);
                 AnReviews.ReviewerName = Convert.ToString(DB.DataTable.Rows[Index]["ReviewerName"]);
                 AnReviews.ReviewText = Convert.ToString(DB.DataTable.Rows[Index]["ReviewText"]);
                 AnReviews.ReviewedProduct = Convert.ToString(DB.DataTable.Rows[Index]["ReviewedProduct"]);
                 AnReviews.ReviewApproved = Convert.ToBoolean(DB.DataTable.Rows[Index]["ReviewApproved"]);
                 AnReviews.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);

                 mReviewsList.Add(AnReviews);
                 Index++;
             }
         }*/





        public int Add()
        {

            clsDataConnection DB = new clsDataConnection();
          //  DB.AddParameter("@ReviewsId", mThisReviews.ReviewsId);
            DB.AddParameter("@ReviewRating", mThisReviews.ReviewRating);
            DB.AddParameter("@ReviewerName", mThisReviews.ReviewerName);
            DB.AddParameter("@ReviewText", mThisReviews.ReviewText);
            DB.AddParameter("@ReviewedProduct", mThisReviews.ReviewedProduct);
            DB.AddParameter("@ReviewApproved", mThisReviews.ReviewApproved);
            DB.AddParameter("@DateAdded", mThisReviews.DateAdded);

            return DB.Execute("sproc_tblReviews_Insert");

        }







        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReviewsId", mThisReviews.ReviewsId);
            DB.Execute("sproc_tblReviews_Delete");
        }





        public void Update()
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ReviewsId", mThisReviews.ReviewsId);
            DB.AddParameter("@ReviewRating", mThisReviews.ReviewRating);
            DB.AddParameter("@ReviewerName", mThisReviews.ReviewerName);
            DB.AddParameter("@ReviewText", mThisReviews.ReviewText);
            DB.AddParameter("@ReviewedProduct", mThisReviews.ReviewedProduct);
            DB.AddParameter("@ReviewApproved", mThisReviews.ReviewApproved);
            DB.AddParameter("@DateAdded", mThisReviews.DateAdded);

            DB.Execute("sproc_tblReviews_Update");
            //  return DB.Execute("sproc_tblReviews_Insert");

        }





        public void ReportByReviewRating(string ReviewRating)
        {
            /*clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReviewRating,", ReviewRating);
            DB.Execute("sproc_tblReviews_FilterByReviewRating");
            PopulateArray(DB);*/
        }










       /* public void ReportByReviewRatingTestDataFound()
        {
            clsReviewsCollection = FilteredReviews = new clsReviewsCollection();
            Boolean OK = true;
            FilteredReviews.ReportByReviewRating("x");

            if (FilteredReviews.Count == 2)
            {
                if (FilteredReviews.ReviewsList[0].ReviewsId != 36)
                {
                    OK = false;

                }

            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);*/
        }
    }








    



    


