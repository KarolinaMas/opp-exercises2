namespace GeoFigures.Models
{
    internal class Rectangle : Shape
    {
        private int _height;
        private int _width;
        public int Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                    _height = value;
            }
        }
        public int Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                    _width = value;
            }
        }

        public Rectangle() { }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public override double GetArea()
        {
            return Height * Width;
        }

        public override double GetPerimeter()
        {
            return Height * 2 + Width * 2;
        }
    }
}
