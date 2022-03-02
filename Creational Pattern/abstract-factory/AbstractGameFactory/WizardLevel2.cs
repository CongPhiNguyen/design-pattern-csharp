using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WizardLevel2: Wizard
    {
        public WizardLevel2() : base()
        {
            name = "Wizard Level 2";
            attackName = "Water pulse";
        }
    }
}
