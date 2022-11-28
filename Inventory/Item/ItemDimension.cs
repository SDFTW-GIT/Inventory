namespace Inventory.Item
{
    public class ItemDimension
    {
        private float width;
        private float height;
        private float depth;

        public ItemDimension(float width, float height, float depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }

        public float GetWidth() { return width; }
        public float GetHeight() { return height; }
        public float GetDepth() { return depth; }

        public override string ToString()
        {
            return "W:" + GetWidth() + " H:" + GetHeight() + " D:" + GetDepth();
        }
    }
}
