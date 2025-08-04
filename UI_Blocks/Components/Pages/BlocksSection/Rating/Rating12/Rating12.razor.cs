using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Rating.Rating12
{
    public partial class Rating12
    {
        public string ProgressWidth = "100%";

        public List<RatingModel> CustomerRating = new List<RatingModel>
        {
            new RatingModel { Id = 1, Label = "Features", Value = 92, RatingValue = 4.6 },
            new RatingModel { Id = 2, Label = "Value for money", Value = 90, RatingValue = 4.2 },
            new RatingModel { Id = 3, Label = "Ease of use", Value = 54, RatingValue = 2.7 },
            new RatingModel { Id = 4, Label = "Customer support", Value = 98, RatingValue = 4.9 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                ProgressWidth = windowWidth < 640? "100%" : "306px";
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
