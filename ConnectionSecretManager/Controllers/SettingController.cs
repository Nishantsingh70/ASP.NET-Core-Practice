using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ConnectionSecretManager.Configuration;


namespace ConnectionSecretManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingController : ControllerBase
    {
        private readonly IOptions<DatabaseSettings> _databaseSettings;
        public SettingController( IOptions<DatabaseSettings> databaseSettings) 
        {
            _databaseSettings = databaseSettings;
        }

        [HttpGet("connection")]
        public IActionResult GetConnection()
        {
            var settings = _databaseSettings.Value;
            return Ok(settings);
        }
    }
}
