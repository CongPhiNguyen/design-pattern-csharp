using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorState
{
    public abstract class State
    {
        public abstract void receiveObject(Warrior warrior, string Object);
    }
}
