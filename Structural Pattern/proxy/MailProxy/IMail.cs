using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailProxy
{
    public interface IMail
    {
        public void sendMail();
        public void checkMail();
        public void reportSpam();
        public void groupEmail();
    }
}
