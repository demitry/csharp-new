namespace CSharpCodeGenDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            HelloFrom("Generated Code");

            Console.WriteLine(new Foo().Bar);
            // Even if we have Error CS0246	The type or namespace name 'Foo' could not be found
            // It runs OK
        }

        static partial void HelloFrom(string name);
    }
}