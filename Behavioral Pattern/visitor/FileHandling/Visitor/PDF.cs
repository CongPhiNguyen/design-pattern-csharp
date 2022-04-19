using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class PDF : Visitor
    {
        public override void VisitExtracting(Extracting extracting)
        {
            Console.WriteLine("File .pdf is convert to .doc");
        }

        public override void VisitSending(Sending sending)
        {
            Console.WriteLine("Sending pdf file via mail");
        }

        public override void VisitZipping(Zipping zipping)
        {
            Console.WriteLine("Zipping pdf file. File extension is .zip");
        }
    }
}
