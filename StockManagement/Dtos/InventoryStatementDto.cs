using Microsoft.EntityFrameworkCore;

namespace StockManagement.Dtos
{
    [Keyless]//veri tabanında tablo oluşturmaması için eklendi

    public class InventoryStatementDto
    {
        public int RowNumber { get; set; }
        public string TransactionType { get; set; } 
        public string DocumentNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Quantity { get; set; }
    }
}
