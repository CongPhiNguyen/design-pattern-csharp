using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    internal class Facade
    {
        Notifier notifier = new Notifier();
        PaperPrinter paperPrinter = new PaperPrinter();
        PDFPrinter pDFPrinter = new PDFPrinter();
        SendFax sendFax = new SendFax();
        SendMail sendMail = new SendMail();

        public Facade()
        {
            notifier = new Notifier();
            paperPrinter = new PaperPrinter();
            pDFPrinter = new PDFPrinter();
            sendFax = new SendFax();
            sendMail = new SendMail();
        }

        public void writeReport()
        {
            Console.WriteLine("Writing report....");
            paperPrinter.print();
            pDFPrinter.printPDF();
            sendFax.sendFax();
        }

        public void sendTask()
        {
            Console.WriteLine("Sending task....");
            sendMail.sendMail();
            notifier.Notify();
            paperPrinter.print();
        }


    }
}
