namespace ShapePrototype
{
    class MainApp
    {
        public static void Main()
        {
            ShapePrototype shapePrototype = new ShapePrototype();
            shapePrototype.p = new Point(100,200);
            shapePrototype.Color = "Red";
            DisplayValues(shapePrototype);

            ShapePrototype shallowCopy = shapePrototype.ShallowCopy();
            Console.WriteLine("Shallow copy before changing the origin");
            DisplayValues(shallowCopy);

            ShapePrototype deepCopy = shapePrototype.DeepCopy();
            Console.WriteLine("Deep copy before changing the origin");
            DisplayValues(deepCopy);


            Console.WriteLine("----------------------------");
            shapePrototype.p.X = 200;
            shapePrototype.Color = "Blue";
            Console.WriteLine("Origin changed to");
            DisplayValues(shapePrototype);

            Console.WriteLine("Shallow copy after changing the origin");
            DisplayValues(shallowCopy);

            Console.WriteLine("Deep copy after changing the origin");
            DisplayValues(deepCopy);

            Console.WriteLine("----------------------------\n");

            // Tạo 1 mảng các object gồm các deepcopy
            List<ShapePrototype> shapes = new List<ShapePrototype>();
            ShapePrototype shapePrototype1 = new ShapePrototype();
            shapePrototype1.p = new Point(100, 100);
            shapePrototype1.Color = "Red";
            shapes.Add(shapePrototype1);

            RectanglePrototype rectanglePrototype = new RectanglePrototype();
            rectanglePrototype.p = new Point(100, 100);
            rectanglePrototype.Color = "Blue";
            rectanglePrototype.width = 200;
            rectanglePrototype.height = 200;
            shapes.Add(rectanglePrototype);

            CirclePrototype circlePrototype = new CirclePrototype();
            circlePrototype.p = new Point(100, 100);
            circlePrototype.Color = "Blue";
            circlePrototype.radius = 40;
            shapes.Add(circlePrototype);

            List<ShapePrototype> shapesCopy = bussinessLogic(shapes);
        }
        public static void DisplayValues(ShapePrototype p)
        {
            Console.WriteLine("Coordinate: ({0},{1}). Color: {2}", p.p.X, p.p.Y, p.Color);
        }
        public static List<ShapePrototype> bussinessLogic(List<ShapePrototype> shapes)
        {
            List<ShapePrototype> res = new List<ShapePrototype>();
            foreach (ShapePrototype shape in shapes)
            {
                res.Add(shape);
            }
            return res;
        }
    }
}
