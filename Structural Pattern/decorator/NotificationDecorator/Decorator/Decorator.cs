using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationDecorator
{
    public abstract class Decorator: Notification
    {
        private Notification notification;
        public void setNotification(Notification notification)
        {
            this.notification = notification;
        }
        public override void sendMessage()
        {
            if(notification != null)
            {
                notification.sendMessage();
            }
        }
    }
}
