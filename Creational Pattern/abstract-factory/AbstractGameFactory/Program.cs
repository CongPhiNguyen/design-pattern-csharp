namespace AbstractFactory
{
    class MainApp{
        public static void Main()
        {
            CharacterGenerator characterLevel1 = new CharacterLevel1();
            Stage stage1 = new Stage(characterLevel1);
            stage1.start();

            Console.WriteLine("\n-----------------------------------------\n");

            CharacterGenerator characterLevel2 = new CharacterLevel2();
            Stage stage2 = new Stage(characterLevel2);
            stage2.start();
        }
    }      
}