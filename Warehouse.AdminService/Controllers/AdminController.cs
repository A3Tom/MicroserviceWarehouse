using Microsoft.AspNetCore.Mvc;

namespace Warehouse.AdminService.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return string.Empty;
        }
    }
}