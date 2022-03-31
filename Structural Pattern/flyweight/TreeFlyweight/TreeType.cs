using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeFlyweight
{
    internal class TreeType
    {
        string name;
        public string Name { get => name; set => name = value; }
        string color;
        public string Color { get => color; set => color = value; }
        string texture;
        public string Texture { get => texture; set => texture = value; }
        public TreeType(string name, string color, string texture)
        {
            this.name = name;
            this.color = color;
            this.texture = texture;
        }

       public void draw(string canvas, float x, float y)
       {
            Console.WriteLine("Drawing {2} with color {3} texture {4} to ({0}, {1})", x, y, this.name, this.color, this.texture);
       }
    }
}
