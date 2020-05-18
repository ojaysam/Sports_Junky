using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sports_Junky_Classes
{
    public class clsReviews
    {
        

        private string mReviewerName;
        public string ReviewerName
        {
            get
            {
                return mReviewerName;
            }
            set
            {
                mReviewerName = value;
            }
        }


        private string mReviewText;
        public string ReviewText
        {
            get
            {
                return mReviewText;
            }
            set
            {
                mReviewText = value;
            }
        }

        private string mReviewedProduct;
        public string ReviewedProduct
        {
            get
            {
                return mReviewedProduct;
            }
            set
            {
                mReviewedProduct = value;
            }
        }


        private Int32 mReviewRating;
        public int ReviewRating
        {
            get
            {
                return mReviewRating;
            }
            set
            {
                mReviewRating = value;
            }
        }

        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }


        private Boolean mReviewApproved;
        public bool ReviewApproved
        {
            get
            {
                return mReviewApproved;
            }
            set
            {
                mReviewApproved = value;
            }
        }

        private Int32 mReviewsId;
        public Int32 ReviewsId
        {
            get
            {
                return mReviewsId;
            }
            set
            {
                mReviewsId = value;
            }
        }




        public bool Find(int ReviewsId)
        {

            /* mReviewsId = 2;
             mReviewRating = 4;
             mReviewerName = "John";
             mReviewText = "Product is good";
             mReviewedProduct = "Shorts";
             mReviewApproved = true;
             mDateAdded = Convert.ToDateTime("05/02.2020");
             return true;*/

            
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReviewsId", ReviewsId);
            DB.Execute("sproc_tblReviews_FilterByReviewsId");
            if (DB.Count == 1)
            {




                mReviewsId = Convert.ToInt32(DB.DataTable.Rows[0]["ReviewsId"]);
                mReviewRating = Convert.ToInt32(DB.DataTable.Rows[0]["ReviewRating"]);
                mReviewerName = Convert.ToString(DB.DataTable.Rows[0]["ReviewerName"]);
                mReviewText = Convert.ToString(DB.DataTable.Rows[0]["ReviewText"]);
                mReviewedProduct = Convert.ToString(DB.DataTable.Rows[0]["ReviewedProduct"]);
                mReviewApproved = Convert.ToBoolean(DB.DataTable.Rows[0]["ReviewApproved"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                return true;
            }
            else
            {
                return false;
            }

        }

    

        public string Valid(string reviewedProduct, string reviewText, string dateAdded, string reviewerName)
        {
            String Error = "";
            DateTime DateTemp;

            if (reviewerName.Length == 0)
            {
                Error = Error + "The name may not be blank : ";

            }

            if (reviewerName.Length > 50)
            {
                Error = Error + "The name must be less than 50 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }

            }

            catch
            {
                Error = Error + "The date was not a valid date : ";
            }


            

            if (reviewText.Length == 0)
            {
                Error = Error + "The text may not be blank : ";
            }

            if (reviewText.Length > 50)
            {
                Error = Error + "The text must be less than 50 characters : ";
            }

            if (reviewedProduct.Length == 0)
            {
                Error = Error + "The product must not be blank : ";
            }

            if (reviewedProduct.Length > 50)
            {
                Error = Error + "The product must be less than 50 characters : ";
            }

            return Error;
        }
    }
}