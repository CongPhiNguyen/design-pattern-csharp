using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorCommand
{
    public class Invoker
    {
        Command command;
        Content content = null;
        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void SetContent(Content content)
        {
            this.content = content;
        }

        public void ExecuteCommand()
        {
            command.Execute(this.content);
        }
    }
}
