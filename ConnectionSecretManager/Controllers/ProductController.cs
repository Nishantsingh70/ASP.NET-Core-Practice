using ConnectionSecretManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConnectionSecretManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProdDbContext _prodDbContext;

        public ProductController(ProdDbContext prodDbContext)
        {
            _prodDbContext = prodDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            var products = await _prodDbContext.Products.ToListAsync();
            return Ok(products);
        }
    }
}
