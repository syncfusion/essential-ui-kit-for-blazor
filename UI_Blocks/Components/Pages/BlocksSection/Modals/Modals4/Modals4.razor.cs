using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor.Lists;
using Syncfusion.Blazor.Buttons;

namespace UI_Blocks.Components.Pages.BlocksSection.Modals.Modals4
{
    public partial class Modals4
    {
        public SfDialog? Dialog;
        public SfListView<TeamMember> ListView;
        public bool IsMobile;

        public List<TeamMember> DataSource = new List<TeamMember> 
        {
            new TeamMember { Id = 1, Name = "Jane Smith", Email = "jane.smith@example.com", Status = "Active", Role = "Admin" },
            new TeamMember { Id = 2, Name = "Mark Johnson", Email = "mark.johnson@example.com", Status = "Active", Role = "Editor" },
            new TeamMember { Id = 3, Name = "Emily White", Email = "emily.white@example.com", Status = "Pending", Role = "Viewer" },
            new TeamMember { Id = 4, Name = "Tom Harris", Email = "tom.harris@example.com", Status = "Active", Role = "Editor" },
            new TeamMember { Id = 5, Name = "Lisa Green", Email = "lisa.green@example.com", Status = "Active", Role = "Viewer" }
        };

        public async Task OnSelectAllChangedAsync(ChangeEventArgs<bool> args)
        {
            if (args.Checked)
            {
                await ListView.CheckItemsAsync();
            }
            else
            {
                await ListView.UncheckItemsAsync();
            }
        }

        [JSInvokable]
        public async Task ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction" && Dialog != null)
            {
                IsMobile = windowWidth <= 640;
                await Dialog.HideAsync();
                await Dialog.ShowAsync(IsMobile);
            }
        }

        public class TeamMember
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Status { get; set; } = string.Empty;
            public string Role { get; set; } = string.Empty;
        }
    }
}