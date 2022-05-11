namespace DevelopmentChain
{
    public class MainApp
    {
        public static void Main()
        {
            Handler ba  = new BusinessAnalysis();
            Handler ds = new Designer();
            Handler dv = new Developer();
            Handler test = new Tester();

            ba.SetSuccessor(ds);
            ds.SetSuccessor(dv);
            dv.SetSuccessor(test);

            Request[] requests =
            {
                new Request(type:"Indentify Business"),
                new Request(type:"Coding"),
                new Request(type:"Analysic"),
                new Request(type: "Testing"),
                new Request(type: "Design database"),
                new Request(type: "Design UI/UX"),
            };

            foreach(Request request in requests)
            {
                ba.HandleRequest(request);
            }

        }
    }
}
