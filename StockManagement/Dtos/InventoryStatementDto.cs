using Microsoft.EntityFrameworkCore;

namespace StockManagement.Dtos
{
    [Keyless]
    public class InventoryStatementDto
    {
        public int RowNumber { get; set; }
        public string TransactionType { get; set; }
        public string DocumentNumber { get; set; }
        public string TransactionDate { get; set; } // çünkü prosedür VARCHAR döndürüyor
        public decimal InboundQuantity { get; set; }
        public decimal OutboundQuantity { get; set; }
        public decimal StockBalance { get; set; }
    }

}
