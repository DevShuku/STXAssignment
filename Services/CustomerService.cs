using STXAssignment.Data;
using STXAssignment.Controllers;


namespace STXAssignment.Services
{
    public class CustomerService : ICustomerServices
    {
        private readonly ILogger _logger;
        private readonly ICustomerServices _customerService;
        private readonly AppDbContext _context;
        //  private readonly IConfiguration _configuration;

        //Injecting the Dependency Object using Constructor means it is a Loose Coupling
        public CustomerService(ILogger<CustomerController> logger,AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public List<Customer> LoadCustomerDetails()
        { // 
            /* string query1 = @"
 select c1.CustomerId, c1.CustomerName, c1.Type, c1.ContactId, c1.Contact , c1.Country from Customers c1";
             DataTable table = new DataTable();
             string sqlDataSource = _customerServices.GetConnectionString("") */

            var custList = _context.Customer.ToList();

            return custList;//_customerServices.LoadCustomerDetails();
        }
        public Customer? LoadCustomerDetailById(int id)
        {
            var custList = _context.Customer.ToList();
            var customerById = custList.FirstOrDefault(c => c.CustomerId == id);
            return customerById;
            //return _customerServices.LoadCustomerDetailById(id);
        }
    }
}