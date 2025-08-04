using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.Calendar.Calendar5
{
    public partial class Calendar5
    {
        public bool IsSidebarOpen = true;
        public string Width = "310px";
        public List<TodoData> data = new List<TodoData>
        {
            new TodoData { Id = 1, Header = "Read a book about UI", Date = "09:00 AM - 11:00 AM", Completed = true },
            new TodoData { Id = 2, Header = "Meeting with client", Date = "12:00 AM - 12:30 PM", Completed = true },
            new TodoData { Id = 3, Header = "Hangout with friends", Date = "01:00 PM - 02:00 PM", Completed = true },
            new TodoData { Id = 4, Header = "Coffee break", Date = "04:00 PM - 04:30 PM", Completed = false },
            new TodoData { Id = 5, Header = "Dinner with family", Date = "08:00 PM - 09:00 PM", Completed = false }
        };

        public void HandleCheckboxChange(int id)
        {
            var item = data.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.Completed = !item.Completed;
                StateHasChanged();
            }
        }

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                Width = windowWidth < 540 ? "100%" : "310px";
            }
            StateHasChanged();
        }

        public class TodoData
        {
            public int Id { get; set; }
            public string Header { get; set; } = string.Empty;
            public string Date { get; set; } = string.Empty;
            public bool Completed { get; set; }
        }
    }
}