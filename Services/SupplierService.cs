using STXAssignment.Interfaces;
using static STXAssignment.Controllers.SupplierController;

namespace STXAssignment.Services
{
    public class SupplierService
    {
        public ISupplierServices _supplierServices;
        private readonly ILogger _logger;

        //Injecting the Dependency Object using Constructor means it is a Loose Coupling
        public SupplierService(ISupplierServices _supplierServices, ILogger logger)
        {
            this._supplierServices = _supplierServices;
            _logger = logger;
        }
        public List<Supplier> LoadSupplierDetails()
        {
            return _supplierServices.LoadSupplierDetails();
        }
        public Supplier? LoadSupplierDetailById(int id)
        {
            return _supplierServices.LoadSupplierDetailById(id);
        }
    }
}