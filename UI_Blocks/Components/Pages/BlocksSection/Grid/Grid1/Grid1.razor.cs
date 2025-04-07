namespace UI_Blocks.Components.Pages.BlocksSection.Grid.Grid1
{
    public partial class Grid1
    {
        public class Detail
        {
            public string Name { get; set; } = string.Empty;
            public string Initial { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string ColorTheme { get; set; } = string.Empty;
        }

        public class Assignee
        {
            public string Name { get; set; } = string.Empty;
            public string Avatar { get; set; } = string.Empty;
        }

        public class Lead
        {
            public int Id { get; set; }
            public string LeadId { get; set; } = string.Empty;
            public Detail Details { get; set; } = new Detail();
            public string Status { get; set; } = string.Empty;
            public string Interest { get; set; } = string.Empty;
            public DateTime Date { get; set; }
            public Assignee Assignee { get; set; } = new Assignee();
            public string Source { get; set; } = string.Empty;
            public int Revenue { get; set; }
        }
        
        List<Lead> GridData = new List<Lead>
        {
            new Lead
            {
                Id = 1,
                LeadId = "L1001",
                Details = new Detail
                {
                    Name = "John Doe",
                    Initial = "JD",
                    Email = "john.doe@example.com",
                    ColorTheme = "Red"
                },
                Status = "Qualified",
                Interest = "High",
                Date = new DateTime(2024, 9, 15),
                Assignee = new Assignee
                {
                    Name = "Alice Smith",
                    Avatar = "avatar-8.jpg"
                },
                Source = "Web Inquiry",
                Revenue = 90000
            },
            new Lead
            {
                Id = 2,
                LeadId = "L1002",
                Details = new Detail
                {
                    Name = "Emily White",
                    Initial = "EW",
                    Email = "emily.white@example.com",
                    ColorTheme = "Blue"
                },
                Status = "New",
                Interest = "Medium",
                Date = new DateTime(2024, 10, 8),
                Assignee = new Assignee
                {
                    Name = "Bob Johnson",
                    Avatar = "avatar-1.jpg"
                },
                Source = "Referral",
                Revenue = 80000
            },
            new Lead
            {
                Id = 3,
                LeadId = "L1003",
                Details = new Detail
                {
                    Name = "Michael Green",
                    Initial = "MG",
                    Email = "michael.green@example.com",
                    ColorTheme = "Green"
                },
                Status = "Contacted",
                Interest = "High",
                Date = new DateTime(2024, 12, 9),
                Assignee = new Assignee
                {
                    Name = "Carol Brown",
                    Avatar = "avatar-4.jpg"
                },
                Source = "Trade Show",
                Revenue = 85000
            },
            new Lead
            {
                Id = 4,
                LeadId = "L1004",
                Details = new Detail
                {
                    Name = "Sarah Brown",
                    Initial = "SB",
                    Email = "sarah.brown@example.com",
                    ColorTheme = "Orange"
                },
                Status = "Lead",
                Interest = "Low",
                Date = new DateTime(2024, 9, 14),
                Assignee = new Assignee
                {
                    Name = "Dave Wilson",
                    Avatar = "avatar-3.jpg"
                },
                Source = "Email Campaign",
                Revenue = 60000
            },
            new Lead
            {
                Id = 5,
                LeadId = "L1005",
                Details = new Detail
                {
                    Name = "David Miller",
                    Initial = "DM",
                    Email = "david.miller@example.com",
                    ColorTheme = "Blue"
                },
                Status = "Qualified",
                Interest = "High",
                Date = new DateTime(2024, 9, 20),
                Assignee = new Assignee
                {
                    Name = "Emma Davis",
                    Avatar = "avatar-11.jpg"
                },
                Source = "Direct Mail",
                Revenue = 95000
            },
            new Lead
            {
                Id = 6,
                LeadId = "L1006",
                Details = new Detail
                {
                    Name = "Laura Martinez",
                    Initial = "LM",
                    Email = "laura.martinez@example.com",
                    ColorTheme = "Purple"
                },
                Status = "New",
                Interest = "Medium",
                Date = new DateTime(2024, 9, 16),
                Assignee = new Assignee
                {
                    Name = "Frank Moore",
                    Avatar = "avatar-2.jpg"
                },
                Source = "Web Inquiry",
                Revenue = 75000
            },
            new Lead
            {
                Id = 7,
                LeadId = "L1007",
                Details = new Detail
                {
                    Name = "Chris Lee",
                    Initial = "CL",
                    Email = "chris.lee@example.com",
                    ColorTheme = "Green"
                },
                Status = "Contacted",
                Interest = "Medium",
                Date = new DateTime(2024, 9, 17),
                Assignee = new Assignee
                {
                    Name = "Grace Hui",
                    Avatar = "avatar-12.jpg"
                },
                Source = "Referral",
                Revenue = 85000
            },
            new Lead
            {
                Id = 8,
                LeadId = "L1008",
                Details = new Detail
                {
                    Name = "Megan Johnson",
                    Initial = "MJ",
                    Email = "megan.johnson@example.com",
                    ColorTheme = "Orange"
                },
                Status = "Lead",
                Interest = "High",
                Date = new DateTime(2024, 9, 18),
                Assignee = new Assignee
                {
                    Name = "Henry King",
                    Avatar = "avatar-5.jpg"
                },
                Source = "Trade Show",
                Revenue = 95000
            },
            new Lead
            {
                Id = 9,
                LeadId = "L1009",
                Details = new Detail
                {
                    Name = "Robert Smith",
                    Initial = "RS",
                    Email = "robert.smith@example.com",
                    ColorTheme = "Blue"
                },
                Status = "New",
                Interest = "Medium",
                Date = new DateTime(2024, 9, 19),
                Assignee = new Assignee
                {
                    Name = "Ivy Walker",
                    Avatar = "avatar-14.jpg"
                },
                Source = "Email Campaign",
                Revenue = 70000
            },
            new Lead
            {
                Id = 10,
                LeadId = "L1010",
                Details = new Detail
                {
                    Name = "Olivia Davis",
                    Initial = "OD",
                    Email = "olivia.davis@example.com",
                    ColorTheme = "Red"
                },
                Status = "Contacted",
                Interest = "Low",
                Date = new DateTime(2024, 9, 20),
                Assignee = new Assignee
                {
                    Name = "Jack Lee",
                    Avatar = "avatar-6.jpg"
                },
                Source = "Direct Mail",
                Revenue = 90000
            }
        };
    }
}