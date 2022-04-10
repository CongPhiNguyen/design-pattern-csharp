using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailProxy
{
    public class Mail : IMail
    {
        public void sendMail()
        {
            Console.WriteLine("Sending Mail....");
        }
        public void checkMail()
        {
            Console.WriteLine("Checking Mail....");
        }
        public void reportSpam()
        {
            Console.WriteLine("Reporting Spam Mail....");
        }
        public void groupEmail()
        {
            Console.WriteLine("Grouping Mail....");
        }
    }
}
