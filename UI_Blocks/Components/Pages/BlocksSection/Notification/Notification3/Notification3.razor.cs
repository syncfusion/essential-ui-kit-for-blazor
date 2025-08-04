using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.Notification.Notification3
{
    public partial class Notification3
    {
        public SfDialog? Dialog;
        public SfDropDownButton? Dropdown;
        public bool IsDropdownOpened = false;
        public bool IsDialogVisible = true;
        public string DialogWidth = "448px";
        public string[] ChoiceSelected = { "All" };

        public List<Message> ChatData = new List<Message>
        {
            new Message { Id = 1, Initial = "LG", Sender = "Lisa Green", ColorTheme = "Green", Content = "Hi, Rachael Lee", Time = "9:46 AM" },
            new Message { Id = 2, Initial = "OA", Sender = "Oliva Adams", ColorTheme = "Orange", Content = "Hi, David Clark", Time = "9:46 AM" },
            new Message { Id = 3, Initial = "SM", Sender = "Sophia Martinez", ColorTheme = "Green", Content = "Hi, John wilson", Time = "9:46 AM" },
            new Message { Id = 4, Initial = "TH", Sender = "Tom Harris", ColorTheme = "Red", Content = "Hi, Oliva Adams", Time = "9:46 AM" },
            new Message { Id = 5, Initial = "SM", Sender = "Sophia Martinez", ColorTheme = "Green", Content = "Hi, Lucas Robinson", Time = "9:46 AM" }
        };

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                DialogWidth = windowWidth < 480 ? "328px" : "448px";
                await Dialog.RefreshPositionAsync();
                if (IsDropdownOpened && Dropdown != null)
                {
                    Dropdown.Toggle();
                }
            }
            StateHasChanged();
        }

        public class Message
        {
            public int Id { get; set; }
            public string Initial { get; set; } = string.Empty;
            public string Sender { get; set; } = string.Empty;
            public string ColorTheme { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public string Time { get; set; } = string.Empty;
        }
    }
}
