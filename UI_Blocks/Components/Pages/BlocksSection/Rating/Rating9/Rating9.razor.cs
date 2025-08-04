using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Rating.Rating9
{
    public partial class Rating9
    {
        public string ProgressWidth = "100%";

        public List<CustomerRating> CustomerRatings = new List<CustomerRating>
        {
            new CustomerRating { Id = 1, Label = 5, Value = 96 },
            new CustomerRating { Id = 2, Label = 4, Value = 18 },
            new CustomerRating { Id = 3, Label = 3, Value = 11 },
            new CustomerRating { Id = 4, Label = 2, Value = 4 },
            new CustomerRating { Id = 5, Label = 1, Value = 6 }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                ProgressWidth = windowWidth < 640 ? "100%" : "246px";
            }
            StateHasChanged();
        }

        public class CustomerRating
        {
            public int Id { get; set; }
            public int Label { get; set; }
            public int Value { get; set; }
        }
    }
}
