using STXAssignment.Controllers;
using STXAssignment.Data;
namespace STXAssignment.Services
{
    public class SupplierService : ISupplierServices
    {
        private readonly AppDbContext _context;
        private readonly ILogger _logger;

        //Injecting the Dependency Object using Constructor means it is a Loose Coupling
        public SupplierService(ILogger<SupplierController> logger, AppDbContext context)
        {
            _context = context;
            _logger = logger;
        }
        public List<Supplier> LoadSupplierDetails()
        {
            var suplierList = _context.Suplier.ToList();
            return suplierList;//_supplierServices.LoadSupplierDetails();
        }
        public Supplier? LoadSupplierDetailById(int id)
        {

            var suplierList = _context.Suplier.ToList();
            var supplierById = suplierList.FirstOrDefault(c => c.SupplierId == id);
            return supplierById; //_supplierServices.LoadSupplierDetailById(id);
        }
    }
}