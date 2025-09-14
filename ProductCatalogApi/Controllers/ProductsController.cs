using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Data;
using ProductCatalogApi.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _db;

        public ProductsController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts(
            [FromQuery] string? category,
            [FromQuery] decimal? minPrice,
            [FromQuery] decimal? maxPrice,
            [FromQuery] string? search)
        {
            var q = _db.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
            {
                q = q.Where(p => p.Category == category);
            }

            if (minPrice.HasValue)
            {
                q = q.Where(p => p.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                q = q.Where(p => p.Price <= maxPrice.Value);
            }

            if (!string.IsNullOrWhiteSpace(search))
            {
                var s = search.ToLower();
                q = q.Where(p => EF.Functions.Like(p.Name.ToLower(), $"%{s}%")
                                 || EF.Functions.Like(p.Description.ToLower(), $"%{s}%")
                                 || EF.Functions.Like(p.Category.ToLower(), $"%{s}%"));
            }

            var products = await q.ToListAsync();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _db.Products.FindAsync(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpGet("category/{categoryName}")]
        public async Task<IActionResult> GetProductsByCategory(string categoryName)
        {
            var products = await _db.Products
                .Where(p => p.Category == categoryName)
                .ToListAsync();

            return Ok(products);
        }

        [HttpGet("search/{searchTerm}")]
        public async Task<IActionResult> SearchProducts(string searchTerm)
        {
            var st = searchTerm.ToLower();
            var products = await _db.Products
                .Where(p => p.Name.ToLower().Contains(st) || p.Description.ToLower().Contains(st))
                .ToListAsync();

            return Ok(products);
        }
        [HttpGet("pricerange")]
        public async Task<IActionResult> GetProductsByPriceRange([FromQuery] decimal minPrice, [FromQuery] decimal maxPrice)
        {
            var products = await _db.Products
                .Where(p => p.Price >= minPrice && p.Price <= maxPrice)
                .ToListAsync();

            return Ok(products);
        }
    }
}
