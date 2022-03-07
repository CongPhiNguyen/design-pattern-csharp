using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAdapter
{
    internal class RoundHole
    {
        double radius;
        double Radius { get => radius; }

        public RoundHole(double rad) { 
            this.radius = rad;
        }
        public void fits(Nail nail)
        {
            if(nail.Type == "round nail")
            {
                Console.WriteLine("Round Nail is nailing the Round Hole.....");
                if(nail.Radius <= this.radius)
                {
                    Console.WriteLine("Nail is nailed successfully");
                }
                else
                {
                    Console.WriteLine("Nail is nailed failed");
                }
            }
            else
            {
                Console.WriteLine("Square Nail can't be nailed in the Round Hole. Need to use adapter");
            }
        }
    }
}
