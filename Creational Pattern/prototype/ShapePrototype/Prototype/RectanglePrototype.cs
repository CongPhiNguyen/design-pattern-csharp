using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePrototype
{
    internal class RectanglePrototype: ShapePrototype
    {
        public int width;
        public int height;

        public RectanglePrototype DeepCopy(){
            RectanglePrototype other = (RectanglePrototype)this.MemberwiseClone();
            other.p = new Point(p.X, p.Y);
            other.Color = String.Copy(Color);
            other.width = width;
            other.height = height;
            return other;
        }
    }
}
