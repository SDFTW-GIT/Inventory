namespace Inventory.Interfaces
{
    internal interface IProductItem : IItem
    {
        public int ProductID { get; set; }
    }
}
