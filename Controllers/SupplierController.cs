using Microsoft.AspNetCore.Mvc;
using STXAssignment.Interfaces;
using STXAssignment.Services;

namespace STXAssignment.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public partial class SupplierController : ControllerBase
    {
        private readonly ILogger<SupplierController> _logger;
        public SupplierController(ILogger<SupplierController> logger)
        {
            _logger = logger;
        }

        // Implement HTTP GET endpoint to retrieve the details of a specific Supplier by ID
        [HttpGet("{id}")]
        public IActionResult GetSupplierById(int id)
        {
            try
            {
                SupplierService _supplierService = new SupplierService(new SupplierDAL(), _logger);
                Supplier? supplierById = _supplierService.LoadSupplierDetailById(id);
                if (supplierById == null)
                {
                    return NotFound(); // Return 404 Not Found if supplier with given ID is not found
                }
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
                SupplierService _supplierService = new SupplierService(new SupplierDAL(), _logger);
                List<Supplier> _supplier = _supplierService.LoadSupplierDetails();

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
    