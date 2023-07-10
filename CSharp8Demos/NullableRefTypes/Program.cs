#nullable enable
namespace NullableRefTypes
{
    public class Person
    {
        public Person(string firstName, string? lastName) => 
            (FirstName, LastName) = (firstName, lastName);
        
        public string FirstName { get; set; }
        public string? LastName { get; set; }

        public string FullName => $"{FirstName}, {LastName?[0]}";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Dmitri", "Popov");
            Console.WriteLine(person.FullName);
            Person person2 = new Person("Dmitri", null);
            Console.WriteLine(person2.FullName);

            var n1 = (null as Person).FullName; // warning
            var n2 = (null as Person)!.FullName; // NO warning
            //var n3 = (null as Person)!!!!!!!!.FullName; // NO warning, was also legal? No, it is Error CS8715	Duplicate null suppression operator ('!')
            var n4 = (null as Person)!?.FullName;// DOES in fact perform the null check
            //var n5 = (null as Person)?!.FullName; // won't compile
        }
    }
}