namespace ShapeAdapter
{
    class MainApp
    {
        public static void Main()
        {
            RoundHole hole = new RoundHole(10);
            RoundNail roundNail = new RoundNail(5);

            hole.fits(roundNail);
            Console.WriteLine("-------------------\n");

            SquareNail smallSquareNail = new SquareNail(5);
            SquareNail largeSquareNail = new SquareNail(15);

            hole.fits(smallSquareNail);
            Console.WriteLine("-------------------\n");

            RoundNail smallSqualeNailAdapter = new SquareNailAdapter(smallSquareNail);
            RoundNail largeSqualeNailAdapter = new SquareNailAdapter(largeSquareNail);
            Console.WriteLine("-------------------");
            hole.fits(smallSqualeNailAdapter);
            hole.fits(largeSqualeNailAdapter);


        }
    }
}
