using Sports_Junky_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReviewsList : System.Web.UI.Page
{
    Int32 ReviewsId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ReviewsId = Convert.ToInt32(Session["ReviewsId"]);

        if (IsPostBack == false)
        {
            DisplayReviews();
        }

    }

    void DisplayReviews()
    {
        Sports_Junky_Classes.clsReviewsCollection Reviews = new Sports_Junky_Classes.clsReviewsCollection();
        lstReviewsList.DataSource = Reviews.ReviewsList;
        lstReviewsList.DataValueField = "ReviewsId";
        lstReviewsList.DataTextField = "ReviewerName";
        lstReviewsList.DataBind();
        



    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ReviewsId"] = -1;
        Response.Redirect("AnReviews.aspx");
    }




    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ReviewsId;
        if (lstReviewsList.SelectedIndex != -1)
        {
            ReviewsId = Convert.ToInt32(lstReviewsList.SelectedValue);
            Session["ReviewsId"] = ReviewsId;
            Response.Redirect("DeleteReviews.aspx");
        }
        else
            lblError.Text = "Please select a record to delete fromt the list";
    }




    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ReviewsId;
        if (lstReviewsList.SelectedIndex != -1)
        {
            ReviewsId = Convert.ToInt32(lstReviewsList.SelectedValue);
            Session["ReviewsId"] = ReviewsId;
            Response.Redirect("AnReviews.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }

        
    }




    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsReviewsCollection Reviews = new clsReviewsCollection();
        Reviews.ReportByReviewRating(lstReviewsList.Text);
        lstReviewsList.DataSource = Reviews.ReviewsList;
        lstReviewsList.DataValueField = "ReviewsId";
        lstReviewsList.DataTextField = "ReviewRating";
        lstReviewsList.DataBind();

    }




    protected void btnClear_Click(object sender, EventArgs e)
     {

        clsReviewsCollection Reviews = new clsReviewsCollection();
        Reviews.ReportByReviewRating("");
        lstReviewsList.Text = "";
        lstReviewsList.DataSource = Reviews.ReviewsList;
        lstReviewsList.DataValueField = "ReviewsId";
        lstReviewsList.DataTextField = "ReviewRating";
        lstReviewsList.DataBind();
    }



    protected void lstReviewsList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}