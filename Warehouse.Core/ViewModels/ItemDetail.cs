namespace Warehouse.Core.ViewModels
{
    public class ItemDetail
    {
        public int Id { get; init; }
        
        public string Name { get; init; }
        public string Description { get; init; }
        public string[] Aliases { get; init; }

        public IEnumerable<StockDetail> Stock { get; init; }
    }
}
