    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailProxy
{
    public class MailProxy : IMail
    {
        private Mail mailService;
        public void sendMail()
        {
            if(mailService == null)
            {
                mailService = new Mail();
            }
            mailService.sendMail();
        }
        public void checkMail()
        {
            if (mailService == null)
            {
                mailService = new Mail();
            }
            mailService.checkMail();
        }
        public void reportSpam()
        {
            if (mailService == null)
            {
                mailService = new Mail();
            }
            mailService.reportSpam();
        }
        public void groupEmail()
        {
            if (mailService == null)
            {
                mailService = new Mail();
            }
            mailService.groupEmail();
        }
    }
}
