using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAdapter
{
    abstract class Nail
    {
        protected string type = "";
        public string Type { get => type; }

        protected double radius = 0.0;
        public double Radius { get => radius; }

    }
}
