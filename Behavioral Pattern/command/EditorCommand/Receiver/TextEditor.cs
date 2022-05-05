using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorCommand
{
    public class TextEditor : Editor
    {
        public override void Copy(Content content)
        {
            if(content == null)
            {
                Console.WriteLine("Clipboard is blank");
            }
            else if(content.GetType().Name == "Image")
            {
                Console.WriteLine("Copy Image from TextEditor");
            }
            else if(content.GetType().Name == "Text")
            {
                Console.WriteLine("Copy Text from TextEditor");
            }
        }
        public override void Paste(Content content)
        {
            if (content == null)
            {
                Console.WriteLine("Clipboard is blank");
            }
            else if (content.GetType().Name == "Image")
            {
                Console.WriteLine("Pasted Image into TextEditor");
            }
            else if (content.GetType().Name == "Text")
            {
                Console.WriteLine("Pasted Text into TextEditor");
            }
        }

    }
}
