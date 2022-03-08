namespace MilkTeaBuilder
{
    class MainApp
    {
        public static void Main()
        {
            // Old way to do this problem
            /*Milktea milktea = new Milktea(sua: Sua.SuaBo, tra: Tra.TraXanh,tranChau: false, thach: false);
            milktea.show();*/

            MilkteaDirector director = new MilkteaDirector();
            MatchaBuilder matchaBuilder = new MatchaBuilder();
            MixMilkteaBuilder mixMilkteaBuilder = new MixMilkteaBuilder();

            director.construct(matchaBuilder);
            Milktea m1 = matchaBuilder.getResult();
            m1.show();

            Console.WriteLine("\n--------------------\n");

            director.construct(mixMilkteaBuilder);
            Milktea m2 = mixMilkteaBuilder.getResult();
            m2.show();

        }
    }
}
