using Microsoft.JSInterop;

namespace UI_Blocks.Components.Pages.BlocksSection.List.List5
{
    public partial class List5
    {
        public string WidthStyle = "max-width:448px";

        public List<Country> Countries = new List<Country>
        {
            new Country { Id = 1, Name = "Afghanistan", Number = "+93", Badge = "AF", Pic = "afghanistan.png" },
            new Country { Id = 2, Name = "Albania", Number = "+355", Badge = "AL", Pic = "albania.png" },
            new Country { Id = 3, Name = "Algeria", Number = "+213", Badge = "DZ", Pic = "algeria.png" },
            new Country { Id = 4, Name = "Andorra", Number = "+376", Badge = "AD", Pic = "andorra.png" },
            new Country { Id = 5, Name = "Angola", Number = "+244", Badge = "AO", Pic = "angola.png" },
            new Country { Id = 6, Name = "Argentina", Number = "+54", Badge = "AR", Pic = "argentina.png" },
            new Country { Id = 7, Name = "Armenia", Number = "+374", Badge = "AM", Pic = "armenia.png" },
            new Country { Id = 8, Name = "Australia", Number = "+61", Badge = "AU", Pic = "australia.png" }
        };

        [JSInvokable]
        public void ResizeHandler(string message, int windowWidth)
        {
            if (message == "resizeAction")
            {
                WidthStyle = windowWidth < 1024 ? "width:100%" : "max-width:448px";
            }
            StateHasChanged();
        }

        public class Country
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Number { get; set; } = string.Empty;
            public string Badge { get; set; } = string.Empty;
            public string Pic { get; set; } = string.Empty;
        }
    }
}
