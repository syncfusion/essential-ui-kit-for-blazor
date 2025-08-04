using Syncfusion.Blazor.DropDowns;
using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Search.Search2
{
    public partial class Search2
    {
        public SfAutoComplete<string, SearchItem>? Search;
        public string? Width;
        public string SearchKeyword = "Webflow";
        public List<SearchItem> Data = new List<SearchItem>
        {
            new SearchItem { Id = 1, Text = "Active Employees in HR", Status = " " },
            new SearchItem { Id = 2, Text = "Open Positions in Sales", Status = " " },
            new SearchItem { Id = 3, Text = "Employees with High Performance Ratings", Status = " " },
            new SearchItem { Id = 4, Text = "Training Programs Available", Status = " " },
            new SearchItem { Id = 5, Text = "Darlene Robertson", Status = "Offline" }
        };
        public async Task FocusHandlerAsync()
        {
            if (Search != null)
            {
                await Task.Delay(250);
                await Search.ShowPopupAsync();
            }
        }

        public void SearchResult(FilteringEventArgs args)
        {
            SearchKeyword = !string.IsNullOrWhiteSpace(args.Text) ? args.Text.Trim() : "Webflow";
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

