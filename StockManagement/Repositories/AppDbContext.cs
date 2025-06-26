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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ürünler
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, ProductCode = "P001", Name = "Kalem", Unit = "Adet", VatRate = 8 },
                new Product { Id = 2, ProductCode = "P002", Name = "Defter", Unit = "Adet", VatRate = 18 },
                new Product { Id = 3, ProductCode = "P003", Name = "Silgi", Unit = "Adet", VatRate = 8 }
            );
            modelBuilder.Entity<InventoryTransaction>().HasData(
    // Kalem için hareketler
    new InventoryTransaction { Id = 1, TransactionType = 0, DocumentNumber = "GIR-K001", Quantity = 100, TransactionDate = new DateTime(2024, 1, 1), ProductId = 1 },
    new InventoryTransaction { Id = 2, TransactionType = 1, DocumentNumber = "CIK-K001", Quantity = 20, TransactionDate = new DateTime(2024, 1, 5), ProductId = 1 },
    new InventoryTransaction { Id = 3, TransactionType = 0, DocumentNumber = "GIR-K002", Quantity = 50, TransactionDate = new DateTime(2024, 1, 10), ProductId = 1 },
    new InventoryTransaction { Id = 4, TransactionType = 1, DocumentNumber = "CIK-K002", Quantity = 30, TransactionDate = new DateTime(2024, 1, 15), ProductId = 1 },
    new InventoryTransaction { Id = 5, TransactionType = 0, DocumentNumber = "GIR-K003", Quantity = 70, TransactionDate = new DateTime(2024, 1, 20), ProductId = 1 },

    // Defter için hareketler
    new InventoryTransaction { Id = 6, TransactionType = 0, DocumentNumber = "GIR-D001", Quantity = 120, TransactionDate = new DateTime(2024, 2, 1), ProductId = 2 },
    new InventoryTransaction { Id = 7, TransactionType = 1, DocumentNumber = "CIK-D001", Quantity = 25, TransactionDate = new DateTime(2024, 2, 5), ProductId = 2 },
    new InventoryTransaction { Id = 8, TransactionType = 0, DocumentNumber = "GIR-D002", Quantity = 80, TransactionDate = new DateTime(2024, 2, 10), ProductId = 2 },
    new InventoryTransaction { Id = 9, TransactionType = 1, DocumentNumber = "CIK-D002", Quantity = 40, TransactionDate = new DateTime(2024, 2, 15), ProductId = 2 },
    new InventoryTransaction { Id = 10, TransactionType = 0, DocumentNumber = "GIR-D003", Quantity = 100, TransactionDate = new DateTime(2024, 2, 20), ProductId = 2 },

    // Silgi için hareketler
    new InventoryTransaction { Id = 11, TransactionType = 0, DocumentNumber = "GIR-S001", Quantity = 90, TransactionDate = new DateTime(2024, 3, 1), ProductId = 3 },
    new InventoryTransaction { Id = 12, TransactionType = 1, DocumentNumber = "CIK-S001", Quantity = 15, TransactionDate = new DateTime(2024, 3, 5), ProductId = 3 },
    new InventoryTransaction { Id = 13, TransactionType = 0, DocumentNumber = "GIR-S002", Quantity = 60, TransactionDate = new DateTime(2024, 3, 10), ProductId = 3 },
    new InventoryTransaction { Id = 14, TransactionType = 1, DocumentNumber = "CIK-S002", Quantity = 25, TransactionDate = new DateTime(2024, 3, 15), ProductId = 3 },
    new InventoryTransaction { Id = 15, TransactionType = 0, DocumentNumber = "GIR-S003", Quantity = 110, TransactionDate = new DateTime(2024, 3, 20), ProductId = 3 }
);

        }

    }
}
