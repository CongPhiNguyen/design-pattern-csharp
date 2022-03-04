using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WarriorLevel2: Warrior
    {
        public WarriorLevel2():base() {
            name = "Warrior Level 2";
            attackName = "Sword Dance";
        }

        public override void interact(Wizard a)
        {
            Console.WriteLine("   {0} attack {1} with {2}\n   {1} return with {3}\n   Explore!!!",
                this.Name, a.Name, this.attackName, a.attackName);
        }
    }
}
