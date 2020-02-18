using Sports_Junky_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnReviews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsReviews AnReviews = new clsReviews();

        AnReviews = (clsReviews)Session["AnReviews"];

        Response.Write(AnReviews.ReviewRating);


       

    }

    protected void btnSubmit_OK(object sender, EventArgs e)
    {
        clsReviews AnReviews = new clsReviews();

        AnReviews.ReviewRating = rvwTextOK.Text;
        AnReviews.ReviewerName = rvwNameOK.Text;
        AnReviews.ReviewText = rvwTextOK.Text;
        AnReviews.ReviewedProduct = rvwdProdOK.Text;
        AnReviews.DateAdded = Convert.ToDateTime(dateAddOK.Text);
        AnReviews.ReviewApproved = Convert.ToBoolean(rvwAppOK.Text);

        Session["AnReviews"] = AnReviews;
        Response.Redirect("ReviewsViewer.aspx");

    }
}