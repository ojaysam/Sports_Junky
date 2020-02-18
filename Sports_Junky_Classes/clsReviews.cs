using System;

namespace Sports_Junky_Classes
{
    public class clsReviews
    {
        public string ReviewerName { get; set; }
        public string ReviewText { get; set; }
        public string ReviewedProduct { get; set; }
        public int ReviewRating { get; set; }
        public DateTime DateAdded { get; set; }
        public bool ReviewApproved { get; set; }
    }
}