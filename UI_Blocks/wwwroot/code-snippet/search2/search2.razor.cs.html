using Syncfusion.Blazor.DropDowns;
using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Search.Search2
{
    public partial class Search2
    {
        private SfAutoComplete<string, SearchItem>? Search;
        public string? Width;
        private List<SearchItem> Data = new List<SearchItem>
        {
            new() { Id = 1, Text = "Active Employees in HR", Status = " ",},
            new() {Id = 2, Text = "Open Positions in Sales",  Status = " ",},
            new() {Id = 3,  Text = "Employees with High Performance Ratings", Status = " ",},
            new() {Id = 4,Text = "Training Programs Available", Status = " ",},
            new() {Id = 5,Text = "Darlene Robertson",Status = "Offline",}
        };
        private async Task FocusHandlerAsync()
        {
            if (Search != null)
            {
                await Task.Delay(250);
                await Search.ShowPopupAsync();
            }
        }

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Search != null)
            {
                Width = windowWidth > 767 ? "max-width:400px" : "width:100%";
                await Search.ShowPopupAsync();
            }
        }
        public class SearchItem
        {
            public int Id { get; set; }
            public string? Status { get; set; } = string.Empty;
            public string? Text { get; set; } = string.Empty;
        }
    }

}

