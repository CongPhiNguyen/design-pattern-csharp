using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaBuilder
{
    internal class MilkteaDirector
    {
        public void construct(MilkteaBuilder milkteaBuilder)
        {
            milkteaBuilder.chooseMilk();
            milkteaBuilder.chooseTea();
            milkteaBuilder.addThach();
            milkteaBuilder.addTranChau();
            milkteaBuilder.addBanhPlan();
            milkteaBuilder.addPudding();
        }
    }
}
