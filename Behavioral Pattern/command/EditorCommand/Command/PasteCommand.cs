using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorCommand
{
    internal class PasteCommand : Command
    {
        public PasteCommand(Editor editor) : base(editor)
        {

        }
        public override void Execute(Content content)
        {
            editor.Paste(content);
        }
    }
}
