namespace Interpreter
{
    public class MainApp
    {
        public static void Main()
        {
            Context context = new Context();

            List<AbstractExpression> list = new List<AbstractExpression>();

            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
        }

    }
}
