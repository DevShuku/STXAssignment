using Microsoft.AspNetCore.Mvc;

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

        // Define a static List of Employee objects
        private static List<TradeDetails> _tradeDetailsList = new List<TradeDetails>
        {
          new TradeDetails
          {
            TradeId = "TR-22-00001",
            TradeName= "XYZ trading",
            TradeDate = new DateOnly(2024, 05, 02),
            ContractDetails = new List<ContractDetail>
            {
              new ContractDetail { ContractId = "SMJ-001", ContractName ="SMJ Power Ltd", PaymentMethod = "Letter of Credit" },
              new ContractDetail { ContractId = "JMS-001", ContractName ="JMS Power Ltd", PaymentMethod = "Letter of Credit" }
            },
            ProductDetails = new List<ProductDetail>
            {
              new ProductDetail { ProductId = "12345 COAL", ProductName ="2000MT"},
              new ProductDetail { ProductId = "45678 Barite", ProductName ="2000MT"},
              new ProductDetail { ProductId = "12345 GOLD", ProductName ="3000MT"},
              new ProductDetail { ProductId = "45678 CRUDE", ProductName ="4000MT"},
              new ProductDetail { ProductId = "12345 IRON", ProductName ="5000MT"}
            },
            ShippingDetails = new ShippingDetail{ ShippingId = "SHNO-1", ShippingBy ="Sea", CostDetails="FOB", LoadingPort="Dubai,UAE", DestinationPort="Sharjah,UAE",LaycanFromDate=new DateOnly(2024, 05, 02),LaycanToDate=new DateOnly(2024, 05, 05)},
            Status = new ContractStage{ StatusId = 1, EstimatedCostSheet =0, CustomerContract=1, SupplierContract=2}

          },
          new TradeDetails
          {
            TradeId = "TR-22-00002",
            TradeName= "XYZ trading",
            TradeDate = new DateOnly(2024, 05, 02),
            ContractDetails = new List<ContractDetail>
            {
              new ContractDetail { ContractId = "SMJ-001", ContractName ="SMJ Power Ltd", PaymentMethod = "Letter of Credit" },
              new ContractDetail { ContractId = "JMS-001", ContractName ="JMS Power Ltd", PaymentMethod = "Letter of Credit" }
            },
            ProductDetails = new List<ProductDetail>
            {
              new ProductDetail { ProductId = "12345 COAL", ProductName ="2000MT"},
              new ProductDetail { ProductId = "45678 Barite", ProductName ="2000MT"},
              new ProductDetail { ProductId = "12345 GOLD", ProductName ="3000MT"},
              new ProductDetail { ProductId = "45678 CRUDE", ProductName ="4000MT"},
              new ProductDetail { ProductId = "12345 IRON", ProductName ="5000MT"}
            },
            ShippingDetails = new ShippingDetail{ ShippingId = "SHNO-1", ShippingBy ="Sea", CostDetails="FOB", LoadingPort="Dubai,UAE", DestinationPort="Sharjah,UAE",LaycanFromDate=new DateOnly(2024, 05, 02),LaycanToDate=new DateOnly(2024, 05, 05)},
            Status = new ContractStage{ StatusId = 1, EstimatedCostSheet =2, CustomerContract=1, SupplierContract=2}
          },
          new TradeDetails
          {
            TradeId = "TR-22-00003",
            TradeName= "ABC trading",
            TradeDate = new DateOnly(2024, 05, 02),
            ContractDetails = new List<ContractDetail>
            {
              new ContractDetail { ContractId = "SMJ-001", ContractName ="SMJ Power Ltd", PaymentMethod = "Letter of Credit" },
              new ContractDetail { ContractId = "JMS-001", ContractName ="JMS Power Ltd", PaymentMethod = "Letter of Credit" }
            },
            ProductDetails = new List<ProductDetail>
            {
              new ProductDetail { ProductId = "12345 COAL", ProductName ="2000MT"},
              new ProductDetail { ProductId = "45678 Barite", ProductName ="2000MT"},
              new ProductDetail { ProductId = "12345 GOLD", ProductName ="3000MT"},
              new ProductDetail { ProductId = "45678 CRUDE", ProductName ="4000MT"},
              new ProductDetail { ProductId = "12345 IRON", ProductName ="5000MT"}
            },
            ShippingDetails = new ShippingDetail{ ShippingId = "SHNO-1", ShippingBy ="Sea", CostDetails="FOB", LoadingPort="Dubai,UAE", DestinationPort="Sharjah,UAE",LaycanFromDate=new DateOnly(2024, 05, 02),LaycanToDate=new DateOnly(2024, 05, 05)},
            Status = new ContractStage{ StatusId = 1, EstimatedCostSheet =1, CustomerContract=1, SupplierContract=2}
          }
        };
        // rejected -0 Approved-1 Pending-2

        //
        // Implement HTTP GET endpoint to retrieve the list of Trades
        [HttpGet]
        [Route("TradeDetailsList")]
        public IActionResult GetTradeDetails()
        {
            try
            {
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
    