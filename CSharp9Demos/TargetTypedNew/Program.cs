namespace TargetTypedNew
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public Person()
        {
         
        }

        public int Age { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            var p2 = new Person();

            Person p3 = new (); // default ctor
            Person p4 = new() { Name = "Andry", Age = 22 };

            Person p5;
            p5 = new("Jane"); // possible but we lost some info while split init
        }
    }

    public class Demo
    {
        public static void UsePerson(Person p)
        {
            //
        }

        public static Person MakePerson(string name, int age)
        {
            return new() { Name = name, Age = age };
        }

        public static void Method()
        {
            UsePerson(new());

            UsePerson(new("John"));
        }
    }
}