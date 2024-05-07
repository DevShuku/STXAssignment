using Microsoft.AspNetCore.Mvc;
using STXAssignment.Interfaces;
using STXAssignment.Services;

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

        // Implement HTTP GET endpoint to retrieve the details of a specific Customer by ID
        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            try
            {
                CustomerService _customerService = new CustomerService(new CustomerDAL(), _logger);
                Customer? customerById = _customerService.LoadCustomerDetailById(id);
                if (customerById == null)
                {
                    return NotFound(); // Return 404 Not Found if customer with given ID is not found
                }
                return Ok(customerById); // Return 200 OK with the details of the customer
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return (IActionResult)ex;
            }
        }


        // Implement HTTP GET endpoint to retrieve the list of Customers
        [HttpGet]
        [Route("CustomerList")]
        public IActionResult GetCustomers()
        {
            try
            {
                CustomerService _customerService = new CustomerService(new CustomerDAL(),_logger);
                List<Customer> _customer = _customerService.LoadCustomerDetails();
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
    