using Syncfusion.Blazor.DropDowns;
using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Search.Search3
{
    public partial class Search3
    {
        public SfAutoComplete<string, SearchItem>? Search;
        public string? Width;
        public List<SearchItem> Data = new List<SearchItem>()
        {
            new SearchItem { Id = 1, Name = "Johnson" },
            new SearchItem { Id = 2, Name = "White" },
            new SearchItem { Id = 3, Name = "Harris" },
            new SearchItem { Id = 4, Name = "Jane Smith", Initial = "JS", EmailId = "jane.smith@example.com" },
            new SearchItem { Id = 5, Name = "Mark Johnson", Initial = "MJ", EmailId = "markjohnson@example.com" },
            new SearchItem { Id = 6, Name = "Tom Harris", Initial = "TH", EmailId = "tomharris@example.com" }
        };
        public async Task FocusHandlerAsync()
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
                Width = windowWidth < 767 ? "max-width:480px" : "width:100%";
                await Search.ShowPopupAsync();
            }
        }
        public class SearchItem
        {
            public int Id { get; set; }
            public string? Name { get; set; } = string.Empty;
            public string? Initial { get; set; } = string.Empty;
            public string? EmailId { get; set; } = string.Empty;
        }
    }
}

