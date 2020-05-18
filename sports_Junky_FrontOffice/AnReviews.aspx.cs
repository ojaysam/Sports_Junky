using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sports_Junky_Classes;

public partial class AnReviews : System.Web.UI.Page
{
    Int32 ReviewsId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //clsReviews AnReviews = new clsReviews();
        // AnReviews = (clsReviews)Session["AnReviews"];
        // Response.Write(AnReviews.ReviewerName);

        ReviewsId = Convert.ToInt32(Session["ReviewsId"]);
        if (IsPostBack == false)
        {
            if (ReviewsId != -1)
            {
                DisplayReviews();
            }
        }
    }

    protected void cnclOK_Click(object sender, EventArgs e)
    {
        //Response.Redirect("Default.aspx");
         Response.Redirect("AnReviews.aspx");

    }





    /* protected void btnSubmit_Click(object sender, EventArgs e)
     {

         if (ReviewsId == -1)
         {
             Add();
         }
         else
         {
             Update();
         }
     }*/



    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       /* Error = AnReviews.Valid(ReviewedProduct, ReviewText,
         DateAdded, ReviewerName);


        if (Error == "")
        {
            AnReviews.ReviewsId = ReviewsId;
            AnReviews.ReviewerName = ReviewerName;
            AnReviews.ReviewText = ReviewText;
            AnReviews.ReviewedProduct = ReviewedProduct;
            AnReviews.DateAdded = Convert.ToDateTime(DateAdded);
            AnReviews.ReviewApproved = chkReviewApproved.Checked;
            AnReviews.ReviewRating = ReviewRating.ToString();

            clsReviewsCollection ReviewsList new clsReviewsCollection();

            if (ReviewsId == -1)
            {
                ReviewsList.ThisReviews = AnReviews;
                ReviewsList.Add();
            }

            else
            {
                ReviewsList.ThisReviews.Find(ReviewsId);
                ReviewsList.ThisReviews = AnReviews;
                ReviewsList.Update();

            }
            Response.Redirect("ReviewsList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }*/
    
















             clsReviews Reviews = new clsReviews();
             string ReviewRating = rvwRatOK.Text;
             string ReviewText = rvwTextOK.Text;
             string ReviewerName = rvwNameOK.Text;
             string ReviewedProduct = rvwdProdOK.Text;
             string DateAdded = dateAddOK.Text;
             string ReviewApproved = rvwAppOK.Text;

             string Error = "";

             Error = AnReviews.Valid(ReviewText, ReviewerName, DateAdded, ReviewedProduct)

                 if (Error == "")
             {
                 AnReviews.ReviewText= ReviewText;
                 AnReviews.ReviewerName = ReviewerName;
                 AnReviews.ReviewedProduct = ReviewedProduct;
                 AnReviews.DateAdded = Convert.ToDateTime(DateAdded);
                 AnReviews.ReviewApproved = ReviewApproved;
                 AnReviews.ReviewRating = ReviewRating.ToString();

                 clsReviewsCollection ReviewsList = new clsReviewsCollection();
                 ReviewsList.ThisReviews = AnReviews;
                 ReviewsList.Add();
                 Response.Redirect("ReviewsList.aspx");

             }
                 else
             {
                 lblError.Text = Error;
             }


        }



        void Add()
    {
        clsReviewsCollection Reviews = new clsReviewsCollection();
        String Error = Reviews.ThisReviews.Valid(rvwTextOK.Text, rvwNameOK.Text, rvwdProdOK.Text, dateAddOK.Text);

        if (Error == "")
        {
            Reviews.ThisReviews.ReviewText = rvwTextOK.Text;
            Reviews.ThisReviews.ReviewerName = rvwNameOK.Text;
            Reviews.ThisReviews.ReviewedProduct = rvwdProdOK.Text;
            Reviews.ThisReviews.DateAdded = Convert.ToDateTime(dateAddOK.Text);
            Reviews.ThisReviews.ReviewApproved = Convert.ToBoolean(rvwAppOK.Text);

            Reviews.Add();
            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }





    void Update()
    {
        Sports_Junky_Classes.clsReviewsCollection Reviews = new Sports_Junky_Classes.clsReviewsCollection();
        String Error = Reviews.ThisReviews.Valid(rvwTextOK.Text, rvwNameOK.Text, rvwdProdOK.Text, dateAddOK.Text);

        if (Error == "")
        {
            Reviews.ThisReviews.Find(ReviewsId);

            Reviews.ThisReviews.ReviewText = rvwTextOK.Text;
            Reviews.ThisReviews.ReviewerName = rvwNameOK.Text;
            Reviews.ThisReviews.ReviewedProduct = rvwdProdOK.Text;
            Reviews.ThisReviews.DateAdded = Convert.ToDateTime(dateAddOK.Text);
            Reviews.ThisReviews.ReviewApproved = Convert.ToBoolean(rvwAppOK.Text);

            Reviews.Update();
            Response.Redirect("Default.aspx");

        }
        else
        {
            lblError.Text = "There were problems with the data entered " + Error;
        }

    }

    void DisplayReviews()
    {

        clsReviewsCollection Reviews = new clsReviewsCollection();
        Reviews.ThisReviews.Find(ReviewsId);

        rvwsId.Text = Reviews.ThisReviews.ReviewsId.ToString();
        rvwTextOK.Text = Reviews.ThisReviews.ReviewText;
        rvwNameOK.Text = Reviews.ThisReviews.ReviewerName;
        rvwdProdOK.Text = Reviews.ThisReviews.ReviewedProduct;
        rvwRatOK.Text = Reviews.ThisReviews.ReviewRating.ToString();
        dateAddOK.Text = Reviews.ThisReviews.DateAdded.ToString();
        rvwAppOK.Text = Reviews.ThisReviews.ReviewApproved.ToString();




    }









    /* Error = AnReviews.Valid(ReviewedProduct, ReviewText,
         DateAdded, ReviewerName);


     if (Error == "")
     {
         AnReviews,ReviewsId = ReviewsId;
         AnReviews.ReviewerName = ReviewerName;
         AnReviews.ReviewText = ReviewText;
         AnReviews.ReviewedProduct = ReviewedProduct;
         AnReviews.DateAdded = Convert.ToDateTime(DateAdded);
          AnReviews.ReviewApproved = chkReviewApproved.Checked;
          AnReviews.ReviewRating = ReviewRating.ToString();




         //clsReviews AnReviews = new clsReviews();
         /* AnReviews.ReviewerName = rvwNameOK.Text;
          AnReviews.ReviewText = rvwTextOK.Text;
          AnReviews.ReviewedProduct = rvwdProdOK.Text;
          AnReviews.DateAdded = Convert.ToDateTime(dateAddOK.Text);


          string ReviewerName = rvwNameOK.Text;
          string ReviewText = rvwTextOK.Text;
          string ReviewedProduct = rvwdProdOK.Text;
          string DateAdded = dateAddOK.Text;
          string ReviewRating = rvwRatOK.Text;
          string ReviewApproved = rvwAppOK.Text;*/


    //  string Error = "";*/






    /*  clsReviewsCollection ReviewsList = new clsReviewsCollection();

      if (ReviewsId == -1)
      {
          ReviewsList.ThisReviews = AnReviews;
          ReviewsList.Add();
      }

      else
      {
          ReviewsList.ThisReviews.Find(ReviewsId);
          ReviewsList.ThisReviews = AnReviews;
          ReviewsList.Update();

      }
      Response.Redirect("ReviewsList.aspx");


      //ReviewsList.ThisReviews = AnReviews;
     // ReviewsList.Add();
     // Response.Write("AddressViewer.aspx");
  }
  else
  {
      lblError.Text = Error;
  }


}









protected void btnFind_Click(object sender, EventArgs e)
{
  clsReviews AnReviews = new clsReviews();
  Int32 ReviewsId;
  Boolean Found = false;
  ReviewsId = Convert.ToInt32(rvwsId.Text);
  Found = AnReviews.Find(ReviewsId);
  if (Found == true)
  {

       rvwTextOK.Text = AnReviews.ReviewText;
       rvwNameOK.Text = AnReviews.ReviewerName;
       rvwdProdOK.Text = AnReviews.ReviewedProduct;
       rvwRatOK.Text = AnReviews.ReviewRating.ToString();
       dateAddOK.Text = AnReviews.DateAdded.ToString();
      rvwAppOK.Text = AnReviews.ReviewApproved.ToString();



  }
}

protected void rvwdProdOK_TextChanged(object sender, EventArgs e)
{

}

void DisplayReviews()
{
  clsReviewsCollection Reviews = new clsReviewsCollection();
  Reviews.ThisReviews.Find(ReviewsId);

  rvwsId.Text = Reviews.ThisReviews.ReviewsId.ToString();
  rvwTextOK.Text = Reviews.ThisReviews.ReviewText;
  rvwNameOK.Text = Reviews.ThisReviews.ReviewerName;
  rvwdProdOK.Text = Reviews.ThisReviews.ReviewedProduct;
  rvwRatOK.Text = Reviews.ThisReviews.ReviewRating.ToString();
  dateAddOK.Text = Reviews.ThisReviews.DateAdded.ToString();
  rvwAppOK.Text = Reviews.ThisReviews.ReviewApproved.ToString();


}*/


}
