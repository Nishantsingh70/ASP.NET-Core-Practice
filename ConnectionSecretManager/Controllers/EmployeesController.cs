using ConnectionSecretManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConnectionSecretManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly DevDbContext _db;

        public EmployeesController(DevDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            var employees = await _db.Employees.ToListAsync();
            return Ok(employees);
        }
    }
}
