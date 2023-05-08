namespace CourierKata.Tests
{
    public class Parcel
    {
        public Parcel(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public int Length { get; } 
        public int Width { get; } 
        public int Height { get; }
    }
}