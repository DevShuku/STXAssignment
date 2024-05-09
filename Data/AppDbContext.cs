using STXAssignment.Controllers;
using static STXAssignment.Controllers.TradeDetailsController;

namespace STXAssignment.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Supplier> Suplier { get; set; }

        public DbSet<Meeting> Meeting { get; set; }

        public DbSet<TradeDetails> TradeDetails { get; set; }
    }
}
