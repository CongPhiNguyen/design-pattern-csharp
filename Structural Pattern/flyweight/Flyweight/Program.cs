namespace Flyweight
{
    public class MainApp
    {
        public static void Main()
        {
            int extrinsicstate = 22;
            FlyweightFactory factory = new FlyweightFactory();
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);
            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);
            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);
            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);
        }
    }
}
