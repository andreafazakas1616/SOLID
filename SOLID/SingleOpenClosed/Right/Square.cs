
namespace SOLID.SingleOpenClosed.Right
{
    public class Square : IShape
    {
        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public double GetArea()
        {
            double area = Width * Width;
            return area;
        }
    }
}
