namespace UI_Blocks.Components.Pages.BlocksSection.TileView.TileView5
{
    public partial class TileView5
    {

        private List<JobDetail> JobDetails = new()
        {
            new JobDetail { JobId = 1, Title = "Embedded Power Electronics Design Engineer (Entry-Level)", Company = "Nokia Solutions Pvt. Ltd", Reviews = 343, Experience = "0-2 yrs", Salary = "8-12 Lacs PA", Location = "USA", Posted = "2 days ago", Openings = 1, Applicants = 927, Logo = "nokia.png" },
            new JobDetail { JobId = 2, Title = "Walk in Interview_Salesforce Developer", Company = "Delta Solutions Pvt. Ltd", Reviews = 4567, Experience = "0-5 yrs", Salary = "6-10 Lacs PA", Location = "UK", Posted = "4 days ago", Openings = 4, Applicants = 234, Logo = "salesforce.png" },
            new JobDetail { JobId = 3, Title = "Walk in Interview_Salesforce Developer", Company = "Cisco Solutions Pvt. Ltd", Reviews = 4567, Experience = "2-5 yrs", Salary = "10-16 Lacs PA", Location = "France", Posted = "8 days ago", Openings = 2, Applicants = 12, Logo = "cisco.png" }
        };

        public class JobDetail
        {
            public int JobId { get; set; }
            public string Title { get; set; } = string.Empty;
            public string Company { get; set; } = string.Empty;
            public int Reviews { get; set; }
            public string Experience { get; set; } = string.Empty;
            public string Salary { get; set; } = string.Empty;
            public string Location { get; set; } = string.Empty;
            public string Posted { get; set; } = string.Empty;
            public int Openings { get; set; }
            public int Applicants { get; set; }
            public string Logo { get; set; } = string.Empty;
        }
    }
}
