namespace AbstractFactory
{
    class MainApp{
        public static void Main()
        {
            AbstractFactory factory1 = new Factory1();
            Client client1 = new Client(factory1);
            client1.Run();

            AbstractFactory factory2 = new Factory2();
            Client client2 = new Client(factory2);
            client2.Run();

        }
    }      
}