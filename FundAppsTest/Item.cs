namespace FundAppsTest
{
    public class Item
    {
        public Item(int height, int width, int depth, int weight)
        {
            Height = height;
            Width = width;
            Depth = depth;
            Weight = weight;
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Weight { get; set; }
    }
}