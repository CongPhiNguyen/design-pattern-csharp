using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorMemento
{
    public class Mementor
    {
        string state;
        public string State { get { return state; } set { state = value; } }
        public Mementor(string State)
        {
            this.state = State;
        }
    }
}
