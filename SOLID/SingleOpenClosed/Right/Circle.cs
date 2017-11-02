using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleOpenClosed.Right
{
    public class Circle:IShape
    {
        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public double GetArea()
        {
            double area = Math.PI * (double)((double)Width / (double)2) *
                                     (double)((double)Width / (double)2);
            return area;
        }
    }
}
