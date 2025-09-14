using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _db;

        public CategoriesController(AppDbContext db)
        {
            _db = db;
        }

        // GET /api/categories
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _db.Products
                                      .Where(p => !string.IsNullOrEmpty(p.Category))
                                      .Select(p => p.Category)
                                      .Distinct()
                                      .OrderBy(c => c)
                                      .ToListAsync();

            return Ok(categories);
        }
    }
}
