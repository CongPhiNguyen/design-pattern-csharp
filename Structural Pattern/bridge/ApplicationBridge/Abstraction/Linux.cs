using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBridge { 
    public class Linux : OS_Abstraction
    {
        public override void runApp()
        {
            application.runApp(this.GetType().Name);
        }
    }
}
