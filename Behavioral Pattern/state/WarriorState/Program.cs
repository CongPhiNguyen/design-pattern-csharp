namespace WarriorState
{
    public class MainApp
    {
        public static void Main()
        {
            Warrior warrior = new Warrior(new Normal());
            warrior.receiveObject("Fullpower");
            warrior.receiveObject("Poison String");
            warrior.receiveObject("Paralyzed Lighting");
            warrior.receiveObject("Healing Potion");
            warrior.receiveObject("Paralyzed Lighting");
            warrior.receiveObject("Fullpower Extra");

        }
    }
}
