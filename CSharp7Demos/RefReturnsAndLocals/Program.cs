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