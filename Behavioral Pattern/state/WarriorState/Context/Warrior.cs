using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorState
{
    public class Warrior
    {
        State state;
        
        public Warrior(State state)
        {
            this.state = state;
        }

        public State State
        {
            get { return this.state; }
            set { 
                this.state = value;
            }
        }

        public void receiveObject(string Object)
        {
            this.state.receiveObject(this, Object);
        }
    }
}
