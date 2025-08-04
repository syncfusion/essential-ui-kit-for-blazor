using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Rating.Rating14
{
    public partial class Rating14
    {
        public double Rating = 4.2;
        public string ProgressWidth = "100%";

        public List<RatingModel> CustomerRating = new List<RatingModel>
        {
            new RatingModel { Id = 1, Label = "Features", Value = 100, RatingValue = 5 },
            new RatingModel { Id = 2, Label = "Value for money", Value = 80, RatingValue = 4 },
            new RatingModel { Id = 3, Label = "Ease of use", Value = 60, RatingValue = 3 },
            new RatingModel { Id = 4, Label = "Customer support", Value = 40, RatingValue = 2 },
            new RatingModel { Id = 5, Label = "Customer", Value = 20, RatingValue = 1 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                ProgressWidth = windowWidth < 640 ? "100%" : "262px";
            }
            StateHasChanged();
        }
        
        public class RatingModel
        {
            public int Id { get; set; }
            public string Label { get; set; } = string.Empty;
            public int Value { get; set; }
            public int RatingValue { get; set; }
        }
    }
}
