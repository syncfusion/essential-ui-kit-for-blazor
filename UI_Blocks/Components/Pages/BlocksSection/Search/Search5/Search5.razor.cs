using Syncfusion.Blazor.DropDowns;
using Microsoft.JSInterop;
namespace UI_Blocks.Components.Pages.BlocksSection.Search.Search5
{
    public partial class Search5
    {
        private SfAutoComplete<string, SearchItem>? Search;
        public string? Width;
        private List<SearchItem> Data = new List<SearchItem>()
        {
            new() {Id = "#23568", Ticket = "Unable to Log In to the Application", CreatedDate = "October 5, 2024", FontIcon = "e-icons e-circle-info", ColorTheme = "Green", },
            new() { Id = "#23562", Ticket = "Software Update Error", CreatedDate = "October 1, 2024", FontIcon = "e-icons e-reset", ColorTheme = "Orange",},
            new() { Id = "#23556", Ticket = "Feature Request: Dark Mode", CreatedDate = "September 28, 2024", FontIcon = "e-icons e-objects", ColorTheme = "Blue",},
            new() { Id = "#23554", Ticket = "API Documentation Missing", CreatedDate = "September 25, 2024", FontIcon = "e-icons e-file-new", ColorTheme = "Red",},
            new() { Id = "#23548", Ticket = "Unable to Generate Reports", CreatedDate = "September 21, 2024", FontIcon = "e-icons e-circle-info", ColorTheme = "Indigo",},
            new() { Id = "#23547", Ticket = "Multi-Language Support", CreatedDate = "September 19, 2024", FontIcon = "e-icons e-paragraph", ColorTheme = "Green",},
        };

        private async Task FocusHandlerAsync()
        {
            await Task.Delay(100);
            await Search.ShowPopupAsync();
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
        private string GetColorThemeClass(string ColorTheme)
        {
            return ColorTheme switch
            {
                "Green" => "bg-success-subtle text-success bg-green-100 text-green-600 dark:bg-green-800 dark:text-green-300",
                "Orange" => "bg-warning-subtle text-warning-emphasis bg-orange-50 text-orange-500 dark:bg-orange-800 dark:text-orange-300",
                "Blue" => "bg-info-subtle text-info-emphasis bg-cyan-50 text-cyan-500 dark:bg-cyan-800 dark:text-cyan-300",
                "Red" => "bg-danger-subtle text-danger-emphasis bg-red-50 text-red-500 dark:bg-red-800 dark:text-red-300",
                "Indigo" => "bg-primary-subtle text-primary bg-indigo-50 text-indigo-600 dark:bg-indigo-800 dark:text-indigo-300",
                _ => ""
            };
        }
        public class SearchItem
        {
            public string? Id { get; set; } 
            public string? Ticket { get; set; } = string.Empty;
            public string? CreatedDate { get; set; } = string.Empty;
            public string? FontIcon { get; set; } = string.Empty;
            public string? ColorTheme { get; set; } = string.Empty;

        }
    }
}
