using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class Program
    {
        public static void Main()
        {
            ObjectStructure objectStructure = new ObjectStructure();
            
            Extracting extracting = new Extracting();
            Sending sending = new Sending();
            Zipping zipping = new Zipping();

            Doc doc = new Doc();
            PDF pdf = new PDF();

            Console.WriteLine("Doc----------------");
            objectStructure.Attach(extracting);
            objectStructure.Attach(sending);
            objectStructure.Accept(doc);

            Console.WriteLine("PDF----------------");
            objectStructure.Detach(sending);
            objectStructure.Attach(zipping);
            objectStructure.Accept(pdf);
        }
    }
}
