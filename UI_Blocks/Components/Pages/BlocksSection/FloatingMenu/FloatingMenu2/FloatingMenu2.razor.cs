using Microsoft.JSInterop;
using Syncfusion.Blazor.Inputs;
using Syncfusion.Blazor.Popups;

namespace UI_Blocks.Components.Pages.BlocksSection.FloatingMenu.FloatingMenu2
{
    public partial class FloatingMenu2
    {
        public SfDialog? Dialog;
        public SfTextBox? TextBox;
        public bool IsToggleState = true;
        public bool IsMobileView = false;
     
        public List<FloatingData> Data = new List<FloatingData>
        {
            new FloatingData { Id = 1, Time = "12:12 PM", Contact = "ChatBot", Chat = "Hello! How can I help you?" },
            new FloatingData { Id = 2, Time = "12:12 PM", Contact = "You", Chat = "Hi, I'm having trouble accessing the company VPN." },
            new FloatingData { Id = 3, Time = "12:12 PM", Contact = "ChatBot", Chat = "I can help with that. Are you seeing any error messages?" }
        };

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobileView = windowWidth < 620;
                await Dialog.RefreshPositionAsync();
            }
            StateHasChanged();
        }

        public class FloatingData
        {
            public int Id { get; set; }
            public string Time { get; set; } = string.Empty;
            public string Contact { get; set; } = string.Empty;
            public string Chat { get; set; } = string.Empty;
        }
    }
}