namespace ExprVarsInitializers
{
    public class A
    {
        public A(int i, out int j) { j = i; }
    }

    public class B : A
    {
        public B(int i) : base(i, out var j)
        {
            Console.WriteLine($"j: {j}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B(99);
        }
    }
}