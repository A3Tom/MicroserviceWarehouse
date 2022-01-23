namespace Warehouse.Core.Entities;
public class Transaction
{
    public int Id { get; init; }
    public int ItemId { get; init; }
    public int LocationId { get; init; }

    public decimal Quantity { get; init; }

    public DateTime CreatedOn { get; init; }
}

