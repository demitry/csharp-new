# What's New in C#7, C#8, C#9 and C#10

Learn about latest features of C#7, C#8, C#9 and C#10, **5 video hours**, **Dmitri Nesteruk**

<!-- TOC -->

- [What's New in C#7, C#8, C#9 and C#10](#whats-new-in-c7-c8-c9-and-c10)
    - [Section 1: What's New in C# 7](#section-1-whats-new-in-c-7)
        - [Out Variables [2]](#out-variables-2)
        - [Pattern Matching [3]](#pattern-matching-3)
        - [Tuples [4]](#tuples-4)
        - [Deconstruction [5]](#deconstruction-5)
        - [Local Functions [6]](#local-functions-6)
        - [Ref Returns and Locals References [7]](#ref-returns-and-locals-references-7)
        - [Expression Bodied Members [8]](#expression-bodied-members-8)
        - [Throw Expressions [9]](#throw-expressions-9)
        - [Generalized Async Return Types [10]](#generalized-async-return-types-10)
        - [Literal Improvements [11]](#literal-improvements-11)
    - [Section 2: What's New in C# 7.1](#section-2-whats-new-in-c-71)
        - [Why Is My C#7.1 Program Not Compiling?!? [12]](#why-is-my-c71-program-not-compiling-12)
        - [Async Main [13]](#async-main-13)
        - [Default Expressions [14]](#default-expressions-14)
        - [Reference Assemblies [15]](#reference-assemblies-15)
            - [Reference assemblies structure](#reference-assemblies-structure)
        - [Infer Tuple Names [16]](#infer-tuple-names-16)
        - [Pattern-Matching with Generics [17]](#pattern-matching-with-generics-17)
    - [Section 3: What's New in C# 7.2](#section-3-whats-new-in-c-72)
        - [Leading Digit Separators [18]](#leading-digit-separators-18)
        - ['private protected' Access Modifier [19]](#private-protected-access-modifier-19)
        - [Non-trailing named arguments [20]](#non-trailing-named-arguments-20)
        - ['in' Parameters [21]](#in-parameters-21)
        - ['ref readonly' Variables [22]](#ref-readonly-variables-22)
        - ['ref struct' and Span<T> [23]](#ref-struct-and-spant-23)
            - [Memory Types](#memory-types)
            - [The problem](#the-problem)
            - [Ref Struct Type](#ref-struct-type)
        - [Span<T> Demo [24]](#spant-demo-24)
    - [Section 4: What's New in C# 7.3](#section-4-whats-new-in-c-73)
        - [Performance Improvements [25]](#performance-improvements-25)
            - [fixed statement - pin a variable for pointer operations](#fixed-statement---pin-a-variable-for-pointer-operations)
            - [Indexed fields do not require pinning](#indexed-fields-do-not-require-pinning)
            - [ref local may be reassigned](#ref-local-may-be-reassigned)
            - [stackalloc arrays support initializers](#stackalloc-arrays-support-initializers)
        - [Feature Enhancements [26]](#feature-enhancements-26)
            - [Attributes on backing fields of auto-props](#attributes-on-backing-fields-of-auto-props)
            - ['In' method overload resolution tiebreaker](#in-method-overload-resolution-tiebreaker)
            - [Extended expression variables in initializers](#extended-expression-variables-in-initializers)
            - [Tuples equality](#tuples-equality)
            - [Tuples vs System.Tuple](#tuples-vs-systemtuple)
        - [New Compiler Features [27]](#new-compiler-features-27)
            - [C# compiler options](#c-compiler-options)
            - [PublicSign](#publicsign)
            - [Pathmap PDBs](#pathmap-pdbs)
            - [Deterministic](#deterministic)
        - [Bonus Lecture: Other Courses at a Discount [28]](#bonus-lecture-other-courses-at-a-discount-28)
    - [Section 5: What's New in C# 8](#section-5-whats-new-in-c-8)
        - [Nullable Reference Types [29]](#nullable-reference-types-29)
        - [Indices and Ranges [30]](#indices-and-ranges-30)
        - [Default Interface Members [31]](#default-interface-members-31)
            - [Before version C# 8 - Behavioral Mixins](#before-version-c-8---behavioral-mixins)
            - [C# 8 Default Interface Members](#c-8-default-interface-members)
            - [Modifiers](#modifiers)
            - [Interface Inheritance: The most specific implementation is called](#interface-inheritance-the-most-specific-implementation-is-called)
            - [Diamond inheritance](#diamond-inheritance)
        - [Pattern Matching [32]](#pattern-matching-32)
            - [Property Patterns](#property-patterns)
            - [Empty vs Default](#empty-vs-default)
            - [Recursive patterns](#recursive-patterns)
            - [Switch-Based Validation](#switch-based-validation)
            - [Recursive Patterns with Type Checks](#recursive-patterns-with-type-checks)
            - [Deconstruction](#deconstruction)
    - [Section 6: What's New in C# 9](#section-6-whats-new-in-c-9)
        - [Introduction [33]](#introduction-33)
        - [Record Types [34]](#record-types-34)
            - [Records Equality](#records-equality)
            - [Positional Records](#positional-records)
            - [GetHashCode](#gethashcode)
            - [Records With Expressions](#records-with-expressions)
        - [Top-Level Calls [35]](#top-level-calls-35)
        - [Initial Setters [36]](#initial-setters-36)
        - [Pattern Matching Improvements [37]](#pattern-matching-improvements-37)
        - [Target-Typed New [38]](#target-typed-new-38)
        - [Source Generators [39]](#source-generators-39)
            - [MS link](#ms-link)
            - [Source Generators](#source-generators)
            - [How does it work?](#how-does-it-work)
            - [Compared to](#compared-to)
            - [Demo](#demo)
        - [Partial Method Syntax [40]](#partial-method-syntax-40)
            - [Partial methods](#partial-methods)
        - [Module Initializers [40]](#module-initializers-40)
            - [Module Initializers Feature](#module-initializers-feature)
            - [Module Initializer Runtime Guarantees](#module-initializer-runtime-guarantees)
            - [Module Initializer Restrictions](#module-initializer-restrictions)
    - [Section 7: What's New in C# 10](#section-7-whats-new-in-c-10)
        - [Record Structs](#record-structs)
            - [What are Record Structs](#what-are-record-structs)
            - [Record Struncts Restrinctions](#record-struncts-restrinctions)
            - [Uses of Record Structs](#uses-of-record-structs)
            - [Recommended - readonly record struct](#recommended---readonly-record-struct)
        - [Glogal Using Derictives](#glogal-using-derictives)
        - [File-Scoped Namespace Declaration](#file-scoped-namespace-declaration)
        - [Extended Property Patterns](#extended-property-patterns)
        - [Generic Attributes](#generic-attributes)
        - [Lambda Improvements lots!](#lambda-improvements-lots)
            - [Attributes on lambda functions](#attributes-on-lambda-functions)
            - [Explicit return type](#explicit-return-type)
            - [Infer a natural delegate for lambdas and method groups](#infer-a-natural-delegate-for-lambdas-and-method-groups)
        - [Enchanced #line direcrives](#enchanced-line-direcrives)

<!-- /TOC -->

## Section 1: What's New in C# 7

### Out Variables [2]

```cs
using static System.Console;

namespace OutVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt;
            if (DateTime.TryParse("01/01/2017", out dt))
            {
                WriteLine($"Old-fashioned parse: {dt}");
            }

            if (DateTime.TryParse("02/02/2016", out DateTime dt1))
            {
                WriteLine($"New parse: {dt1}");
            }
            WriteLine($"I can use dt1 here: {dt1}"); // Available outside the if block

            // variable declaration is an expression, not a statement
            if (DateTime.TryParse("02/02/2016", out /*DateTime*/ var dt2))
            {
                WriteLine($"New parse: {dt2}");
            }

            // the scope of dt2 extends outside the if block
            WriteLine($"I can use dt2 here: {dt2}");

            // what if the parse fails?
            int.TryParse("abc", out var i);
            WriteLine($"If parsing fails - we are getting the default i = {i}"); // default value

            //For reference type default = null
        }
    }
}
```

### Pattern Matching [3]

```cs
namespace PatternMatching
{
    public class Shape
    {

    }

    public class Rectangle : Shape
    {
        public int Width, Height;
    }

    public class Circle : Shape
    {
        public int Diameter;
    }

    internal class Program
    {
        public void DisplayShape(Shape shape)
        {
            // Old way:

            if (shape is Rectangle)
            {
                var rc = (Rectangle)shape; // cast

            }
            else if (shape is Circle)
            {
                // ...
            }

            var rect = shape as Rectangle;
            if (rect != null) // nonnull
            {
                //...
            }
            
            // in C# 7:
            
            if (shape is Rectangle r) // if is Rectangle - assign variable r (new way of casting)
            {
                // use r
            }

            // can also do the invserse
            if (!(shape is Circle notCircle))
            {
                // not a circle!
            }


            switch (shape)
            {
                case Circle c: // switch not on shape BUT on the TYPE of shape
                    // use c
                    break;
                case Rectangle sq when (sq.Width == sq.Height):
                    // square!
                    break;
                case Rectangle rr:
                    // use rr
                    break;
            }

            var z = (23, 32);

            // in F# we can switch on tuples, but maybe it could be available in a later versions
            //https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/pattern-matching
            //switch (z) // cannot switch on tuples
            //{
            //  case (0, 0):
            //    WriteLine("origin");
            //}
        }

        static void Main(string[] args)
        {
            
        }
    }
}
```

In F# we can switch on tuples

<https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/pattern-matching>

```fsharp
let function1 x =
    match x with
    | (var1, var2) when var1 > var2 -> printfn "%d is greater than %d" var1 var2
    | (var1, var2) when var1 < var2 -> printfn "%d is less than %d" var1 var2
    | (var1, var2) -> printfn "%d equals %d" var1 var2

function1 (1,2)
function1 (2, 1)
function1 (0, 0)
```

### Tuples [4]

It was not as good as it could be

```cs
using static System.Console;

namespace Tuples
{
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

    internal class Program
    {
        //Pre-C#7 days, old-fashion way:
        // sp.Item1 ugly (the don't have any names)

        static Tuple<double, double> SumAndProduct(double a, double b)
        {
            return Tuple.Create(a + b, a * b);
        }

        // It was required ValueTuple nuget package (2017), now it is available without it
        // originally with no names
        
        //static (double, double) NewSumAndProduct(double a, double b)
        //{
        //    return (a + b, a * b);
        //}

        static (double sum, double product) NewSumAndProduct(double a, double b)
        {
            return (a + b, a * b);
        }

        static void Main(string[] args)
        {
            // New
            var sp = SumAndProduct(2, 5);
            
            // sp.Item1 ugly (the don't have any names)
            WriteLine($"sum = {sp.Item1}, product = {sp.Item2}");

            var sp2 = NewSumAndProduct(2, 5);
            WriteLine($"new sum = {sp2.sum}, product = {sp2.product}");
            WriteLine($"Item1 = {sp2.Item1}");
            WriteLine(sp2.GetType());

            // converting to valuetuple loses all info

            ValueTuple<double, double> vt0 = sp2;
            //vt0.sum // lost all info, only sp2 knows all the info
            
            var vt = sp2;
            // back to Item1, Item2, etc...
            var item1 = vt.Item1; // :(

            // can use var below
            //(double sum, var product) = NewSumAndProduct(3, 5);
            
            var (sum, product) = NewSumAndProduct(3, 5);

            // note! var works but double doesn't
            // double (s, p) = NewSumAndProduct(3, 4);

            WriteLine($"sum = {sum}, product = {product}");
            WriteLine(sum.GetType());

            // also assignment
            double s, p;
            (s, p) = NewSumAndProduct(1, 10);

            (double ss, double pp) = NewSumAndProduct(12, 23);

            // tuple declarations with names
            //var me = new {name = "Dmitri", age = 123}; // AnonymousType
            var me = (name: "Dmitry", age: 123);
            WriteLine("ME: " + me);
            WriteLine(me.GetType());

            // names are not part of the type:
            WriteLine("Fields: " + string.Join(",", me.GetType().GetFields().Select(pr => pr.Name)));
            WriteLine("Properties: " + string.Join(",", me.GetType().GetProperties().Select(pr => pr.Name)));

            WriteLine($"My name is {me.name} and I am {me.age} years old");
            // proceed to show return: TupleElementNames in dotPeek (internally, Item1 etc. are used everywhere)

            // unfortunately, tuple names only propagate out of a function if they're in the signature
            var snp = new Func<double, double, (double sum, double product)>((a, b) => (sum: a + b, product: a * b));
            var result = snp(1, 2);
            // there's no result.sum unless you add it to signature
            WriteLine($"sum = {result.sum}");

            var snp2 = new Func<double, double, (double, double)>((a, b) => (sum: a + b, product: a * b));
            var result2 = snp2(1, 2);
            // there's no result.sum unless you add it to signature
            //WriteLine($"sum = {result2.sum}");// Not propagated
            WriteLine($"sum = {result2.Item1}");

            // When you reference result.product - you really reference result.Item2

            // deconstruction
            Point pt = new Point { X = 2, Y = 3 };
            var (x, y) = pt; // interesting error here
            WriteLine($"Got a point x = {x}, y = {y}");

            // can also discard values
            (int z, _) = pt;
        }
    }
}
```

DotPeek:

```cs
      [TupleElementNames(new string[] {"sum", "product"})]
      public static Func<double, double, ValueTuple<double, double>> \u003C\u003E9__2_2;
      public static Func<double, double, ValueTuple<double, double>> \u003C\u003E9__2_3;
```

### Deconstruction [5]

```cs
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
```

### Local Functions [6]

```cs
namespace LocalFunctions
{
    public class EquationSolver
    {
        //private Func<double, double, double, double> CalculateDiscriminant = (aa, bb, cc) => bb * bb - 4 * aa * cc;

        public static Tuple<double, double> SolveQuadratic(double a, double b, double c)
        {
            //Old C#:
            //var CalculateDiscriminant = new Func<double, double, double, double>((aa, bb, cc) => bb * bb - 4 * aa * cc);

            //double CalculateDiscriminant(double aa, double bb, double cc)
            //{
            //  return bb * bb - 4 * aa * cc;
            //}
            //double CalculateDiscriminant(double aa, double bb, double cc) => bb * bb - 4 * aa * cc;
            //double CalculateDiscriminant() => b * b - 4 * a * c;

            //New C# 7:
            //var disc = CalculateDiscriminant(a, b, c);
            var disc = CalculateDiscriminant();

            var rootDisc = Math.Sqrt(disc);
            return Tuple.Create(
              (-b + rootDisc) / (2 * a),
              (-b - rootDisc) / (2 * a)
            );

            // can place here
            double CalculateDiscriminant() => b * b - 4 * a * c;
        }

        //private static double CalculateDiscriminant(double a, double b, double c)
        //{
        //  return b * b - 4 * a * c;
        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var result = EquationSolver.SolveQuadratic(1, 10, 16);
            Console.WriteLine(result);
        }
    }
}
```

### Ref Returns and Locals References [7]

```cs
using System;
using static System.Console;

namespace RefReturnsAndLocals
{
    internal class Program
    {
        static ref int Find(int[] numbers, int value)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == value)
                    return ref numbers[i];
            }

            // cannot do by value return, we return ref
            //return -1; 

            // cannot return a local
            //int fail = -1;
            //return ref fail;

            throw new ArgumentException("meh");
        }

        static ref int Min(ref int x, ref int y)
        {
            //return x < y ? x : y;             // No
            //return x < y ? (ref x) : (ref) y; // No
            //return ref (x < y ? x : y);       // No
            
            if (x < y) return ref x;
            return ref y;
        }

        static void Main(string[] args)
        {
            //--------------------------------------------
            // Local references:
            //--------------------------------------------

            WriteLine(typeof(string).Assembly.ImageRuntimeVersion);

            // reference to a local element
            int[] numbers = { 1, 2, 3 };
            WriteLine(string.Join(",", numbers));

            ref int refToSecond = ref numbers[1]; // Any change to refToSecond will change numbers[1]
            var valueOfSecond = refToSecond;

            // Cannot rebind? Interesting, seems I can rebind refToSecond = ref numbers[0];
            refToSecond = ref numbers[0]; 
            //WriteLine(typeof(string).Assembly.ImageRuntimeVersion); -> v4.0.30319

            refToSecond = 123;
            WriteLine(string.Join(",", numbers)); // 1, 123, 3

            
            // reference persists even after the array is resized
            Array.Resize(ref numbers, 1);
            WriteLine($"second = {refToSecond}, array size is {numbers.Length}");
            refToSecond = 321;
            WriteLine($"second = {refToSecond}, array size is {numbers.Length}");
            //numbers.SetValue(321, 1); // will throw System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

            // won't work with lists
            var numberList = new List<int> { 1, 2, 3 };
            //ref int second = ref numberList[1]; // property or indexer cannot be out 
            //Error CS0206  A non ref-returning property or indexer may not be used as an out or ref value RefReturnsAndLocals

            //--------------------------------------------
            //
            //--------------------------------------------

            int[] moreNumbers = { 10, 20, 30 };
            //ref int refToThirty = ref Find(moreNumbers, 30);
            //refToThirty = 1000;

            // disgusting use of language
            Find(moreNumbers, 30) = 555;

            WriteLine(string.Join(",", moreNumbers));

            // too many references:
            int a = 1, b = 2;
            ref var minRef = ref Min(ref a, ref b); // Refer to the same piece of memory

            // non-ref call just gets the value (Copied)
            int minValue = Min(ref a, ref b);
            WriteLine($"min is {minValue}");
        }
    }
}
```

### Expression Bodied Members [8]

```cs
namespace ExpressionBodiedMembers
{
    internal class Program
    {
        // community contributed feature
        public class Person
        {
            private int id;

            private static readonly Dictionary<int, string> names = new Dictionary<int, string>();

            public Person(int id, string name) => names.Add(id, name); //expression body

            ~Person() => names.Remove(id);

            public string Name
            {
                get => names[id];
                set => names[id] = value;   //expression body
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```

### Throw Expressions [9]

```cs
using static System.Console;

namespace ThrowExpressions
{
    internal class Program
    {
        public class Demo
        {
            public string Name { get; set; }

            // Old way
            /*
            public Demo(string name)
            {
                if(name == null)
                {
                    throw new ArgumentNullException(paramName: nameof(name));
                }

                Name = name;
            }
            */

            // New way
            public Demo(string name)
            {
                Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            }

            public int GetValue(int n)
            {
                return n > 0 ? n + 1 : throw new Exception();
            }
        }


        static void Main(string[] args)
        {
            int v = -2;
            try
            {
                var demo = new Demo("");
                v = demo.GetValue(-1); // does not get defaulted!
            }
            catch (Exception e)
            {
                WriteLine(e);
            }
            finally
            {
                WriteLine(v);
            }
        }
    }
}
```

### Generalized Async Return Types [10]

async returns void/Task/Task<T>

C# 7: + ValueTask/ValueTask < T >

```cs
namespace GeneralizedAsyncReturnTypes
{
    internal class Program
    {
        // new ValueTask type
        
        // Prior to C# 7: return void/Task/Task<T>

        public static async Task<long> GetDirSize(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any())
                return 0; // Still imply the creation of the Task even though you might not actually need it

            // Task<long> is return type so it still needs to be instantiated

            return await Task.Run(() => Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Sum(f => new FileInfo(f).Length));
        }

        // C# 7: + ValueTask/ValueTask<T>
        // Avoiding of creation of fully fledged Task
        public static async ValueTask<long> GetDirSize2(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any())
                return 0;

            return await Task.Run(() => Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Sum(f => new FileInfo(f).Length));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetDirSize2("c:\temp").Result);
        }
    }
```

### Literal Improvements [11]

```cs
    int a = 123_321;
    int b = 123_321______123;
    int d = 1_22_333; // can place them anywhere, underscores will be ignored by the compiler
    
    // cannot do trailing
    //int c = 1_2_3___; // R# remove
    // also works for hex
    
    long h = 0xAB_BC_D123EF;
    // also binary
    var bin = 0b1110_0010_0011;
```

## Section 2: What's New in C# 7.1
### Why Is My C#7.1 Program Not Compiling?!? [12]

Use latest minor C# version (not major version)

### Async Main [13]

```cs
namespace  AsyncMain
{
    internal class Program
    {
        // used to be the case that your demo
        // would have to reside in a separate
        // body

        private static string url = "http://google.com/robots.txt";

        /*
        private static async Task MainAsync(string s)
        {
            Console.WriteLine(await new HttpClient().GetStringAsync(s));
        }

        public static void Main(string[] args)
        {
            // fine
            MainAsync(url).GetAwaiter().GetResult();
        }
        */

        // there is no async void, it's
        // Task Main
        // Task<int> Main if you need to return
        static async Task Main(string[] args)
        {
            Console.WriteLine(await new HttpClient().GetStringAsync(url));
        }
    }
}
```

### Default Expressions [14]

```cs
using static System.Console;

namespace DefaultExpessions
{
    internal class Program
    {
        // allowed in argument names
        // only upside: switching from ref to value type

        // VS Action 'Simplify Default Expression'
        public DateTime GetTimeStamps(List<int> items = default(List<int>))
        {
            // ...
            return default;
        }

        public DateTime GetTimeStamps2(List<int> items = default)
        {
            // ...
            return default; // default DateTime
        }

        /// <summary>
        /// Default literal, one of the slightly meaningless features.
        /// </summary>
        static void Main()
        {
            // Simplify default expression here
            int a = default(int); // so simplified in c# 7.1
            WriteLine(a);

            int b = default;
            WriteLine(b);

            // constants are ok if the inferred type is suitable
            const int c = default;
            WriteLine(c);

            // will not work here
            // const int? d = default; // oops, won't work

            // cannot leave defaults on their own
            var e = new[] { default, 33, default };
            //var e = new[] { default, default }; //CS0826	No best type found for implicitly-typed array
            WriteLine(string.Join(",", e));

            // rather silly way of doing things; null is shorter
            string s = default;
            Write("string default == null: ");
            WriteLine(s == null);

            // comparison with default is OK if type can be inferred
            if (s == default)
            {
                WriteLine("Yes, s is default/null");
            }

            // ternary operations
            var x = a > 0 ? default : 1.5;
            WriteLine(x.GetType().Name);
        }
    }
}
```

### Reference Assemblies [15]

<https://github.com/dotnet/roslyn/blob/main/docs/features/refout.md>

<https://learn.microsoft.com/en-us/dotnet/standard/assembly/reference-assemblies>

csc RefAssemblyDemo..cs **/refout**:Demo.dll

only public metadata

contain only the minimum amount of metadata required to represent the library's public API surface

regular assemblies are called implementation assemblies.

Reference assemblies can't be loaded for execution, but they can be passed as compiler input in the same way as implementation assemblies

Use case:

Suppose, you have only the latest version of some library on your machine, but you want to build a program that targets an earlier version of that library. If you compile directly against the implementation assembly, you might inadvertently use API members that aren't available in the earlier version. You'll only find this mistake when testing the program on the target machine. If you compile against the reference assembly for the earlier version, you'll immediately get a compile-time error.

#### Reference assemblies structure

Reference assemblies are an expansion of the related concept, metadata-only assemblies. Metadata-only assemblies have their method bodies replaced with a single throw null body, but include all members except anonymous types. The reason for using throw null bodies (as opposed to no bodies) is so that PEVerify can run and pass (thus validating the completeness of the metadata).

Reference assemblies further remove metadata (private members) from metadata-only assemblies.

The metadata in reference assemblies continues to keep the following information:

- All types, including private and nested types.
- All attributes, even internal ones.
- All virtual methods.
- Explicit interface implementations.
- Explicitly implemented properties and events, because their accessors are virtual.
- All fields of structures.

### Infer Tuple Names [16]

```cs
using static System.Console;

namespace InferTupleNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dot Net framework 4.7
            // reminder: tuples
            var me = (name: "Dmitry", age: 30);
            WriteLine(me);

            var alsoMe = (me.age, me.name);
            WriteLine(alsoMe.Item1); // typical C# 7.0
            WriteLine(alsoMe.name); // new  C# 7.1 , took these names and initialize corresponding names is this tuple

            var months = new[] { "March", "April", "May" };
            var result2 = months.Select(m => (
                m.Length,
                FirstChar: m[0]
            )).Where(t=> t.Length == 5);
            WriteLine(string.Join(",",result2));

            var result = new[] { "March", "April", "May" } // explicit name not required
              .Select(m => (
                /*Length:*/ m/*?*/.Length, // optionally nullable
                FirstChar: m[0])) // some names (e.g., ToString) disallowed
              .Where(t => t.Length == 5); // note how .Length is available here
            WriteLine(string.Join(",", result));

            // tuples produced by deconstruction
            var now = DateTime.UtcNow;
            var u = (now.Hour, now.Minute);
            var v = ((u.Hour, u.Minute) = (11, 12)); // construct new tuple from existing
            WriteLine(v.Minute);
        }
    }
}
```

### Pattern-Matching with Generics [17]

```cs
using static System.Console;

namespace PatternMatchingWithGenerics
{
    internal class Program
    {
        public class Animal
        {

        }

        public class Pig : Animal
        {

        }

        public static void Cook<T>(T animal) where T : Animal
        {
            // note the red squiggly!
            // cast is redundant here
            if (/*(object)*/animal is Pig pig)
            {
                // cook and eat it
                Write("We cooked and ate the pig...");
            }

            switch (/*(object)*/animal)
            {
                case Pig pork:
                    WriteLine(" and it tastes delicious!");
                    break;
            }
        }

        static void Main(string[] args)
        {
            var pig = new Pig();
            Cook(pig);
        }
    }
}
```

## Section 3: What's New in C# 7.2

### Leading Digit Separators [18]

```cs
    // binary
    var x = 0b_1111_0000;
    
    // hex
    var y = 0x_baad_f00d;
    
    //var z = _baad_food; // No
```

### 'private protected' Access Modifier [19]

<https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers>

Caller's location | public | protected | internal protected | internal | private protected | private
| :------------------------------------- | :----- | :--- | :--- | :--- | :--- | :--- |
| Within the class                       | ✔️️ | ✔️ | ✔️ | ✔️ | ✔️ | ✔️ |
| Derived class (same assembly)          | ✔️   | ✔️ | ✔️ | ✔️ | ✔️ | ❌   |
| Non-derived class (same assembly)      | ✔️   | ✔️ | ❌   | ✔️ | ❌   | ❌   |
| Derived class (different assembly)     | ✔️   | ✔️ | ✔️ | ❌   | ❌   | ❌   |
| Non-derived class (different assembly) | ✔️   | ❌   | ❌   | ❌   | ❌   | ❌   |

<https://metanit.com/sharp/tutorial/3.2.php>

**private**: закрытый или приватный компонент класса или структуры. Приватный компонент доступен только в рамках своего класса или структуры.

**private protected**: компонент класса доступен из любого места в своем классе или в производных классах, которые определены в той же сборке.

**file**: добавлен в версии **C# 11** и применяется к типам, например, классам и структурам. Класс или структура с такми модификатором доступны только из текущего файла кода.

**protected**: такой компонент класса доступен из любого места в своем классе или в производных классах. При этом производные классы могут располагаться в других сборках.

**internal**: компоненты класса или структуры доступен из любого места кода в той же сборке, однако он недоступен для других программ и сборок.

**protected internal**: совмещает функционал двух модификаторов protected и internal. Такой компонент класса доступен из любого места в текущей сборке и из производных классов, которые могут располагаться в других сборках.

**public**: публичный, общедоступный компонент класса или структуры. Такой компонент доступен из любого места в коде, а также из других программ и сборок.

---

### Non-trailing named arguments [20]

```cs
namespace NonTrailingNamedArguments
{
    internal class Program
    {
        static void doSomething(int foo, int bar)
        {
            Console.WriteLine($"foo: {foo} bar: {bar}");
        }


        static void Main(string[] args)
        {
            doSomething(33, bar: 44);

            doSomething(foo: 33, 44); // Now you can use named arg before unnamed argument

            // still illegal
            //doSomething(33, foo: 44); // but cannot change the position of arguments while using unnamed arg

            doSomething(bar: 33, foo: 44);
        }
    }
}
```

### 'in' Parameters [21]

```cs
namespace InParameters
{
    internal class Program
    {
        struct Point
        {
            // in = read only ref for struct

            // 8 + 8 = 16 bytes in memory
            // There was an idea of C#, when you pass the structure into the method
            // - you pass the 16 bytes
            public double X, Y;

            public Point(double x, double y)
            {
                X = x; Y = y;
            }

            public void Reset() => X = Y = 0;

            public override string ToString() => $"({X}, {Y})";
        }

        // Pass copy of 4 doubles = 32 bytes
        /*
        double MeasureDistance(Point p1, Point p2)
        {
            var dx = p1.X - p2.X;
            var dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        */

        // "in" keyword - doesn't relate to out keyword

        // it says:
        // 1) PASS BY REFERENCE (not by value)
        // pass just memory address, 64 bit, instead of 32 * 8 = 256 bits
        // => same a lot of memory
        
        // 2) READONLY: in keyword makes this structure READONLY!
        double MeasureDistance(in Point p1, in Point p2)
        {
            //p1 = new Point(2, 2);
            // CS8331  Cannot assign to variable 'p1' or use it as the right hand side of a ref assignment because it is a readonly variable

            //changeMe(p1); 
            // Error	CS1620	Argument 1 must be passed with the 'ref' keyword

            p1.Reset();
            // Allowed, but SURPRISE - the result is still the same!
            // We reset the COPY! (another element of protection against people can modify)

            var dx = p1.X - p2.X;
            var dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }


        // 3) You cannot overload with the same arguments with difference just in "in" keyword
        // Surprise, is it allowed, yes, but you have to specify "in"
        // distance = MeasureDistance(in p1, in p2); to determine which method to call
        // Unlikely
        double MeasureDistance(Point p1, Point p2)
        {
            return 0.0;
        }

        void changeMe(ref Point p) => p.X++;

        public Program()
        {
            var p1 = new Point(1,1);
            var p2 = new Point(4,5);

            var distance = MeasureDistance(p1, p2);
            Console.WriteLine($"The distance between {p1} and {p2} is {distance}");
            
            distance = MeasureDistance(in p1, in p2);
            Console.WriteLine( $"The distance between {p1} and {p2} is {distance}" );

            changeMe(ref p2);
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
```

### 'ref readonly' Variables [22]

```cs
            //public static Point Origin = new Point();

            public static Point origin = new Point();

            public static ref readonly Point Origin => ref origin;

            //We had ref for classes, NOW we have ref for value types
            // - read only ref for value type            

            ...

            var distanceFromOrigin = MeasureDistance(in p1, Point.Origin); // Point = value type, you are copying, We want to ref, now we have ref read only

            Point copyOfOrigin = Point.Origin; // by value

            //ref var o = ref Point.Origin; // connot, because Origin is read only

            ref readonly var originRef = ref Point.Origin;
            
            //originRef.X++; //CS1059 The operand of an increment or decrement operator must be a variable, property or indexer
```

### 'ref struct' and Span<T> [23]

#### Memory Types

- Managed memory (new operator)
  - Small objects < 85 k (generational part of managed heap)
  - Large objects > 85 k (Large Object Heap, LOH and)
  - Released by GC

- Unmanaged memory
  - Allocated on unmanaged heap with Marshal.AllocHGlobal / CoTaskMem
  - Released with Marshal.FreeHGlobal / CoTaskMem
  - GC not involved

- Stack memory (stackallock keyword)
  - Very fast allocation / deallocation
  - Very small < 1 Mb, overrallocate - and you set SO Stack Overflow / process dies
  - Nobody uses it :)

#### The problem

- Imagine you want to refer to a part of the string
  - ... without making a copy of the string. But Substring() allocates a copy.
  
- You can refer to the start/end indices or use pointers

- More generally you can refer to
  - Memory where a memory range begins
  - Location/index where you need to start takung the values
  - How many values to take / index of final element

- We need a general way of referring to a range of values in memory (for reading, copying, etc.)

- That generalizarion is expressed as Span<T>

#### Ref Struct Type

- A value type that must be stack-allocated

- Can never be created on the heap as member of another class

- Main motivation - to support Span<T>

- Compiler-enforced rules
  - Cannot box a ref struct (i.e. cannot assign to object, dynamic or interface type)
  - Cannot declare a ref struct as a member of another class or normal struct
  - Cannot declare local ref struct variables in async methods or synchronous methods that return Task or Task-like types.
  - Cannot declare ref struct locals in iterators.
  - Cannot capture ref struct vars in lambda expressions or local functions.

- Rules prevent a ref struct from being promoted to the managed heap

Sad news:

Warning: in .NET Framework, current Span<T> in System.Memory NuGet is not a ref struct, therefore all of theese limitations have not yet kicked in.

TODO: read more

### Span<T> Demo [24]

Nuget: System.Memory

Project Properties: Build -> General -> [x] Unsafe code,

Allow code that uses unsafe

csproj:

```xml
    <AllowUnsafeBlocks>True</AllowUnsafeBlocks>
...
  <ItemGroup>
    <PackageReference Include="System.Memory" Version="4.5.5" />
  </ItemGroup>
```

```cs
using System.Runtime.InteropServices;

namespace SpanDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            unsafe
            {
                byte* ptr = stackalloc byte[100];
                Span<byte> memory = new Span<byte>(ptr, 100);

                IntPtr unmanagedPtr = Marshal.AllocHGlobal(123);
                Span<byte> unmanagedMemory = new Span<byte>(unmanagedPtr.ToPointer(), 123);
                Marshal.FreeHGlobal(unmanagedPtr);
            }

            char[] stuff = "hello".ToCharArray();
            Span<char> arrayMemory = stuff;

            ReadOnlySpan<char> more = "Hi There".AsSpan();

            Console.WriteLine($"Our span has {more.Length} elements.");
            arrayMemory.Fill('x');//arrayMemory is view to stuff
            Console.WriteLine(stuff);
            arrayMemory.Clear();
            Console.WriteLine("arrayMemory.Clear();");
            Console.WriteLine(stuff);
        }
    }
}
```

## Section 4: What's New in C# 7.3
### Performance Improvements [25]

#### fixed statement - pin a variable for pointer operations

- fixed keyword - create buffer with a fixed size array in a data structure
  - private fixed char filename[255];
- Great for interop!
- No bounds checking! (unless you used stackalloc)
- Can only be used in unsafe context
- Can only be instance fields of unsafe structs. 

Fixed statement 'pins' a variable in memory
- Prevents relocation
- Point p = new Point();
- fixed (int * px = &p.x) {*px = 1;}
- Arrays, strings, fixed-size buffers

Starting with C# 7.3 fixed operateson any type that implements a method 

DangerousGetPinnableReference()

- Method must return a ref variable (ref T or ref readonly T) to an unmanaged type

- See Span<T>.DangerousGetPinnableReference()

<https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/fixed>

The fixed statement prevents the garbage collector from relocating a moveable variable and declares a pointer to that variable. The address of a fixed, or pinned, variable doesn't change during execution of the statement. You can use the declared pointer only inside the corresponding fixed statement. The declared pointer is readonly and can't be modified:

```cs
namespace FixedStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The fixed statement prevents the garbage collector from relocating a moveable variable and declares a pointer to that variable.The address of a fixed, or pinned, variable doesn't change during execution of the statement.
            //You can use the declared pointer only inside the corresponding fixed statement. The declared pointer is readonly and can't be modified:

            //Declare:

            // 1. With an array, The initialized pointer contains the address of the first array element.
            unsafe
            {
                byte[] bytes = { 1, 2, 3 };
                fixed (byte* pointerToFirst = bytes)
                {
                    Console.WriteLine($"The address of the first array element: (long)pointerToFirst:X = {(long)pointerToFirst:X}.");
                    Console.WriteLine($"The value of the first array element: *pointerToFirst = {*pointerToFirst}.");
                }
            }
            // Output is similar to:
            // The address of the first array element: 2173F80B5C8.
            // The value of the first array element: 1.

            
            // 2. With an address of a variable. Use the address-of & operator, as the following example shows:
            unsafe
            {
                int[] numbers = { 10, 20, 30 };
                fixed (int* ptrToFirst = &numbers[0], ptrToLast = &numbers[^1])
                {
                    Console.WriteLine($"{(long)ptrToFirst:X}");
                    Console.WriteLine($"{(long)ptrToLast:X}");
                    Console.WriteLine($"ptrToLast - ptrToFirst = {ptrToLast - ptrToFirst}");  // output: 2
                    // Since the subtraction operation of pointers returns the difference in the number of elements rather than in bytes, the output will represent the number of elements between the pointers.
                }
            }

            // 3. When the initialized pointer contains the address of an object field or an array element, the fixed statement guarantees that the garbage collector doesn't relocate or dispose of the containing object instance during the execution of the statement body.

            //With the instance of the type that implements a method named GetPinnableReference.
            //That method must return a ref variable of an unmanaged type.
            //The.NET types System.Span<T> and System.ReadOnlySpan<T> make use of this pattern.
            //You can pin span instances, as the following example shows:
            unsafe
            {
                int[] numbers = { 10, 20, 30, 40, 50 };
                Span<int> interior = numbers.AsSpan()[1..^1];
                fixed (int* p = interior)
                {
                    for (int i = 0; i < interior.Length; i++)
                    {
                        Console.WriteLine(p[i]);
                    }
                    // output:
                    // 20
                    // 30
                    // 40
                }
            }

            // 4. With a string:
            
            unsafe
            {
                var message = "Hello!";
                fixed (char* p = message)
                {
                    Console.WriteLine(*p);  // output: H
                }
            }

            // 5. With a fixed-size buffer.

            // You can allocate memory on the stack, where it's not subject to garbage collection and therefore doesn't need to be pinned.To do that, use a stackalloc expression.

            // You can also use the fixed keyword to declare a fixed-size buffer.
        }
    }
}
```

You can use the fixed statement only in an unsafe context. The code that contains unsafe blocks must be compiled with the AllowUnsafeBlocks compiler option.

#### Indexed fields do not require pinning

```cs
unsafe struct MyStruct
{
    public fixed int myField[9];
}
```

In earlier C# you had to pin a variable to access of the integers in myField.

But in C# 7.3 you can just write:

```cs
    var ms = new MyStruct();
    int p = ms.myField[3];
```

Variable p does not need to be pinned; you still need to be in unsafe context.

#### ref local may be reassigned

ref local variables can now be reassigned to refer to some different location

```cs
    ref MyStruct refLocal = ref MyStruct;
    refLocal = ref someOtherStruct;
```

#### stackalloc arrays support initializers

```cs
    int* pArr1 = stackalloc int[3] {1,2,3};
    
    int* pArr2 = stackalloc int[] {4,5,6};
```

### Feature Enhancements [26]

#### Attributes on backing fields of auto-props

attach to field (not on prop itself)

```cs
    [field: SomeCleverAttribute]
    public float SomeProperty { get; set; }
```

#### 'In' method overload resolution tiebreaker

When C# introduced the **in** modifier, overloads with and without in woild cause ambiguity:

```
static void Foo(X arg);
static void Foo(in X arg);
```

In C# 7.3, the by-value (first) overload is preferred to the by-readonly-ref bersion.

To specify the use of read-only-ref version, you must include **in** modifier when calling the method.

#### Extended expression variables in initializers

C# syntax for **out** variables has been extwnded:

Now out can happen in:

- Field initializers
- Property initializers
- Constructor initializers
- Query clauses

Legal but unusual behaviour

```cs
namespace ExprVarsInitializers
{
    public class A
    {
        public A(int i, out int j) { j = i; }
    }

    public class B : A
    {
        public B(int i) : base(i, out var j)
        {
            Console.WriteLine($"j: {j}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B(99);
        }
    }
}
```

Tuples

<https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples>

#### Tuples equality

<https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples#tuple-equality>

```cs
(int a, byte b) left = (5, 10);
(long a, int b) right = (5, 10);
Console.WriteLine(left == right);  // output: True
Console.WriteLine(left != right);  // output: False

var t1 = (A: 5, B: 10);
var t2 = (B: 5, A: 10);
Console.WriteLine(t1 == t2);  // output: True
Console.WriteLine(t1 != t2);  // output: False
```

#### Tuples vs System.Tuple

C# tuples, which are backed by System.ValueTuple types, are different from tuples that are represented by System.Tuple types. The main differences are as follows:

- System.ValueTuple types are value types. System.Tuple types are reference types.
- System.ValueTuple types are mutable. System.Tuple types are immutable.
- Data members of System.ValueTuple types are fields. Data members of System.Tuple types are properties.

### New Compiler Features [27]

#### C# compiler options
<https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/>

#### PublicSign

<https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/security#publicsign>

- PublicSign / -publicsign: Publicly sign the assembly.
- DelaySign / -delaysign: Delay-sign the assembly using only the public portion of the strong - name key.
KeyFile / -keyfile : Specify a strong name key file.
- KeyContainer / -keycontainer: Specify a strong name key container.
- HighEntropyVA / -highentropyva: Enable high-entropy Address Space Layout Randomization (ASLR)

PublicSign
This option causes the compiler to apply a public key but doesn't actually sign the assembly. The PublicSign option also sets a bit in the assembly that tells the runtime that the file is signed.

```xml
    <PublicSign>true</PublicSign>
```

The PublicSign option requires the use of the KeyFile or KeyContainer option. The KeyFile and KeyContainer options specify the public key. The PublicSign and DelaySign options are mutually exclusive.

#### Pathmap (PDBs)

<https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/advanced#pathmap>

#### Deterministic

<https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/code-generation#deterministic>

### Bonus Lecture: Other Courses at a Discount [28]

## Section 5: What's New in C# 8
### Nullable Reference Types [29]

<https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-reference-types>

- #nullable enable //per file
- on the project level
```
<NullableReferenceTypes>true</NullableReferenceTypes> // on the project level
```
- Does not change executed code
- Uses a [NullableAttribute(flags)] to decorate all members
- BCL does NOT support it? yet?
- "Remapping" from T to T? has no effect
- Type? u = t;
- Console.write(u.Name); // no warning

```cs
#nullable enable //per file
//<NullableReferenceTypes>true</NullableReferenceTypes> // on the project level
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
        }
    }
}
```

- #nullable enable
- Compiler is more strict
- string? != Nullable<string>
- It is still a string but we need additional null checks
- public string FullName => $"{FirstName}, {LastName?[0]}";
- [CanBeNull] Foo foo -> Foo? foo

```cs
string? s = GetString();
char c = s[0]; // warning
if(s!=null)
{
    char c = s[0]; // NO warning
}
```

Two ways to stop null checks:

- Keep the var non-nullable
- Wrute exoression with a bang (!)

- (null as Person).FullName // warning
- (null as Person)!.FullName // NO warning
- (null as Person)!!!!!!!!.FullName //Error CS8715	Duplicate null suppression operator ('!')
- (null as Person)!?.FullName // DOES in fact perform the null check
- (null as Person)?!.FullName // won't compile

```cs
            var n1 = (null as Person).FullName; // warning
            var n2 = (null as Person)!.FullName; // NO warning
            //var n3 = (null as Person)!!!!!!!!.FullName; // NO warning, was also legal? No, it is Error CS8715	Duplicate null suppression operator ('!')
            var n4 = (null as Person)!?.FullName;// DOES in fact perform the null check
            //var n5 = (null as Person)?!.FullName; // won't compile
```

### Indices and Ranges [30]

<https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/ranges>

```cs
namespace IndicesAndRanges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two new types in []:");
            // index refers to single position
            //  - Value
            //  - IsFromEnd
            Index i0 = 2;//implicit conversion
            Index i1 = new Index(0, fromEnd: false);

            var i2 = ^0; // Index(0, true), "hat zero"
                         // -1 is not last

            var items = new[] { 1, 2, 3, 4, 5 };
            items[^2] = 33;
            //Array.ForEach(items, Console.Write);
            Console.WriteLine("[{0}]", string.Join(", ", items));
            
            string[] words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumps",    // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0

            Console.WriteLine($"The last word is words[^1]: {words[^1]}");


            // range of values
            // X..Y
            // where X and Y are of type Index
            // Indices are inclusive from the end

            items = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("items: [{0}]", string.Join(", ", items));

            //items[0..4] // exclusive {1,2,3,4}
            //items[0..^0]// inclusive {1,2,3,4, 5}
            Console.WriteLine("items[0..4]: [{0}]", string.Join(", ", items[0..4]));
            Console.WriteLine("items[0..^0]: [{0}]", string.Join(", ", items[0..^0]));

            //X > Y // ArgumentOutOfRangeException , there are no checks!, no swaps!

            //Range examples:

            Index iOne = 3;  // number 3 from beginning
            Index iTwo = ^4; // number 4 from end
            int[] arrayOfNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"{arrayOfNumbers[iOne]}, {arrayOfNumbers[iTwo]}"); // "3, 6"
            var slice = arrayOfNumbers[iOne..iTwo]; // { 3, 4, 5 }


            var a = i1..i2;// Range(i1, i2)
            var b = i1..;
            var c = ..i2;
            // var d = 1..2..100
            var e = ..;
            //var f = Range.ToEnd(2);
            
            // Array slices yield copies
            var stuff = items[..2]; // creates a copy, call Array.Slice
                                    //Array.Slice

            //String yield substring
            var ss = "string"[..^1]; // "strin"
            var fo = "foo"[..^1]; // "fo"

            // AsSpan() takes a range

            // Span<T>.Slice() gives sub-spans

            // Custom types can define their own indexers:
            //public int[] this[Range range]
            //{
            //    get => ...
            //}

            //You could use ArraySegment<T>. It's very light-weight as it doesn't copy the array:
            string[] array = { "one", "two", "three", "four", "five" };
            var segment = new ArraySegment<string>(array, 1, 2); // "two", "three"
        }
    }
}
```

### Default Interface Members [31]

<https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/default-interface-methods>

<https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interface-implementation/default-interface-methods-versions>

#### Before version C# 8 - Behavioral Mixins

```cs
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
```

#### C# 8 Default Interface Members

```cs
    // In C# 8 you can write implementation details inside the interface

    public interface IHuman
    {
        string Name { get; }

        public void SayHello()
        {
            Console.WriteLine($"Hello, I am {Name}");
        }
    }

    public class Human : IHuman
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
        }
    }
```

#### Modifiers

- Interface syntax extended to accept protected, internal, public, virtual
- By defasult, default interface methods are virtual unless sealed/private is used
- Interfaces without bodies are abstract
- Interfaces can inmplement interfaces

#### Interface Inheritance: The most specific implementation is called

```cs
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

    //...
    
    ((IHuman)new Human() { Name = "Henry" }).SayHello(); // Hello (2) ... is called
    // Independent methods:
    ((IFriendlyHuman)new Human() { Name = "Henry" }).SayHello(); // Hello (2) ... is called
    // The most specific implementation is called
```

#### Diamond inheritance

```cs
    interface ITalk { void Greet(); }

    interface IAmBritish : ITalk
    {
        void ITalk.Greet() => Console.WriteLine("Good day!");
    }

    interface IAmAmerican : ITalk
    {
        void ITalk.Greet() => Console.WriteLine("Howdy!");
    }

    // Diamond inheritance = Coflict
    //class DualNation : IAmBritish, IAmAmerican { }
    // CS8705
    // Interface member 'ITalk.Greet()' does not have a most specific implementation.
    // Neither 'IAmBritish.ITalk.Greet()', nor 'IAmAmerican.ITalk.Greet()' are most specific.
```

### Pattern Matching [32]

"match" in F#

#### Property Patterns

```cs
        struct PhoneNumber
        {
            public int Code, Number;
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
        }
```

#### Empty vs Default

```cs
            var origin3 = phoneNumber switch
            {
                { Number: 112 } => "Emergency",
                { Code: 44 } => "UK",
                { } => "Unknown",
            };

            // - Is it switch exhaustive?
            // - It depends on #nullable enable/disable
```

#### Recursive patterns

```cs
            var person = new Person();
            var personsOrigin = person switch
            {
                { Name: "Dave" } => "USA",
                { PhoneNumber: { Code: 46 } } => "Sweden",
                { Name: var name } => $"No idea where {name} lives"
            };
```

#### Switch-Based Validation

```cs
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
```

#### Recursive Patterns with Type Checks

```cs
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
```

#### Deconstruction

```cs
// in recrangle class:
            public void Deconstruct(out (double X, double Y) origin, out double width, out double height)
            {
                origin.X = Origin.X;
                origin.Y = Origin.Y;
                width = Width;
                height = Height;
            }
//So we can switch
                var type = shape switch
                {
                    Rectangle((0, 0), 0, 0) => "Point at origin",
                    Circle((0, 0), _) => "Circle at origin",
                    Rectangle(_, var w, var h) when w == h => "Square",
                    Rectangle((var x, var y), var w, var h) => $"A {w}x{h} rectangle at ({x},{y})",
                    _ => "something else"
                };
```

## Section 6: What's New in C# 9

### Introduction [33]

- Sim-shipped with .NET5
- Still on VS 2019
- New tech: Blazor, EF Core 5, Xamarin Forms 5 etc.
- New language features

Content:

- New keywords:
  - **init and or not**
- Record Types
- Top-level Calls
- Initial Setters
- Pattern-Matching Improvements (and or not + relational patters...)
- Performance and Interop
  - Native sized integers (nint / nuint)
  - Function pointers
  - SkipLocalsInit
- Fit and Finish
  - Target typed new,
  - Target type resolution of conditional expressions,
  - Static modifier for lambda expressions and anonymous methods
  - Covariant return types
  - foreach GetEnumerator() use
  - Discards as parameters to lambdas
  - Attributes on local functions
- C# Code Generators
  - Partial Method Syntax
  - Module Initializers
  
### Record Types [34]

- Major feature of C# 9 programming language

#### Records Equality

```cs
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
```

#### Positional Records

```cs
namespace PositionalRecords
{
    public record Point(int x, int y); // avoids typing even a ctor

    internal class Program
    {
        static void Main(string[] args)
        {
            var origin = new Point(0, 0);
            var (x,y) = origin; // deconstruct

            Console.WriteLine($"({x},{y})");

            var p = new Point(2, 3);
            Console.WriteLine(p.GetHashCode());
        }
    }
}
```

#### GetHashCode

```cs
    [CompilerGenerated]
    public override int GetHashCode()
    {
      return (EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003Cx\u003Ek__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003Cy\u003Ek__BackingField);
    }
```

Decompiled:

```cs
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace PositionalRecords
{
  [NullableContext(1)]
  [Nullable(0)]
  public class Point : 
  /*[Nullable(0)]*/
  IEquatable<Point>
  {
    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly int \u003Cx\u003Ek__BackingField;
    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly int \u003Cy\u003Ek__BackingField;

    public Point(int x, int y)
    {
      this.\u003Cx\u003Ek__BackingField = x;
      this.\u003Cy\u003Ek__BackingField = y;
      base.\u002Ector();
    }

    [CompilerGenerated]
    protected virtual Type EqualityContract
    {
      [CompilerGenerated] get
      {
        return typeof (Point);
      }
    }

    public int x
    {
      [CompilerGenerated] get
      {
        return this.\u003Cx\u003Ek__BackingField;
      }
      [CompilerGenerated] init
      {
        this.\u003Cx\u003Ek__BackingField = value;
      }
    }

    public int y
    {
      [CompilerGenerated] get
      {
        return this.\u003Cy\u003Ek__BackingField;
      }
      [CompilerGenerated] init
      {
        this.\u003Cy\u003Ek__BackingField = value;
      }
    }

    [CompilerGenerated]
    public override string ToString()
    {
      StringBuilder builder = new StringBuilder();
      builder.Append("Point");
      builder.Append(" { ");
      if (this.PrintMembers(builder))
        builder.Append(' ');
      builder.Append('}');
      return builder.ToString();
    }

    [CompilerGenerated]
    protected virtual bool PrintMembers(StringBuilder builder)
    {
      RuntimeHelpers.EnsureSufficientExecutionStack();
      builder.Append("x = ");
      builder.Append(this.x.ToString());
      builder.Append(", y = ");
      builder.Append(this.y.ToString());
      return true;
    }

    [NullableContext(2)]
    [CompilerGenerated]
    [SpecialName]
    public static bool op_Inequality(Point left, Point right)
    {
      return !Point.op_Equality(left, right);
    }

    [NullableContext(2)]
    [CompilerGenerated]
    [SpecialName]
    public static bool op_Equality(Point left, Point right)
    {
      if ((object) left == (object) right)
        return true;
      return (object) left != null && left.Equals(right);
    }

    [CompilerGenerated]
    public override int GetHashCode()
    {
      return (EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003Cx\u003Ek__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003Cy\u003Ek__BackingField);
    }

    [NullableContext(2)]
    [CompilerGenerated]
    public override bool Equals(object obj)
    {
      return this.Equals(obj as Point);
    }

    [NullableContext(2)]
    [CompilerGenerated]
    public virtual bool Equals(Point other)
    {
      if ((object) this == (object) other)
        return true;
      return (object) other != null && Type.op_Equality(this.EqualityContract, other.EqualityContract) && EqualityComparer<int>.Default.Equals(this.\u003Cx\u003Ek__BackingField, other.\u003Cx\u003Ek__BackingField) && EqualityComparer<int>.Default.Equals(this.\u003Cy\u003Ek__BackingField, other.\u003Cy\u003Ek__BackingField);
    }

    [CompilerGenerated]
    public virtual Point \u003CClone\u003E\u0024()
    {
      return new Point(this);
    }

    [CompilerGenerated]
    protected Point(Point original)
    {
      base.\u002Ector();
      this.\u003Cx\u003Ek__BackingField = original.\u003Cx\u003Ek__BackingField;
      this.\u003Cy\u003Ek__BackingField = original.\u003Cy\u003Ek__BackingField;
    }

    [CompilerGenerated]
    public void Deconstruct(out int x, out int y)
    {
      x = this.x;
      y = this.y;
    }
  }
}

```

#### Records With Expressions

"with" = Clone() = Shallow Copy

```cs
namespace RecordsWithExpressions
{
    public record Color
    {
        public Color(string name, bool isMetallic)
        {
            Name = name;
            IsMetallic = isMetallic;
        }
        public Color(){ }

        public string Name { get; set; }
        public bool IsMetallic { get; set; }
    }

    public record Car
    {
        public Color Color { get; set; }
        public string Engine { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myFirstCar = new() 
            { 
                Color = new() { Name = "Black", IsMetallic = false }, 
                Engine = "V6" 
            };

            Car upgradedCar = myFirstCar with { Engine = "V8" }; 
            // car - cloned and modified
            // Shallow copy! Unfortunately!

            upgradedCar.Color.IsMetallic = true; // Both cars are metallic now!

            Console.WriteLine(myFirstCar);
            Console.WriteLine(upgradedCar);
            //Car { Color = Color { Name = Black, IsMetalic = True }, Engine = V6 }
            //Car { Color = Color { Name = Black, IsMetalic = True }, Engine = V8 }

            // The reason: "with" = Clone() = shallow copy with references to the Color, 
            // Upgraded car refers to the same Color object.

            // Need Deep copy? - implement Prototype pattern, Serialization/De-serialization
            // Deep Copy is hard => MS didn't it.
        }
    }
}
```


### Top-Level Calls [35]

C, Python, F#...

```cs
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
```

### Initial Setters [36]

```cs
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
```

### Pattern Matching Improvements [37]

and or not && || !

is

```cs
namespace PatternMatchingImprovements
{
    internal static class Program
    {
        public static bool IsLetter(this char c) =>
            c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        public static bool IsLetterOrSeparator(this char c) =>
            c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or ';' or ',';

        // behind the scenes - labels and goto statements.

        static void Main(string[] args)
        {
            // and or not && || !

            // "is" keyword was changed!
            // not only for type check, 
            // check a set of conditions

            Console.WriteLine("Hello, World!");

            object o = new object();
            //if (o != null)
            if (o is not null)
            {

            }

            //if (!(o is string))
            if(o is not string)
            {

            }

            int i = 0;
            //if (i is 2.0) {} // Error CS0266  Cannot implicitly convert type 'double' to 'int'.
           
            double d = 0;
            if (d is 2.0) { }

            if (d is 2) { }


            int temperature = 6666;

            var feel = temperature switch
            {
                //int t when t < 0 => // a lot of typing
                < 0 => "freezing",
                >= 0 and < 20 => "tolerable",
                //>= 20 and not 666 and not 6666 => "warm",
                >= 20 and not (666 or 6666)=> "warm",
                666 or 6666 => "hellish" 
            };
        }
    }
}
```

### Target-Typed New [38]

```cs
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
```

### Source Generators [39]

#### MS link

<https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview>

#### Source Generators

- Sometimes you need to generate code (plain text)
- C#/Roslyn doesn't have proper metaprogramming support
  - And maybe never will have
  - See Fody, PostSharp etc.
- Injecting your code into compiler and altering existing structures is still impossible
- But **we can add source files to project at compile time**
- We can have multiple generators attached to the same project 
- Addictive process, order does not matter, no you cannot modify existing structures, no different generators can interract.

#### How does it work?

- You make a separate .NET Standard lib prj
- Ref nuget Microsoft.CodeAnalysis.Analyzers
- To Make a source generator
  - Make a class that implements ISourceGenerator
  - Decorate it with Generator attribute
- The generator spits out text (strings) that get added as source files.
- Reference the analyzer project in your own project - **be sure to reference it as an analyzer**!

#### Compared to

- You can generate code using any program
  - Any language (Haskel,...)
  - Use an object model (e.g. Roslyn) instead of text - very verbose, not realistic
- T4 (text templating transformation, Visual Studio feature)
  - Can access project info
- Source Generator is a compiler feature

#### Demo

Generator project - class library:

nugets:
 
- Microsoft.CodeAnalysis.Analyzers
- Microsoft.CodeAnalysis.Common

Demo project: Add project reference to the Generator library

Gen project

Add

OutputItemType="Analyzer"

ReferenceOutputAssembly = false

Demo.csproj

```xml
  <ItemGroup>
    <ProjectReference Include="..\Generator\Generator.csproj"
                      OutputItemType="Analyzer"
                      ReferenceOutputAssembly="false" />
  </ItemGroup>

```

<https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview>

### Partial Method Syntax [40]

#### Partial methods

Partial methods are not new

- partial void Foo();
- Can call Foo() even if there is no implementation
- Code generator can implement if
- partial void Foo() { ... actual code ... }

- In prior versions of C#, partial methods are always void and have no params
- C#9 extends what is allowed at the expense of requiring an implementation part
  - Non-void retrun types
  - Out params
  - Accessibility keywords

### Module Initializers [40]

#### Module Initializers Feature

- Not a new feature to .NET
- Developers didn't have clear access
- Module = typicaly assemnly = axecutable or library
- Module Initializer gets called when the module is first loaded
  - Eager, one-time initialization
- Use Cases
  - Enable source generators to run global init login without the user calling anything
  - Hold on! But we have static constructors but Module Initializers are better / healthier
  - Initialize application state before the application starts
  - Avoid deadlock and startup race conditions
  - Startup dependency resolutions (unit testing, DI, web, etc.)
  - Security: Environment variables determined and locked at startup
  - Security: Validation and vulnerability checks

#### Module Initializer Runtime Guarantees

1. A Module Initializer is executed at, or sometime before, first access to any static field or first invocation of the method defined in module

2. Shall run exactly once for any given module unless explicitly called by user code.

3. No method other than those called directly from the module initializer will be able to access the types, methods, or data in the module before its initializer completes execution.

#### Module Initializer Restrictions

- Any method decorated as

```
[ModuleInitializer]
```

- MUST BE **static**, **void**, **parameterless**
- Cannot be generic or containe in generic type
- Must be accessible from the module as **public** or **internal**
  - Cannot be a local function

We had the similar solution for the module initialization in the Fody library

Now he have it as part of the language

## Section 7: What's New in C# 10

<https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10>

### Record Structs

<https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record>

#### What are Record Structs

- Same as record classes BUT value types!
- Synteshized members
  - Constructor
  - Deconstruct
  - Equals/==/!=
  - GetHashCode
  - PrintMembers
  - ToString
- Predictable differences to record classes
  - Equals() DOES NOT do null checks! because the sctruct cannot be null
- Performance can be sugnificantly better than ordinary structs
  - Also better than value tuples
  - Standard struct Equals()/GetHashCode() implementations are bad (boxing etc.))
  - Record struct can be 20x faster with 100 % less allocations

#### Record Struncts Restrinctions

- Cannot have a Clone() member
- Instance fields can be unsafe
- Cannot declare destructor

#### Uses of Record Structs

- Small composite value types
```cs
record struct Point<T> (T X, T Y) { ... }
Point<int> p = new (2,3);
```

- Record Struncts are **mutable**

- Mutable structs are **DANGEROUS**!

player.Position.X++; // does nothing, is this a new value through copying !!!?

#### Recommended - readonly record struct

Recommend:
```cs
readonly record struct Point ...
p.X++; // Will not compile
```

### Glogal Using Derictives

With C# 10 you can use global using directives that the compiler will consider for the whole project.

- fights against endless duplication
- Having "using System;" everywhere is repetitive
- Instead we have **global using System;**
- Put global using in any file
- Make sence to have GlobalUsings.cs
- New .NET 6 projects include several global usings that are implicit:

```xml
<ImplicitUsings>enable</ImplicitUsings>
```

### File-Scoped Namespace Declaration

Each namespace Foo.Bar {} causes indentation

It is annoing

In C# 10 you can write

```cs
namespace Foo.Bar;

class Whatever {...}
```

Everything after will be placed in that namespace;

Cool!

Rider has refactoring options:

- "To file-scoped namespace in project"
- "To file-scoped namespace in solution"

### Extended Property Patterns

```cs
if(obj is Developer
    { Manager.FirstName: "Sam" } d)
    // use d
```

d in going to be null if Manager.FirstName is not "Sam"

```cs
if(obj is Developer {
    Manager.FirstName.Lenght : 6,
    Manager.YearOfBirth: 1980 } dev)
    {
        // use dev
    }
```

### Generic Attributes

- Current approach to taking a type in an attribute

```cs
class MyAttribute : Attribute {
    MyAttribute(Type type) { ... }
}
//Usage: [My(typeof(Foo))]
```

- Now we can use type parameters instead:

```cs
class My<T> : Attribute {}
//Usage: 
[Attr<fload>] public void Bar () { ... }
```

- Restrictions: Type parameters from containing type cannot be used in attributes

```cs
[SomeAttr<T>] void Foo () { ... } //error
[SomeAttr<List<T>>] void Bar () { ... } //error
```

### Lambda Improvements (lots!)

3 catergories of improvements:

#### Attributes on lambda functions

<https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions#attributes>

- Now we can add attributes to lambda expressions:

```cs
f = [A] () => {};
```

- attributes om the whole lambda VS. attributes on parameter

```cs
  f = [return: A] x => x; // syntax error at "=>"
  f = [return: A] (x) => x; // [A] lambda
```

- Multiple Attributes

```cs
var f = [A1, A2][A3] () => {}; // ok
var g = ([A1][A2, A3] int x)  () => {}; // ok
```

- Attributes are not supported for delegate {} symtax:

```cs
var f = [A] delegate { return 1;}; // syntax error at delegate
var g = delegate ([A] int x) {return x;}; // syntax error at "["
```

- Collectiona initializers also use [A] syntax, so parser will differentiate:

```cs
var y = new C { [A] = x}; // ok: y[A] = x
var z = new C { [A] x = x}; // ok: z[0] = [A] x => x
```

```cs
// ?[ is conditional element access, so cannot go in front
x = b ? [A]; // ok
y = b ? [A] () -> {} : z; // syntax error at '('

```

#### Explicit return type

- You can specify an explicit return type before the parameter list

```cs
f = T () => default; // ok
f = ref int (ref int x) => ref x; // ok
f = static void (_) => {} // ok
```

- Not supported for delegate {} syntax

```cs
f = delegate int { return 1; }; // syntax error
f = delegate int (int x) { return x; }; // syntax error
```

Exact method type inference from lambda return:

```cs
static void F<T> (Func<T, T> f) { ... }
F(int (i) => i); // Func<int, int>
```

- Variance conversion not allowed from lambda return type to delegate return type

```cs
Func<object> f1 = string () => null; // error
Func<object?> f2 = object () => x; // warning
```

- Lambda expressions with ref return types are allowed within expressions (without additional parens):

```cs
d = ref int () => x; // d = (ref int () => x);
F(ref int () => x); // F((ref int () => x));
```

- Var cannot be used as an explicit return type

```cs
d = var (var v) => v; // error:
// error: contextual keyword 'var' cannot be used as an explicit return type
```

#### Infer a natural delegate for lambdas and method groups

- Finally, lambdas waill be inferred to Action/Func<>

```cs
var f3 = () => 1; // System.Func<int>

var f4 = string () => null; // System.Func<string>

var f5 = delegate (object o) {}; // System.Action<object>
```

### Enchanced #line direcrives

```
#line
```
debugging and diagnostics
