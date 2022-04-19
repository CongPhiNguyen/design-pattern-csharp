using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public abstract class Visitor
    {
        public abstract void VisitExtracting(Extracting extracting);
        public abstract void VisitSending(Sending sending);

        public abstract void VisitZipping(Zipping zipping);
    }
}
