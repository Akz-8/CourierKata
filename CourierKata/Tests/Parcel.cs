namespace CourierKata.Tests
{
    public class Parcel
    {
        public Parcel(int length, int width, int height, int weight)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        public int Length { get; } 
        public int Width { get; } 
        public int Height { get; }
        public int Weight { get; }
    }
}