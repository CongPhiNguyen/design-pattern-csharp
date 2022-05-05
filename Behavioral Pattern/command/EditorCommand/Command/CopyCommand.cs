using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorCommand
{
    public class CopyCommand : Command
    {
        public CopyCommand(Editor editor) : base(editor)
        {

        }
        public override void Execute(Content content)
        {
            editor.Copy(content);
        }
    }
}
