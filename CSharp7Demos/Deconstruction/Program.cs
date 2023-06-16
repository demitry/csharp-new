using static System.Console;

namespace Deconstruction
{
    internal class Program
    {

        public class Point0
        {
            public int X, Y;
        }

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

        static void Main(string[] args)
        {
            // Deconstruction

            var pt0 = new Point0();
            //var (x0, y0) = pt0; // interesting error here
            //WriteLine($"Got a point x = {x0}, y = {y0}");

/*
Severity	Code	Description	Project	File	Line	Suppression State
Error	CS8129	No suitable 'Deconstruct' instance or extension method was found for type 'Program.Point0', with 2 out parameters and a void return type.
Error	CS8130	Cannot infer the type of implicitly-typed deconstruction variable 'y0'.
Error	CS8130	Cannot infer the type of implicitly-typed deconstruction variable 'x0'.
Error	CS1061	'Program.Point0' does not contain a definition for 'Deconstruct' and no accessible extension method 'Deconstruct' accepting a first argument of type 'Program.Point0' could be found (are you missing a using directive or an assembly reference?)
*/

            Point pt = new Point { X = 2, Y = 3 };
            var (x, y) = pt; // interesting error here
            WriteLine($"Got a point x = {x}, y = {y}");

            // can also discard (_) values, "do not care" values, ignore
            (int z, _) = pt;
        }
    }
}