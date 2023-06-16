using static System.Console;

namespace Tuples
{
    public class Point
    {
        public int X, Y;

        public void Deconstruct(out string s)
        {
            s = $"{X}-{Y}";
        }

        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }

    internal class Program
    {
        //Pre-C#7 days, old-fashion way:
        // sp.Item1 ugly (the don't have any names)

        static Tuple<double, double> SumAndProduct(double a, double b)
        {
            return Tuple.Create(a + b, a * b);
        }

        // It was required ValueTuple nuget package (2017), now it is available without it
        // originally with no names
        
        //static (double, double) NewSumAndProduct(double a, double b)
        //{
        //    return (a + b, a * b);
        //}

        static (double sum, double product) NewSumAndProduct(double a, double b)
        {
            return (a + b, a * b);
        }

        static void Main(string[] args)
        {
            // New
            var sp = SumAndProduct(2, 5);
            
            // sp.Item1 ugly (the don't have any names)
            WriteLine($"sum = {sp.Item1}, product = {sp.Item2}");

            var sp2 = NewSumAndProduct(2, 5);
            WriteLine($"new sum = {sp2.sum}, product = {sp2.product}");
            WriteLine($"Item1 = {sp2.Item1}");
            WriteLine(sp2.GetType());

            // converting to valuetuple loses all info

            ValueTuple<double, double> vt0 = sp2;
            //vt0.sum // lost all info, only sp2 knows all the info
            
            var vt = sp2;
            // back to Item1, Item2, etc...
            var item1 = vt.Item1; // :(

            // can use var below
            //(double sum, var product) = NewSumAndProduct(3, 5);
            
            var (sum, product) = NewSumAndProduct(3, 5);

            // note! var works but double doesn't
            // double (s, p) = NewSumAndProduct(3, 4);

            WriteLine($"sum = {sum}, product = {product}");
            WriteLine(sum.GetType());

            // also assignment
            double s, p;
            (s, p) = NewSumAndProduct(1, 10);

            (double ss, double pp) = NewSumAndProduct(12, 23);

            // tuple declarations with names
            //var me = new {name = "Dmitri", age = 123}; // AnonymousType
            var me = (name: "Dmitry", age: 123);
            WriteLine("ME: " + me);
            WriteLine(me.GetType());

            // names are not part of the type:
            WriteLine("Fields: " + string.Join(",", me.GetType().GetFields().Select(pr => pr.Name)));
            WriteLine("Properties: " + string.Join(",", me.GetType().GetProperties().Select(pr => pr.Name)));

            WriteLine($"My name is {me.name} and I am {me.age} years old");
            // proceed to show return: TupleElementNames in dotPeek (internally, Item1 etc. are used everywhere)

            // unfortunately, tuple names only propagate out of a function if they're in the signature
            var snp = new Func<double, double, (double sum, double product)>((a, b) => (sum: a + b, product: a * b));
            var result = snp(1, 2);
            // there's no result.sum unless you add it to signature
            WriteLine($"sum = {result.sum}");

            var snp2 = new Func<double, double, (double, double)>((a, b) => (sum: a + b, product: a * b));
            var result2 = snp2(1, 2);
            // there's no result.sum unless you add it to signature
            //WriteLine($"sum = {result2.sum}");// Not propagated
            WriteLine($"sum = {result2.Item1}");

            // When you reference result.product - you really reference result.Item2

            // deconstruction
            Point pt = new Point { X = 2, Y = 3 };
            var (x, y) = pt; // interesting error here
            WriteLine($"Got a point x = {x}, y = {y}");

            // can also discard values
            (int z, _) = pt;
        }
    }
}