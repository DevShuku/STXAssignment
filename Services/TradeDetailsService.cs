using STXAssignment.Controllers;
using STXAssignment.Data;
using static STXAssignment.Controllers.TradeDetailsController;

namespace STXAssignment.Services
{
    public class TradeDetailsService: ITradeDetailsServices
    {
        public ITradeDetailsServices _tradeDetailsServices;
        private readonly AppDbContext _context;
        private readonly ILogger _logger;

        //Injecting the Dependency Object using Constructor means it is a Loose Coupling
        public TradeDetailsService(ILogger<TradeDetailsController> logger, AppDbContext context)
        {
            _context= context;
            _logger = logger;
        }
        public async Task<List<TradeDetails>> LoadTradeDetailsDetails()
        {

            var tradeDetailList = await _context.TradeDetails.ToListAsync();
            return tradeDetailList;
        }
    }
}