using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor.ProgressBar;

namespace UI_Blocks.Components.Pages.BlocksSection.Notification.Notification2
{
    public partial class Notification2
    {
        public SfDialog? Dialog;
        public SfProgressBar? ProgressBar;
        public bool IsDialogVisible = true;
        public string DialogWidth = "448px";

        public List<Notification> NotificationData = new List<Notification>
        {
            new Notification { Id = 1, Avatar = "avatar-2.jpg", Sender = "Lucas Robinson", Content = "Hey, can you check the latest documents posted in the group?", Time = "1 day" },
            new Notification { Id = 2, Avatar = "avatar-5.jpg", Sender = "David Clark", Content = "Hey, can you check the latest documents posted in the group?", Time = "4 day" }
        };

        private async void AfterOpen(Syncfusion.Blazor.Popups.OpenEventArgs args)
        {
            args.PreventFocus = true;
            await Task.Delay(50);
            if (ProgressBar != null)
            {
                await ProgressBar.RefreshAsync();
            }
        }

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                DialogWidth = windowWidth < 480 ? "328px" : "448px";
                await Dialog.RefreshPositionAsync();
                StateHasChanged();
            }
        }

        public class Notification
        {
            public int Id { get; set; }
            public string Avatar { get; set; } = string.Empty;
            public string Sender { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public string Time { get; set; } = string.Empty;
        }
    }
}
