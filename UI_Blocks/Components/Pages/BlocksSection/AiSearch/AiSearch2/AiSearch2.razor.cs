using Microsoft.JSInterop;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Navigations;

namespace UI_Blocks.Components.Pages.BlocksSection.AiSearch.AiSearch2
{
    public partial class AiSearch2
    {
        public SfAutoComplete<string, SearchItem>? Search;
        public SfTab Tab;
        public bool IsTabSwitch = false;
        public string? Width;
        public OverflowMode OverflowMode { get; set; } = OverflowMode.Extended;
        public List<SearchItem> FilteredData { get; set; } = new List<SearchItem>();

        public List<SearchItem> AllData = new List<SearchItem>
        {
            new SearchItem { Id = 1, Name = "Bob Johnson", Status = "Last active 5 minutes ago", Image = "avatar-1.jpg", Category = "Team" },
            new SearchItem { Id = 2, Name = "Marketing site brief", Status = "Added by Bob Johnson in Sisyphus", Image = "", Category = "Files" },
            new SearchItem { Id = 3, Name = "Site UX research notes", Status = "Added by Bob Johnson in Sisyphus", Image = "", Category = "Files" },
            new SearchItem { Id = 4, Name = "Book ideas (Draft 01)", Status = "Added by Bob Johnson in Untitled Labs", Image = "", Category = "Files" },
            new SearchItem { Id = 5, Name = "Sisyphus website redesign", Status = "Project added by Bob Johnson February 20, 2023", Image = "", Category = "Project" },
            new SearchItem { Id = 6, Name = "Untitled Labs launch", Status = "Project added by Bob Johnson February 20, 2023", Image = "", Category = "Project" }
        };

        public void SelectItem()
        {
            IsTabSwitch = false;
            Search?.HidePopupAsync();
        }

        public async Task FocusHandlerAsync()
        {
            IsTabSwitch = true;
            await Task.Delay(100);
            await Search.ShowPopupAsync();
        }

        public async Task TabSelectedAsync(SelectEventArgs args)
        {
            IsTabSwitch = true;
            switch (args.SelectedIndex) {
                case 0: FilteredData = AllData.Take(6).ToList(); break;
                case 1: FilteredData = AllData.Where(item => item.Category == "Team").ToList(); break;
                case 2: FilteredData = AllData.Where(item => item.Category == "Files").ToList(); break;
                case 3: FilteredData = AllData.Where(item => item.Category == "Project").ToList(); break;
                default: FilteredData = new List<SearchItem>(); break;
            }
            await InvokeAsync(StateHasChanged);
        }

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Search != null)
            {
                OverflowMode = windowWidth < 640 ? OverflowMode.Popup : OverflowMode.Extended;
                Width = windowWidth < 767 ? "max-width:560px" : "width:100%";
                await Search.ShowPopupAsync();
                /* SB Code - Start */
                await Task.Delay(100);
                if (Tab != null)
                {
                    Tab.RefreshAsync();
                }
                /* SB Code - End */
            }
            await InvokeAsync(StateHasChanged);
        }

        public class SearchItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Status { get; set; } = string.Empty;
            public string Image { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
        }
    }
}
