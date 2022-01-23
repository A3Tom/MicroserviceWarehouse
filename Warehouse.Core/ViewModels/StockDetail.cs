using Warehouse.Core.Enums;

namespace Warehouse.Core.ViewModels;
public class StockDetail
{
    public Location Location { get; init; }
    public decimal Quantity { get; set; }
    public UnitOfMeasurement UnitOfMeasurement { get; init; }

}

