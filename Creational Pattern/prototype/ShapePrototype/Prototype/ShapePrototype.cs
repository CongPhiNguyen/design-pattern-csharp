using System;

namespace ShapePrototype
{
    internal class ShapePrototype
    {
        public string Color;
        public Point p;

        public ShapePrototype ShallowCopy()
        {
            return (ShapePrototype)this.MemberwiseClone();
        }

        public ShapePrototype DeepCopy()
        {
            ShapePrototype other = (ShapePrototype)this.MemberwiseClone();
            other.p = new Point(p.X, p.Y);
            other.Color = String.Copy(Color);
            return other;
        }
    }
}
