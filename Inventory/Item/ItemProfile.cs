using Inventory.Interfaces;

namespace Inventory.Item
{
    public class ItemProfile : IItem, IDimensionItem, ICostItem,
        IManufacturedItem, IProductItem, IPurchaseOrderItem, ITrackableItem
    {
        /// <summary>
        /// Name of the Item (eg. Fridge 9000, etc...)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the Item (eg. I am red, and round, etc...)
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Type of Item (eg. Fridge, Microwave, etc...)
        /// </summary>
        public ItemType Type { get; set; }
        /// <summary>
        /// Dimension of Item (Width, Height, Depth)
        /// </summary>
        public ItemDimension Dimension { get; set; }
        /// <summary>
        /// Cost of Item ($$$)
        /// </summary>
        public float Cost { get; set; }
        /// <summary>
        /// Manufacturer of Item (Mfg.)
        /// </summary>
        public string ManufacturerName { get; set; }
        /// <summary>
        /// Product Identification Number (PID)
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// Purchase Order Number (PO#)
        /// </summary>
        public int PurchaseOrderNumber { get; set; }
        /// <summary>
        /// Tracking Number (TID)
        /// </summary>
        public int TrackingID { get; set; }
    }
}
