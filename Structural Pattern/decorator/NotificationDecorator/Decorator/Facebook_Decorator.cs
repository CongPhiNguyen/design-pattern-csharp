using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationDecorator
{
    internal class Facebook_Decorator: Decorator
    {
        public override void sendMessage()
        {
            base.sendMessage();
            // Added Behavior
            Console.WriteLine("Notification is sending via Facebook...");
        }
    }
}
