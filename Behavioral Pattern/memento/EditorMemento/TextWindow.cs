using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorMemento
{
    public class TextWindow
    {
        public string state;

        public Mementor createMemento()
        {
            return new Mementor(state);
        }

        public void setMemento(Mementor mementor)
        {
            state = mementor.State;
        }

        public void addText(string text)
        {
            if (state == null) state = text;
            else
                state += text;
        }

        public Mementor save()
        {
            return createMemento();
        }

        public void restore(Mementor mementor)
        {
            state = mementor.State;
        }
    }
}
