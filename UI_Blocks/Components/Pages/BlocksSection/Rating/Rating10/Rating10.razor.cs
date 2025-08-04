namespace UI_Blocks.Components.Pages.BlocksSection.Rating.Rating10
{
    public partial class Rating10
    {
        public List<RatingItem> CustomerRating = new List<RatingItem>
        {
            new RatingItem { Rating = "User experience", Value = 4.0 },
            new RatingItem { Rating = "Pricing", Value = 3.5 },
            new RatingItem { Rating = "Features", Value = 4.0 },
            new RatingItem { Rating = "Performance", Value = 5.0 },
            new RatingItem { Rating = "Support", Value = 4.0 }
        };

        public List<ReviewItem> ReviewData = new List<ReviewItem>
        {
            new ReviewItem
            {
                Title = "Great SaaS platform for businesses!",
                Rating = 4,
                Review = "This SaaS application provides an intuitive interface, making it easy to manage tasks and automate workflows. The overall performance is smooth, and the features are well-structured for different use cases."
            },
            new ReviewItem
            {
                Title = "Highly scalable and reliable!",
                Rating = 4,
                Review = "We've been using this platform for months, and it has helped streamline our operations significantly. The uptime is excellent, and the integrations with third-party tools are seamless."
            },
            new ReviewItem
            {
                Title = "Affordable and feature-packed solution!",
                Rating = 4,
                Review = "This tool offers a lot more than we expected at this price point. From project tracking to team collaboration, it covers all the essentials. Would love to see more advanced analytics in future updates."
            }
        };

        public class RatingItem
        {
            public string Rating { get; set; } = string.Empty;
            public double Value { get; set; }
        }

        public class ReviewItem
        {
            public string Title { get; set; } = string.Empty;
            public int Rating { get; set; }
            public string Review { get; set; } = string.Empty;
        }
    }
}
