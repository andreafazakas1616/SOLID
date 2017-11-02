
namespace SOLID.Liskov.Right
{
    public class CalculateSquareRectangle2
    {

    }

    public abstract class Shape
    {
        public abstract int Area();
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int Area()
        {
            return Width * Height;
        }
    }

    public class Square : Shape
    {
        public int SideLength;

        public override int Area()
        {
            return SideLength*SideLength;
        }
    }
}