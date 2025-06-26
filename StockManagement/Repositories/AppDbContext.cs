using Microsoft.EntityFrameworkCore;
using StockManagement.Dtos;
using StockManagement.Models;

namespace StockManagement.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<InventoryTransaction> InventoryTransactions { get; set; }

        // Prosedür sonucu DTO için tanım
        public DbSet<InventoryStatementDto> InventoryStatement { get; set; } 
    }
}
