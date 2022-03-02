using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WizardLevel1: Wizard
    {
        public WizardLevel1():base()
        {
            name = "Wizard Level 1";
            attackName = "Fire ball";
        }
    }
}
