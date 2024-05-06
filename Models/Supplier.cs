namespace STXAssignment.Controllers
{
    public partial class SupplierController
    {
        // Define the Supplier class
        /*public class Supplier
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            // Add any other properties as needed
        }*/

        public class Supplier
        {
            public int SupplierId { get; set; }
            public string SupplierName { get; set; }
            public string Category { get; set; }
            // public string Contact { get; set; }
            public Contact Contact { get; set; }
            public string? Country { get; set; } = null;
            // Add any other properties as needed
        }
        public class Contact
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }

        }
    }
}
    