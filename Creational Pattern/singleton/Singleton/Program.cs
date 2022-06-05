namespace Singleton
{
    public static class MainApp
    {
        public static void Main()
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
        }
    }
}
