using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaBuilder
{
    abstract class MilkteaBuilder
    { 
        public abstract void chooseMilk();

        public abstract void chooseTea();
        public abstract void addThach();
        public abstract void addTranChau();
        public abstract void addPudding();
        public abstract void addBanhPlan();
        public abstract void reset();
        public abstract Milktea getResult();
    }
}
