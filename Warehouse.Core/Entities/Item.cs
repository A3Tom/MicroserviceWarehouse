using Warehouse.Core.Abstract;

namespace Warehouse.Core.Entities;
public class Item : WarehouseEntity
{
    public int Id { get; init; }
    
    public string Name { get; init; }
    public string Description { get; init; }
}

