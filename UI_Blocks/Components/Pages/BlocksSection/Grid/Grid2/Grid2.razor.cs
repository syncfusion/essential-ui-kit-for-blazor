namespace UI_Blocks.Components.Pages.BlocksSection.Grid.Grid2
{
    public partial class Grid2
    {
        public class Person
        {
            public string Name { get; set; } = string.Empty;
            public string Initial { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string ColorTheme { get; set; } = string.Empty;
            public string Avatar { get; set; } = string.Empty;
        }

        public class Ticket
        {
            public int Id { get; set; }
            public string TicketId { get; set; } = string.Empty;
            public string Issue { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
            public string Estimated { get; set; } = string.Empty;
            public DateTime ResponseDue { get; set; }
            public string Priority { get; set; } = string.Empty;
            public Person Assignee { get; set; } = new Person();
            public Person CreatedBy { get; set; } = new Person();
            public string Status { get; set; } = string.Empty;
        }

        List<Ticket> GridData = new List<Ticket>
        {
            new Ticket
            {
                Id = 1,
                TicketId = "HD-0001",
                Issue = "Laptop not powering on",
                Category = "Hardware",
                Estimated = "1 hour",
                ResponseDue = new DateTime(2024, 5, 1),
                Priority = "High",
                Assignee = new Person
                {
                    Name = "Jane Smith",
                    Initial = "",
                    Email = "jane.smith@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-8.jpg"
                },
                CreatedBy = new Person
                {
                    Name = "Sarah Lee",
                    Initial = "SL",
                    ColorTheme = "Blue",
                    Avatar = ""
                },
                Status = "Not Started"
            },
            new Ticket
            {
                Id = 2,
                TicketId = "HD-0002",
                Issue = "Email application not syncing",
                Category = "Software",
                Estimated = "2 days",
                ResponseDue = new DateTime(2024, 10, 1),
                Priority = "Medium",
                Assignee = new Person
                {
                    Name = "Mark Johnson",
                    Initial = "",
                    Email = "mark.johnson@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-1.jpg"
                },
                CreatedBy = new Person
                {
                    Name = "Tom Richards",
                    Initial = "",
                    ColorTheme = "",
                    Avatar = "avatar-2.jpg"
                },
                Status = "In Progress"
            },
            new Ticket
            {
                Id = 3,
                TicketId = "HD-0003",
                Issue = "Unable to connect to VPN",
                Category = "Network",
                Estimated = "4 hours",
                ResponseDue = new DateTime(2024, 1, 15),
                Priority = "High",
                Assignee = new Person
                {
                    Name = "Emily White",
                    Initial = "EW",
                    Email = "emily.white@example.com",
                    ColorTheme = "Red",
                    Avatar = ""
                },
                CreatedBy = new Person
                {
                    Name = "Lisa Brown",
                    Initial = "",
                    ColorTheme = "",
                    Avatar = "avatar-10.jpg"
                },
                Status = "Not Started"
            },
            new Ticket
            {
                Id = 4,
                TicketId = "HD-0004",
                Issue = "Printer not responding",
                Category = "Hardware",
                Estimated = "7 hours",
                ResponseDue = new DateTime(2024, 1, 20),
                Priority = "Low",
                Assignee = new Person
                {
                    Name = "Tom Hicks",
                    Initial = "",
                    Email = "tom.hicks@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-3.jpg"
                },
                CreatedBy = new Person
                {
                    Name = "Jane Smith",
                    Initial = "JS",
                    ColorTheme = "Green",
                    Avatar = ""
                },
                Status = "Resolved"
            },
            new Ticket
            {
                Id = 5,
                TicketId = "HD-0005",
                Issue = "Application crashing",
                Category = "Software",
                Estimated = "1 day",
                ResponseDue = new DateTime(2024, 1, 25),
                Priority = "High",
                Assignee = new Person
                {
                    Name = "David Clark",
                    Initial = "",
                    Email = "david.clark@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-4.jpg"
                },
                CreatedBy = new Person
                {
                    Name = "Robert Johnson",
                    Initial = "",
                    ColorTheme = "",
                    Avatar = "avatar-5.jpg"
                },
                Status = "Not Started"
            },
            new Ticket
            {
                Id = 6,
                TicketId = "HD-0006",
                Issue = "Slow internet connection",
                Category = "Network",
                Estimated = "2 hours",
                ResponseDue = new DateTime(2024, 1, 2),
                Priority = "Medium",
                Assignee = new Person
                {
                    Name = "Rachel Lee",
                    Initial = "RL",
                    Email = "rachel.lee@example.com",
                    ColorTheme = "Orange",
                    Avatar = ""
                },
                CreatedBy = new Person
                {
                    Name = "Linda Morgan",
                    Initial = "",
                    ColorTheme = "",
                    Avatar = "avatar-11.jpg"
                },
                Status = "In Progress"
            },
            new Ticket
            {
                Id = 7,
                TicketId = "HD-0007",
                Issue = "Monitor screen flickering",
                Category = "Hardware",
                Estimated = "1 hour",
                ResponseDue = new DateTime(2024, 5, 2),
                Priority = "Low",
                Assignee = new Person
                {
                    Name = "Fred Butler",
                    Initial = "",
                    Email = "fred.butler@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-1.jpg"
                },
                CreatedBy = new Person
                {
                    Name = "Chris Johnson",
                    Initial = "",
                    ColorTheme = "",
                    Avatar = "avatar-2.jpg"
                },
                Status = "Resolved"
            },
            new Ticket
            {
                Id = 8,
                TicketId = "HD-0008",
                Issue = "Cannot install software",
                Category = "Software",
                Estimated = "2 days",
                ResponseDue = new DateTime(2024, 10, 2),
                Priority = "High",
                Assignee = new Person
                {
                    Name = "Olivia Adams",
                    Initial = "",
                    Email = "olivia.adams@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-8.jpg"
                },
                CreatedBy = new Person
                {
                    Name = "Chloe Anderson",
                    Initial = "CA",
                    ColorTheme = "Red",
                    Avatar = ""
                },
                Status = "Not Started"
            },
            new Ticket
            {
                Id = 9,
                TicketId = "HD-0009",
                Issue = "Cannot access website",
                Category = "Network",
                Estimated = "1 day",
                ResponseDue = new DateTime(2024, 2, 15),
                Priority = "High",
                Assignee = new Person
                {
                    Name = "Lucas Richards",
                    Initial = "",
                    Email = "lucas.richards@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-10.jpg"
                },
                CreatedBy = new Person
                {
                    Name = "Chris Johnson",
                    Initial = "",
                    ColorTheme = "",
                    Avatar = "avatar-4.jpg"
                },
                Status = "Resolved"
            },
            new Ticket
            {
                Id = 10,
                TicketId = "HD-0010",
                Issue = "Keyboard not working",
                Category = "Hardware",
                Estimated = "30 minutes",
                ResponseDue = new DateTime(2024, 2, 20),
                Priority = "Medium",
                Assignee = new Person
                {
                    Name = "Sophia Martinez",
                    Initial = "SM",
                    Email = "sophia.martinez@example.com",
                    ColorTheme = "Blue",
                    Avatar = ""
                },
                CreatedBy = new Person
                {
                    Name = "Sarah Lee",
                    Initial = "",
                    ColorTheme = "",
                    Avatar = "avatar-13.jpg"
                },
                Status = "In Progress"
            }
        };
    }
}