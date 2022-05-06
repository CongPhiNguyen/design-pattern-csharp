using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorMemento
{
    public class TextEditor
    {
        private TextWindow textWindow;
        private Mementor mementor;

        public TextEditor(TextWindow textWindow)
        {
            this.textWindow = textWindow;
        }

        public void write(String text)
        {
            textWindow.addText(text);
        }

        public void print()
        {
            Console.WriteLine(textWindow.state);
        }

        public void hitSave()
        {
            this.mementor = textWindow.save();
        }

        public void hitUndo()
        {
            textWindow.restore(this.mementor);
        }
    }
}
