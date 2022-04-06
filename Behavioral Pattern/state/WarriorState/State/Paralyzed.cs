﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorState
{
    internal class Paralyzed: State
    {
        public override void receiveObject(Warrior warrior, string Object)
        {
            switch (Object)
            {
                case "Poison String":
                    Console.WriteLine("Receive Poison String. State change from Paralyzed to Poisoned");
                    warrior.State = new Poisoned();
                    break;
                case "Healing Potion":
                    Console.WriteLine("Receive Healing Potion. State change from Paralyzed to Normal");
                    warrior.State = new Normal();
                    break;
                case "Paralyzed Lighting":
                    Console.WriteLine("Receive Paralyzed Lighting. State is not change");
                    break;
                case "Fullpower":
                    Console.WriteLine("Receive Fullpower. State change from Paralyzed to Normal");
                    warrior.State = new Normal();
                    break;
                case "Fullpower Extra":
                    Console.WriteLine("Receive Fullpower Extra. State change from Paralyzed to Fullpower");
                    warrior.State = new FullPower();
                    break;
                default:
                    break;
            }
        }
    }
}
