using Warehouse.Core.Enums;

namespace Warehouse.Core.Entities;
public class Stock
{
    public int Id { get; init; }
    public int LocationId { get; init; }
    public decimal Quantity { get; init; }
    public UnitOfMeasurement UnitOfMeasurement { get; init; }
}

