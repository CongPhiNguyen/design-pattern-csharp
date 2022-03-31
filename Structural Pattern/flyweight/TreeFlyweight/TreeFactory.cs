using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeFlyweight
{
    class TreeFactory
    {
        List<TreeType> treeTypes = new List<TreeType>();
        
        public TreeType getTreeType(string name, string color, string texture)
        {
            for(int i = 0; i < treeTypes.Count; i++)
            {
                if(treeTypes[i].Name == name && treeTypes[i].Color == color &&
                    treeTypes[i].Texture == texture)
                {
                    return treeTypes[i];
                }
            }
            TreeType res = new TreeType(name, color, texture);
            return res;
        }
    }
}
