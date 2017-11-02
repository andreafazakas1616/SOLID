using System;
using System.Collections.Generic;

namespace SOLID.SingleOpenClosed.Wrong
{
    public class Shape
    {
        public Shape(int type, double width)
        {
            this.type = type;
            this.width = width;
        }

        public const int square = 1;
        public const int circle = 2;
        private readonly double width;
        public int type = -1;

        public double getArea()
        {
            switch (type)
            {
                case square:
                    return width * width;
                case circle:
                    return Math.PI * (width / 2) * (width / 2);
            }
            throw new SystemException("Can`t compute area of unknown shape");
        }

        public static double CalculateTotalArea(List<Shape> shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                for (int i = 0; i < shapes.Count; i++)
                {
                    if (shapes[i].type == square)
                    {
                        totalArea += shapes[i].getArea();
                    }
                    if (shapes[i].type == circle)
                    {
                        totalArea += shapes[i].getArea();
                    }
                }
            }
            return totalArea;
        }
    }
}

