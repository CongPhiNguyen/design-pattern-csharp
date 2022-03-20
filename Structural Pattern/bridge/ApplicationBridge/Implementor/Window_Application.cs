using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBridge
{
    internal class Window_Application : Application
    {
        public override void runApp(string OSName)
        {
            if (OSName == "Window")
            {
                Console.WriteLine("App started successfully!");
            }
            else
            {
                Console.WriteLine("ERROR: {0} can't be started in {1} OS...", this.GetType().Name, OSName);
            }
        }
    }
}
