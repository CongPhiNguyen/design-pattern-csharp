using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorState
{
    public class Poisoned : State
    {
        public override void receiveObject(Warrior warrior, string Object)
        {
            switch (Object)
            {
                case "Poison String":
                    Console.WriteLine("Receive Poison String. State is not change: Poisoned");
                    break;
                case "Healing Potion":
                    Console.WriteLine("Receive Healing Potion. State change from Poisoned to Normal");
                    warrior.State = new Normal();
                    break;
                case "Paralyzed Lighting":
                    Console.WriteLine("Receive Paralyzed Lighting. State change from Poisoned to Paralyzed");
                    warrior.State = new Paralyzed();
                    break;
                case "Fullpower":
                    Console.WriteLine("Receive Fullpower. State change from Poisoned to Normal");
                    warrior.State = new Normal();
                    break;
                case "Fullpower Extra":
                    Console.WriteLine("Receive Fullpower Extra. State change from Poisoned to Fullpower");
                    warrior.State = new FullPower();
                    break;
                default:
                    break;
            }
        }
    }
}
