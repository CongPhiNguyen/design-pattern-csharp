using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorState
{
    internal class Normal: State
    {
        public override void receiveObject(Warrior warrior, string Object)
        {
            switch (Object)
            {
                case "Poison String":
                    Console.WriteLine("Receive Poison String. State change from Normal to Poisoned");
                    warrior.State = new Poisoned();
                    break;
                case "Healing Potion":
                    Console.WriteLine("Receive Healing Potion. State is not change");
                    break;
                case "Paralyzed Lighting":
                    Console.WriteLine("Receive Paralyzed Lighting. State change from Normal to Paralyzed");
                    warrior.State = new Paralyzed();
                    break;
                case "Fullpower":
                    Console.WriteLine("Receive Fullpower. State change from Normal to FullPower");
                    warrior.State = new FullPower();
                    break;
                case "Fullpower Extra":
                    Console.WriteLine("Receive Fullpower Extra. State change from Normal to Fullpower");
                    warrior.State = new FullPower();
                    break;
                default:
                    break;
            }
        }
    }
}
