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

        public Stage(CharacterGenerator factory)
        {
            wizard = factory.createWizard();
            warrior = factory.createWarrior();
        }

        public void start()
        {
            Console.WriteLine("Stage start");
            warrior.interact(wizard);
            Console.WriteLine("State end");
        }
    }
}
