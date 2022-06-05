namespace PrinterSingleton
{
    public static class MainApp
    {
        public static void Main()
        {
            PrinterSingleton firstPrinterObject = null;
            PrinterSingleton secondPrinterObject = null;
            PrinterSingleton thirdPrinterObject = null;

            Task task1 = Task.Factory.StartNew(() => {
                firstPrinterObject = InitializePrinterObjectAndAddDocument("First", "First-Document");
            });
            Task task2 = Task.Factory.StartNew(() => {
                secondPrinterObject = InitializePrinterObjectAndAddDocument("Second", "Second-Document");
            });
            Task task3 = Task.Factory.StartNew(() => {
                thirdPrinterObject = InitializePrinterObjectAndAddDocument("Third", "Third-Document");
            });

            Task.WaitAll(task1, task2, task3);
            Console.WriteLine("All threads complete");
            Console.WriteLine("Are these First Printer Object And Second Printer Object Same - {0} ", firstPrinterObject.Equals(secondPrinterObject) ? "Yes" : "No");
            Console.WriteLine("Are these First Printer Object And Third Printer Object Same - {0} ", firstPrinterObject.Equals(thirdPrinterObject) ? "Yes" : "No");
            Console.WriteLine("Are these Second Printer Object And Third Printer Object Same - {0} ", secondPrinterObject.Equals(thirdPrinterObject) ? "Yes" : "No");
            Console.ReadLine();

        }
        static PrinterSingleton InitializePrinterObjectAndAddDocument(string instanceName, string documentName)
        {
            var printerObject = PrinterSingleton.getPrinterInstance(instanceName);
            printerObject.addDocument(documentName);
            printerObject.printDocument();
            return printerObject;
        }
    }
}
