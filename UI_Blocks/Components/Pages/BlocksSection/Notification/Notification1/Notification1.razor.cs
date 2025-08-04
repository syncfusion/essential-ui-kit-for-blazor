using Microsoft.JSInterop;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor.SplitButtons;

namespace UI_Blocks.Components.Pages.BlocksSection.Notification.Notification1
{
    public partial class Notification1
    {
        public SfDialog? Dialog;
        public SfDropDownButton? Dropdown;
        public bool IsDropdownOpened = false;
        public bool IsDialogVisible = true;
        public List<NotificationItem> MessageData { get; set; } = new List<NotificationItem>();
        public int SelectedTabIndex = 0;
        public string DialogWidth = "448px";

        public List<NotificationItem> Data = new List<NotificationItem>
        {
            new NotificationItem
            {
                Id = 1,
                Avatar = "avatar-8.jpg",
                Name = "Jane Smith",
                Content = "wants to edit the Design System",
                Time = "5 min ago",
                Category = "Following"
            },
            new NotificationItem
            {
                Id = 2,
                Avatar = "avatar-5.jpg",
                Name = "David Clark",
                Content = "added a file to Dark Mode",
                Time = "1 hour ago",
                Category = "Following"
            },
            new NotificationItem
            {
                Id = 3,
                Initial = "RL",
                ColorTheme = "Orange",
                Name = "Rachel Lee",
                Content = "finished created new component",
                Time = "1:12 pm",
                Category = "Archieve"
            },
            new NotificationItem
            {
                Id = 4,
                Initial = "LG",
                ColorTheme = "Green",
                Name = "Lisa Green",
                Content = "mentioned you in Rewrite Button component",
                Time = "1:52 pm",
                Category = "Archieve"
            }
        };

        public void TabCreated()
        {
            MessageData = Data.Take(4).ToList();
        }

        public async Task TabSelectedAsync(SelectEventArgs args)
        {
            SelectedTabIndex = args.SelectedIndex;
            switch (args.SelectedIndex)
            {
                case 0:
                    MessageData = Data.Take(4).ToList();
                    break;
                case 1:
                    MessageData = Data.Where(list => list.Category == "Following").ToList();
                    break;
                case 2:
                    MessageData = Data.Where(list => list.Category == "Archieve").ToList();
                    break;
                default:
                    MessageData = new List<NotificationItem>();
                    break;
            }
            await InvokeAsync(StateHasChanged);
        }

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                DialogWidth = windowWidth < 480 ? "328px" : "448px";
                await Dialog.RefreshPositionAsync();
            }
            if (IsDropdownOpened && Dropdown != null)
            {
                Dropdown.Toggle();
            }
            StateHasChanged();
        }

        public class NotificationItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Avatar { get; set; } = string.Empty;
            public string Initial { get; set; } = string.Empty;
            public string ColorTheme { get; set; } = string.Empty;
            public string Content { get; set; } = string.Empty;
            public string Time { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
        }
    }
}

