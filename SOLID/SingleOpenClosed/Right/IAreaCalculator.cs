using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleOpenClosed.Right
{
    public interface IAreaCalculator
    {
        double CalculateArea(IList<IShape> shapes);
    }
}
