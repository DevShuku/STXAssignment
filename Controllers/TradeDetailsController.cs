using Microsoft.AspNetCore.Mvc;
using STXAssignment.Data;
using STXAssignment.Services;

namespace STXAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class TradeDetailsController : ControllerBase
    {
        private readonly ILogger<TradeDetailsController> _logger;
        private readonly AppDbContext _context;
        public TradeDetailsController(ILogger<TradeDetailsController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Implement HTTP GET endpoint to retrieve the list of Trades
        [HttpGet]
        [Route("TradeDetailsList")]
        public IActionResult GetTradeDetails([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                // Validate pagination parameters
                if (pageNumber < 1)
                {
                    _logger.LogError("Page number must be greater than or equal to 1.");
                    return BadRequest("Page number must be greater than or equal to 1.");
                }
                if (pageSize < 1)
                {
                    _logger.LogError("Page size must be greater than or equal to 1.");
                    return BadRequest("Page size must be greater than or equal to 1.");
                }
                TradeDetailsService _tradeDetailsService = new TradeDetailsService(_logger,_context);
                List<TradeDetails> _tradeDetailsList = _tradeDetailsService.LoadTradeDetailsDetails();

                // Calculate skip count based on pagination parameters
                int skipCount = (pageNumber - 1) * pageSize;

                // Retrieve paginated trade details
                var paginatedTradeDetails = _tradeDetailsList.Skip(skipCount).Take(pageSize).ToList();

                _logger.LogInformation($"Success!! TradeDetails are : {0}", paginatedTradeDetails);
                return Ok(paginatedTradeDetails);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return (IActionResult)ex;
            }
        }
    }
}
    