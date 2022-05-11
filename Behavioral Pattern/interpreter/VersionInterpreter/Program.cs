namespace VersionInterpreter
{
    public class MainApp
    {
        public static void Main()
        {
            Console.WriteLine("----- Interpreter program -----\n\n");
            List<IExpression> expressions = new List<IExpression>();
            expressions.Add(new CheckExpression());
            expressions.Add(new ProgramNameExpression());
            expressions.Add(new VersionExpression());
            expressions.Add(new OSExpression());

            List<Context> contexts = new List<Context>();
            contexts.Add(new Context("git-1.1.0-linux"));
            contexts.Add(new Context("node-1.1.0-window"));
            contexts.Add(new Context("htop---1.1.0---macOS"));

            foreach(var context in contexts)
            {
                foreach(var expression in expressions)
                {
                    expression.InterpreterContext(context);
                }
                Console.WriteLine("-----------------------------------\n");
            }    

        }
    }
}
