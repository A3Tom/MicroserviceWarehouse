using Microsoft.AspNetCore.Mvc;
using Warehouse.Core.ViewModels;

namespace Warehouse.ItemService.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ItemController : ControllerBase
{
    private readonly ILogger<ItemController> _logger;

    public ItemController(ILogger<ItemController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ItemDetail Get()
    {
        return new();
    }
}
