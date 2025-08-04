namespace UI_Blocks.Components.Pages.BlocksSection.Grid.Grid9
{
    public partial class Grid9
    {
        public List<Permission> GridData = new List<Permission>
        {
            new Permission { Id = 1, Category = "User Management", PermissionName = "Create Users", SystemAdmin = true, ItManager = true, HrManager = false, FinanceManager = false, SalesManager = false, CustomerServiceRep = false, GeneralEmployee = false },
            new Permission { Id = 2, Category = "User Management", PermissionName = "Edit Users", SystemAdmin = true, ItManager = true, HrManager = false, FinanceManager = false, SalesManager = false, CustomerServiceRep = false, GeneralEmployee = false },
            new Permission { Id = 3, Category = "User Management", PermissionName = "Delete Users", SystemAdmin = true, ItManager = false, HrManager = false, FinanceManager = false, SalesManager = false, CustomerServiceRep = false, GeneralEmployee = false },
            new Permission { Id = 4, Category = "User Management", PermissionName = "View Users", SystemAdmin = true, ItManager = true, HrManager = true, FinanceManager = true, SalesManager = true, CustomerServiceRep = true, GeneralEmployee = true },
            new Permission { Id = 5, Category = "Financial Operations", PermissionName = "Create Invoices", SystemAdmin = true, ItManager = false, HrManager = false, FinanceManager = true, SalesManager = true, CustomerServiceRep = false, GeneralEmployee = false },
            new Permission { Id = 6, Category = "Financial Operations", PermissionName = "Approve Expenses", SystemAdmin = true, ItManager = false, HrManager = false, FinanceManager = true, SalesManager = false, CustomerServiceRep = false, GeneralEmployee = false },
            new Permission { Id = 7, Category = "Financial Operations", PermissionName = "View Financial Reports", SystemAdmin = true, ItManager = false, HrManager = false, FinanceManager = true, SalesManager = false, CustomerServiceRep = false, GeneralEmployee = false },
            new Permission { Id = 8, Category = "HR Functions", PermissionName = "Manage Payroll", SystemAdmin = true, ItManager = false, HrManager = true, FinanceManager = true, SalesManager = false, CustomerServiceRep = false, GeneralEmployee = false },
            new Permission { Id = 9, Category = "HR Functions", PermissionName = "Handle Leave Requests", SystemAdmin = true, ItManager = false, HrManager = true, FinanceManager = false, SalesManager = false, CustomerServiceRep = true, GeneralEmployee = false },
            new Permission { Id = 10, Category = "HR Functions", PermissionName = "Conduct Performance Reviews", SystemAdmin = true, ItManager = false, HrManager = true, FinanceManager = false, SalesManager = false, CustomerServiceRep = false, GeneralEmployee = false },
            new Permission { Id = 11, Category = "Sale Operations", PermissionName = "Create Sales Orders", SystemAdmin = true, ItManager = false, HrManager = false, FinanceManager = false, SalesManager = true, CustomerServiceRep = true, GeneralEmployee = false },
            new Permission { Id = 12, Category = "Sale Operations", PermissionName = "Apply Discounts", SystemAdmin = true, ItManager = false, HrManager = false, FinanceManager = false, SalesManager = true, CustomerServiceRep = false, GeneralEmployee = false },
            new Permission { Id = 13, Category = "Sale Operations", PermissionName = "View Sales Reports", SystemAdmin = true, ItManager = false, HrManager = false, FinanceManager = true, SalesManager = true, CustomerServiceRep = false, GeneralEmployee = false },
            new Permission { Id = 14, Category = "IT Operations", PermissionName = "Manage System Configurations", SystemAdmin = true, ItManager = true, HrManager = false, FinanceManager = false, SalesManager = false, CustomerServiceRep = false, GeneralEmployee = false },
            new Permission { Id = 15, Category = "IT Operations", PermissionName = "Monitor System Performance", SystemAdmin = true, ItManager = true, HrManager = false, FinanceManager = false, SalesManager = false, CustomerServiceRep = false, GeneralEmployee = false },
            new Permission { Id = 16, Category = "IT Operations", PermissionName = "Manage Backups", SystemAdmin = true, ItManager = true, HrManager = false, FinanceManager = false, SalesManager = false, CustomerServiceRep = false, GeneralEmployee = false },
            new Permission { Id = 17, Category = "General Access", PermissionName = "Access Company Directory", SystemAdmin = true, ItManager = true, HrManager = true, FinanceManager = true, SalesManager = true, CustomerServiceRep = true, GeneralEmployee = true },
            new Permission { Id = 18, Category = "General Access", PermissionName = "Submit Expense Reports", SystemAdmin = true, ItManager = true, HrManager = true, FinanceManager = true, SalesManager = true, CustomerServiceRep = true, GeneralEmployee = true },
            new Permission { Id = 19, Category = "General Access", PermissionName = "View Personal Information", SystemAdmin = true, ItManager = true, HrManager = true, FinanceManager = true, SalesManager = true, CustomerServiceRep = true, GeneralEmployee = true }
        };

        public class Permission
        {
            public int Id { get; set; }
            public string Category { get; set; } = string.Empty;
            public string PermissionName { get; set; } = string.Empty;
            public bool SystemAdmin { get; set; }
            public bool ItManager { get; set; }
            public bool HrManager { get; set; }
            public bool FinanceManager { get; set; }
            public bool SalesManager { get; set; }
            public bool CustomerServiceRep { get; set; }
            public bool GeneralEmployee { get; set; }
        }
    }
}