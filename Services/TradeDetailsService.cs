using STXAssignment.Interfaces;
using static STXAssignment.Controllers.TradeDetailsController;

namespace STXAssignment.Services
{
    public class TradeDetailsService
    {
        public ITradeDetailsServices _tradeDetailsServices;
        private readonly ILogger _logger;

        //Injecting the Dependency Object using Constructor means it is a Loose Coupling
        public TradeDetailsService(ITradeDetailsServices _tradeDetailsServices, ILogger logger)
        {
            this._tradeDetailsServices = _tradeDetailsServices;
            _logger = logger;
        }
        public List<TradeDetails> LoadTradeDetailsDetails()
        {
            return _tradeDetailsServices.LoadTradeDetailsDetails();
        }
    }
}