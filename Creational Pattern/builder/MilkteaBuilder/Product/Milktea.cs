using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MilkTeaBuilder
{
    public enum Tra { TraXanh, TraDen, LucTra };
    public enum Sua { SuaBo, SuaDe };
    public class Milktea
    {
        public Tra tra;
        public Sua sua;
        public bool tranChau = false;
        public bool thach = false;
        public bool banhPlan = false;
        public bool pudding = false;


        // Old ways to do this problem
        public Milktea(Tra tra = Tra.TraXanh,
            Sua sua = Sua.SuaBo, bool tranChau = false, bool thach = false,
            bool banhPlan = false, bool pudding = false)
        {
            this.tra = tra;
            this.sua = sua;
            this.tranChau = tranChau;
            this.thach = thach;
            this.banhPlan = banhPlan;
            this.pudding = pudding;
        }

        public void show()
        {
            Console.WriteLine("Milktea part----------------");
            Console.WriteLine("Loai tra: {0}", this.tra);
            Console.WriteLine("Loai sua: {0}", this.sua);
            Console.WriteLine("Tran Chau: {0}", this.tranChau);
            Console.WriteLine("Thach: {0}", this.thach);
            Console.WriteLine("Banh Plan: {0}", this.banhPlan);
            Console.WriteLine("Pudding: {0}", this.pudding);
        }
    }
}
