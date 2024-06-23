using STXAssignment.Data;
using STXAssignment.Controllers;


namespace STXAssignment.Services
{
    public class CustomerService : ICustomerServices
    {
        private readonly ILogger _logger;
        private readonly AppDbContext _context;
        //  private readonly IConfiguration _configuration;

        //Injecting the Dependency Object using Constructor means it is a Loose Coupling
        public CustomerService(ILogger<CustomerController> logger,AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<List<Customer>> LoadCustomerDetails()
        { // 
            /* string query1 = @"
             select c1.CustomerId, c1.CustomerName, c1.Type, c1.ContactId, c1.Contact , c1.Country from Customers c1";
             DataTable table = new DataTable();
             string sqlDataSource = _customerServices.GetConnectionString("") */

            var custList = await _context.Customer.ToListAsync();
            return custList;//_customerServices.LoadCustomerDetails();
        }
        public async Task<Customer?> LoadCustomerDetailById(int id)
        {
            return await _context.Customer.FindAsync(id);
        }
    }
}