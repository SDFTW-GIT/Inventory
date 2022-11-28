using Inventory.Item;

namespace Inventory.Interfaces
{
    public interface IDimensionItem : IItem
    {
        public ItemDimension Dimension { get; set; }
    }
}
