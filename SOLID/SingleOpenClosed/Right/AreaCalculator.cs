
using System.Collections.Generic;

namespace SOLID.SingleOpenClosed.Right
{
    public class AreaCalculator:IAreaCalculator
    {
        public double CalculateArea(IList<IShape> shapes)
        {
            double totalArea = 0;
            foreach (IShape shape in shapes)
            {
                totalArea += shape.GetArea();
            }
            return totalArea;
        }
    }
}
