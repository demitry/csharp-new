using System;
using System.Reflection;

Console.WriteLine("Hello, World!");

Foo();

// Behind the scenes:
// You do get a class, 
// Inside the class you will have main method (static void)

// GOOD STAFF:

// You can have functions

void Foo()
{
    Console.WriteLine("Foo");
}

Foo();

// Args are available here
Console.WriteLine(args.Length);
Console.WriteLine(args[0]);

// Async main is available
//await Task.CompletedTask;

// BAD STAFF:
Console.WriteLine("BAD STAFF:");
var method = MethodBase.GetCurrentMethod();
Console.WriteLine(method.DeclaringType.Namespace);  // No namespace!
Console.WriteLine(method.DeclaringType.Name);   // Program  // <<Main>$>d__0 (await Task.CompletedTask;)
Console.WriteLine(method.Name);                 //< Main >$ // MoveNext (await Task.CompletedTask;)
//So, there can be only one compilation unit, else you will get:
//Error CS8802	Only one compilation unit can have top-level statements.

// The result of calling the program
return 1;

// One restriction: top level instructions - before types
class Person
{

}

// Foo();// Error CS8803	Top-level statements must precede namespace and type declarations.