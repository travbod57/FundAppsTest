namespace FundAppsTest
{
    public class Item
    {
        public Item(int height, int width, int depth, int weight, bool isHeavyItem = false)
        {
            Height = height;
            Width = width;
            Depth = depth;
            Weight = weight;
            IsHeavyItem = isHeavyItem;
        }

        public bool IsHeavyItem { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Depth { get; private set; }
        public int Weight { get; private set; }
    }
}