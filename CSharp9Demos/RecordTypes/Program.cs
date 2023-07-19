namespace RecordTypes
{
    public record Address
    {
        public Address(int houseNumber, string street)
        {
            HouseNumber = houseNumber;
            Street = street;
        }

        public Address() { }

        public int HouseNumber { get; }
        public string Street { get; }
    }

    public record Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var t = typeof(Person);
            foreach (var m in t.GetMembers())
            {
                // Console.WriteLine($" - {m.Name}");
            }
                

            /*
             - get_Name
             - set_Name
             - get_Age
             - set_Age
             
             - ToString
            
             - op_Inequality
             - op_Equality
             
             - GetHashCode - really stable and safe
             - Equals - 1 for generic and 1 for non-generic types
             - Equals
             - <Clone>$
             - GetType
             - .ctor
             
             - Name
             - Age
             */

            var p = new Person() { Name = "John", Age = 22 };
            Console.WriteLine(p); // Person { Name = John, Age = 22 } (nice ToString)

            // Equality - structural Meaning
            var p2 = new Person() { Name = "John", Age = 22 };
            Console.WriteLine(p == p2);
            // True, it is not comparison by reference,
            // It is comparison by actual value
            // And it is recursive

            p.Address = new(123, "London Ad");
            p2.Address = new(123, "London Ad");

            Console.WriteLine(p == p2); // True
            p2.Address = new(1234, "London Ad");
            Console.WriteLine(p == p2); // False

            Console.WriteLine(typeof(Person).GetInterfaces()[0].Name); // IEquatable`1
        }
    }
}