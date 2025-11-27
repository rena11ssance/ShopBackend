using Microsoft.AspNetCore.Mvc;
using ShopBackend.Data;

namespace ShopBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class StoreController : Controller
    {
        protected readonly AppDbContext dbContext;
        public StoreController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
