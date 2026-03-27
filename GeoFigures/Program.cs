using GeoFigures.Models;

var circle = new Circle(3);

var triangle = new Triangle(9, 9);

var rect = new Rectangle(10, 5);

Console.WriteLine(rect.GetArea());
Console.WriteLine(circle.GetArea());
Console.WriteLine(triangle.GetArea());

Console.WriteLine(rect.GetPerimeter());
Console.WriteLine(circle.GetPerimeter());
Console.WriteLine(triangle.GetPerimeter());
