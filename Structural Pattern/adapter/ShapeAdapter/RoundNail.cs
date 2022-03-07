using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAdapter
{
    class RoundNail: Nail
    {
        public RoundNail(double rad)
        {
            this.radius = rad;
            this.type = "round nail";
        }
    }
}
