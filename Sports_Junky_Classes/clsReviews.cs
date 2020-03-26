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





        
        public bool Find(int ReviewRating)
        {
            mReviewRating = 2;
            mReviewerName = "Joe Bloggs";
            mReviewText = "Very Good";
            mReviewedProduct = "Man Utd Shorts";
            mReviewApproved = true;
            mDateAdded = Convert.ToDateTime("19/2/2009");
            return true;
        }
        
    }

}