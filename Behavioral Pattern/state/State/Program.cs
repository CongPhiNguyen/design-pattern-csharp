namespace State
{
    public class MainApp
    {
        public static void Main()
        {
            var context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }
}
