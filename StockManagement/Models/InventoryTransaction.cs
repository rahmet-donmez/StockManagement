

namespace StockManagement.Models
{
    public class InventoryTransaction : BaseEntity
    {
        public int TransactionType { get; set; }
        public string DocumentNumber { get; set; }
        public decimal Quantity { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
