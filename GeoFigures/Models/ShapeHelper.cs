namespace GeoFigures.Models
{
    public class ShapeHelper
    {
        public static double CalculateArea(List<Shape> list)
        {
            double sum = 0;

            foreach (var shape in list)
            {
                sum += shape.GetArea();
            }
            return sum;
        }

        public static double CalculatePerimeter(List<Shape> list)
        {
            double sum = 0;

            foreach (var shape in list)
            {
                sum += shape.GetPerimeter();
            }
            return sum;
        }
    }
}
