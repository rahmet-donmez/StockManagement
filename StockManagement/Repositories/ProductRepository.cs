using Microsoft.EntityFrameworkCore;
using StockManagement.Dtos;

namespace StockManagement.Repositories
{
    public class ProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<List<InventoryStatementDto>> InventoryListAsync(string productCode, int startInt, int endInt)
        {
            var result = await _context.InventoryStatement
                       .FromSqlRaw("EXEC GetInventoryStatement @ProductCode = {0}, @StartDate = {1}, @EndDate = {2}",
                           productCode, startInt, endInt)
                       .ToListAsync();

            return result;
        }

    }
}
