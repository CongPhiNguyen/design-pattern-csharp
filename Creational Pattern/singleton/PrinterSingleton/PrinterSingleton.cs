using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterSingleton
{
    public class PrinterSingleton
    {
        private static PrinterSingleton _printerInstance;
        private Queue<string> namQueue = new Queue<string>();

        private PrinterSingleton() { }
        public static PrinterSingleton getPrinterInstance(string instanceName)
        {
            if(_printerInstance == null) {
                Console.WriteLine("{0} printer object created", instanceName);
                _printerInstance = new PrinterSingleton();
            }
            return _printerInstance;
        }
    
        public void addDocument(string documentName)
        {
            this.namQueue.Enqueue(documentName);
            Console.WriteLine("Add document", documentName);
        }

        public void printDocument()
        {
            Console.WriteLine("Print document: {0}", this.namQueue.Dequeue());
        }
    }
}
