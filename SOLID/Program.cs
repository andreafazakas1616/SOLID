using SOLID.Liskov.Wrong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate without Liskov
            Rectangle rectangle = new Rectangle
            {
                Width = 2,
                Height = 3
            };

            var actual = CalculateSquareRectangle.CalculateArea(rectangle);
            Console.WriteLine("Expected value: 6");
            Console.WriteLine("Actual value: {0}", actual);

            Square square = new Square
            {
                Height = 3,
               
            };

            var actual2 = CalculateSquareRectangle.CalculateArea(square);
            Console.WriteLine("Expected value: 9");
            Console.WriteLine("Actual value: {0}", actual2);

            Rectangle square2 = new Square
            {
                Width = 4,
                Height = 5
            };
            var actual3 = CalculateSquareRectangle.CalculateArea(square2);
            Console.WriteLine("Expected value: 20");
            Console.WriteLine("Actual value: {0}", actual3);

            //using Liskov
            List<Liskov.Right.Shape> shapes = new List<Liskov.Right.Shape>
            {
               new Liskov.Right.Rectangle {Height = 4, Width = 5},
               new Liskov.Right.Square {SideLength = 4}
            };

            var areas = new List<int>();

            foreach (Liskov.Right.Shape shape in shapes)
            {
                areas.Add(shape.Area());
            }
            Console.WriteLine("Rectangle area expected value: 20");
            Console.WriteLine("Rectangle area actual value: {0}", areas[0]);
            Console.WriteLine("Square area expected value: 16");
            Console.WriteLine("Square area actual value: {0}", areas[1]);

            Console.ReadLine();
        }
    }
}
