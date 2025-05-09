namespace UI_Blocks.Components.Pages.BlocksSection.Header.Header13
{
    public partial class Header13
    {
        public List<string> Periods { get; set; } = new List<string>
        {
            "Today",
            "Yesterday",
            "Last 7 Days",
            "Last 30 Days",
            "This Month",
            "Last Month",
            "Custom Range..."
        };

        public List<string> Products { get; set; } = new List<string>
        {
            "All Products",
            "Product A",
            "Product B",
            "Product C",
            "Product D",
            "Custom Selection..."
        };

        public List<string> Regions { get; set; } = new List<string>
        {
            "All Regions",
            "North America",
            "Europe",
            "Asia-Pacific",
            "South America",
            "Middle East & Africa",
            "Custom Region..."
        };
    }
}