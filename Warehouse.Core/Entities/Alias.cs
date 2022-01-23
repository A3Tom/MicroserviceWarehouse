using Warehouse.Core.Abstract;

namespace Warehouse.Core.Entities;
public class Alias : WarehouseEntity
{
    public int Id { get; init; }
    public int ItemId { get; init; }
    public string AliasName { get; init; }
}

