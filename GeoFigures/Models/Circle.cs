namespace GeoFigures.Models
{
    internal class Circle
    {
        public double Radius { get; set; }

        public Circle() { }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            double result = Math.PI * Math.Pow(Radius, 2);
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }

        public double GetPerimeter()
        {
            double result = Radius * 2 * Math.PI;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
    }
}
