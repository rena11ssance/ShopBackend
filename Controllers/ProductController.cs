using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopBackend.Data;

namespace ShopBackend.Controllers
{
    public class ProductController : StoreController
    {
        public ProductController(AppDbContext dbContext)
            : base(dbContext)
        {
            
        }

        [HttpGet("/GetProducts")]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await base.dbContext.Products.ToListAsync());
        }
    }
}
