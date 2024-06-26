using Microsoft.AspNetCore.Mvc;
using STXAssignment.Data;
using STXAssignment.Services;
using Microsoft.AspNetCore.Authorization;

namespace STXAssignment.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public partial class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly AppDbContext _context;

       // private readonly ICustomerServices _customerService;

        public CustomerController(ILogger<CustomerController> logger, AppDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        // Implement HTTP GET endpoint to retrieve the details of a specific Customer by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            try
            {
                CustomerService _customerService = new CustomerService(_logger,_context);
                Customer? customerById = await _customerService.LoadCustomerDetailById(id);
                if (customerById == null)
                {
                    _logger.LogError(" Returned 404 error - Customer Id is not found");
                    return NotFound(); // Return 404 Not Found if customer with given ID is not found
                }
                _logger.LogInformation($"Success!! Customer Details of Id : {0} are : {1}", id, customerById);
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
        public async Task<IActionResult> GetCustomers()
        {
            try
            {
                CustomerService _customerService = new CustomerService(_logger,_context);
                List<Customer> _customer = await _customerService.LoadCustomerDetails();
                _logger.LogInformation($"Success!! Customer Details are : {0}", _customer);
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
    