using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Calendar.Calendar1
{
    public partial class Calendar1
    {
        public bool IsSidebarOpen = true;
        public string Width = "310px";

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                Width = windowWidth < 540 ? "100%" : "310px";
            }
            StateHasChanged();
        }

    }
}