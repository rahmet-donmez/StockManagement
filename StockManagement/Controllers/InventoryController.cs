using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockManagement.Repositories;
using StockManagement.Services;

namespace StockManagement.Controllers
{
    public class InventoryController : Controller
    {

        private readonly ProductService _productService;

        public InventoryController(ProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Statement(string productCode, DateTime startDate, DateTime endDate)
        {
            int startInt = Convert.ToInt32(startDate.ToOADate());
            int endInt = Convert.ToInt32(endDate.ToOADate());

            var result = await _productService.InventoryListAsync(productCode, startDate, endDate);

            return View(result);
        }
    }
}
