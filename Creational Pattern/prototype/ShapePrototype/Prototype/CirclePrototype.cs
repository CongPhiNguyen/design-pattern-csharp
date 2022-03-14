using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePrototype
{
    internal class CirclePrototype: ShapePrototype
    {
        public int radius;

        public CirclePrototype DeepCopy()
        {
            CirclePrototype other = (CirclePrototype)this.MemberwiseClone();
            other.p = new Point(p.X, p.Y);
            other.Color = String.Copy(Color);
            other.radius = radius;
            return other;
        }
    }
}
