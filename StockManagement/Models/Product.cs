
namespace StockManagement.Models
{
    public class Product : BaseEntity
    {
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal VatRate { get; set; }

        public ICollection<InventoryTransaction> Transactions { get; set; }
    }
}
