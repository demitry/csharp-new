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

            var origin = phoneNumber switch
            {
                { Number: 112 } => "Emergency",
                { Code: 44 } => "UK"
            };
            // Warning CS8509 The switch expression does not handle all possible values of its input type (it is not exhaustive).

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
        }

        // Deconstruction

        public class Shape
        {
            public string Name { get; set; }
        }

        public class Rectangle : Shape
        {

        }

        public class Ciccle : Shape
        {

        }

        //var type = shape switch
        //{
        //}
    }
}