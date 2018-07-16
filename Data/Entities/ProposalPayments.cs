namespace ZestMonitor.Api.Data.Entities
{
    public class ProposalPayments
    {
        public int Id { get; set; }
        public string ShortDescription { get; set; }
        public int Amount { get; set; }
        public int ExpectedPayment { get; set; }
    }
}