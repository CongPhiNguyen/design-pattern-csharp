using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorCommand
{
    public class ImageEditor: Editor
    {
        public override void Copy(Content content)
        {
            if (content == null)
            {
                Console.WriteLine("Clipboard is blank");
            }
            else if (content.GetType().Name == "Image")
            {
                Console.WriteLine("Copy Image from ImageEditor");
            }
            else if (content.GetType().Name == "Text")
            {
                Console.WriteLine("Copy Text from ImageEditor");
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
                Console.WriteLine("Pasted Image into ImageEditor");
            }
            else if (content.GetType().Name == "Text")
            {
                Console.WriteLine("Can't Paste Text into ImageEditor");
            }
        }
    }
}
