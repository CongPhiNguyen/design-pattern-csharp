using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling
{
    public class DocumentHandling : AbstractHandling
    {
        public override void connectDatabase()
        {
            Console.WriteLine("Connecting to document database");
        }
        public override void closingConnection()
        {
            Console.WriteLine("Closing connect of document database");
        }

        public override void pdfConvert()
        {
            Console.WriteLine("Convert pdf to readable file");
        }

        public override void handlingData()
        {
            Console.WriteLine("Processing data of the converted file");
        }
    }
}
