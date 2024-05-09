namespace STXAssignment.Controllers
{
   // public partial class SupplierController
    //{
        public class Supplier
        {
            [Key]
            public int SupplierId { get; set; }
            public string SupplierName { get; set; }
            public string Category { get; set; }
            public string ContactName { get; set; }
            //public Contact Contact { get; set; }
            public string? Country { get; set; } = null;
            // Add any other properties as needed
        }
       /* public class Contact
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }

        } */
    //}
}
    