using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class Sending : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitSending(this);
        }
    }
}
