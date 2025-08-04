using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Rating.Rating11
{
    public partial class Rating11
    {
        public string ProgressWidth = "100%";

        public List<RatingModel> CustomerRating = new List<RatingModel>
        {
            new RatingModel { Id = 1, Label = "Customer support", Value = 88, RatingValue = 4.4 },
            new RatingModel { Id = 2, Label = "Ease of use", Value = 90, RatingValue = 4.5 },
            new RatingModel { Id = 3, Label = "Reliability", Value = 54, RatingValue = 2.7 },
            new RatingModel { Id = 4, Label = "Integration", Value = 90, RatingValue = 4.4 },
            new RatingModel { Id = 5, Label = "Features", Value = 88, RatingValue = 4.4 },
            new RatingModel { Id = 6, Label = "Pricing & Value", Value = 70, RatingValue = 3.5 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                ProgressWidth = windowWidth < 640 ? "100%" : "214px";
            }
            StateHasChanged();
        }
        
        public class RatingModel
        {
            public int Id { get; set; }
            public string Label { get; set; } = string.Empty;
            public int Value { get; set; }
            public double RatingValue { get; set; }
        }
    }
}
