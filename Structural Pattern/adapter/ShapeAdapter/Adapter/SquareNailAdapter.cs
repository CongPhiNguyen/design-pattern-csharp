using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAdapter
{
    internal class SquareNailAdapter: RoundNail
    {
        private SquareNail squareNail = new SquareNail(0.0);
        public SquareNailAdapter(double width):base(width)
        {

        }

        public SquareNailAdapter(SquareNail squareNail):base(squareNail.Radius)
        {
            this.squareNail = squareNail;
            Console.WriteLine("Adaptered SquareNail to RoundNail");
        }

        public double nailRadius { get => squareNail.Radius * Math.Sqrt(2) / 2; }
    }
}
