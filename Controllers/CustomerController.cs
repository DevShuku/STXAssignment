using Microsoft.AspNetCore.Mvc;

namespace STXAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        // Initialize the static List of Customer objects - dummy data - we can get these data from database after configuring 
        private static List<Customer> _customer = new List<Customer>
        {   // Add more Customer objects as needed

            new() { CustomerId = 1, CustomerName = "ABC Wholesalers", Type = "Wholesaler", Contact = new Contact { Name = "John Smith", Email = "john@example.com", Phone = "+971586790303" }, Country = "UAE" },
            new() { CustomerId = 2, CustomerName = "XYZ Retail Chain", Type = "Retailer", Contact = new Contact { Name = "Shreshta", Email = "shreshta@example.com", Phone = "+919737789890" }, Country = "INDIA" },
            new() { CustomerId = 3, CustomerName = "Global Import Ltd", Type = "Importer", Contact = new Contact { Name = "David Lee", Email = "david@example.com", Phone = "+447700123456" }, Country = "UK" }
        };

        // Implement HTTP GET endpoint to retrieve the list of Customers
        [HttpGet]
        [Route("CustomerList")]
        public IActionResult GetCustomers()
        {
            try
            {
                return Ok(_customer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return (IActionResult)ex;
            }
        }
    }
}
    