namespace TreeFlyweight
{
    public class MainApp
    {
        public static void Main()
        {
            Forest forest = new Forest();
            forest.plantTree(10, 10, "name", "color", "texture");
            forest.plantTree(100, 10, "Pine", "brown", "textureA");
            forest.plantTree(10, 100, "Apple", "black", "textureB");
            forest.plantTree(100, 100, "Peach", "green", "textureC");
            forest.draw("canvas");
        }
    }
}
