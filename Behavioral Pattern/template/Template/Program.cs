namespace Template
{
    public class MainApp
    {
        public static void Main()
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();
            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
        }
    }
}
