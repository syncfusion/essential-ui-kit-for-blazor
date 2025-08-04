namespace UI_Blocks.Components.Pages.BlocksSection.Grid.Grid4
{
    public partial class Grid4
    {
        public List<Contact> GridData = new List<Contact>
        {
            new Contact
            {
                Id = 1,
                ContactId = "C0001",
                Profile = new Profile
                {
                    Name = "Jane Smith",
                    Initial = "",
                    Email = "jane.smith@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-8.jpg"
                },
                JobTitle = "Marketing Director",
                Company = "Tech Solutions",
                CommunicationPreferences = new List<string> { "Email", "Phone" },
                Location = "Austin, TX",
                LeadSource = "Referral",
                Avatar = "avatar-14.jpg",
                AssignedTo = new AssignedTo
                {
                    Name = "Sarah Lee",
                    Department = "Marketing"
                },
                Status = "Active"
            },
            new Contact
            {
                Id = 2,
                ContactId = "C0002",
                Profile = new Profile
                {
                    Name = "Mark Johnson",
                    Initial = "",
                    Email = "mark.johnson@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-1.jpg"
                },
                JobTitle = "Sales Manager",
                Company = "Innovate Inc.",
                CommunicationPreferences = new List<string> { "Phone" },
                Location = "San Jose, CA",
                LeadSource = "Direct",
                Avatar = "avatar-7.jpg",
                AssignedTo = new AssignedTo
                {
                    Name = "Tom Richards",
                    Department = "Sales"
                },
                Status = "Inactive"
            },
            new Contact
            {
                Id = 3,
                ContactId = "C0003",
                Profile = new Profile
                {
                    Name = "Emily White",
                    Initial = "",
                    Email = "emily.white@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-9.jpg"
                },
                JobTitle = "CEO",
                Company = "Creative Co.",
                CommunicationPreferences = new List<string> { "Email", "Phone" },
                Location = "Boston, MA",
                LeadSource = "Web Inquiry",
                Avatar = "avatar-13.jpg",
                AssignedTo = new AssignedTo
                {
                    Name = "Lisa Brown",
                    Department = "Executive"
                },
                Status = "Active"
            },
            new Contact
            {
                Id = 4,
                ContactId = "C0004",
                Profile = new Profile
                {
                    Name = "Tom Harris",
                    Initial = "TH",
                    Email = "tom.harris@example.com",
                    ColorTheme = "Red",
                    Avatar = ""
                },
                JobTitle = "Product Manager",
                Company = "Media Group",
                CommunicationPreferences = new List<string> { "Email" },
                Location = "Miami, FL",
                LeadSource = "Referral",
                Avatar = "avatar-7.jpg",
                AssignedTo = new AssignedTo
                {
                    Name = "Tom Richards",
                    Department = "Sales"
                },
                Status = "Inactive"
            },
            new Contact
            {
                Id = 5,
                ContactId = "C0005",
                Profile = new Profile
                {
                    Name = "Lisa Green",
                    Initial = "LG",
                    Email = "lisa.green@example.com",
                    ColorTheme = "Green",
                    Avatar = ""
                },
                JobTitle = "IT Specialist",
                Company = "Global Tech",
                CommunicationPreferences = new List<string> { "Email", "Phone" },
                Location = "Portland, OR",
                LeadSource = "Direct",
                Avatar = "avatar-13.jpg",
                AssignedTo = new AssignedTo
                {
                    Name = "Lisa Brown",
                    Department = "Executive"
                },
                Status = "Inactive"
            },
            new Contact
            {
                Id = 6,
                ContactId = "C0006",
                Profile = new Profile
                {
                    Name = "David Clark",
                    Initial = "",
                    Email = "david.clark@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-2.jpg"
                },
                JobTitle = "HR Manager",
                Company = "PeopleWorks",
                CommunicationPreferences = new List<string> { "Email" },
                Location = "Dallas, TX",
                LeadSource = "Referral",
                Avatar = "avatar-14.jpg",
                AssignedTo = new AssignedTo
                {
                    Name = "Sarah Lee",
                    Department = "Marketing"
                },
                Status = "Active"
            },
            new Contact
            {
                Id = 7,
                ContactId = "C0007",
                Profile = new Profile
                {
                    Name = "Rachel Lee",
                    Initial = "RL",
                    Email = "rachel.lee@example.com",
                    ColorTheme = "Blue",
                    Avatar = ""
                },
                JobTitle = "CFO",
                Company = "Finance Corp",
                CommunicationPreferences = new List<string> { "Email", "Phone" },
                Location = "New York, NY",
                LeadSource = "Web Inquiry",
                Avatar = "avatar-7.jpg",
                AssignedTo = new AssignedTo
                {
                    Name = "Tom Richards",
                    Department = "Sales"
                },
                Status = "Inactive"
            },
            new Contact
            {
                Id = 8,
                ContactId = "C0008",
                Profile = new Profile
                {
                    Name = "Olivia Adams",
                    Initial = "",
                    Email = "olivia.adams@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-12.jpg"
                },
                JobTitle = "Operations Manager",
                Company = "Logistics Ltd",
                CommunicationPreferences = new List<string> { "Phone" },
                Location = "Seattle, WA",
                LeadSource = "Referral",
                Avatar = "avatar-13.jpg",
                AssignedTo = new AssignedTo
                {
                    Name = "Lisa Brown",
                    Department = "Executive"
                },
                Status = "Active"
            },
            new Contact
            {
                Id = 9,
                ContactId = "C0009",
                Profile = new Profile
                {
                    Name = "Lucas Robinson",
                    Initial = "",
                    Email = "lucas.robinson@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-5.jpg"
                },
                JobTitle = "Customer Support Manager",
                Company = "SupportWorks",
                CommunicationPreferences = new List<string> { "Phone", "Email" },
                Location = "Miami, FL",
                LeadSource = "Web Inquiry",
                Avatar = "avatar-14.jpg",
                AssignedTo = new AssignedTo
                {
                    Name = "Sarah Lee",
                    Department = "Marketing"
                },
                Status = "Inactive"
            },
            new Contact
            {
                Id = 10,
                ContactId = "C0010",
                Profile = new Profile
                {
                    Name = "Sophia Martinez",
                    Initial = "",
                    Email = "sophia.martinez@example.com",
                    ColorTheme = "",
                    Avatar = "avatar-10.jpg"
                },
                JobTitle = "Business Analyst",
                Company = "Insight Analytics",
                CommunicationPreferences = new List<string> { "Email", "Phone" },
                Location = "Atlanta, GA",
                LeadSource = "Direct",
                Avatar = "avatar-14.jpg",
                AssignedTo = new AssignedTo
                {
                    Name = "Sarah Lee",
                    Department = "Marketing"
                },
                Status = "Active"
            }
        };

        public class Profile
        {
            public string Name { get; set; } = string.Empty;
            public string Initial { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string ColorTheme { get; set; } = string.Empty;
            public string Avatar { get; set; } = string.Empty;
        }

        public class AssignedTo
        {
            public string Name { get; set; } = string.Empty;
            public string Department { get; set; } = string.Empty;
        }

        public class Contact
        {
            public int Id { get; set; }
            public string ContactId { get; set; } = string.Empty;
            public Profile Profile { get; set; } = new Profile();
            public string JobTitle { get; set; } = string.Empty;
            public string Company { get; set; } = string.Empty;
            public List<string> CommunicationPreferences { get; set; } = new List<string>();
            public string Location { get; set; } = string.Empty;
            public string LeadSource { get; set; } = string.Empty;
            public string Avatar { get; set; } = string.Empty;
            public AssignedTo AssignedTo { get; set; } = new AssignedTo();
            public string Status { get; set; } = string.Empty;
        }
    }
}