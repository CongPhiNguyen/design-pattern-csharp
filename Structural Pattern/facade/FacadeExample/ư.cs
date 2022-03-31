namespace FacadeExample
{
    public static class MainApp
    {
        public static void Main()
        {
            Facade facade = new Facade();
            facade.sendTask();
            Console.WriteLine("-----------------");
            facade.writeReport();
        }
    }
}
