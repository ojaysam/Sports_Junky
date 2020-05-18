using Sports_Junky_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteReviews : System.Web.UI.Page
{
    Int32 ReviewsId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ReviewsId = Convert.ToInt32(Session["ReviewsId"]);
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsReviewsCollection Reviews = new clsReviewsCollection();
        Reviews.ThisReviews.Find(ReviewsId);
        Reviews.Delete();
        Response.Redirect("ReviewsList.aspx");

       /* DeleteReviews1();
        Response.Redirect("Default.aspx");*/

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
       // Response.Redirect("Default.aspx");
        Response.Redirect("ReviewsList.aspx");
    }

    void DeleteReviews1()
    {
        clsReviewsCollection Reviews = new clsReviewsCollection();
        Reviews.ThisReviews.Find(ReviewsId);
        Reviews.Delete();
    }

}