namespace DataHandling
{
    public class MainApp
    {
        public static void Main()
        {
            Console.WriteLine("Picture Handling......");
            AbstractHandling pictureHandling = new PictureHandling();
            pictureHandling.templateMethod();

            Console.WriteLine("\nDocumemt Handling......");
            AbstractHandling documentHandling = new DocumentHandling();
            documentHandling.templateMethod();
        }
    }
}
