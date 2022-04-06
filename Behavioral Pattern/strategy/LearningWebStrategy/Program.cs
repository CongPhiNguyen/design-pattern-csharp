namespace LearningWebStrategy
{
    public class MainApp
    {
        public static void Main()
        {
            Context context;

            Console.WriteLine("Student accessing...");
            context = new Context(new StudentStrategy());
            context.ContextInterface();

            Console.WriteLine("\nTeacher accessing...");
            context = new Context(new TeacherStrategy());
            context.ContextInterface();

            Console.WriteLine("\nAdmin accessing...");
            context = new Context(new AdminStrategy());
            context.ContextInterface();
        }
    }
}
