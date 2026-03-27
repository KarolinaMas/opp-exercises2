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

        public double GetArea()
        {
            double result = (double)Height * Width / 2;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
    }
}
