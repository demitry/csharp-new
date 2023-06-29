namespace NonTrailingNamedArguments
{
    internal class Program
    {
        static void doSomething(int foo, int bar)
        {
            Console.WriteLine($"foo: {foo} bar: {bar}");
        }


        static void Main(string[] args)
        {
            doSomething(33, bar: 44);

            doSomething(foo: 33, 44); // Now you can use named arg before unnamed argument

            // still illegal
            //doSomething(33, foo: 44); // but cannot change the position of arguments while using unnamed arg

            doSomething(bar: 33, foo: 44);
        }
    }
}