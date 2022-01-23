namespace Warehouse.Core.Abstract;
public abstract class WarehouseEntity
{
    public bool Active { get; init; } = true;

    public DateTime CreatedOn { get; init; } = DateTime.UtcNow;
    public DateTime? ModifiedOn { get; init; }
}

