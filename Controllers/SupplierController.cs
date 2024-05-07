using Microsoft.AspNetCore.Mvc;
using static STXAssignment.Controllers.CustomerController;

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

        // Initialize the static List of Supplier objects - dummy data - we can get these data from database after configuring 
        private static List<Supplier> _supplier = new()
        {            
            // Add more Supplier objects as needed
            new() { SupplierId = 1, SupplierName = "ABC Electronics Co.", Category = "Electronics", Contact =new Contact { Name = "Michael Chang", Email = "michael@abcelectronics.com", Phone = "+971586790303" }, Country = "USA" },
            new() { SupplierId = 2, SupplierName = "XYZ Textiles Ltd.", Category = "Textiles", Contact = new Contact { Name = "Haya Emir", Email = "haya@example.com", Phone = "+919737789890" }, Country = "OMAN" },
            new() { SupplierId = 3, SupplierName = "Global Foods Inc.", Category = "Food & Beverage", Contact = new Contact { Name = "Sophia Lee", Email = "sophia@globalfoods.com", Phone = "+447700123498" }, Country = "UK" }
   
        };

        // Implement HTTP GET endpoint to retrieve the details of a specific Supplier by ID
        [HttpGet("{id}")]
        public IActionResult GetSupplierById(int id)
        {
            var supplierById = _supplier.FirstOrDefault(s => s.SupplierId == id);
            if (supplierById == null)
            {
                return NotFound(); // Return 404 Not Found if Supplier with given ID is not found
            }
            return Ok(supplierById); // Return 200 OK with the details of the Supplier
        }

        // Implement HTTP GET endpoint to retrieve the list of Supplier
        [HttpGet]
        [Route("SupplierList")]
        public IActionResult GetSuppliers()
        {
            try
            {
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
    