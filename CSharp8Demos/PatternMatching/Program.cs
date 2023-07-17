#nullable enable
using static PatternMatching.Program;

namespace PatternMatching
{
    internal class Program
    {
        public struct PhoneNumber
        {
            public int Code, Number;
        }

        public class Person
        {
            public string Name { get; set; }
            public PhoneNumber? PhoneNumber { get; set; }
        }

        static void Main(string[] args)
        {
            var phoneNumber = new PhoneNumber();

            //var origin = phoneNumber switch
            //{
            //    { Number: 112 } => "Emergency",
            //    { Code: 44 } => "UK"
            //};
            // Warning CS8509 The switch expression does not handle all possible values of its input type (it is not exhaustive).
            // And exception during the execution

            var origin2 = phoneNumber switch
            {
                { Number: 112 } => "Emergency",
                { Code: 44 } => "UK",
                { } => "Indeterminate",
                //_ => "Missing" //phoneNumber is null
            };

            //  Empty vs Default
            var origin3 = phoneNumber switch
            {
                { Number: 112 } => "Emergency",
                { Code: 44 } => "UK",
                { } => "Unknown",
            };

            // - Is it switch exhaustive?
            // - It depends on #nullable enable/disable

            //  Recursive patterns
            var person = new Person();
            var personsOrigin = person switch
            {
                { Name: "Dave" } => "USA",
                { PhoneNumber: { Code: 46 } } => "Sweden",
                { Name: var name } => $"No idea where {name} lives"
            };

            // Switch-Based Validation

            var error = person switch
            {
                null => "Object missing",
                { PhoneNumber: null } => "Phone number missing entirely",
                { PhoneNumber: { Number : 0 } } => "Actual number missing",
                { PhoneNumber: { Code: var code } } when code < 0 => "WTF?",
                { } => null //no error
            };

            if(error != null)
            {
                throw new ArgumentException(error);
            }
        }

        public class ExtendedPhoneNumber
        {
            public int Code, Number;

            public string Office { get; set; }
        }

        public class Helper
        {
            // Recursive Patterns with Type Checks
            public IEnumerable<ExtendedPhoneNumber> Numbers { get; set; }

            IEnumerable<int> GetMainOfficeNumbers()
            {
                foreach (var pn in Numbers)
                {
                    if( pn is ExtendedPhoneNumber { Office: "main" })
                        yield return pn.Number;
                }
            }

            // Demonstrate Deconstruction for switch
            public void GetShapeType(Shape shape)
            {
                var type = shape switch
                {
                    Rectangle((0, 0), 0, 0) => "Point at origin",
                    Circle((0, 0), _) => "Circle at origin",
                    Rectangle(_, var w, var h) when w == h => "Square",
                    Rectangle((var x, var y), var w, var h) => $"A {w}x{h} rectangle at ({x},{y})",
                    _ => "something else"
                };
            }
        }

        // Deconstruction

        public class Point
        {
            public double X, Y;

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        public class Shape
        {
            public string Name { get; set; }
        }

        public class Rectangle : Shape
        {
            //public Rectangle(Point origin, double width, double height)
            //public Rectangle(Tuple<double, double> origin, double width, double height)
            public Rectangle((double X, double Y) origin, double width, double height)
            {
                Origin = new Point(origin.X, origin.Y);
                Width = width;
                Height = height;
            }

            public Point Origin { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }


            // CS8129	No suitable 'Deconstruct' instance or extension method was found for type
            // CS1061	'Program.Rectangle' does not contain a definition for 'Deconstruct' and no accessible extension method 'Deconstruct' accepting a first argument of type 'Program.Rectangle' could be found
            //public void Deconstruct(out Point origin, out double width, out double height)
            public void Deconstruct(out (double X, double Y) origin, out double width, out double height)
            {
                origin.X = Origin.X;
                origin.Y = Origin.Y;
                width = Width;
                height = Height;
            }

        }

        public class Circle : Shape
        {
            //public Circle(Point origin, double radius)
            public Circle((double X, double Y) origin, double radius)
            //
            {
                Origin = new Point(origin.X, origin.Y);
                Radius = radius;
            }

            public void Deconstruct(
                out (double X, double Y) origin,
                out double radius)
            {
                origin = (Origin.X, Origin.Y);
                radius = Radius;
            }

            public Point Origin { get; set; }
            public double Radius { get; set; }
        }
    }
}