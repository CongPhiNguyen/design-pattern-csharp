namespace FactoryGame
{
    class MainApp
    {
        public static void Main()
        {
            GameCreator[] creators = new GameCreator[3];
            creators[0] = new ChessCreator();
            creators[1] = new CheckerCreator();
            creators[2] = new LudoCreator();
            foreach (GameCreator creator in creators)
            {
                GameProduct product = creator.createGame();
                Console.WriteLine("Created {0}\n\n", product.GetType().Name);
                
            }
        }
    }
}

