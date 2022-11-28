using Inventory.Utilites;

namespace Inventory.Item
{
    public class ItemReader
    {
        public static void ReadItem(ItemProfile item)
        {
            Logger.Log("\tName: " + item.Name);
            Logger.Log("\tDesc: " + item.Description);
            Logger.Log("\tType: " + item.Type);
            Logger.Log("\tDim: " + item.Dimension.ToString());
            Logger.Log("\tCost: $" + item.Cost);
            Logger.Log("\tMFG: " + item.ManufacturerName);
            Logger.Log("\tPID: " + item.ProductID);
            Logger.Log("\tPO#: " + item.PurchaseOrderNumber);
            Logger.Log("\tTID: " + item.TrackingID);
        }

    }
}
