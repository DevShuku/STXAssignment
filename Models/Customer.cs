namespace STXAssignment.Controllers
{
    public partial class CustomerController
    {
        // Define the Customer class
        public class Customer
        {
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
            public string Type { get; set; }
           // public string Contact { get; set; }
            public Contact Contact {  get; set; }
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
    