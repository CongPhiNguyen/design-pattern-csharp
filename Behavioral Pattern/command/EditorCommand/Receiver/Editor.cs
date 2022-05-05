using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorCommand
{
    public abstract class Editor
    {
        public abstract void Copy(Content content);
        public abstract void Paste(Content content);
    }
}
