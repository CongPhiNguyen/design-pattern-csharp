using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WarriorLevel1: Warrior
    {
        public WarriorLevel1():base()
        {
            name = "Warrior Level 1";
            attackName = "Sword Swing";
        }

        public override void interact(Wizard a)
        {
            Console.WriteLine("   {0} attack {1} with {2}\n   {1} return with {3}\n   Impact!!!",
                this.Name, a.Name, this.attackName, a.attackName);
        }
    }
}
