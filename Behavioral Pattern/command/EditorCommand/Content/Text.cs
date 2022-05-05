using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorCommand
{
    public class Text : Content
    {
        String text;
        public Text(string text)
        {
            this.text = text;
        }
        
        public Text()
        {

        }
    }
}
