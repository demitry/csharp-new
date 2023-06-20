using static System.Console;

namespace DefaultExpressions
{
    internal class Program
    {
        // allowed in argument names
        // only upside: switching from ref to value type

        // VS Action 'Simplify Default Expression'
        public DateTime GetTimeStamps(List<int> items = default(List<int>))
        {
            // ...
            return default;
        }

        public DateTime GetTimeStamps2(List<int> items = default)
        {
            // ...
            return default; // default DateTime
        }

        /// <summary>
        /// Default literal, one of the slightly meaningless features.
        /// </summary>
        static void Main()
        {
            // Simplify default expression here
            int a = default(int); // so simplified in c# 7.1
            WriteLine(a);

            int b = default;
            WriteLine(b);

            // constants are ok if the inferred type is suitable
            const int c = default;
            WriteLine(c);

            // will not work here
            // const int? d = default; // oops, won't work

            // cannot leave defaults on their own
            var e = new[] { default, 33, default };
            //var e = new[] { default, default }; //CS0826	No best type found for implicitly-typed array
            WriteLine(string.Join(",", e));

            // rather silly way of doing things; null is shorter
            string s = default;
            Write("string default == null: ");
            WriteLine(s == null);

            // comparison with default is OK if type can be inferred
            if (s == default)
            {
                WriteLine("Yes, s is default/null");
            }

            // ternary operations
            var x = a > 0 ? default : 1.5;
            WriteLine(x.GetType().Name);
        }
    }
}