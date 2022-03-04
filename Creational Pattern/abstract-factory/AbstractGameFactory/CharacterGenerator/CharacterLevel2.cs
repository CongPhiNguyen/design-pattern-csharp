using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class CharacterLevel2: CharacterGenerator
    {
        public override Wizard createWizard()
        {
            return new WizardLevel2();
        }
        public override Warrior createWarrior()
        {
            return new WarriorLevel2();
        }
    }
}
