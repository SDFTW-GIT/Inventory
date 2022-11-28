using Inventory.Item;

namespace Inventory.Interfaces
{
    public interface IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ItemType Type { get; set; }

    }
}
