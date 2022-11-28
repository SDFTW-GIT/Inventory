namespace Inventory.Interfaces
{
    public interface ITrackableItem : IItem
    {
        public int TrackingID { get; set; }
    }
}
