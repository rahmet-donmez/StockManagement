using StockManagement.Dtos;
using StockManagement.Repositories;

namespace StockManagement.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<InventoryStatementDto>> InventoryListAsync(string productCode, DateTime startDate, DateTime endDate)
        {
            int startInt = Convert.ToInt32(startDate.ToOADate());
            int endInt = Convert.ToInt32(endDate.ToOADate());
            var result = await _productRepository.InventoryListAsync(productCode, startInt, endInt);

            return result;
        }
    }
}
