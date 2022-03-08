using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaBuilder
{
    internal class MatchaBuilder: MilkteaBuilder
    {
        Milktea milktea = new Milktea();
        public override void chooseMilk()
        {
            milktea.sua = Sua.SuaBo;
        }

        public override void chooseTea() 
        {            
           milktea.tra = Tra.TraXanh;
        } 
        public override void addThach()
        {
            milktea.thach = true;
        }
        public override void addTranChau()
        {
            milktea.tranChau = true;
        }
        public override void addPudding()
        {
            milktea.pudding = false;
        }
        public override void addBanhPlan()
        {
            milktea.banhPlan = false;
        }
        public override void reset()
        {
            milktea = new Milktea();
        }
        public override Milktea getResult()
        {
            return milktea;
        }

    }
}
