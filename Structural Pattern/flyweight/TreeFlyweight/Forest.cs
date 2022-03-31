using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeFlyweight
{
    internal class Forest
    {
        List<Tree> trees = new List<Tree>();
        TreeFactory treeFactory = new TreeFactory();

        public void plantTree(float x, float y, string name, string color, string texture)
        {
            TreeType type = treeFactory.getTreeType(name, color, texture);
            Tree tree = new Tree(x, y, type);
            trees.Add(tree);
        }

        public void draw(string canvas)
        {
            foreach(Tree tree in trees)
            {
                tree.draw(canvas);
            }
        }
    }
}
