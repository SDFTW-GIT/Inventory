using Inventory.Item;
using Inventory.Utilites;

namespace Inventory.InventoryFiles
{
    public class InventoryOperations
    {
        private readonly ItemProfile[] list;
        private int index = 0;

        public InventoryOperations(InventoryList inventoryList)
        {
            list = inventoryList.GetItems();
        }

        public void AddItem(ItemProfile item)
        {
            list[index] = item;
            index++;
        }

        public void RemoveItem(ItemProfile subject)
        {

            if (ItemExists(subject))
            {
                list[GetItemIndex(subject)] = null;
            }
        }

        public int GetItemIndex(ItemProfile item)
        {
            int itemIndex = 0;

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != null)
                {
                    if (list[i] == item)
                    {
                        itemIndex = i;
                    }
                }
            }

            return itemIndex;
        }

        public bool ItemExists(ItemProfile subject)
        {
            bool exists = false;

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != null)
                {
                    if (list[i] == subject)
                    {
                        exists = true;
                    }
                }
            }

            return exists;
        }

        public void ReadInventoryList()
        {
            foreach (ItemProfile item in list)
            {
                if (item != null)
                {
                    Logger.Log("\t" + (GetItemIndex(item) + 1) + ":");
                    ItemReader.ReadItem(item);
                    Logger.Log("");
                }
                else
                {
                    Logger.Log("\tNull!");
                }
            }
        }

    }
}
