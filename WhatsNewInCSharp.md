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
        - [Ref Returns and Locals [7]](#ref-returns-and-locals-7)
        - [Expression Bodied Members [8]](#expression-bodied-members-8)
        - [Throw Expessions [9]](#throw-expessions-9)
        - [Generalized Async Return Types [10]](#generalized-async-return-types-10)
        - [Literal Improvements [11]](#literal-improvements-11)
    - [Section 2: What's New in C# 7.1](#section-2-whats-new-in-c-71)
        - [Why Is My C#7.1 Program Not Compiling?!? [12]](#why-is-my-c71-program-not-compiling-12)
        - [Async Main [13]](#async-main-13)
        - [Default Expessions [14]](#default-expessions-14)
        - [Ref Assemblies [15]](#ref-assemblies-15)
        - [Infer Tuple Names [16]](#infer-tuple-names-16)
        - [Pattern-Matching with Generics [17]](#pattern-matching-with-generics-17)
    - [Section 3: What's New in C# 7.2](#section-3-whats-new-in-c-72)
        - [Leading Digit Separators [18]](#leading-digit-separators-18)
        - ['private protected' Access Modifier [19]](#private-protected-access-modifier-19)
        - [Non-trailing named arguments [20]](#non-trailing-named-arguments-20)
        - ['in' Parameters [21]](#in-parameters-21)
        - ['ref readonly' Variables [22]](#ref-readonly-variables-22)
        - ['ref struct' and Span<T> [23]](#ref-struct-and-spant-23)
        - [Span<T> Demo [24]](#spant-demo-24)
    - [Section 4: What's New in C# 7.3](#section-4-whats-new-in-c-73)
        - [Performance Improvements [25]](#performance-improvements-25)
        - [Feature Enhancements [26]](#feature-enhancements-26)
        - [New Compiler Features [27]](#new-compiler-features-27)
        - [Bonus Lecture: Other Courses at a Discount [28]](#bonus-lecture-other-courses-at-a-discount-28)
    - [Section 5: What's New in C# 8](#section-5-whats-new-in-c-8)
        - [Nullable Reference Types [29]](#nullable-reference-types-29)
        - [Indices and Ranges [30]](#indices-and-ranges-30)
        - [Default Interface Members [31]](#default-interface-members-31)
        - [Pattern Matching [32]](#pattern-matching-32)
    - [Section 6: What's New in C# 9](#section-6-whats-new-in-c-9)
        - [Introduction [33]](#introduction-33)
        - [Record Types [34]](#record-types-34)
        - [Top-Level Calls [35]](#top-level-calls-35)
        - [Initial Setters [36]](#initial-setters-36)
        - [Pattern Matching Improvements [37]](#pattern-matching-improvements-37)
        - [Target-Typed New [38]](#target-typed-new-38)
        - [Source Generators [39]](#source-generators-39)
        - [Partial Method Syntax and Module Initializers [40]](#partial-method-syntax-and-module-initializers-40)
    - [Section 7: What's New in C# 10](#section-7-whats-new-in-c-10)
        - [What's New in C# 10 [41]](#whats-new-in-c-10-41)

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
### Local Functions [6] 
### Ref Returns and Locals [7] 
### Expression Bodied Members [8] 
### Throw Expessions [9] 
### Generalized Async Return Types [10]
### Literal Improvements [11]

## Section 2: What's New in C# 7.1
### Why Is My C#7.1 Program Not Compiling?!? [12]
### Async Main [13]
### Default Expessions [14]
### Ref Assemblies [15]
### Infer Tuple Names [16]
### Pattern-Matching with Generics [17]

## Section 3: What's New in C# 7.2
### Leading Digit Separators [18]
### 'private protected' Access Modifier [19]
### Non-trailing named arguments [20]
### 'in' Parameters [21]
### 'ref readonly' Variables [22]
### 'ref struct' and Span<T> [23]
### Span<T> Demo [24]

## Section 4: What's New in C# 7.3
### Performance Improvements [25]
### Feature Enhancements [26]
### New Compiler Features [27]
### Bonus Lecture: Other Courses at a Discount [28]

## Section 5: What's New in C# 8
### Nullable Reference Types [29]
### Indices and Ranges [30]
### Default Interface Members [31]
### Pattern Matching [32]

## Section 6: What's New in C# 9
### Introduction [33]
### Record Types [34]
### Top-Level Calls [35]
### Initial Setters [36]
### Pattern Matching Improvements [37]
### Target-Typed New [38]
### Source Generators [39]
### Partial Method Syntax and Module Initializers [40]

## Section 7: What's New in C# 10
### What's New in C# 10 [41]
