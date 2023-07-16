using System.Security.Cryptography;

namespace DefaultInterfaceMembers
{
    // Before version C# 8:
    // Behavioral Mixins
    // Classes can have any number of interfaces, you can attach behavior. 
    // You cannot attach state, there is no "extension field" or "extension property".
    
    public interface IHumanBefore
    {
        string Name { get; }
    }

    public static class ExtensionMethods
    {
        public static void Greet(this IHumanBefore human)
        {
            Console.WriteLine($"Hello, I am {human.Name}");
        }
    }

    // In C# 8 you can write implementation details inside the interface

    public interface IHuman
    {
        string Name { get; }

        void SayHello()
        {
            Console.WriteLine($"Hello, I am {Name}");
        }
    }

    public interface IFriendlyHuman : IHuman
    {
        string Name { get; }

        //void SayHello()
        //{
        //    Console.WriteLine($"Greeting, my name is {Name}");
        //}

        // Implicit interface method implementation
        void IHuman.SayHello()
        {
            Console.WriteLine($"Hello (2), I am {Name}");
        }
    }

    public class Human : IHuman, IFriendlyHuman
    {
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // The way it works is very strange,
            // It is not how you are expecting:
            Human human = new Human() { Name = "John" };
            //human.SayHello(); // will not compile, CS1061	'Human' does not contain a definition for 'SayHello' ...
            // Class unaware of default interface implementation

            // The only way to call SayHello() - cast to interface:
            IHuman human1 = new Human() { Name = "Bob" };
            human1.SayHello();

            ((IHuman)new Human() { Name = "Henry" }).SayHello();

            // Independent methods:
            ((IFriendlyHuman)new Human() { Name = "Henry" }).SayHello();

            // The most specific implementation is called
        }
    }

    // Diamond inheritance

    interface ITalk { void Greet(); }

    interface IAmBritish : ITalk
    {
        void ITalk.Greet() => Console.WriteLine("Good day!");
    }

    interface IAmAmerican : ITalk
    {
        void ITalk.Greet() => Console.WriteLine("Howdy!");
    }

    // Diamond inheritance
    //class DualNation : IAmBritish, IAmAmerican { }

    // CS8705
    // Interface member 'ITalk.Greet()' does not have a most specific implementation.
    // Neither 'IAmBritish.ITalk.Greet()', nor 'IAmAmerican.ITalk.Greet()' are most specific.

}