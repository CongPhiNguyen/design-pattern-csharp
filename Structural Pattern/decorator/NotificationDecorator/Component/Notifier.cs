using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationDecorator
{
    internal class Notifier : Notification
    {
        public override void sendMessage()
        {
            Console.WriteLine("Notification is sending via Notifier...");
        }
    }
}
