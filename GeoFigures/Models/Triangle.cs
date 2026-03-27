namespace GeoFigures.Models
{
    internal class Triangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Triangle(int heigth, int width)
        {
            Height = heigth;
            Width = width;
        }
    }
}
