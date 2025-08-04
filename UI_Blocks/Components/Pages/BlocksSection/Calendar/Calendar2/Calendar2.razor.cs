using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Calendar.Calendar2
{
    public partial class Calendar2
    {
        public bool IsSidebarOpen = true;
        public double[] Value = [2500, 4000];
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