using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Stage
    {
        Wizard wizard;
        Warrior warrior;

        // Constructor

        public Stage(CharacterGenerator character)
        {
            wizard = character.createWizard();
            warrior = character.createWarrior();
        }

        public void start()
        {
            Console.WriteLine("Stage start");
            warrior.interact(wizard);
            Console.WriteLine("State end");
        }
    }
}
