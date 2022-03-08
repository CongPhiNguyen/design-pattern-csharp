using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAdapter
{
    internal class SquareNail: Nail
    {
        public SquareNail(double width)
        {
            this.radius = width;
            this.type = "square nail";
        }
    }
}
