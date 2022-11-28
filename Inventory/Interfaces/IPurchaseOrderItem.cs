namespace Inventory.Interfaces
{
    internal interface IPurchaseOrderItem : IItem
    {
        public int PurchaseOrderNumber { get; set; }

    }
}
