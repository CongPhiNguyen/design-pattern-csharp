namespace Command
{
    class MainApp
    {
        public static void Main()
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

        }
    }
}
