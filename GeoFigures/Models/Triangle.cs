namespace GeoFigures.Models
{
    internal class Triangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Triangle() { }

        public Triangle(int heigth, int width)
        {
            Height = heigth;
            Width = width;
        }

        public override double GetArea() // for 90 deg triangle
        {
            double result = (double)Height * Width / 2;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }

        public override double GetPerimeter() // for 90 deg triangle
        {
            double thirdSide = Math.Pow(Height, 2) + Math.Pow(Width, 2);
            double result = Width + Height + Math.Sqrt(thirdSide);
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
    }
}
