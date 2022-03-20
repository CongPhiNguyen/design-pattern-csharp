using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBridge
{
    public class OS_Abstraction
    {
        protected Application application;
        public Application Application
        {
            set { application = value; }
        }
        public virtual void runApp()
        {
            application.runApp(this.GetType().Name);
        }
    }
}
