using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Warrior
    {
        protected string name = "";
        public string Name { get { return name; }}
        public string attackName = "";
        public string AttackName { get { return attackName; } }

        public Warrior()
        {

        }
        public abstract void interact(Wizard a);
    }
}
