using System.Runtime.InteropServices;
using GeoFigures.Models;

var circle = new Circle(3);

var triangle = new Triangle(9, 9);
var triangle2 = new Triangle();

var rect = new Rectangle(10, 5);

// Console.WriteLine(rect.GetArea());
// Console.WriteLine(circle.GetArea());
// Console.WriteLine(triangle.GetArea());

// Console.WriteLine(rect.GetPerimeter());
// Console.WriteLine(circle.GetPerimeter());
// Console.WriteLine(triangle.GetPerimeter());
// Console.WriteLine(triangle2.GetPerimeter()); // gaunam 0, nes properties default reiksmes 0.

// klasiu paveldijimas

var shapeList = new List<Shape>()
{
    new Triangle(4, 8),
    new Circle(8),
    new Circle(7),
    new Rectangle(2, 7),
};

double totalArea = ShapeHelper.CalculateArea(shapeList);
double totalPerimeter = ShapeHelper.CalculatePerimeter(shapeList);

Console.WriteLine(totalArea);
Console.WriteLine(totalPerimeter);
