namespace Inventory.Item
{
    //Creates Items
    public class ItemCreator
    {
        public static ItemProfile CreateAndReturnItem(string name, string description, ItemType type, ItemDimension dimension,
            float cost, string manufacturerName, int productID, int purchaseOrderNumber, int trackingId)
        {
            ItemProfile item = new()
            {
                Name = name,
                Description = description,
                Type = type,
                Dimension = dimension,
                Cost = cost,
                ManufacturerName = manufacturerName,
                ProductID = productID,
                PurchaseOrderNumber = purchaseOrderNumber,
                TrackingID = trackingId
            };

            return item;
        }
    }
}
