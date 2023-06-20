using static System.Console;

namespace InferTupleNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dot Net framework 4.7
            // reminder: tuples
            var me = (name: "Dmitry", age: 30);
            WriteLine(me);

            var alsoMe = (me.age, me.name);
            WriteLine(alsoMe.Item1); // typical C# 7.0
            WriteLine(alsoMe.name); // new  C# 7.1 , took these names and initialize corresponding names is this tuple

            var months = new[] { "March", "April", "May" };
            var result2 = months.Select(m => (
                m.Length,
                FirstChar: m[0]
            )).Where(t=> t.Length == 5);
            WriteLine(string.Join(",",result2));

            var result = new[] { "March", "April", "May" } // explicit name not required
              .Select(m => (
                /*Length:*/ m/*?*/.Length, // optionally nullable
                FirstChar: m[0])) // some names (e.g., ToString) disallowed
              .Where(t => t.Length == 5); // note how .Length is available here
            WriteLine(string.Join(",", result));

            

            // tuples produced by deconstruction
            var now = DateTime.UtcNow;
            var u = (now.Hour, now.Minute);
            var v = ((u.Hour, u.Minute) = (11, 12)); // construct new tuple from existing
            WriteLine(v.Minute);
        }
    }
}