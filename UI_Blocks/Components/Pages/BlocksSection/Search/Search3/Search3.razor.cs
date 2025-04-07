using Syncfusion.Blazor.DropDowns;
using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Search.Search3
{
    public partial class Search3
    {
        private SfAutoComplete<string, SearchItem>? Search;
        public string? Width;
        private List<SearchItem> Data = new List<SearchItem>()
        {
            new() { Id = 1, Name = "Johnson", },
            new() { Id = 2, Name = "White", },
            new() { Id = 3, Name = "Harris", },
            new() { Id = 4, Name = "Jane Smith", Initial = "JS", EmailId = "jane.smith@example.com" },
            new() { Id = 5, Name = "Mark Johnson", Initial = "MJ", EmailId = "markjohnson@example.com" },
            new() { Id = 6, Name = "Tom Harris", Initial = "TH", EmailId = "tomharris@example.com" },
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

