using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBridge.Abstraction
{
    public class Window : OS_Abstraction
    {
        public override void runApp()
        {
            application.runApp(this.GetType().Name);
        }
    }
}
