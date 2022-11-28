namespace Inventory.Interfaces
{
    internal interface IManufacturedItem : IItem
    {
        public string ManufacturerName { get; set; }

    }
}
