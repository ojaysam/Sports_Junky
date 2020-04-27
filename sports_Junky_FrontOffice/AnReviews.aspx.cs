using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sports_Junky_Classes;

public partial class AnReviews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsReviews AnReviews = new clsReviews();
        AnReviews = (clsReviews)Session["AnReviews"];
        Response.Write(AnReviews.ReviewerName);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsReviews AnReviews = new clsReviews();
        AnReviews.ReviewerName = rvwNameOK.Text;
        AnReviews.ReviewText = rvwTextOK.Text;
        AnReviews.ReviewedProduct = rvwdProdOK.Text;
        AnReviews.DateAdded = Convert.ToDateTime(dateAddOK.Text);
        AnReviews.ReviewApproved = Convert.ToBoolean(rvwAppOK.Text);
        AnReviews.ReviewApproved = Convert.ToBoolean(rvwRatOK.Text);



        Session["AnReviews"] = AnReviews;
        Response.Write("AddressViewer.aspx");
    }
}