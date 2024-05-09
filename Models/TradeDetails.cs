namespace STXAssignment.Controllers
{
    public partial class TradeDetailsController
    {
        // Initialize the static List of Customer objects - dummy data - we can get these data from database after configuring 
        public class TradeDetails
        {
            [Key]
            public string TradeId { get; set; }
            public string TradeName { get; set; }
            public DateOnly TradeDate { get; set; }
            public string ContractDetail { get; set; }
            public string ProductDetail { get; set; }
            public string ShippingDetail { get; set; }
            public string Status { get; set; }
            // public List<ContractDetail> ContractDetails {  get; set; }
            //public List<ProductDetail> ProductDetails { get; set; }
            //public  ShippingDetail ShippingDetails { get; set; }
            //public ContractStage Status {  get; set; }

            // Add any other properties as needed
        }
        /*
        public class ContractDetail
        { 
            public string ContractId { get; set; }
            public string ContractName { get; set; }
            public string PaymentMethod { get; set; } // we can have a seperate class for the payment methods -  Letter of Credit , Cash Against Delivery, Advanced Payment

        }

        public class ProductDetail
        {
            public string ProductId { get; set; }
            public string ProductName { get; set; }
        }

        public class ShippingDetail
        {
            public string ShippingId { get; set; }
            public string ShippingBy { get; set; }
            public string CostDetails { get; set; }
            public string LoadingPort { get; set; }
            public string DestinationPort { get; set; }
            public DateOnly LaycanFromDate { get; set; }
            public DateOnly LaycanToDate { get; set; }

        }

        public class ContractStage
        {
            public int StatusId { get; set; }
            public int EstimatedCostSheet { get; set; }
            public int CustomerContract { get; set; }
            public int SupplierContract { get; set; }
        } */
    }
}
    