using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.List.List6
{
    public partial class List6
    {
        public string WidthStyle = "max-width:452px";

        public List<DataItem> FieldData = new List<DataItem>
        {
            new DataItem { Id = 1, Field = "Full Name", FontIcon = "e-icons e-user" },
            new DataItem { Id = 2, Field = "Email Address", FontIcon = "sf-icon-mail-02" },
            new DataItem { Id = 3, Field = "Phone Number", FontIcon = "sf-icon-phone-01" },
            new DataItem { Id = 4, Field = "Date of Birth", FontIcon = "e-icons e-day" },
            new DataItem { Id = 5, Field = "Address", FontIcon = "e-icons e-location" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                WidthStyle = windowWidth < 1024 ? "width:100%" : "max-width:452px";
            }
            StateHasChanged();
        }

        public class DataItem
        {
            public int Id { get; set; }
            public string Field { get; set; } = string.Empty;
            public string FontIcon { get; set; } = string.Empty;
        }
    }
}
