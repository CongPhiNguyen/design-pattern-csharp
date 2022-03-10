namespace ShapeAdapter
{
    class MainApp
    {
        public static void Main()
        {
            RoundHole hole = new RoundHole(5);
            RoundNail roundNail = new RoundNail(5);

            hole.fits(roundNail);
            Console.WriteLine("-------------------\n");

            SquareNail smallSquareNail = new SquareNail(5);

            hole.fits(smallSquareNail);
            Console.WriteLine("-------------------\n");

            RoundNail smallSqualeNailAdapter = new SquareNailAdapter(smallSquareNail);
            Console.WriteLine("-------------------");
            hole.fits(smallSqualeNailAdapter);


        }
    }
}
