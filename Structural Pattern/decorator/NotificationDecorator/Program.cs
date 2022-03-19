namespace NotificationDecorator
{
    public class MainApp
    {
        public static void Main()
        {
            Console.WriteLine("Using Notifier");
            Notifier notifier = new Notifier();
            Facebook_Decorator fb1 = new Facebook_Decorator();
            Slack_Decorator slack1 = new Slack_Decorator();
            SMS_Decorator sms1 = new SMS_Decorator();   

            fb1.setNotification(notifier);
            slack1.setNotification(fb1);
            sms1.setNotification(slack1);

            sms1.sendMessage();

            Console.WriteLine("\nUsing Toastifier");
            Toastifier toastifier = new Toastifier();

            fb1.setNotification(toastifier);
            sms1.setNotification(fb1);

            sms1.sendMessage();
        }
    }
}
