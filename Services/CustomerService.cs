using STXAssignment.Interfaces;
using static STXAssignment.Controllers.CustomerController;

namespace STXAssignment.Services
{
    public class CustomerService
    {
        public ICustomerServices _customerServices;
        private readonly ILogger _logger;

        //Injecting the Dependency Object using Constructor means it is a Loose Coupling
        public CustomerService(ICustomerServices _customerServices, ILogger logger)
        {
            this._customerServices = _customerServices;
            _logger = logger;
        }
        public List<Customer> LoadCustomerDetails()
        {
            return _customerServices.LoadCustomerDetails();
        }
        public Customer? LoadCustomerDetailById(int id)
        {
            return _customerServices.LoadCustomerDetailById(id);
        }
    }
}