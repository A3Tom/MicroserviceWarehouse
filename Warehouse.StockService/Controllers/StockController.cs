using Microsoft.AspNetCore.Mvc;
using Warehouse.Core.ViewModels;

namespace Warehouse.StockService.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class StockController : ControllerBase
{
    private readonly ILogger<StockController> _logger;

    public StockController(ILogger<StockController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public StockDetail Get()
    {
        return new();
    }
}