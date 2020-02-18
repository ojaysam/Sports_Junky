using Sports_Junky_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReviewsViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsReviews AnReviews = new clsReviews();

        AnReviews = (clsReviews)Session["AnReviews"];
        Response.Write(AnReviews.ReviewRating);
    }
}