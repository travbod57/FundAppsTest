namespace FundAppsTest
{
    public class Item
    {
        public Item(int height, int width, int depth)
        {
            Height = height;
            Width = width;
            Depth = depth;
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
    }
}