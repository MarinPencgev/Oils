namespace Oils.Data.Domains
{
    public class Lot
    {
        public string Id { get; set; }
        public string SerialNumber { get; set; }
        public int PackagesCount { get; set; }
        public decimal PackagesWeight{ get; set; }

        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}