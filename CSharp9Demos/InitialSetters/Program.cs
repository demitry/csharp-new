namespace InitialSetters
{
    public class Person
    {
        private readonly int ssn;
        
        public Person() { }
        
        public Person(int ssn)
        {
            this.ssn = ssn;
            SSN = ssn;
        }

        public int SSN { get; init; }

        //Backing prop
        private readonly string lastname;
        
        public string FirstName { get; init; }
        
        public string LastName
        {
            get => lastname;
            init => lastname = value ??
                throw new ArgumentNullException(nameof(lastname));
        }

        //init = can be called in places: ctor or object initializer

        // and indexer:
        public string this[int i]
        {
            get { return i > 0 ? LastName : FirstName; }
            init
            {
                if (i > 0) LastName = value;
                else FirstName = value;
            }
        }

        void ChangeIt()
        {
            //ssn = 0;

            // Error CS0191  A readonly field cannot be assigned to(except in a constructor or init - only setter of the type in which the field is defined or a variable initializer)

            //What if I want the property with the same behavior?
            // public int SSN { get; init; }

            //SSN = 0; 
            //Error	CS8852	Init-only property or indexer 'Person.SSN' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.	
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Person { SSN = 12345 };
            Console.WriteLine("Hello, World!");
        }
    }
}