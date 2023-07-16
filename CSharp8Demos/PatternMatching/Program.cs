#nullable enable
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
                { PhoneNumber: null } => "Phone number missing enrirely",

            }
        }
    }
}