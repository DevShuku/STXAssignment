using Microsoft.AspNetCore.Mvc;
using STXAssignment.Interfaces;
using STXAssignment.Services;

namespace STXAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class TradeDetailsController : ControllerBase
    {
        private readonly ILogger<TradeDetailsController> _logger;
        public TradeDetailsController(ILogger<TradeDetailsController> logger)
        {
            _logger = logger;
        }

        // Implement HTTP GET endpoint to retrieve the list of Trades
        [HttpGet]
        [Route("TradeDetailsList")]
        public IActionResult GetTradeDetails()
        {
            try
            {
                TradeDetailsService _tradeDetailsService = new TradeDetailsService(new TradeDetailsDAL(), _logger);
                List<TradeDetails> _tradeDetailsList = _tradeDetailsService.LoadTradeDetailsDetails();

                return Ok(_tradeDetailsList);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return (IActionResult)ex;
            }
        }
    }
}
    