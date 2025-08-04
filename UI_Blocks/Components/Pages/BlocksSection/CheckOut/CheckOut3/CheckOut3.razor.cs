namespace UI_Blocks.Components.Pages.BlocksSection.CheckOut.CheckOut3
{
    public partial class CheckOut3
    {

        public string SelectedPaymentMethod = "Debit card";

        public string SelectedBillingAddress = "Individual";

        public string SelectedDeliveryAddress = "Delivery to the same address";

        public List<Product> Products = new List<Product>
        {
            new Product{ Id = 1, Image = "apple-magsafe.png", Description = "Apple MagSafe Charger (for iPhone, AirPods Pro, AirPods with Wireless Charging Case)", Quantity = 1, Amount = "$2,000" },
            new Product{ Id = 2, Image = "apple-iPad.png", Description = "Apple iPad (10th Generation): With A14 Bionic Chip, 27.69 cm (10.9″) Liquid Retina Display, 64GB, Wi-Fi 6, 12MP Front/12MP Back Camera, Touch ID, All-Day Battery Life - Blue", Quantity = 1, Amount = "$2,000" },
            new Product{ Id = 3, Image = "apple-macbook-air.png", Description = "Apple MacBook Air Laptop: M1 Chip, 13.3-Inch (33.74 cm) Retina Display, 8GB RAM, 256GB SSD Storage, Backlit Keyboard, FaceTime HD Camera, Touch ID. Works with iPhone/iPad; Space Grey", Quantity = 1, Amount = "$1,000" },
            new Product{ Id = 4, Image = "apple-magic-keyboard.png", Description = "Apple Magic Keyboard - US English - Silver (For Mac with macOS 11.3 or later, iPad running iPadOS 14.5 or later)", Quantity = 1, Amount = "$1,000" },
            new Product{ Id = 5, Image = "apple-magic-mouse.png", Description = "Apple Magic Mouse (For Bluetooth-Enabled Mac with OS X 10.11 or later, iPad with iPadOS 13.4 or later)", Quantity = 1, Amount = "$1,000" },
            new Product{ Id = 6, Image = "apple-iphone-charger.png", Description = "Original iPhone Charger: 20W Fast USB Type-C Adapter for iPhone 15/15 Plus/15 Pro/15 Pro Max, iPhone 14/14 Plus/14 Pro/14 Pro Max, iPhone 13/12/11 & Others. PD 3.0, 20 Watt, BIS Certified, 2 Years Warranty", Quantity = 1, Amount = "$1,900" }
        };

        public class Product
        {
            public int Id { get; set; }
            public string Image { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public int Quantity { get; set; }
            public string Amount { get; set; } = string.Empty;
        }
    }
}
