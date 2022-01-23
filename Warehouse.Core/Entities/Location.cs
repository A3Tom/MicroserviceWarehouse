using Warehouse.Core.Abstract;

namespace Warehouse.Core.Entities;
public class Location : WarehouseEntity
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Code { get; init; }
}

