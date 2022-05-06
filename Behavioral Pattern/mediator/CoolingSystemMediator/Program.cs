namespace CoolingSystemMediator
{
    public class MainApp
    {
        public static void Main()
        {
            Fan fan = new Fan();
            Button btn = new Button();
            PowerSupplier powerSupplier = new PowerSupplier();
            Mediator mediator = new Mediator(btn, fan,powerSupplier);
            mediator.start();
            mediator.press();
            mediator.press();
            mediator.press();
            mediator.stop();
        }
    }
}
