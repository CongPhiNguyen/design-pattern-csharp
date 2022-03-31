namespace Facade
{
    class MainApp
    {
        public static void Main()
        {
            Facade facade = new Facade();
            facade.MethodA();
            Console.WriteLine("----------");
            facade.MethodB();
        }
    }
}
