
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class CharacterGenerator
    {
        public abstract Wizard createWizard();
        public abstract Warrior createWarrior();
    }
}
