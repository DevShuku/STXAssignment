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
        public async Task<List<Supplier>> LoadSupplierDetails()
        {
            var suplierList =await _context.Suplier.ToListAsync();
            return suplierList;
        }
        public async Task<Supplier?> LoadSupplierDetailById(int id)
        {
            return await _context.Suplier.FindAsync(id);
        }
    }
}