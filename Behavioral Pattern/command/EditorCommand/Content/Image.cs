using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorCommand
{
    public class Image : Content
    {
        int[][] colorVector = {};
        public Image(int[][] colorVector)
        {
            this.colorVector = colorVector;
        }
        public Image()
        {
            
        }
    }
}
