using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor.Buttons;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Inputs;
using Microsoft.AspNetCore.Components.Web;

namespace UI_Blocks.Components.Pages.BlocksSection.FloatingMenu.FloatingMenu2
{
    public partial class FloatingMenu2
    {
        private bool _toggleState = false;
        private bool IsMobileView = false;
        private SfDialog? Dialog;
        private string XValue { get; set; } = string.Empty;
        private string YValue { get; set; } = string.Empty;
        SfTextBox? TextBox { get; set; }
        private List<FloatingData> Data = new List<FloatingData>
        {
            new FloatingData { Id = 1, Time = "12:12 PM", Contact = "ChatBot", Chat = "Hello! How can I help you?" },
            new FloatingData { Id = 2, Time = "12:12 PM", Contact = "You", Chat = "Hi, I'm having trouble accessing the company VPN." },
            new FloatingData { Id = 3, Time = "12:12 PM", Contact = "ChatBot", Chat = "I can help with that. Are you seeing any error messages?" }
        };
        
        private void onOpen(Syncfusion.Blazor.Popups.OpenEventArgs args){ args.PreventFocus = true;}

        private async void AddNavIconAsync()
        {
            if (TextBox != null)
            {
                await TextBox.AddIconAsync("append", "sf-icon-navigation-right-up border-0");
            }
        }
        public async Task CreatedHandler(Object args)
        {
            XValue = "right";
            YValue = "top";
        }

        private async Task ToggleDialogAsync()
        {
            if (Dialog == null)
            {
                return;
            }

            if (_toggleState)
            {
                await Dialog.ShowAsync();
                StateHasChanged();
            }
            else
            {
                await Dialog.HideAsync();
            }
            _toggleState = !_toggleState;
        }

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobileView = windowWidth < 620;
                await Dialog.RefreshPositionAsync();
                StateHasChanged();
            }
        }

        public class FloatingData
        {
            public int Id { get; set; }
            public string? Time { get; set; }
            public string? Contact { get; set; }
            public string? Chat { get; set; }
        }
    }
}