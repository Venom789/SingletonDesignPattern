namespace SingletonDesignPattern
{
    public class PrinterManager
    {
        private static PrinterManager _instance;

        // Private constructor to prevent external instantiation
        private PrinterManager() { }

        public static PrinterManager Instance
        {
            get
            {
                // Lazy initialization: create the instance only when it's first accessed
                if (_instance == null)
                {
                    _instance = new PrinterManager();
                }
                return _instance;
            }
        }

        // Other methods and properties of the PrinterManager class
        public void PrintDocument(string document)
        {
            Console.WriteLine("Printing document: " + document);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Access the printer manager instance
            PrinterManager printerManager = PrinterManager.Instance;

            // Use the printer manager to print documents
            printerManager.PrintDocument("Report.pdf");
            printerManager.PrintDocument("Letter.docx");

            // Both calls use the same instance of the PrinterManager
            // and ensure that only one instance exists throughout the application.
        }
    }

}