using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorState
{
    internal class FullPower : State
    {
        public override void receiveObject(Warrior warrior, string Object)
        {
            switch (Object)
            {
                case "Poison String":
                    Console.WriteLine("Receive Poison String. State change from Fullpower to Normal");
                    warrior.State = new Normal();
                    break;
                case "Healing Potion":
                    Console.WriteLine("Receive Healing Potion. State is not change");
                    break;
                case "Paralyzed Lighting":
                    Console.WriteLine("Receive Paralyzed Lighting. State change from Fullpower to Normal");
                    warrior.State = new Normal();
                    break;
                case "Fullpower":
                    Console.WriteLine("Receive Fullpower. State is not change");
                    break;
                case "Fullpower Extra":
                    Console.WriteLine("Receive Fullpower Extra. State is not change");
                    break;
                default:
                    break;
            }
        }
    }
}
