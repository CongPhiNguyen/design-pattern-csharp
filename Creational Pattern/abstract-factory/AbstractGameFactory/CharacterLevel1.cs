using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class CharacterLevel1 : CharacterGenerator
    {
        public override Wizard createWizard()
        {
            return new WizardLevel1();
        }
        public override Warrior createWarrior()
        {
            return new WarriorLevel1();
        }
    }
}
