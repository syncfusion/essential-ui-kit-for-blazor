namespace UI_Blocks.Components.Pages.BlocksSection.TileView.TileView3
{
    public partial class TileView3
    {

        public List<TransactionDetail> TransactionDetails = new List<TransactionDetail>
        {
            new TransactionDetail { TransactionId = "TXN000245", Title = "Payment for project management services", Company = "Cisco Solutions Pvt. Ltd", Amount = 25000, Currency = "USD", PaymentType = "Wire Transfer", Category = "Consulting", Status = "Completed" },
            new TransactionDetail { TransactionId = "TXN000246", Title = "Advance payment for Q3 contract", Company = "Client John Chris", Amount = 100000, Currency = "USD", PaymentType = "Deposit", Category = "Income", Status = "Completed" },
            new TransactionDetail { TransactionId = "TXN000247", Title = "Purchase of new office equipment", Company = "Office Supplies Inc", Amount = 7500, Currency = "USD", PaymentType = "Credit Card", Category = "Supplies", Status = "Completed" },
            new TransactionDetail { TransactionId = "TXN000248", Title = "Payment for invoice #9876", Company = "Delta Supplier", Amount = 15000, Currency = "USD", PaymentType = "ACH Transfer", Category = "Supplies", Status = "Pending" }
        };

        private string GetStatusClass(string status)
        {
            return status switch
            {
                "Completed" => "e-badge-success",
                "Pending" => "e-badge-danger",
                _ => ""
            };
        }

        public class TransactionDetail
        {
            public string TransactionId { get; set; } = string.Empty;
            public string Title { get; set; } = string.Empty;
            public string Company { get; set; } = string.Empty;
            public decimal Amount { get; set; }
            public string Currency { get; set; } = string.Empty;
            public string PaymentType { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
            public string Status { get; set; } = string.Empty;
        }
    }

}
