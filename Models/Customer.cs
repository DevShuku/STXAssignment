using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace STXAssignment.Controllers
{
   // public partial class CustomerController
    //{
        // Define the Customer class
        public class Customer
        {
            [Key]
            public int CustomerId { get; set; }

            [Required]
            [StringLength(maximumLength:100,MinimumLength =2)]
            public string CustomerName { get; set; }
            public string Type { get; set; }
            //public Contact Contact {  get; set; }
            public string? ContactId { get; set; }
            public string Contact { get; set; }
            public string? Country { get; set; } = null;
            // Add any other properties as needed
        }
        /*
        public class Contact
        {
            [Key]
            public string ContactId { get; set; }
            [Required]
            [StringLength(maximumLength: 100, MinimumLength = 2)]
            public string Name { get; set; }
            [EmailAddress]
            public string Email { get; set; }
            public string Phone { get; set; }

        } */
    //}
}
    