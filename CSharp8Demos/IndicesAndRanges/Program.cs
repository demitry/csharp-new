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