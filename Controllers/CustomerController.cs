using Microsoft.AspNetCore.Mvc;
using STXAssignment.Interfaces;
using STXAssignment.Services;
using static STXAssignment.Controllers.MeetingsController;

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
        public IActionResult GetCustomers()
        {
            try
            {
                CustomerService _customerService = new CustomerService(new CustomerDAL(),_logger);
                List<Customer> _customer = _customerService.LoadCustomerDetails();
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
    