using Microsoft.AspNetCore.Mvc;
using Warehouse.Core.Enums;
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
        _logger.LogInformation("New Request");
        return new()
        {
            Id = Random.Shared.Next(4, 4444),
            Aliases = new string[] { "Big Man", "Eh Pope" },
            Name = "Jorge Bergoglio",
            Description = "Jorgie fae the big hoos",
            Stock = new StockDetail[]
            {
                new()
                {
                    Quantity = 1,
                    UnitOfMeasurement = UnitOfMeasurement.Papacy,
                    Location = new()
                    {
                        Id = Random.Shared.Next(4, 4444),
                        Code = "ARARA",
                        Name = "Hings Hings Hings"
                    }
                }
            }
        };
    }
}
