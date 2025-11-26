using Microsoft.AspNetCore.Mvc;

namespace ShopBackend.Controllers
{
    public class ProductController : StoreController
    {
        [HttpGet("/get")]
        public async Task<ActionResult<string>> Get()
        {
            return Ok(await Task.FromResult("Hello, World!"));
        }
    }
}
