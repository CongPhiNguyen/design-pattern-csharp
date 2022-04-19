using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class Doc : Visitor
    {
        public override void VisitExtracting(Extracting extracting)
        {
            Console.WriteLine("File .doc can't be extracted");
        }

        public override void VisitSending(Sending sending)
        {
            Console.WriteLine("Sending doc file via mail");
        }

        public override void VisitZipping(Zipping zipping)
        {
            Console.WriteLine("Zipping doc file. File extension is .zip");
        }
    }
}
