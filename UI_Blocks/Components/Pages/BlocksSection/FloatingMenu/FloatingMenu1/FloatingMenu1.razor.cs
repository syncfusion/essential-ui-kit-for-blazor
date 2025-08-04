using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;

namespace UI_Blocks.Components.Pages.BlocksSection.FloatingMenu.FloatingMenu1
{
    public partial class FloatingMenu1
    {
        public SfDialog? Dialog;
        public bool IsToggleState = true;
        public bool IsMobileView = false;

        public List<FloatingData> Data = new List<FloatingData>
        {
            new FloatingData { Question = "How do I reset my password?", Answer = "Detailed steps on resetting a forgotten password or changing an existing one." },
            new FloatingData { Question = "How can I contact customer support?", Answer = "Guidance on reaching out to customer service via chat, email, or phone." },
            new FloatingData { Question = "How do I update my account information?", Answer = "Instructions for editing personal details such as email address, phone number, or payment..." },
            new FloatingData { Question = "What should I do if I can't log in?", Answer = "Troubleshooting steps for login issues, including account lockouts or forgotten credentials." },
            new FloatingData { Question = "How do I track my order?", Answer = "Steps to track the status of an order, including shipping updates and expected delivery times." }
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
            public string Question { get; set; } = string.Empty;
            public string Answer { get; set; } = string.Empty;
        }
    }
}
