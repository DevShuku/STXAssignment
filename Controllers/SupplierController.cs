using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using STXAssignment.Data;
using STXAssignment.Services;

namespace STXAssignment.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public partial class SupplierController : ControllerBase
    {
        private readonly ILogger<SupplierController> _logger;
        private readonly ISupplierServices _supplierServices;
        private readonly AppDbContext _context;
        public SupplierController(ILogger<SupplierController> logger, AppDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        // Implement HTTP GET endpoint to retrieve the details of a specific Supplier by ID
        [HttpGet("{id}")]
        public IActionResult GetSupplierById(int id)
        {
            try
            {
                SupplierService _supplierService = new SupplierService(_logger, _context);
                Supplier? supplierById = _supplierService.LoadSupplierDetailById(id);
                if (supplierById == null)
                {
                    _logger.LogError(" Returned 404 error - Supplier Id is not found");
                    return NotFound(); // Return 404 Not Found if supplier with given ID is not found
                }
                _logger.LogInformation($"Success!! Supplier Details of Id : {0} are : {1}", id, supplierById);
                return Ok(supplierById); // Return 200 OK with the details of the supplier
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return (IActionResult)ex;
            }
        }

        // Implement HTTP GET endpoint to retrieve the list of Supplier
        [HttpGet]
        [Route("SupplierList")]
        public IActionResult GetSuppliers()
        {
            try
            {
                SupplierService _supplierService = new SupplierService(_logger, _context);
                List<Supplier> _supplier = _supplierService.LoadSupplierDetails();
                _logger.LogInformation($"Success!! Customer Details are : {0}", _supplier);
                return Ok(_supplier);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return (IActionResult)ex;
            }
        }
    }
}
    