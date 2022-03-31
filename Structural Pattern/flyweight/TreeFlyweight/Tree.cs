using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeFlyweight
{
    internal class Tree
    {
        float x, y;
        TreeType type;
        public Tree(float x, float y, TreeType type)
        {
            this.x = x;
            this.y = y;
            this.type = type;  
        }
        public void draw(string canvas)
        {
            type.draw(canvas, this.x, this.y);
        }
    }
}
