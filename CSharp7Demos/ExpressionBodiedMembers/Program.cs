namespace ExpressionBodiedMembers
{
    internal class Program
    {
        // community contributed feature
        public class Person
        {
            private int id;

            private static readonly Dictionary<int, string> names = new Dictionary<int, string>();

            public Person(int id, string name) => names.Add(id, name); //expression body

            ~Person() => names.Remove(id);

            public string Name
            {
                get => names[id];
                set => names[id] = value;   //expression body
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}