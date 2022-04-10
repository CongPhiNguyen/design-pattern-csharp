namespace MailProxy
{
    public class MainApp
    {
        public static void Main()
        {
            MailProxy mailProxy = new MailProxy();
            mailProxy.sendMail();
            mailProxy.groupEmail();
            mailProxy.reportSpam();
            mailProxy.checkMail();
        }
    }
}
