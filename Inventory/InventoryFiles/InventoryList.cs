using Inventory.Item;

namespace Inventory.InventoryFiles
{
    public class InventoryList
    {
        private readonly static int LIST_LENGTH = 5;

        private ItemProfile[] items = new ItemProfile[LIST_LENGTH];
        public ItemProfile[] GetItems() { return items; }

    }
}
