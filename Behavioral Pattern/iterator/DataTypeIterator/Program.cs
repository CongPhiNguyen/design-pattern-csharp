namespace DataTypeIterator
{
    public class MainApp {
        public static void Main(string[] args) {
            DataTypeAggregate data = new DataTypeAggregate();
            data[0] = new DataType(1);
            data[1] = new DataType(2);
            data[2] = new DataType(3);
            data[3] = new DataType(4);

            DataTypeIterator iterator = data.CreateIterator();
            Console.WriteLine(iterator.Value());

            Console.WriteLine("Iterating......");
            while (!iterator.isEnd())
            {
                Console.WriteLine(iterator.Value());
                iterator.Next();
            }
        }
    }
}
