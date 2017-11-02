
namespace SOLID.Liskov.Wrong
{
    public class CalculateSquareRectangle
    {
        public static int CalculateArea(Rectangle r)
        {
            return r.Height * r.Width;
        }

        public static int CalculateArea(Square s)
        {
            return s.Height * s.Width;
        }
    }

    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
    }

    public class Square : Rectangle
    {
        private int _width;
        private int _height;

        public override int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
                _height = value;
            }
        }

        public override int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _width = value;
                _height = value;
            }
        }
    }

}
