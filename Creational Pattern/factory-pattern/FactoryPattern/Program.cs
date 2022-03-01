namespace FactoryPattern
{
    class MainApp
    {
        public static void Main()
        {
            CreatorFactory[] creators = new CreatorFactory[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();
            foreach (CreatorFactory creator in creators)
            {
                ProductFactory product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
        }
    }
}

